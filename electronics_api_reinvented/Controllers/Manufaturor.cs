using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace electronics_api_reinvented.Controllers
{
    [Table("manufacturors")]
    public class Manufaturor
    {
        [Key]
        public int ID { get; set; } = 0; //related to device.VendorId
        [Required]
        public string Manufaturor_name { get; set; }
    }
}
