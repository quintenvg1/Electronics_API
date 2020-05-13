using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace electronics_api_reinvented.Controllers
{
	public class Vendor
	{
		public List<Device> MyDevices {get; set;} //list of devices
		[Key]
		public int ID { get; set; } = 0; //related to device.VendorId
		public string Manufacturor_name { get; set; } = "nullos";

		/*
		public Vendor(string brand, int Vendorid)
		{
			this.ID = Vendorid;
			this.Manufacturor_name = brand;
		}
		*/
	}
}
