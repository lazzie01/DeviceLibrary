using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DeviceLibrary.DataAccessLayer.Models
{
    public class Booking
    {
        [Key]
        public int Id { get; set; }

        public DateTime BookDate { get; set; }

        public DateTime ReturnDate { get; set; }

        [ForeignKey("Camera")]
        public int? CameraId { get; set; }

        [ForeignKey("Laptop")]
        public int? LaptopId { get; set; }

        public virtual Camera Camera { get; set; }

        public virtual Laptop Laptop { get; set; }

    }
}
