using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BackUpMe.Controls.Pages.SubPages
{
	public partial class SettingsEmail : UserControl
	{
		public SettingsEmail()
		{
			InitializeComponent();
		}

		private void txtPort_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
			{
				e.Handled = true;
			}
		}

		private void txtPort_TextChanged(object sender, EventArgs e)
		{
			if (!string.IsNullOrEmpty(txtPort.Text))
			{
				if (!int.TryParse(txtPort.Text, out int port))
				{
					MessageBox.Show("Only Digits allowed in this text box.", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}

				if (port > 65535 || port <= 0)
				{
					MessageBox.Show("Invalid value in port. Please use a number between 1 and 65535.", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
					txtPort.Text = "1";
					return;
				}
			}

			txtPort.Text = (sender as TextBox).Text;
		}

		private void chkEmailSender_CheckedChanged(object sender, EventArgs e)
		{
			foreach (Control ctrl in pnl_background.Controls)
			{
				if (ctrl.GetType() == typeof(TextBox) || (ctrl.GetType() == typeof(CheckBox) && ctrl.Name != "chkEmailSender"))
				{
					ctrl.Enabled = chkEmailSender.Checked;
				}
			}
		}
	}
}
