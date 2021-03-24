using BackUpMe.Common.Enumeration;
using BackUpMe.Common.Utilities;
using BackUpMe.Data.Repository;
using BackUpMe.Infastructure.Model;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace BackUpMe.Service
{
	public class Worker : BackgroundService
	{
		private readonly ILogger<Worker> _logger;
		private readonly IJobRepository jobRepository;
		private readonly IActivityJobRepository activityJobRepository;

		public Worker(ILogger<Worker> logger, IJobRepository jobRepository, IActivityJobRepository activityJobRepository)
		{
			_logger = logger;
			this.jobRepository = jobRepository;
			this.activityJobRepository = activityJobRepository;
		}

		protected override async Task ExecuteAsync(CancellationToken stoppingToken)
		{
			while (!stoppingToken.IsCancellationRequested)
			{

				// Get Jobs
#if DEBUG
				_logger.LogInformation("Retrive Jobs From Database.");
#endif
				IEnumerable<Job> jobs = await jobRepository.GetJobs();

#if DEBUG
				_logger.LogInformation("Retrived Jobs From Database.");
#endif
				var counter = 0;
				foreach (var job in jobs)
				{
					++counter;
					_logger.LogInformation($"Job in line {counter} started and {DateTime.Now}");
					switch (job.BackUpType)
					{
						case BackUpType.EveryDay:
							await DoWorkEveryDay(job);
							break;
						case BackUpType.EveryWeek:
							break;
						case BackUpType.EveryMonth:
							break;
						default:
							break;
					}
				}

				_logger.LogInformation("Worker running at: {time}", DateTimeOffset.Now);
				await Task.Delay(1000, stoppingToken);
			}
		}

		private async Task DoWorkEveryDay(Job job)
		{

			//if ((job.TimeToExecute.Hour != DateTime.Now.Hour) || (job.TimeToExecute.Minute != DateTime.Now.Minute))
			//{
			//	return;
			//}

			//var dbList = await activityJobRepository.GetActivityJobs(job.Id);

			//// Check if Running Now
			//if (dbList.OrderByDescending(aj => aj.Id).Take(1).FirstOrDefault().IsRunning)
			//{
			//	return;
			//}


			//if (dbList.Any(aj => aj.FinishedExecutionDate <= DateTime.Now && aj.StatusType == StatusType.Success && aj.JobId == job.Id))
			//{
			//	return;
			//}


			var activityJob = new ActivityJob()
			{
				Job = job,
				JobId = job.Id,
				IsRunning = true,
				StartedExecutionDate = DateTime.Now
			};

			if (await activityJobRepository.InsertActivityJob(activityJob))
			{
				ProcessStartInfo processStartInfo = new ProcessStartInfo();
				processStartInfo.FileName = "backupmeproc";
				processStartInfo.Arguments = activityJob.Id.ToString();
				Process.Start(processStartInfo);
			}



			// FileAndFolderManager.CopyDirectoriesAndFiles(job.SourcePath, job.DestinationPath);

		}




	}
}
