using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using electronika_api.Controllers;

namespace electronika_api.model
{
    public class DBinitializer
    {
        public static void Initialize(DeviceContext context)
        {
            context.Database.EnsureCreated();

            if (context.Devices.Any())
            {
                var Dvc = new device() {
                    Devicename = "default",
                    ID = 0,
                    Price = 0.0
                };

                context.Devices.Add(Dvc);
                context.SaveChanges();
            }
        }
    }
}
