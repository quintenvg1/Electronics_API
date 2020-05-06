using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace electronika_api.Controllers
{
	public class manufacturer //this class is for the manufacturer a manufacturor has devices
	{
		public int ManufacturerID { get; set; } //related to device ManufacturorID
		public List<device> Mydevices { get; set; }
		public string Name { get; set; } = "null";


		public manufacturer(string name)
		{
			this.Name = name;
		}
	}
}
