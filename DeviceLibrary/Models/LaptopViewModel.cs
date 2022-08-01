using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DeviceLibrary.DataAccessLayer.Models;

namespace DeviceLibrary.Models
{
    public class LaptopViewModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Model { get; set; }

        public bool Available { get; set; }

        public DeviceType DeviceType { get; set; }

        public LaptopViewModel() {}

        public LaptopViewModel(Laptop laptop)
        {
            Id = laptop.Id;
            Name = laptop.Name;
            Model = laptop.Model;
            Available = laptop.Available;
            DeviceType = laptop.DeviceType;
        }

        public Laptop ToModel(LaptopViewModel vm)
        {
            return new Laptop
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
