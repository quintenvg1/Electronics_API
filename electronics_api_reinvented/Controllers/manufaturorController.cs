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

        [HttpPost]
        public ActionResult AddManufacturor([FromBody] Manufaturor newmanufaturor)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            try
            {
                mycontext.manufacturors.Add(newmanufaturor);
                mycontext.SaveChanges();
                return Ok();
            }
            catch
            {
                return NotFound();
            }
        }

        [HttpDelete("{ID}")]
        public ActionResult remove_manufacturor(int ID)
        {
            try
            {
                var mantoremove = this.mycontext.manufacturors.Find(ID);
                mycontext.manufacturors.Remove(mantoremove);
                mycontext.SaveChanges();
                return Ok();
            }
            catch
            {
                return NotFound();
            }
        }



        [HttpGet("list")] //returns the list as json?
        public List<Manufaturor> GetManufacturors()
        {
            return mycontext.manufacturors.ToList();
        }
        
        [HttpGet("list/{ID}")]
        public List<Manufaturor> GetSpecificManufacturor(int ID)
        {
            List<Manufaturor> result = new List<Manufaturor>();
            result.Add(mycontext.manufacturors.Find(ID));
            return result;
        }
        


    }
}