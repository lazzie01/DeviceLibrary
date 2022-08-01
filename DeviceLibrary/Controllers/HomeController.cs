using DeviceLibrary.DataAccessLayer.Models;
using DeviceLibrary.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace DeviceLibrary.Controllers
{
    public class HomeController : Controller
    {
        private readonly IDeviceRepository _deviceRepository;

        public HomeController(IDeviceRepository deviceRepository)
        {
            _deviceRepository = deviceRepository;
        }

        public async Task<IActionResult> Index()
        {
           var cameras =  await _deviceRepository.List(DeviceType.Camera);
           var laptops = await _deviceRepository.List(DeviceType.Laptop);

           DeviceViewModel deviceViewModel = new DeviceViewModel
            {
                CameraViewModel = cameras.Select(c=> new CameraViewModel((Camera)c)).ToList(),
                LaptopViewModel = laptops.Select(l => new LaptopViewModel((Laptop)l)).ToList()
           };

            return View(deviceViewModel);
        }
    }
}
