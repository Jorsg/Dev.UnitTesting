using Dev.UnitTesting.Mocking;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assert = NUnit.Framework.Assert;

namespace Dev.UnitTestingTests.Moking
{
	[TestFixture]
	public class VideoServiceTests
	{
		private Mock<IFileReader> _fileReader;
		private VideoService _videoService;
		private Mock<IVideoRepository> _videoRepository;

		[SetUp]
		public void SetUp()
		{
			_fileReader = new Mock<IFileReader>();
			_videoRepository = new Mock<IVideoRepository>();
			_videoService = new VideoService(_fileReader.Object, _videoRepository.Object);
		}


		[Test]
		public void ReadVideoTitle_EmptyFile_ReturnError()
		{
			_fileReader.Setup(fr => fr.Read("video.txr")).Returns("");

			var result = _videoService.ReadVideoTitle();

			Assert.That(result, Is.EqualTo(null));
		}

		[Test]
		public void GetUnprocessedVideoAsCsv_AllVideosAreProceessed_ReturnAnEmptyString()
		{
			_videoRepository.Setup(c => c.GetUnprocessedVideos()).Returns(new List<Video>());

			var result = _videoService.GetUnprocessedVideosAsCsv();

			Assert.That(result, Is.EqualTo(""));

		}

		[Test]
		public void GetUnprocessedVideoAsCsv_AFewUnProceessedVideos_ReturnStringWithIdOfUnprocessedVideos()
		{
			_videoRepository.Setup(c => c.GetUnprocessedVideos()).Returns(new List<Video>
			{
				new Video {Id = 1}, new Video {Id = 2}, new Video {Id = 3},
			});

			var result = _videoService.GetUnprocessedVideosAsCsv();

			Assert.That(result, Is.EqualTo("1,2,3"));

		}
	}
}
