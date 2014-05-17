using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yad2.Model.Entities.BaseEntities;
using Yad2.Services.ViewModels;

namespace Yad2.Services.Messages.SellerServiceMessages
{
    public class UpdateSellerDTLResponse: MessageBase
    {
        public SellerModel Seller { get; set; }
    }
}
