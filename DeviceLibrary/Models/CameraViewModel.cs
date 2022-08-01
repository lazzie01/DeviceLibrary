using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DeviceLibrary.DataAccessLayer.Models;

namespace DeviceLibrary.Models
{
    public class CameraViewModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Model { get; set; }

        public bool Available { get; set; }

        public DeviceType DeviceType { get; set; }

        public CameraViewModel(){}

        public CameraViewModel(Camera camera)
        {
            if (camera != null)
            {
                Id = camera.Id;
                Name = camera.Name;
                Model = camera.Model;
                Available = camera.Available;
                DeviceType = camera.DeviceType;
            }
        }

        public Camera ToModel(CameraViewModel vm)
        {
            return new Camera
            {
                Id = vm.Id,
                Name = vm.Name,
                Model = vm.Model,
                Available = vm.Available,
                DeviceType = vm.DeviceType
            };
        }
    }
}
