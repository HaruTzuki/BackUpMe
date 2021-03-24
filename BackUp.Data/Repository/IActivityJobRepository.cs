using BackUpMe.Infastructure.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackUpMe.Data.Repository
{
	public interface IActivityJobRepository
	{
		Task<ActivityJob> GetActivityJob(int id);
		Task<IEnumerable<ActivityJob>> GetActivityJobs();
		Task<IEnumerable<ActivityJob>> GetActivityJobs(int jobId);
		Task<bool> InsertActivityJob(ActivityJob activityJob);
		Task<bool> UpdateActivityJob(ActivityJob activityJob);
		Task<bool> DeleteActivityJob(ActivityJob activityJob);
	}
}
