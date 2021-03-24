using BackUpMe.Common.Utilities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackUpMe.Common.Configuration
{
	public class DatabaseConnection
	{
		public static string ConnectionString
		{
			get
			{
				return GetConnectionString().Result;
			}
		}

		private async static Task<string> GetConnectionString()
		{

			var appSettingConString = await AppSettings.GetAppSettings().ConfigureAwait(false);

			if (string.IsNullOrEmpty(appSettingConString.ConnectionString))
			{
				appSettingConString.ConnectionString = Path.Combine(AppContext.BaseDirectory, Constants.DB_PATH);
			}

			return appSettingConString.ConnectionString;
		}
	}
}
