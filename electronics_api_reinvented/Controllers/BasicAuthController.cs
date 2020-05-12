using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace electronics_api_reinvented.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class BasicAuthController : Controller
	{

		public IActionResult Login()
		{
			Response.Headers.Add("WWW-Authenticate", "basic");
			return Unauthorized();
		}
	}
}
