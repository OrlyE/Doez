using Infrastructure.Web.Security.Interfaces;
using Infrastructure.Security.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Security;
using System.Web;

namespace Infrastructure.Web.Security.Implementations
{
    public class AspNetCustomCurrentSessionUser : ICurrentSessionUser
    {
        public void SignIn(UserBase user, bool isPersistent)
        {

            if (user == null) throw new ApplicationException("User is null.");
            string groupsOfUser = "";
            if (user.UserGroups != null)
            {
                user.UserGroups.ToList().ForEach(g => groupsOfUser+=g.Name + ",");
            }

            FormsAuthenticationTicket authTicket = new FormsAuthenticationTicket(
                            1,                             // version
                            user.UserName,                 // user name
                            DateTime.Now,                  // created
                            DateTime.Now.AddMinutes(20),   // expires
                            isPersistent,                  // persistent?
                            groupsOfUser                   // can be used to store roles
                            );

            string encryptedTicket = FormsAuthentication.Encrypt(authTicket);

            var authCookie = new HttpCookie(FormsAuthentication.FormsCookieName, encryptedTicket);
            HttpContext.Current.Response.Cookies.Add(authCookie);
        }

        public string GetUserName()
        {
            if (HttpContext.Current != null && 
                HttpContext.Current.User != null &&
                HttpContext.Current.User.Identity != null)
                    return HttpContext.Current.User.Identity.Name;

            return null;
        }


        public void SignOut()
        {
            FormsAuthentication.SignOut();
        }
    }
}
