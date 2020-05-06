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

			if (!context.Devices.Any())
			{
				var device = new Device()
				{
					DeviceId = 0,
					DeviceName = "Default device",
					Price = 100.35,
					VendorId = 1,
				};

				context.Devices.Add(device);
				context.SaveChanges();
				//after the database was surely there the device was added
			}
		}
	}
}
