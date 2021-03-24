using BackUpMe.Controls.Pages.SubPages;
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
	public partial class Settings : UserControl
	{

		private SettingsGeneral ucSettingsGeneral;
		private SettingsEmail ucEmailSettings;
		public Settings()
		{
			InitializeComponent();
			SetUpInit();
		}

		private void SetUpInit()
		{
			InitSettingGeneralPage();
		}

		private void InitSettingGeneralPage()
		{
			if(ucSettingsGeneral is null)
			{
				ucSettingsGeneral = new SettingsGeneral();
			}

			ucSettingsGeneral.Dock = DockStyle.Fill;
			ucSettingsGeneral.Name = "UC_SettingsGeneral";

			if (!pnl_subpage.Controls.Contains(ucSettingsGeneral))
			{
				pnl_subpage.Controls.Add(ucSettingsGeneral);
			}

			ucSettingsGeneral.BringToFront();
		}

		private void btnTabButton_Click(object sender, EventArgs e)
		{
			switch ((sender as Button).Tag.ToString())
			{
				case "GeneralSettings":
					InitSettingGeneralPage();
					break;
				case "EmailSettings":
					InitEmailSettingsPage();
					break;
				default:
					InitSettingGeneralPage();
					break;
			}
		}

		private void InitEmailSettingsPage()
		{
			if(ucEmailSettings is null)
			{
				ucEmailSettings = new SettingsEmail();
			}

			ucEmailSettings.Dock = DockStyle.Fill;
			ucEmailSettings.Name = "UC_EmailSettings";

			if (!pnl_subpage.Controls.Contains(ucEmailSettings))
			{
				pnl_subpage.Controls.Add(ucEmailSettings);
			}

			ucEmailSettings.BringToFront();
		}
	}
}
