using System;
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
        public List<Device> GetDevices()
        {
            return mycontext.device.ToList(); //Create a list from the devices in the database
        }
        public DeviceController(DeviceContext Context)
        {
            this.mycontext = Context;
        }
        private readonly DeviceContext mycontext;
        [HttpGet("add/{deviceID}/{vendorID}/{name}/{Price}")] //create device for the database
        public ActionResult addDevice(int DeviceId, int vendorID, string name, double Price)
        {
            int Device_ID = DeviceId;
            string device_name = name;
            double price = Price;
            int Manufaturor_ID = vendorID;
            mycontext.Add(new Device() { Device_ID = Device_ID, device_name = device_name, Manufaturor_ID = Manufaturor_ID, price = price}) ; //add device to database
            mycontext.SaveChanges(); //save the database
            return Content("new device added"); //return the result
        }
        [HttpGet("show/{deviceId}")] //read data from the database
        public ActionResult showdevice(int ID)
        {
            var Device_ID = ID; //to make a query on a given ID
            
            return Content("device[" + Device_ID + "]");
            //return Content(mycontext.device.Find(Device_ID).ToString());
        }

        [HttpPost("update/{deviceID}/{vendorID}/{name}/{price}")] //update
        public ActionResult update(int deviceID, int vendorID, string name, double price)
        {
            try
            {
                mycontext.Update("where device.ID = deviceID values(deviceID, vendorID, name, price)"); //update the device where the id matches
                mycontext.SaveChanges();
                return Content("updated device"); //return the succes message
            }
            catch
            {
                return Content("update failed");
            }

        }

        [HttpGet("delete/{deviceID}")]
        public ActionResult delete_device(int deviceID)
        {
            var Device_ID = deviceID;
            try
            {
                var device = mycontext.device.Find(Device_ID);
                mycontext.Remove(device);
                mycontext.SaveChanges();
                return Content("removed device with id: "+ deviceID.ToString());
            }
            catch
            {
                return Content("failed to remove the device");
            }
        }
    }
}