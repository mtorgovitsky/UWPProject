using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Devices.Geolocation;

namespace UWPProject.Models
{
    public class Photo
    {
        public int ID { get; set; }
        public string Path { get; set; }
        public string Comments { get; set; }
        public DateTime? Time { get; set; }
        public Geolocator Location { get; set; }
    }
}
