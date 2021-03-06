using BackUpMe.Data.Context;
using BackUpMe.Data.Repository;
using BackUpMe.Infastructure.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BackUpMe.Data.Domain
{
	public class JobRepository : IJobRepository
	{

		public JobRepository()
		{
			
		}

		public async Task<bool> DeleteJob(Job job)
		{
			try
			{
				using var context = new ModelContext();
				context.Jobs.Remove(job);
				return await context.SaveChangesAsync() > 0;
			}
			catch (Exception ex)
			{
				// TODO Error Repository
				return false;
			}
		}

		public async Task<Job> GetJob(int id)
		{
			try
			{
				using var context = new ModelContext();
				return await context.Jobs.FirstOrDefaultAsync(j=>j.Id == id);
			}
			catch (Exception ex)
			{
				// TODO Error Repository
				return null;
			}
		}

		public async Task<IEnumerable<Job>> GetJobs()
		{
			try
			{
				using var context = new ModelContext();
				return await context.Jobs.ToListAsync();
			}
			catch (Exception ex)
			{
				// TODO Error Repository
				return new List<Job>();
			}
		}

		public async Task<bool> InsertJob(Job job)
		{
			try
			{
				using var context = new ModelContext();
				if (job == null)
				{
					return false;
				}

				context.Jobs.Add(job);
				return await context.SaveChangesAsync() > 0;
			}
			catch (Exception ex)
			{
				// TODO Error Repository
				return false;
			}
		}

		public async Task<bool> UpdateJob(Job job)
		{
			try
			{
				using var context = new ModelContext();
				if (job == null)
				{
					return false;
				}

				context.Jobs.Update(job);
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
