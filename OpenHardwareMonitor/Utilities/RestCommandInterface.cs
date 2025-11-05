using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SpaceWizards.HttpListener;


namespace OpenHardwareMonitor.Utilities;

public class RestCommandInterface
{
    private readonly IRestServerImpl _server;

    public RestCommandInterface(IRestServerImpl server)
    {
        _server = server;
    }

    [RestRoute("Get", "/api/available")]
    public async Task IsAvailable(HttpListenerContext context)
    {
        await _server.SendResponseAsync(context, "True").ConfigureAwait(false);
    }

    [RestRoute("Get", "/api/version")]
    public async Task GetVersion(HttpListenerContext context)
    {
        await _server.SendResponseAsync(context, _server.GetVersion());
    }

    [RestRoute("Get", "/api/nodes/")]
    public async Task HardwareNode(HttpListenerContext context)
    {
        context.Response.AddHeader("Cache-Control", "no-cache");
        await _server.SendResponseAsync(context, _server.GetNode(context), "application/json");
    }

    [RestRoute("Get", "/api/rootnode")]
    public async Task RootNode(HttpListenerContext context)
    {
        context.Response.AddHeader("Cache-Control", "no-cache");
        await _server.SendResponseAsync(context, _server.RootNode(context), "application/json");
    }

    [RestRoute("Get", "/api/report")]
    public async Task Report(HttpListenerContext context)
    {
        context.Response.AddHeader("Cache-Control", "no-cache");
        await _server.SendResponseAsync(context, _server.Report(context), "text/plain");
    }
}
