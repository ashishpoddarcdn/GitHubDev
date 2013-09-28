using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Web.Mvc;
using System.Web.Routing;
using MvcApplication5;
using MvcApplication5.Controllers;
using MvcApplication5.ViewModels;
using MvcApplication5.Models;

namespace MvcApplication5.Tests.Controllers
{
    [TestClass]
    public class AccountControllerTest
    {
        [TestMethod]
        public void LogOut()
        {
            var accountController = new AccountController();
            var redirectToRouteResult = accountController.LogOut() as RedirectToRouteResult;

            Assert.IsNotNull(redirectToRouteResult);
            Assert.AreEqual("Index", redirectToRouteResult.RouteValues["Action"]);
            Assert.AreEqual("Home", redirectToRouteResult.RouteValues["controller"]);
        }

        [TestMethod]
        public void Login_UserCanNotLogin()
        {
            AccountController Controller = new AccountController();
            string returnUrl = "/Home/Dashboard";
            string userName = "UserTest";
            string password = "InvalidPass";

            var model = new TblUserInfo
            {
                UserName = userName,
                Password = password
            };
            
            var result = Controller.Login(model, returnUrl) ;
            var redirectResult = result as RedirectResult;
            var viewResult = result as ViewResult;
            Assert.IsInstanceOfType(viewResult.Model, typeof(TblUserInfo));
        }
        [TestMethod]
        public void Login_UserCanNotLogin1()
        {
            AccountController Controller = new AccountController();
            string returnUrl = "/Home/Dashboard";
        
            var result = Controller.Login(null, returnUrl);
            var viewResult = result as ViewResult;

            Assert.IsNull(viewResult.Model);
        }

        [TestMethod]
        public void Register_UserCanRegister()
        {
            AccountController Controller = new AccountController();
            string userName = "UserTest";
            string password = "UserPass";
            string firstName = "firstName";
            string lastName = "lastName";
            decimal phoneNo = 9876543210;

            var model = new TblUserInfo
            {
                FirstName = firstName,
                LastName = lastName,
                PhoneNumber = phoneNo,
                UserName = userName,
                Password = password
            };

            var result = Controller.Register(model);
            var redirectResult = result as RedirectToRouteResult;
            Assert.AreEqual("Dashboard", redirectResult.RouteValues["action"]);
        }

    }
}
