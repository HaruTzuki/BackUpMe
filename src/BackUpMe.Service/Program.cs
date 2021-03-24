using BackUpMe.Data.Domain;
using BackUpMe.Data.Repository;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackUpMe.Service
{
	public class Program
	{
		public static void Main(string[] args)
		{
			CreateHostBuilder(args).Build().Run();
		}

		public static IHostBuilder CreateHostBuilder(string[] args) =>
			Host.CreateDefaultBuilder(args)
				.ConfigureServices((hostContext, services) =>
				{
					services.AddHostedService<Worker>();
					services.AddSingleton<IJobRepository, JobRepository>();
					services.AddSingleton<IActivityJobRepository, ActivityJobRepository>();
				}).UseWindowsService();
	}
}
