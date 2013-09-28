using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MvcApplication5.Models;

namespace MvcApplication5.ViewModels
{
    public class AccountViewModel
    {
        // Below function is created to register / save users.
        public int RegisterUser(TblUserInfo MUserInfo)
        {
            if (MUserInfo != null)
            {
                SocialNetworkingAppEntities db = new SocialNetworkingAppEntities();
                db.TblUserInfo.Add(MUserInfo);
                db.SaveChanges();
                return 1;
            }
            return 0;
        }
        // Below function is created to validate and return the logged in user information.
        public TblUserInfo UserLogin(TblUserInfo MUserInfo)
        {
            if (MUserInfo != null)
            {
                 SocialNetworkingAppEntities db = new SocialNetworkingAppEntities();
                 return (from UserInfo in db.TblUserInfo
                         where UserInfo.UserName == MUserInfo.UserName && UserInfo.Password == MUserInfo.Password
                         select UserInfo).FirstOrDefault();
            }
            return null;
        }
        // Below function is used to change the password.
        public TblUserInfo ChangePassword(TblUserInfo MUserInfo)
        {
            if (MUserInfo != null)
            {
                SocialNetworkingAppEntities db = new SocialNetworkingAppEntities();
                TblUserInfo ObjDBUserInfo = (from UserInfo in db.TblUserInfo
                        where UserInfo.UserName == MUserInfo.UserName && UserInfo.Password == MUserInfo.Password
                        select UserInfo).FirstOrDefault();
                ObjDBUserInfo.Password = MUserInfo.Password;
                db.SaveChanges();
            }
            return null;
        }
    }
}