using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenHardwareMonitor.Utilities
{
    /// <summary>
    /// Attribute for rest routes. This is a bit overdesigned here, but may serve as a starting point for other places where we may need
    /// to replace Grapevine.
    /// </summary>
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = true, Inherited = true)]
    public class RestRouteAttribute : Attribute
    {
        public RestRouteAttribute(string method, string pathPrefix)
        {
            Method = method;
            PathPrefix = pathPrefix;
        }

        public string Method { get; }
        public string PathPrefix { get; }
    }
}
