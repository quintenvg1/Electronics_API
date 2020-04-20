using electronika_api.Controllers;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace electronika_api.model
{
    public class DeviceContext : DbContext
    {
        public DeviceContext(DbContextOptions<DeviceContext> options) : base(options)
        {

        }

        public DbSet<device> Devices { get; set; }
        public DbSet<manufacturer> Manufacturors { get; set; }
    }
}
