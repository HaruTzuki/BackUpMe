using BackUpMe.Data.Context;
using BackUpMe.Data.Repository;
using BackUpMe.Infastructure.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;

namespace BackUpMe.Data.Domain
{
	public class ActivityJobRepository : IActivityJobRepository
	{
		private readonly ModelContext context;
		public ActivityJobRepository()
		{
			context = new ModelContext();
		}

		public async Task<bool> DeleteActivityJob(ActivityJob activityJob)
		{
			try
			{
				context.ActivityJobs.Remove(activityJob);
				return await context.SaveChangesAsync() > 0;
			}
			catch (Exception ex)
			{
				// TODO Error Repository
				return false;
			}
		}

		public async Task<ActivityJob> GetActivityJob(int id)
		{
			try
			{
				return await context.ActivityJobs.Include(j=>j.Job).FirstOrDefaultAsync(aj => aj.Id == id);
			}
			catch (Exception ex)
			{
				// TODO Error Repository
				return null;
			}
		}

		public async Task<IEnumerable<ActivityJob>> GetActivityJobs()
		{
			try
			{
				return await context.ActivityJobs.Include(j=>j.Job).ToListAsync();
			}
			catch (Exception ex)
			{
				// TODO Error Repository
				return new List<ActivityJob>();
			}
		}

		public async Task<IEnumerable<ActivityJob>> GetActivityJobs(int jobId)
		{
			try
			{
				return await context.ActivityJobs.Include(j => j.Job).Where(aj => aj.JobId == jobId).ToListAsync();
			}
			catch (Exception ex)
			{
				// TODO Error Repository
				return new List<ActivityJob>();
			}
		}

		public async Task<bool> InsertActivityJob(ActivityJob activityJob)
		{
			try
			{
				if(activityJob == null)
				{
					return false;
				}

				context.ActivityJobs.Add(activityJob);
				return await context.SaveChangesAsync() > 0;
			}
			catch (Exception ex)
			{
				// TODO Error Repository
				return false;
			}
		}

		public async Task<bool> UpdateActivityJob(ActivityJob activityJob)
		{
			try
			{
				if(activityJob == null)
				{
					return false;
				}

				context.ActivityJobs.Update(activityJob);
				return await context.SaveChangesAsync() > 0;
			}
			catch (Exception ex)
			{
				// TODO Error Repository
				return false;
			}
		}
	}
}
