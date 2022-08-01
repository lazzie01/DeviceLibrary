using System;
using DeviceLibrary.DataAccessLayer.Models;
using DeviceLibrary.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using DeviceLibrary.Constants;

namespace DeviceLibrary.Controllers
{
    public class HomeController : Controller
    {
        private readonly IDeviceRepository _deviceRepository;
        private readonly IBookingRepository _bookingRepository;
        public HomeController(IDeviceRepository deviceRepository, IBookingRepository bookingRepository)
        {
            _deviceRepository = deviceRepository;
            _bookingRepository = bookingRepository;
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

        [HttpPost]
        public JsonResult Book(DeviceType deviceType, int id)
        {
           
            var bookViewModel = new BookViewModel
            {
                Id = id,
                DeviceType = deviceType
            };
            return Json(bookViewModel);
        }

        [HttpPost]
        public async Task<JsonResult> ConfirmBooking(DeviceType deviceType, int deviceId, string email, int duration)
        {
            if (Helper.IsValidEmail(email) && duration >=1 && duration <=5)
            {
                Booking booking = new Booking
                {
                    BookDate = DateTime.Now,
                    ReturnDate = DateTime.Now.AddDays(duration)
                };
                if (deviceType == DeviceType.Camera)
                {
                    booking.Camera = (Camera)await _deviceRepository.Book(deviceId, deviceType);
                }
                if (deviceType == DeviceType.Laptop)
                {
                    booking.Laptop = (Laptop)await _deviceRepository.Book(deviceId, deviceType);
                }

                await _bookingRepository.Book(booking);
                return Json("success");
            }
            return Json("error");
        }
    }
}
