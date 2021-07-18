using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Panoptico.Contracts.Running
{
    public class VersionContract
    {
        //
        // Resumen:
        //     Gets the value of the minor component of the version number for the current System.Version
        //     object.
        //
        // Devuelve:
        //     The minor version number.
        public int Minor { get; set; }
        //
        // Resumen:
        //     Gets the value of the major component of the version number for the current System.Version
        //     object.
        //
        // Devuelve:
        //     The major version number.
        public int Major { get; set; }
        //
        // Resumen:
        //     Gets the value of the build component of the version number for the current System.Version
        //     object.
        //
        // Devuelve:
        //     The build number, or -1 if the build number is undefined.
        public int Build { get; set; }
    }
}
