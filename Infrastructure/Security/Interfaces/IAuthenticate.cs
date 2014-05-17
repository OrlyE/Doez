using Infrastructure.Security.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Security.Interfaces
{
    public interface IAuthenticate
    {
        void Authenticate(string Username,string Password);
    }
}
