using Giphy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SmogDetector.Controllers
{
    public class HomeController : Controller
    {
        public string ImageURL { get; set; }

        private readonly IFunnyService _funnyService;
        public HomeController(IFunnyService funnyService)
        {
            _funnyService = funnyService;
        }

        public ActionResult Index()
        {
            ImageURL = _funnyService.GetRandom("cat");
            return View();
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