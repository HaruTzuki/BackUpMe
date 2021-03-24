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
		public ActivityJobRepository()
		{
			
		}

		public async Task<bool> DeleteActivityJob(ActivityJob activityJob)
		{
			try
			{
				using var context = new ModelContext();
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
				using var context = new ModelContext();
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
				using var context = new ModelContext();
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
				using var context = new ModelContext();
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
				using var context = new ModelContext();
				if (activityJob == null)
				{
					return false;
				}
				context.ActivityJobs.Attach(activityJob);
				//context.ActivityJobs.Add(activityJob);
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
				using var context = new ModelContext();
				if (activityJob == null)
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
