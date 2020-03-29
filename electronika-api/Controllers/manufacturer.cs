using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace electronika_api.Controllers
{
	public class manufacturer //this class is for the manufacturer a manufacturor has devices
	{
		public string Name { get; set; } = "null";

		public List<device> Devicelist { get; set; } = new List<device>();

		public manufacturer(string name)
		{
			this.Name = name;
		}
	}
}
