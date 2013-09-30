using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Web.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Site;
using Site.Controllers;
using Site.Models;
using Site.DataAccess;

namespace Site.Tests.Controller
{
    [TestMethod]
    class SignOutControllerTest
    {
        [TestMethod]
        public void Index()
        {
            // Arrange
            SignOutController controller = new SignOutController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result.Model);
            Assert.AreEqual("SignOut", result.ViewName);
        }

        [TestMethod]
        public void SignOut()
        {
            // Arrange
            SignOutController controller = new SignOutController();

            controller.SignOut();
            Assert.Fail();
        }
    }
}
