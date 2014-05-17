using Infrastructure.Security.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yad2.Services.Messages.SellerServiceMessages
{
    public class SetUserPasswordRequest : MessageBase
    {
        public UserBase user { get; set; }
        public string confirmPassword { get; set; }
        public string password { get; set; }
    }
}
