using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace electronics_api_reinvented.Controllers
{
	[Table("device")]
	public class Device
	{
		/*
		public Device(string Name, int DeviceID, int VendorID, double price)
		{
			this.device_name = Name;
			this.DeviceId = DeviceID;
			this.VendorId = VendorID;
			this.Price = price;
		}*/
		public string device_name { get; set; } = "null";
		[Key]
		public int Device_ID { get; set; } = 0;
		public int Manufaturor_ID { get; set; } = 1;
		public double price { get; set; } = 1.0;


	}
}
