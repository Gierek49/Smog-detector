using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SmogDetector;
using SmogDetector.Controllers;
using SmogDetector.Models;

namespace SmogDetector.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {


        [TestMethod]
        public void TestIndexView()
        {
            var controller = new HomeController();
            var result = controller.Index() as ViewResult;
            Assert.IsNotNull(result);

        }

        [TestMethod]
        public void AboutIndexTest()
        {
            
            var controller = new HomeController();
            var result = controller.Index();
            Assert.IsInstanceOfType(result, typeof(ViewResult));

            var viewResult = result as ViewResult;

            Assert.AreEqual(typeof(CoordinatesModel), viewResult);
        }

        [TestMethod]
        public void Validate_Model_Given_AirPollution()
        {
            var coords = new List<CoordinatesModel>
            {
                new CoordinatesModel {Id = 1, Latitude = 3, AirPollution = "Dobry"},
                new CoordinatesModel {Id = 2, Latitude = 45, AirPollution = "Dobry"},
                new CoordinatesModel {Id = 3, Latitude = 32,  AirPollution = "Bardzo Dobry"}
            };
            var coordsRepository = new Mock<ICoordinatesModelRepository>();
            faqRepository.Setup(e => e.GetAll()).Returns(coords.AsQueryable());
            var controller = new FaqController(faqRepository.Object);
            // Act 
            var result = controller.Index() as ViewResult;
            var model = result.Model as CoordinatesModel;
            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(3, model.FAQs.Count());
        }
    }
}
