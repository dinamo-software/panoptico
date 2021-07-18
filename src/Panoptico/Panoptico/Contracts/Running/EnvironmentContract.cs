using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Panoptico.Contracts.Running
{
    public class EnvironmentContract
    {
        public string ApplicationName { get; internal set; }
        public string EnvironmentName { get; internal set; }
        public string ContentRootPath { get; internal set; }
        public string WebRootPath { get; internal set; }
    }
}
