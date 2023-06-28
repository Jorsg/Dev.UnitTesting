using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Dev.UnitTesting.Mocking
{
	public class Download : IDownloadFile
	{


		public void DownloadFile(string url, string path)
		{
			var client = new WebClient();
			client.DownloadFile(url, path);
		}
	}
}
