using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Logging;
using Microsoft.IdentityModel.Tokens;
using OnlineOrdering.Data.DbContexts;
using OnlineOrdering.Data.Interfaces;
using OnlineOrdering.Data.Models;
using OnlineOrdering.Data.Repositories;
using OnlineOrdering.Services.Interfaces;
using OnlineOrdering.Services.Services;

namespace OnlineOrdering.Web
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


			services.AddIdentity<OOUser, IdentityRole>(cfg =>
			{
				cfg.User.RequireUniqueEmail = true;
			}).AddEntityFrameworkStores<OOContext>();


			services.AddDbContext<OOContext>(cfg =>
			{
				cfg.UseSqlServer(Configuration.GetConnectionString("OOConnectionString"));
			});

			services.AddAuthentication()
				.AddJwtBearer(cfg =>
				{
					cfg.TokenValidationParameters = new TokenValidationParameters()
					{
						ValidIssuer = Configuration["Tokens:Issuer"],
						ValidAudience = Configuration["Tokens:Audience"],
						IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Configuration["Tokens:Key"]))

					};
				});

			services.AddTransient<OnlineOrderingSeeder>();

			services.AddTransient<IRestaurantRepository, RestaurantRepository>();
			services.AddTransient<IRestaurantService, RestaurantService>();

			services.AddControllers();
		}

		// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
		public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
		{
			if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
				IdentityModelEventSource.ShowPII = true;
			}

			app.UseHttpsRedirection();

			app.UseRouting();

			app.UseAuthentication();
			app.UseAuthorization();

			app.UseEndpoints(endpoints =>
			{
				endpoints.MapControllers();
			});
		}
	}
}
