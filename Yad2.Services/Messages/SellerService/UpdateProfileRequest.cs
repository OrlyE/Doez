using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infrastructure.Security.Model;
using Yad2.Model.Entities.BaseEntities;

namespace Yad2.Services.Messages.SellerService
{
    public class UpdateProfileRequest
    {
        public Seller Seller { get; set; }
        public UserBase User { get; set; }
    }
}
