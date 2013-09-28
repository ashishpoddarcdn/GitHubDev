using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcApplication5.Models;
using MvcApplication5.ViewModels;
namespace MvcApplication5.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";
            // Created View Model instance to get the application details from database
            HomePageViewModel HomeVm = new HomePageViewModel();

            TblApplicationInfo ObjAppInfo = HomeVm.GetApplicationDetails();
            if (ObjAppInfo != null)
            {
                ViewBag.ApplicationName = ObjAppInfo.ApplicationName;
                ViewBag.ApplicationDetails = ObjAppInfo.ApplicationDetails;
            }
            return View();
        }

        public ActionResult Dashboard(TblUserInfo MUserInfo)
        {
            if (MUserInfo != null)
            {
                ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";
                // Created View Model instance to get the application details from database
                HomePageViewModel HomeVm = new HomePageViewModel();
                ViewBag.UserName = "Welcome " + MUserInfo.FirstName + " " + MUserInfo.LastName;
                TblApplicationInfo ObjAppInfo = HomeVm.GetApplicationDetails();
                if (ObjAppInfo != null)
                {
                    ViewBag.ApplicationName = ObjAppInfo.ApplicationName;
                    ViewBag.ApplicationDetails = ObjAppInfo.ApplicationDetails;
                }
                return View("Index",MUserInfo);
            }
            return RedirectToAction("Login","Account");
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
