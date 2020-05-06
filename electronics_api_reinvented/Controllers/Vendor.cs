using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace electronics_api_reinvented.Controllers
{
	public class Vendor
	{
		public List<Device> MyDevices {get; set;} //list of devices
		public int VendorId { get; set; } = 0; //related to device.VendorId
		public string Vendor_Brand { get; set; } = "nullos";

		public Vendor(string brand, int Vendorid)
		{
			this.VendorId = Vendorid;
			this.Vendor_Brand = brand;
		}
	}
}
