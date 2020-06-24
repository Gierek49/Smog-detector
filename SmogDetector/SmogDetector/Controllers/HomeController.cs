using SmogDetector.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Services;
using System.Web.Services;
using System.Web.Mvc;
using SmogDetector.Models;
using Giphy;


namespace SmogDetector.Controllers
{
    public class HomeController : Controller
    {
        public string ImageURL { get; set; }
        public ActionResult Index()
        {
            var model=new HomgePageModel();
            
            var dd = new FunnyService(); 
            model.URL = dd.GetRandom("cat");
            return View(model);
        }
        //[WebMethod]
        //public static double GetCoords(double lat, double lng)
        //{
        //    return lat + lng;
        //}

        [WebMethod]
        public static string GetCurrentTime(string name)
        {
            return "Hello " + name + Environment.NewLine + "The Current Time is: "
                + DateTime.Now.ToString();
        }

       
    }
}