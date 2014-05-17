using Infrastructure.Security.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Web.Security.Interfaces
{
    public interface ICurrentSessionUser
    {
        void SignIn(UserBase user, bool isPersistent);
        string GetUserName();
        void SignOut();
    }
}
