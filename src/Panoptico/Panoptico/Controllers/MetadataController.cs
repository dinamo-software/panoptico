using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Panoptico.Contracts.Metadata;

namespace Panoptico.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MetadataController : ControllerBase
    {
        [HttpGet("databases")]
        public List<DatabaseContract> GetDatabases()
        {
            var list = new List<DatabaseContract>(0);
            list.Add(new DatabaseContract() { Id = 1, Code = Guid.NewGuid().ToString(), Name = "MASTER" });
            return list;
        }
    }
}
