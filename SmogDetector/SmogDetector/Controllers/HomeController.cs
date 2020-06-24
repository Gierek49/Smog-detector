using SmogDetector.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Services;
using System.Web.Services;
using Giphy;
using System.Diagnostics;
using System.Web.Helpers;

namespace SmogDetector.Controllers
{
    public class HomeController : Controller
    {
        public string ImageURL { get; set; }
        public ActionResult Index()
        {
            var model = new HomgePageModel();

            var dd = new FunnyService();
            model.URL = dd.GetRandom("cat");
            return View(model);
        }

        [HttpPost]
        public ActionResult GetCurrentLevel(CoordinatesModel cords)
        {
            var X = cords.Latitude.Replace(',', '.');
            var Y = cords.Longtitude.Replace(',', '.');
            //utworzenie procesu
            var psi = new ProcessStartInfo();
            //scieżka do pythona 
            psi.FileName = @"C:\Users\admin\AppData\Local\Programs\Python\Python38\python.exe";

            //scieżka do skryptu i argumenty 
            var script = @"C:\Users\admin\Source\Repos\Smog-detector\SmogDetector\SmogDetector\Data\Model.py";

            //konfiguracja
            psi.Arguments = $"\"{script}\" \"{X}\" \"{Y}\" -f";
            psi.UseShellExecute = false;
            psi.CreateNoWindow = true;
            psi.RedirectStandardOutput = true;
            psi.RedirectStandardError = true;

            //wykonanie procesu i zwrot danych
            var errors = "";
            var result = "";

            using (var proces = Process.Start(psi))
            {
                errors = proces.StandardError.ReadToEnd();
                result = proces.StandardOutput.ReadToEnd();
            }

            cords.AirPollution = result.Replace('[', ' ').Replace(']', ' ');

            return Json(new
            {
                success = true,
                responseText = "Stan powietrza: " + cords.AirPollution + errors
            });

        }

    }
}

