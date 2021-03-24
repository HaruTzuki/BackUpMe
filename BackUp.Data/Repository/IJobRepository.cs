using BackUpMe.Infastructure.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BackUpMe.Data.Repository
{
	public interface IJobRepository
	{
		Task<Job> GetJob(int id);
		Task<IEnumerable<Job>> GetJobs();
		Task<bool> InsertJob(Job job);
		Task<bool> UpdateJob(Job job);
		Task<bool> DeleteJob(Job job);
	}
}
