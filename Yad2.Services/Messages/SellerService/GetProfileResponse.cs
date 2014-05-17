using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yad2.Model.Entities.BaseEntities;

namespace Yad2.Services.Messages.SellerService
{
    public class GetProfileResponse : MessageBase
    {
        public Seller Seller { get; set; }
    }
}
