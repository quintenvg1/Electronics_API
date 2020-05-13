using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Threading.Tasks;

namespace electronics_api_reinvented.Controllers
{
	public class DbInitializer
	{
		public static void Initialize(DeviceContext context)
		{
			context.Database.EnsureCreatedAsync();

			if (!context.device.Any())
			{
				//Device newdevice = new Device() {DeviceId = 2, DeviceName = "huawei y5 2018", VendorId = 2, Price = 153.25}; //Example device


				//context.device.Add(newdevice); //try to add it to the database
				//how do i make queries?
				
				context.SaveChanges();
				//after the database was surely there the device was added
			}
		}
	}
}
