using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace electronics_api_reinvented.Controllers
{
    [Route("api/main")]
    [ApiController]
    public class MainController : ControllerBase
    {
        List<Vendor> myvendors = new List<Vendor>();
        string vendorlist;
        int a = 0;
        public ActionResult navigation()
        {
            a += 1;
            return Content("main page, options show vendors, add and remove vendors " + a);
        }

        [HttpGet("vendors/{Vendor}")] //api/main/vendors/"vendorstring"
        public ActionResult showvendors(string Vendor)
        {
            foreach (Vendor a in myvendors) 
            {
               vendorlist += a.Manufacturor_name; //convert to string all the vendor names
            }
            return (Content(vendorlist)); //workaround for json
        }

        [HttpGet("vendors/new/{VendorId}/{vendorname}")]
        public void add_vendor(int VendorId, string vendorname)
        {
            myvendors.Add(new Vendor(/*vendorname, VendorId*/));
        }


    }
}