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
				var device = new Device("name", 1 , 1, 1.0);
				{
					//the device was created
				};

				context.Devices.Add(device);
				context.SaveChanges();
				//after the database was surely there the device was added
			}
		}
	}
}
