using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Panoptico.Contracts.Metadata
{
    public class DatabaseContract
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
    }
}
