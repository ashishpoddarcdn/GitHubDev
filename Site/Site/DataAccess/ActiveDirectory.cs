using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Site.Models;
using System.Security.Claims;

namespace Site.DataAccess
{
    public class ActiveDirectory
    {
        /// <summary>
        /// Gives the user information for the current active directory.
        /// </summary>
        /// <returns>Returns the ADUser model/entity.</returns>
        public static ADUser GetUserInfo()
        {
            ADUser user = new ADUser();

            ClaimsPrincipal cp = ClaimsPrincipal.Current;
            user.FirstName = cp.FindFirst(ClaimTypes.GivenName).Value;
            user.LastName = cp.FindFirst(ClaimTypes.Surname).Value;

            return user;
        }
    }
}