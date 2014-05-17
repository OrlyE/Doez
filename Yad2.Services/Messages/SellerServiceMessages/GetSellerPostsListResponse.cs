using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yad2.Services.Messages.SellerServiceMessages
{
    public class GetSellerPostsListResponse<T> : MessageBase
    {
        public IEnumerable<T> Posts { get; set; }
        //public IEnumerable<string[]> Posts { get; set; }

        //public int CurrentPage { get; set; }
        //public int TotalPages { get; set; }
        //public int ItemsPerPage { get; set; }
    }
}
