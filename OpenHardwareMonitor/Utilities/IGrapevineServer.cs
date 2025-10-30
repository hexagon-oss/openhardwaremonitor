using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SpaceWizards.HttpListener;

namespace OpenHardwareMonitor.Utilities
{
    public interface IGrapevineServer
    {
        String GetJson();
        string GetNode(HttpListenerContext context);
        string RootNode(HttpListenerContext context);
        string GetVersion();
        string Report(HttpListenerContext context);
    }
}
