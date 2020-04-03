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
        private manufacturer samsung = new manufacturer("samsung");
        public device newdevice = new device() { };
        [HttpGet("get/{id}/{variable}")] //set the available rest variables hi/1/test as example
        public IActionResult hello(string variable, int id)
        {
            if (id == 1)
            {
                return Content(id.ToString());
            }
            else
            {
                return Content(variable.ToString() + " id");
            }

        }


        [HttpPost("post/{id}/{variable}")]

        public IActionResult postresult(int id, string variable)
        {
            newdevice.ID = id;
            newdevice.Devicename = variable;
            samsung.Devicelist.Add(newdevice);
            //Console.WriteLine(samsung.Devicelist.ToString());
            return Content("back to main");
        }
    }
}