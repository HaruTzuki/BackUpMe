using BackUpMe.Data.Domain;
using BackUpMe.Data.Repository;
using BackUpMe.Common.Enumeration;
using BackUpMe.Common.Utilities;
using BackUpMe.Infastructure.Model;
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
	public partial class MainPage : UserControl
	{
		private Job job;
		private BackUpType backUpType;
		private byte dayMonth;

		private readonly IJobRepository jobRepository;

		public MainPage()
		{
			InitializeComponent();
			jobRepository = new JobRepository();
		}
		private void rbtn_backUpType_CheckedChanged(object sender, EventArgs e)
		{
			if(!Enum.TryParse((sender as RadioButton).Tag.ToString(), out backUpType))
			{
				return;
			}

			switch (backUpType)
			{
				case BackUpType.EveryDay:
					pnl_backupday.Height = 0;
					break;
				case BackUpType.EveryWeek:
					pnl_backupday.Height = 35;
					dtp_daymonth.Format = DateTimePickerFormat.Custom;
					dtp_daymonth.CustomFormat = "dddd";
					dayMonth = byte.Parse(dtp_daymonth.Value.DayOfWeek.ToString());
					break;
				case BackUpType.EveryMonth:
					pnl_backupday.Height = 35;
					dtp_daymonth.Format = DateTimePickerFormat.Custom;
					dtp_daymonth.CustomFormat = "MMMM";
					dayMonth = byte.Parse(dtp_daymonth.Value.Month.ToString());
					break;
				default:
					break;
			}
		}

		private void btnBrowseSourcePath_Click(object sender, EventArgs e)
		{
			txt_source_path.Text = FileAndFolderManager.OpenFolderManager();
		}

		private void btnBrowseDestinationPath_Click(object sender, EventArgs e)
		{
			txt_destination_path.Text = FileAndFolderManager.OpenFolderManager();
		}

		private async void btnAddTask_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(txtTaskName.Text))
			{
				createTaskErrorProvider.SetError(txtTaskName, "This field is mandatory.");
				return;
			}

			if (string.IsNullOrEmpty(txt_destination_path.Text))
			{
				createTaskErrorProvider.SetError(txt_destination_path, "This field is mandatory");
				return;
			}

			if (string.IsNullOrEmpty(txt_source_path.Text))
			{
				createTaskErrorProvider.SetError(txt_source_path, "This field is mandatory");
				return;
			}


			if(job is null)
			{
				job = new Job();
			}

			job.JobName = txtTaskName.Text;
			job.SourcePath = txt_source_path.Text;
			job.DestinationPath = txt_destination_path.Text;
			job.BackUpType = backUpType;
			job.DayMonth = dayMonth;
			job.TimeToExecute = dtTimeExecution.Value;

			if(!await jobRepository.InsertJob(job))
			{
				MessageBox.Show("Something goes wrong. Please sure if all is correct! If all is correct and problem exist again please contact with administrator.", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			MessageBox.Show("Job added successfully.", "Information...", MessageBoxButtons.OK, MessageBoxIcon.Information);
			
		}
	}
}
