using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DeviceLibrary.DataAccessLayer.Models
{
    public class DeviceRepository : IDeviceRepository
    {
        private readonly AppDbContext _appDbContext;

        public DeviceRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<IEnumerable<IDevice>> List(DeviceType deviceType)
        {
            if (deviceType == DeviceType.Camera)
            {
                return await _appDbContext.Cameras.ToListAsync();
            }
            else if (deviceType == DeviceType.Laptop)
            {
                return await _appDbContext.Laptops.ToListAsync();
            }
            return null;
        }

        public async Task<IDevice> Get(int id, DeviceType deviceType)
        {
            if (deviceType == DeviceType.Camera)
            {
                return await _appDbContext.Cameras.FirstOrDefaultAsync(x=>x.Id==id);
            }
            else if (deviceType == DeviceType.Laptop)
            {
                return await _appDbContext.Laptops.FirstOrDefaultAsync(x => x.Id == id);
            }
            return null;
        }



        public async Task<IDevice> Book(int id, DeviceType deviceType)
        {
            IDevice device = null;
            if (deviceType == DeviceType.Camera)
            {
                device = await _appDbContext.Cameras.FirstOrDefaultAsync(x => x.Id == id);
                device.Available = false;
                await _appDbContext.SaveChangesAsync();
            }
            else if (deviceType == DeviceType.Laptop)
            {
                device = await _appDbContext.Laptops.FirstOrDefaultAsync(x => x.Id == id);
                device.Available = false;
                await _appDbContext.SaveChangesAsync();
            }

            return device;
        }
    }
}
