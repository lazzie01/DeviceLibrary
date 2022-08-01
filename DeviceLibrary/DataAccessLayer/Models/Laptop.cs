using System.ComponentModel.DataAnnotations;

namespace DeviceLibrary.DataAccessLayer.Models
{
    public class Laptop: IDevice
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public string Model { get; set; }

        public bool Available { get; set; }

        public DeviceType DeviceType { get; set; }
    }
}
