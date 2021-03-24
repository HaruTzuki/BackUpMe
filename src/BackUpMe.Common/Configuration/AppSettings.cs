using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackUpMe.Common.Configuration
{
	public class AppSettings
	{
		public string ConnectionString { get; set; }

		public async static Task<AppSettings> GetAppSettings()
		{
			using var appSettingsReader = new StreamReader(Path.Combine(AppContext.BaseDirectory, "appsettings.json"));

			var content = await appSettingsReader.ReadToEndAsync().ConfigureAwait(false);

			var appSettings = JsonConvert.DeserializeObject<AppSettings>(content);

			return appSettings;
		}

		public async Task<bool> CommitAppSettings()
		{
			try
			{
				using var appSettingsWriter = new StreamWriter(Path.Combine(AppContext.BaseDirectory, "appsettings.json"));

				string content = JsonConvert.SerializeObject(this, Formatting.Indented);

				await appSettingsWriter.WriteAsync(content);
			}
			catch (Exception ex)
			{
				// TODO Error Repository
				return false;
			}

			return true;
		}

		public async Task LoadAppSettings()
		{
			var appSettings = await GetAppSettings().ConfigureAwait(false);

			this.ConnectionString = appSettings.ConnectionString;
		}
	}
}
