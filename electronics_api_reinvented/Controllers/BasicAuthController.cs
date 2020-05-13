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
		[HttpGet]
		public IActionResult Login([FromHeader] string Authorization)
		{
			var credentials = Authorization; //read username and password from header field
			if (!string.IsNullOrEmpty(credentials))
				return Ok("you were logged in"); //return an authorsation okay, based on database in future

			Response.Headers.Add("WWW-Authenticate", "Basic");
			return Unauthorized();
			

		}
	}
}
