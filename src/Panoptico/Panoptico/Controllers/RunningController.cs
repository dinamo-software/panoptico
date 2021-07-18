using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
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
        [HttpGet("")]
        public IActionResult Get([FromServices] IWebHostEnvironment env)
        {
            var running = new Contracts.Running.RunningContract();

            running.FrameworkDescription = RuntimeInformation.FrameworkDescription;
            running.Environment = GetEnvironmentInternal(env);
            running.Assembly = GetCurrentAssembly();

            return Ok(running);
        }

        

        [HttpGet("version")]
        public IActionResult GetVersion()
        {
            return Ok(GetCurrentAssembly());
        }


        [HttpGet("environment")]
        public IActionResult GetEnvironment([FromServices] IWebHostEnvironment env)
        {
            return Ok(env);
        }

        [NonAction]
        private Contracts.Running.EnvironmentContract GetEnvironmentInternal(IWebHostEnvironment env)
        {
            return new Contracts.Running.EnvironmentContract()
            {
                ApplicationName = env.ApplicationName,
                EnvironmentName = env.EnvironmentName,
                ContentRootPath = env.ContentRootPath,
                WebRootPath = env.WebRootPath
            };
        }

        [NonAction]
        private Contracts.Running.AssemblyContract GetCurrentAssembly()
        {
            var assembly = typeof(Startup).Assembly;
            var assemblyName = assembly.GetName();

            var assemblyContract = new Contracts.Running.AssemblyContract();

            assemblyContract.ProcessorArchitecture = assemblyName.ProcessorArchitecture.ToString();
            assemblyContract.Name = assemblyName.Name ?? "";
            assemblyContract.Version.Major = assemblyName.Version.Major;
            assemblyContract.Version.Minor = assemblyName.Version.Minor;
            assemblyContract.Version.Build = assemblyName.Version.Build;

            return assemblyContract;
        }
    }
}
