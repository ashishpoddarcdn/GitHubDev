using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MvcApplication5.Models;
namespace MvcApplication5.ViewModels
{
    public class HomePageViewModel
    {
        public TblApplicationInfo GetApplicationDetails()
        {
            SocialNetworkingAppEntities db = new SocialNetworkingAppEntities();
            TblApplicationInfo ObjAppInfo = (from ApplicationInfo in db.TblApplicationInfoes select ApplicationInfo).FirstOrDefault();
            return ObjAppInfo;
        }
    }
}