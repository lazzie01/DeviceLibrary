using System;
using DeviceLibrary.DataAccessLayer.Models;

namespace DeviceLibrary.Models
{
    public class BookViewModel
    {
        public int Id { get; set; }

        public DeviceType DeviceType { get; set; }

        public DateTime DateBooked { get; set; }

        public DateTime DateToBeReturned { get; set; }

        public string EmailAddress { get; set; }

    }
}
