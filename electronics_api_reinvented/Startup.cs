using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using electronics_api_reinvented.Controllers;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;

namespace electronics_api_reinvented
{
	public class Startup
	{
		public Startup(IConfiguration configuration)
		{
			Configuration = configuration;
		}

		public IConfiguration Configuration { get; }

		// This method gets called by the runtime. Use this method to add services to the container.
		public void ConfigureServices(IServiceCollection services)
		{

			services.AddAuthentication();
			services.AddControllers();
			services.Configure<ApiBehaviorOptions>(options =>
			{
				options.SuppressModelStateInvalidFilter = true;
			});


			services.AddDbContextPool<DeviceContext>(options => options

				.UseMySql("Server=localhost;Database=electronics_api;User=root;Password='';", mySqlOptions => mySqlOptions
					// replace with your Server Version and Type
					.ServerVersion(new Version(8, 0, 18), ServerType.MySql)));
		}

		// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
		public void Configure(IApplicationBuilder app, IWebHostEnvironment env, DeviceContext devcontext)
		{
			if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
			}

			app.UseCors(builder =>
			builder.AllowAnyOrigin()
					.AllowAnyMethod()
					.AllowAnyHeader()
			);

			DbInitializer.Initialize(devcontext);

			app.UseHttpsRedirection();

			app.UseRouting();

			app.UseAuthentication();

			app.UseEndpoints(endpoints =>
			{
				endpoints.MapControllers();
			});
		}
	}
}
