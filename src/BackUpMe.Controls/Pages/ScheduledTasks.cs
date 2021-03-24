using BackUpMe.Data.Domain;
using BackUpMe.Data.Repository;
using BackUpMe.Common.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BackUpMe.Controls.Pages
{
	public partial class ScheduledTasks : UserControl
	{
		private readonly IJobRepository jobRepository;
		private readonly IActivityJobRepository activityJobRepository;
		public ScheduledTasks()
		{
			InitializeComponent();
			jobRepository = new JobRepository();
			activityJobRepository = new ActivityJobRepository();
			this.Load += ScheduledTasks_Load;
			this.GotFocus += ScheduledTasks_GotFocus;
		}

		private async void ScheduledTasks_GotFocus(object sender, EventArgs e)
		{
			await GetData();
		}

		private async void ScheduledTasks_Load(object sender, EventArgs e)
		{
			await GetData();
		}

		private async Task GetData()
		{
			var dbJobs = await jobRepository.GetJobs();
			var dbActivityJobs = await activityJobRepository.GetActivityJobs();
			
			foreach(var job in dbJobs)
			{
				list_view_scheduled_tasks.Items.Add(new ListViewItem(new string[]
				{
					job.JobName,
					job.SourcePath,
					job.DestinationPath,
					dbActivityJobs.Where(x=>x.JobId == job.Id).OrderByDescending(x=>x.Id).Take(1).FirstOrDefault()?.FinishedExecutionDate.ToString(),
					dbActivityJobs.Where(x=>x.JobId == job.Id).OrderByDescending(x=>x.Id).Take(1).DefaultIfEmpty(new Infastructure.Model.ActivityJob()).FirstOrDefault().StatusType.ExtToString(),
				}));

			}
		}


		private void list_view_scheduled_tasks_MouseClick(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Right && list_view_scheduled_tasks.FocusedItem.Bounds.Contains(e.Location))
			{
				contextMenu_rows.Show(Cursor.Position);

			}
		}

		private void context_ShowDetails_Click(object sender, EventArgs e)
		{
			ShowTaskDetails();
		}

		private void context_DeleteTask_Click(object sender, EventArgs e)
		{
			DialogResult dr = MessageBox.Show($"You gonna delete Task with Name: {list_view_scheduled_tasks.SelectedItems[0].Text}!" + Environment.NewLine + "This action cannot be undone. Are you sure?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

			if (dr == DialogResult.No) return;

			list_view_scheduled_tasks.Items.Remove(list_view_scheduled_tasks.SelectedItems[0]);
		}

		private void list_view_scheduled_tasks_DoubleClick(object sender, EventArgs e)
		{
			ShowTaskDetails();
		}
		private void ShowTaskDetails()
		{
			MessageBox.Show("You would edit the item " + list_view_scheduled_tasks.SelectedItems[0].Text);
		}
	}
}
