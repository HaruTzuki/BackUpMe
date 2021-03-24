using BackUpMe.Common.Configuration;
using BackUpMe.Common.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BackUpMe.Controls.Pages.SubPages
{
	public partial class SettingsGeneral : UserControl
	{
		private AppSettings appSettings;
		public SettingsGeneral()
		{
			InitializeComponent();
			InitControls();
		}

		private async void InitControls()
		{
			appSettings = new AppSettings();
			await appSettings.LoadAppSettings().ConfigureAwait(false);

			InvokeConnectionStringToTextBox();
			
		}

		private void InvokeConnectionStringToTextBox()
		{
			if (txtDatabasePath.InvokeRequired)
			{
				txtDatabasePath.Invoke(new Action(InvokeConnectionStringToTextBox));
			}
			txtDatabasePath.Text = DatabaseConnection.ConnectionString;
		}

		private async void btnBrowseDatabase_Click(object sender, EventArgs e)
		{
			var folder = FileAndFolderManager.OpenFolderManager();
			if (string.IsNullOrEmpty(folder))
			{
				appSettings.ConnectionString = txtDatabasePath.Text;
			}
			else
			{
				appSettings.ConnectionString = Path.Combine(folder, "backupme.db");
			}

			await appSettings.CommitAppSettings();
			InvokeConnectionStringToTextBox();
		}
	}
}
