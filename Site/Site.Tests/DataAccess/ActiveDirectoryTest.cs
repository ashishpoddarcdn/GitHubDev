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

namespace Site.Tests.DataAccess
{
    [TestMethod]
    class ActiveDirectoryTest
    {
        [TestMethod]
        public void GetUserInfo()
        {
            // Act
            var actual = ActiveDirectory.GetUserInfo();

            // Assert
            Assert.IsNotNull(actual);
            Assert.IsInstanceOfType(actual, typeof(ADUser));
        }
    }
}
