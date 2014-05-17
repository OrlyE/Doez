using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yad2.Services.Messages.SellerServiceMessages
{
    public class GetSellerPostsListRequest<T>
    {
        public int UserId { get; set; }
        public int CategoryId { get; set; }
        public int Page { get; set; }
        public int ItemsPerPage { get; set; }
    }
}
