using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BackUpMe.Common.Utilities
{
	static public class FileAndFolderManager
	{
		static public string OpenFolderManager()
		{
			string mRet = "";

			FolderBrowserDialog fbd = new FolderBrowserDialog();
			fbd.ShowNewFolderButton = true;
			if (fbd.ShowDialog() == DialogResult.OK)
			{
				mRet = fbd.SelectedPath;
			}

			return mRet;
		}

		static public bool CreateFolder(string folderPath)
		{
			try
			{
				if (!Directory.Exists(folderPath))
				{
					Directory.CreateDirectory(folderPath);
				}
			}
			catch (Exception ex)
			{
				//TODO ErrorRepository
				return false;
			}

			return true;
		}

		static public void CopyDirectoriesAndFiles(string sourcePath, string destinationPath, bool copySubDirectories = true)
		{
			var directoryInfo = new DirectoryInfo(sourcePath);


			if (!directoryInfo.Exists)
			{
				throw new DirectoryNotFoundException("Source Directory does not exist or could not be found: " + sourcePath);
			}

			var subDirectoriesInfo = directoryInfo.GetDirectories();

			Directory.CreateDirectory(destinationPath);

			var files = directoryInfo.GetFiles();

			foreach(var file in files)
			{
				file.CopyTo(Path.Combine(destinationPath, file.Name), true);
			}

			if (copySubDirectories)
			{
				foreach(var subDirectory in subDirectoriesInfo)
				{
					CopyDirectoriesAndFiles(subDirectory.FullName, Path.Combine(destinationPath, subDirectory.Name));
				}
			}

		}
	}
}
