﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace electronika_api.Controllers
{
	public class device //a device, owned by manufacturer
	{

		public int ID { get; set; }
		public string ManufaturorID { get; set; }
		public double Price { get; set; }
		public string Devicename { get; set; }

		/*
		//quick initializer
		private device(int Id = 0, string devicename = "undefined", double price = 0.00)
		{
			this.ID = Id;
			this.Devicename = devicename;
			this.Price = price;
		}
		*/
	}
}
