using Dev.UnitTesting.Mocking;
using Microsoft.Extensions.Options;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Assert = NUnit.Framework.Assert;

namespace Dev.UnitTestingTests.Moking
{
	[TestFixture]
	public class InstallerHelperTests
	{
		private Mock<IDownloadFile> _fileDownloader;
		private InstallerHelper _installerHelper;

		[SetUp]
		public void SetUp()
		{
			_fileDownloader = new Mock<IDownloadFile>();
			_installerHelper = new InstallerHelper(_fileDownloader.Object);
		}

		[Test]
		public void DownloaderInstaller_DownlodFails_ReturnFalse()
		{
			_fileDownloader.Setup(c => c.DownloadFile(It.IsAny<string>(), It.IsAny<string>())).Throws<WebException>();

			var result = _installerHelper.DownloadInstaller("customer","installer");

			Assert.That(result, Is.False);
		}
	}
}
