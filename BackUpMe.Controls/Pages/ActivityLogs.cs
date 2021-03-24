using BackUpMe.Common.Enumeration;
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
	public partial class ActivityLogs : UserControl
	{
		public ActivityLogs()
		{
			InitializeComponent();
		}

		private void rbtn_SearchType_CheckedChanged(object sender, EventArgs e)
		{
			if(!Enum.TryParse((sender as RadioButton).Tag.ToString(), out ActivityLogSearchType searchType))
			{
				return;
			}

			switch (searchType)
			{
				case ActivityLogSearchType.AllRecords:
					dateTimePicker1.Enabled = false;
					dateTimePicker2.Enabled = false;
					break;
				case ActivityLogSearchType.SpecificDate:
					dateTimePicker1.Enabled = true;
					dateTimePicker2.Enabled = true;
					break;
				default:
					dateTimePicker1.Enabled = false;
					dateTimePicker2.Enabled = false;
					break;
			}
		}
	}
}
