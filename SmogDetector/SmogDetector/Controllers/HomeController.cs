using SmogDetector.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Services;
using System.Web.Services;

namespace SmogDetector.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }


        //[WebMethod]
        //public static double GetCoords(double lat, double lng)
        //{
        //    return lat + lng;
        //}

        [HttpPost]
        public ActionResult GetCurrentTime(CoordinatesModel nameVmodel)
        {

            return Json(new
            {
                success = true,
                responseText = nameVmodel.Latitude.ToString() + nameVmodel.Longtitude.ToString()
            });
        }
    }


}
