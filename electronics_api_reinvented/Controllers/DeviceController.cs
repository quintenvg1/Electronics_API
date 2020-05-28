using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace electronics_api_reinvented.Controllers
{
    [Route("api/device")]
    [ApiController]
    public class DeviceController : ControllerBase
    {
        public bool loggedin { get; set; } = false;
        [HttpPost] //works completely
        //public object addDevice([FromBody]int Device_ID, string device_name, double price, int Manufaturor_ID)
        public ActionResult<Device> addDevice([FromBody]Device newdevice)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            try
            {
                mycontext.Add(newdevice); //add device to database
                mycontext.SaveChanges(); //save the database
                return Created("", newdevice); //return the result

            }
            catch
            {
                return NotFound();
            }

        }

        [Route("list")]
        [HttpGet]
        public List<Device> GetDevices(int? page = 1, int length = 3, string sort = "", string dir = "", int bymanufacturor = 0)
        {
            IQueryable<Device> query = mycontext.device; //get the specific devices
            if (bymanufacturor != 0) //add paging on specificdevices
            {
                query = query.Where(d => d.Manufaturor_ID == bymanufacturor);
                //return query.ToList();
            }

            if (length > 0)
            {
               
                try
                {
                    //paging
                    query = query.Skip(page.Value * length);
                    query = query.Take(length);
                    //sorting
                    if (sort == "price")
                    {
                        if (dir == "asc")
                        {
                            query = query.OrderBy(d => d.price);
                        }
                        if (dir == "dec")
                        {
                            query = query.OrderByDescending(d => d.price);
                        }

                    }
                    if(sort == "name")
                    {
                        if (dir == "asc")
                        {
                            query = query.OrderBy(d => d.device_name);
                        }
                        if (dir == "dec")
                        {
                            query = query.OrderByDescending(d => d.device_name);
                        }
                    }
                    return query.ToList(); //return the filtered result
                }
                catch
                {
                    //nothing
                }

            }
            
            return mycontext.device.ToList(); //Create a list from the devices in the database
        }


        [HttpGet("list/{id}")]
        public List<Device> Getspecificdevices(int ID)
        {
            List<Device> foundDevices = new List<Device>();
            var devices = mycontext.device;
            foreach(var Device in devices)
            {
                if(Device.Manufaturor_ID == ID)
                {
                    foundDevices.Add(Device);
                }
            }
            return foundDevices;
        }
        public DeviceController(DeviceContext Context)
        {
            this.mycontext = Context;
        }
        private readonly DeviceContext mycontext;
        //[HttpGet("add/{deviceID}/{vendorID}/{name}/{Price}")] //create device for the database

        
            /*
        //[Route("show")] //depricated
        [HttpGet("show/{deviceId}")] //read data from the database
        public ActionResult showdevice(int deviceId)
        {
            var Device_ID = deviceId; //to make a query on a given ID
            var device = mycontext.device.Find(Device_ID);
            try
            {
                return Content(device.device_name.ToString()); //returns the device if it exists
            }
            catch
            {
                return Content("the device doens't exsist");
            }


        }
        */
        [Route("update")]
        [HttpGet("{deviceID}/{vendorID}/{name}/{Price}")] //update
        public ActionResult update(int deviceID, int vendorID, string name, double Price)
        {
  
            string device_name = name;
            double price = Price;
            int Manufaturor_ID = vendorID;
            int Device_ID = deviceID;
            var updated_device = new Device() { Device_ID = Device_ID, device_name = device_name, Manufaturor_ID = Manufaturor_ID, price = Price };
            try
            {
                var device = mycontext.device.Find(Device_ID); //update the device where the id matches
                //mycontext.Update(device, updated_device);
                mycontext.SaveChanges();
                return Content("updated device"); //return the succes message
            }
            catch
            {
                return Content("update failed");
            }

        }
        //[Route("delete")] //apî/device/deviceID
        [HttpDelete("{deviceID}")]
        public ActionResult delete_device(int deviceID)
        {
            /*
            if (!loggedin)
            {
                Redirect("https://localhost:44364/api/basicauth");
                return Content("you have to login first");
                
            }
            */
            var Device_ID = deviceID;
            try
            {
                var device = mycontext.device.Find(Device_ID);
                mycontext.Remove(device);
                mycontext.SaveChanges();
                return Ok();
                //return Content("removed device with id: "+ deviceID.ToString());
            }
            catch
            {
                //return Content("failed to remove the device");
                return NotFound();
            }
        }
    }
}