﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace electronics_api_reinvented.Controllers
{
    [Route("api/devicecontroller")]
    [ApiController]
    public class DeviceController : ControllerBase
    {
        DeviceContext mycontext; //link the database?
        [HttpGet("add/{deviceID}/{vendorID}/{name}/{price}")]
        public ActionResult addDevice(int DeviceId, int vendorID, string name, double price)
        {
            //to add later check for double devices
            mycontext.Add(new Device(name,DeviceId,vendorID,price)); //add device to database
            mycontext.SaveChanges(); //save the database
            return Content("new device added"); //return the result
        }
    }
}