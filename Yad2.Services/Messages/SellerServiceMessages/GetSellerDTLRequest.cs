using Infrastructure.Security.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yad2.Services.ViewModels;

namespace Yad2.Services.Messages.SellerServiceMessages
{
    public class GetSellerDTLRequest
    {
       // public string UserName { get; set; }
        public UserBase User { get; set; }
    }
}
