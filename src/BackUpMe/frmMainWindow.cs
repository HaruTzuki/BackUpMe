using BackUpMe.Controls.Pages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BackUpMe
{
	public partial class frmMainWindow : Form
	{
		public const int WM_NCLBUTTONDOWN = 0xA1;
		public const int HT_CAPTION = 0x2;

		[DllImport("user32.dll")]
		public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
		[DllImport("user32.dll")]
		public static extern bool ReleaseCapture();

		private MainPage ucMainPage;
		private ScheduledTasks ucScheduledTasks;
		private ActivityLogs ucActivityLogs;
		private Settings ucSettings;

		public frmMainWindow()
		{
			InitializeComponent();
			SetUpInit();
		}

		private void SetUpInit()
		{
			InitCreateTaskPage();
		}

		private void BtnCloseApplication_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnMenuClick_Click(object sender, EventArgs e)
		{
			SwitchPages((sender as Button).Tag.ToString());
		}

		private void SwitchPages(string pageName)
		{
			switch (pageName)
			{
				case "CreateTask":
					InitCreateTaskPage();
					break;
				case "ScheduledTasks":
					InitScheduledTasksPage();
					break;
				case "ActivityLogs":
					InitActivityLogsPage();
					break;
				case "Settings":
					InitSettingsPage();
					break;
				default:
					break;
			}
		}

		private void InitSettingsPage()
		{
			if(ucSettings is null)
			{
				ucSettings = new Settings();
			}

			ucSettings.Dock = DockStyle.Fill;
			ucSettings.Name = "UC_Settings";

			if (!pnl_mainpage.Controls.Contains(ucSettings))
			{
				pnl_mainpage.Controls.Add(ucSettings);
			}

			ucSettings.BringToFront();
		}

		private void InitActivityLogsPage()
		{
			if (ucActivityLogs is null)
			{
				ucActivityLogs = new ActivityLogs();
			}

			ucActivityLogs.Dock = DockStyle.Fill;
			ucActivityLogs.Name = "UC_ActivityLogs";

			if (!pnl_mainpage.Controls.Contains(ucActivityLogs))
			{
				pnl_mainpage.Controls.Add(ucActivityLogs);
			}

			ucActivityLogs.BringToFront();
		}

		private void InitCreateTaskPage()
		{
			if (ucMainPage is null)
			{
				ucMainPage = new MainPage();
			}

			ucMainPage.Dock = DockStyle.Fill;
			ucMainPage.Name = "UC_MainPage";

			if (!pnl_mainpage.Controls.Contains(ucMainPage))
			{
				pnl_mainpage.Controls.Add(ucMainPage);
			}

			ucMainPage.BringToFront();

		}

		private void InitScheduledTasksPage()
		{
			if(ucScheduledTasks is null)
			{
				ucScheduledTasks = new ScheduledTasks();
			}

			ucScheduledTasks.Dock = DockStyle.Fill;
			ucScheduledTasks.Name = "UC_ScheduledTasks";

			if (!pnl_mainpage.Controls.Contains(ucScheduledTasks))
			{
				pnl_mainpage.Controls.Add(ucScheduledTasks);
			}

			ucScheduledTasks.BringToFront();
		}

		private void pnl_header_MouseDown(object sender, MouseEventArgs e)
		{
			if(e.Button == MouseButtons.Left)
			{
				ReleaseCapture();
				SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
			}
		}
	}
}
