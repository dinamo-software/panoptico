using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Panoptico.Contracts.Running
{
    public class RunningContract
    {
        public EnvironmentContract Environment { get; set; }
        public AssemblyContract Assembly { get; set; }
        public string FrameworkDescription { get; set; }
    }
}
