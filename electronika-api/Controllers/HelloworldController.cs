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
        [HttpGet]
        public IActionResult hello(int id)
        {
            return Content(id.ToString());
        }

        [HttpPost]

        public IActionResult postresult(int id)
        {
            return Content(id.ToString());
        }
    }
}