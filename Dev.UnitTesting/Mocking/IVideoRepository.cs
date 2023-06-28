namespace Dev.UnitTesting.Mocking
{
	public interface IVideoRepository
	{
		IEnumerable<Video> GetUnprocessedVideos();
	}
}