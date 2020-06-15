using SmogDetector.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using PythonData;

namespace SmogDetector.Controllers
{
    public class CoordinatesController : ApiController
    {
        //CoordinatesModel[] coordinates = new CoordinatesModel[]

        //{
        //    new CoordinatesModel{Id = 1,Latitude=2, Longtitude=2, AirPollution="dobry"},
        //    new CoordinatesModel{Id = 2,Latitude=2, Longtitude=2, AirPollution="dobry"},
        //    new CoordinatesModel{Id = 3,Latitude=2, Longtitude=2, AirPollution="dobry"}
        //};

        //public IEnumerable<CoordinatesModel> GetAll()
        //{
        //    return coordinates;
        //}


        //public CoordinatesModel GetCoordsById(int id)
        //{
        //    var coords = coordinates.FirstOrDefault((I) => I.Id == id);

        //    if (coords == null)
        //    {
        //        throw new HttpResponseException(HttpStatusCode.NotFound);
        //    }

        //    return coords;
        //}



        public CoordinatesModel SendCoordsToPython()
        {
            var coordinatesmodel = new CoordinatesModel()
            {
                Latitude = ,
            }
            return;
        }

    }
}