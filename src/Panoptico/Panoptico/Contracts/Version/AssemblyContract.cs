using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace Panoptico.Contracts.Version
{
    public class AssemblyContract
    {
        public string ProcessorArchitecture { get; set; }

        public string Name { get; set; }

        public VersionContract Version { get; set; } = new VersionContract();
    }
}
