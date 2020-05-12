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
				//Device newdevice = new Device("test",0,0,0);


				//context.Devices.Add(newdevice);
				
				context.SaveChanges();
				//after the database was surely there the device was added
			}
		}
	}
}
