using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace electronics_api_reinvented.Controllers
{
    [Route("api/manufacturors")]
    [ApiController]
    public class manufaturorController : ControllerBase
    {

        private readonly DeviceContext mycontext;
        public manufaturorController(DeviceContext Context)
        {
            this.mycontext = Context;
        }
        [Route("list")]
        public List<Manufaturor> GetManufacturors()
        {
            return mycontext.manufacturors.ToList();
        }
        [HttpGet]
        public ActionResult GetAllManufacturors()
        {
            return GetAllManufacturors(); //Create a list from the devices in the database
        }


    }
}