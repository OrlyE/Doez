using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yad2.Services.Messages.SellerService
{
    public class UpdatePostRequest<T>
    {
        public T Post { get; set; }
        public int UserId { get; set; }
    }
}
