using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using OnlineOrdering.Data.DbContexts;
using Microsoft.Extensions.DependencyInjection;

namespace OnlineOrdering.Web
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var host = CreateHostBuilder(args).Build();

			RunSeeding(host);
			
			host.Run();
		}

		private static void RunSeeding(IHost host)
		{
			var scopeFactory = host.Services.GetService<IServiceScopeFactory>();

			using var scope = scopeFactory.CreateScope();
			var seeder = scope.ServiceProvider.GetService<OnlineOrderingSeeder>();
			seeder.SeedAsync().Wait();
		}

		public static IHostBuilder CreateHostBuilder(string[] args) =>
			Host.CreateDefaultBuilder(args)
				.ConfigureAppConfiguration(ProvisionConfiguration)
				.ConfigureWebHostDefaults(webBuilder =>
				{
					webBuilder.UseStartup<Startup>();
				});

		private static void ProvisionConfiguration(HostBuilderContext ctx, IConfigurationBuilder builder)
		{
			builder.Sources.Clear();

			builder.AddJsonFile("appsettings.json", false, true)
				.AddEnvironmentVariables();
				
		}
	}
}
