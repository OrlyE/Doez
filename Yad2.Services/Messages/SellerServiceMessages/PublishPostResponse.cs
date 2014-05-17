using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yad2.Model.Entities;
using Yad2.Model.Entities.BaseEntities;

namespace Yad2.Services.Messages.SellerServiceMessages
{
    public class PublishPostResponse<T>: MessageBase 
    {
        public T Post { get; set; }
    }
}
