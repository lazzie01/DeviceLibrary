using System.Threading.Tasks;

namespace DeviceLibrary.DataAccessLayer.Models
{
    public class BookingRepository : IBookingRepository
    {

        private readonly AppDbContext _appDbContext;

        public BookingRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<Booking> Book(Booking booking)
        {
            await _appDbContext.Bookings.AddAsync(booking);
            await _appDbContext.SaveChangesAsync();
            return booking;
        }
    }
}
