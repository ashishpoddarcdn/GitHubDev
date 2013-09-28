using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MvcApplication5;
using MvcApplication5.Controllers;
using MvcApplication5.ViewModels;
using MvcApplication5.Models;

namespace MvcApplication5.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void Index()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.AreEqual("Modify this template to jump-start your ASP.NET MVC application.", result.ViewBag.Message);

            HomePageViewModel _vm = new HomePageViewModel();
            var actual = _vm.GetApplicationDetails();
            Assert.IsInstanceOfType(actual,typeof(TblApplicationInfo));
        }

        [TestMethod]
        public void About()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.About() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void Contact()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Contact() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }
        [TestMethod]
        public void Dashboard()
        {
            HomeController controller = new HomeController();
            TblUserInfo obj=new TblUserInfo();
            ViewResult result = controller.Dashboard(obj) as ViewResult;
            var tblUserInfo = result.Model;
            Assert.IsInstanceOfType(tblUserInfo, typeof(TblUserInfo));
        }
        [TestMethod]
        public void DashboardRedirect()
        {
            HomeController controller = new HomeController();
            var result =  (RedirectToRouteResult)controller.Dashboard(null) ;
            Assert.AreEqual("Login", result.RouteValues["action"]);
        }
    }
}
