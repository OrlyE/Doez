using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Yad2.Services.ViewModels
{
    public class UserBaseModel
    {
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
    }
}