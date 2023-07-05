namespace Dev.UnitTesting.Mocking
{
	public interface IBookingRepository
	{
		IQueryable<Booking> GetActiveBookings(int? excludedBookingId = null);
	}
}