﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace electronics_api_reinvented.Controllers
{
	public class Device
	{
		/*
		public Device(string Name, int DeviceID, int VendorID, double price)
		{
			this.DeviceName = Name;
			this.DeviceId = DeviceID;
			this.VendorId = VendorID;
			this.Price = price;
		}*/
		public string DeviceName { get; set; } = "null";
		public int DeviceId { get; set; } = 0;
		public int VendorId { get; set; } = 1;
		public double Price { get; set; } = 1.0;


	}
}
