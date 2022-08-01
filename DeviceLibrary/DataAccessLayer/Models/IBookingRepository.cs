using System.Threading.Tasks;

namespace DeviceLibrary.DataAccessLayer.Models
{
    public interface IBookingRepository
    {
        Task<Booking> Book(Booking booking);
    }
}
