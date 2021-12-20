﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Grapevine;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using NLog.Extensions.Logging;
using OpenHardwareMonitorLib;

namespace OpenHardwareMonitor.Utilities
{
    public class ServerConfig
    {
        private readonly ILogger logger;
        public IConfiguration Configuration { get; private set; }

        /// <summary>
        /// Sets the server port. Must be static to be available from outside
        /// </summary>
        public static int ServerPort
        {
            get;
            set;
        }

        public static GrapevineServer ActiveServer { get; set; }

        public ServerConfig(IConfiguration configuration)
        {
            Configuration = configuration;
            logger = this.GetCurrentClassLogger();
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddLogging(loggingBuilder =>
            {
                loggingBuilder.AddProvider(new ForwardingLoggerProvider(logger));
            });

            services.AddSingleton<IGrapevineServer>(ActiveServer);
        }

        private sealed class ForwardingLoggerProvider : ILoggerProvider
        {
            private ILogger loggerTarget;
            public ForwardingLoggerProvider(ILogger logger1)
            {
                loggerTarget = logger1;
            }

            public void Dispose()
            {
            }

            public ILogger CreateLogger(string categoryName)
            {
                return new ForwardingLogger(loggerTarget, categoryName);
            }
        }

        private sealed class ForwardingLogger : ILogger
        {
            private ILogger loggerTarget;
            private string categoryName;

            public ForwardingLogger(ILogger loggerTarget, string categoryName)
            {
                this.loggerTarget = loggerTarget;
                this.categoryName = categoryName;
            }

            public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception exception, Func<TState, Exception, string> formatter)
            {
                loggerTarget.Log(logLevel, eventId, state, exception, formatter);
            }

            public bool IsEnabled(LogLevel logLevel)
            {
                return true;
            }

            public IDisposable BeginScope<TState>(TState state)
            {
                return loggerTarget.BeginScope(state);
            }
        }

        public void ConfigureServer(IRestServer server)
        {
            // The path to your static content
            FileInfo fi = new FileInfo(Assembly.GetEntryAssembly().Location);
            var folderPath = Path.Combine(fi.Directory.FullName, "web");

            // The following line is shorthand for:
            //     server.ContentFolders.Add(new ContentFolder(folderPath));
            server.ContentFolders.Add(folderPath);
            server.UseContentFolders();

            server.Prefixes.Add($"http://+:{ServerPort}/");

            /* Configure Router Options (if supported by your router implementation) */
            server.Router.Options.SendExceptionMessages = true;
        }
    }
}