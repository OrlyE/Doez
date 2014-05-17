using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infrastructure.Security.Model;

namespace Yad2.Services.Messages.SellerService
{
    public class GetProfileRequest
    {
        public UserBase User { get; set; }
    }
}
