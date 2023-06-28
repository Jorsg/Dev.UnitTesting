using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dev.UnitTesting.Mocking
{
	public interface IDownloadFile
	{
		void DownloadFile(string url, string path);
	}
}
