using Giphy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SmogDetector.Models;

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
       
        //public ActionResult About()
        //{
        //    ViewBag.Message = "Your application description page.";

        //    return View();
        //}

        //public ActionResult Contact()
        //{
        //    ViewBag.Message = "Your contact page.";

        //    return View();
        //}
    }
}