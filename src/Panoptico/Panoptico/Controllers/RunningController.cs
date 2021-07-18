using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Panoptico.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RunningController : ControllerBase
    {
        [HttpGet("version")]
        public IActionResult GetVersion()
        {
            var assembly = typeof(Startup).Assembly;
            var assemblyName = assembly.GetName();

            var assemblyContract = new Contracts.Version.AssemblyContract();

            assemblyContract.ProcessorArchitecture = assemblyName.ProcessorArchitecture.ToString();
            assemblyContract.Name = assemblyName.Name ?? "";
            assemblyContract.Version.Major = assemblyName.Version.Major;
            assemblyContract.Version.Minor = assemblyName.Version.Minor;
            assemblyContract.Version.Build = assemblyName.Version.Build;

            return Ok(assemblyContract);
        }


        [HttpGet("environment")]
        public IActionResult GetEnvironment([FromServices] IWebHostEnvironment env)
        {
            return Ok(env);
        }
    }
}
