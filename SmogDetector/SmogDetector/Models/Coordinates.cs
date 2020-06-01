using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Script.Serialization;

namespace SmogDetector.Models
{
    public class CoordinatesModel
    {
        [MaxLength(6)]
        public int Id { get; set; }
        public double Latitude { get; set; }
        public double Longtitude { get; set; }

        [StringLength(13)]
        public string AirPollution { get; set; }
    }
}