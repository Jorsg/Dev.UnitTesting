using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Dev.UnitTesting.Mocking
{
	public class InstallerHelper
	{
		private readonly IDownloadFile _file;
		private string _setupDestinationFile;

		public InstallerHelper(IDownloadFile file)
		{
			_file = file ?? throw new ArgumentNullException(nameof(file));
		}

		public bool DownloadInstaller(string customerName, string installerName)
		{
			try
			{
				_file.DownloadFile(
					string.Format("http://example.com/{0}/{1}",
						customerName,
						installerName),
					_setupDestinationFile);

				return true;
			}
			catch (WebException)
			{
				return false;
			}
		}
	}
}
