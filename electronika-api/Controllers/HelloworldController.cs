using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace electronika_api.Controllers
{
    [Route("hi")]
    [ApiController]
    public class HelloworldController : ControllerBase
    {
        public IActionResult hello()
        {
            return Content("hello");
        }
    }
}