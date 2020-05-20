using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SmogDetector.Models
{
    public class Coordinates
    {
        public double Lat { get; set; }
        public double Lng { get; set; }
        public string AirPollution { get; set; }
    }
}