using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace electronika_api.Controllers
{
    [Route("api/devices")] //set root path
    [ApiController]
    public class DeviceController : ControllerBase
    {
        [HttpGet]
        //to display devices with sertain paging options
        public ActionResult displaydevices()
        {
            return Content("this is the device page");

        }

        [HttpGet("{manufacturer}")] //continue on root path
        public ActionResult displaydevices(string manufacturer)
        {
            return Content("all devices by " + manufacturer);
        }
    }
}