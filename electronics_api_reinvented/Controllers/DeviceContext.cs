using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DbContext = Microsoft.EntityFrameworkCore.DbContext;


namespace electronics_api_reinvented.Controllers //database for manufacturors and devices
{
	public class DeviceContext : DbContext
	{
		public DeviceContext(DbContextOptions<DeviceContext> options) : base(options)
		{
			
		}

		public DbSet<Device> device { get; set; }
		

		//public DbSet<Vendor> Manufacturors {get; set;}
		

	}
}
