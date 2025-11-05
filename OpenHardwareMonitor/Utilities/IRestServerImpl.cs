using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SpaceWizards.HttpListener;

namespace OpenHardwareMonitor.Utilities
{
    public interface IRestServerImpl
    {
        string GetNode(HttpListenerContext context);
        string RootNode(HttpListenerContext context);
        string GetVersion();
        string Report(HttpListenerContext context);

        Task SendResponseAsync(HttpListenerResponse response, string content, string contentType = "text/html");

        Task SendResponseAsync(HttpListenerContext context, string content, string contentType = "text/html");
    }
}
