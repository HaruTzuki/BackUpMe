using BackUpMe.Common.Utilities;
using BackUpMe.Infastructure.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace BackUpMe.Data.Context
{
	public class ModelContext : DbContext
	{
		public DbSet<Job> Jobs { get; set; }
		public DbSet<ActivityJob> ActivityJobs { get; set; }

		public ModelContext()
		{
			Database.Migrate();
		}

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			var db = Path.Combine(Path.GetDirectoryName(Process.GetCurrentProcess().MainModule?.FileName), Constants.DB_PATH);
			FileAndFolderManager.CreateFolder(Path.GetDirectoryName(db));
			optionsBuilder.UseSqlite($"Data Source={db}");
			base.OnConfiguring(optionsBuilder);
		}
	}
}
