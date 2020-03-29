using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace electronika_api.Controllers
{
	public class device //a device, owned by manufacturer
	{

		public int ID { get; set; }
		public string Devicename { get; set; }

		//quick initializer
		public device(int Id = 0, string devicename = "undefined")
		{
			this.ID = Id;
			this.Devicename = devicename;
		}
	}
}
