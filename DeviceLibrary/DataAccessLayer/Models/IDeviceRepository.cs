using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeviceLibrary.DataAccessLayer.Models
{
    public interface IDeviceRepository
    {
        Task<IEnumerable<IDevice>> List(DeviceType deviceType);

        Task<IDevice> Get(int id, DeviceType deviceType);
    }
}
