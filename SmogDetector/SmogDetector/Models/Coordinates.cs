using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Script.Serialization;

namespace SmogDetector.Models
{
    public class CoordinatesModel
    {
        public int Id { get; set; }
        public string Latitude { get; set; }
        public string Longtitude { get; set; }
        public string AirPollution { get; set; }
    }
}