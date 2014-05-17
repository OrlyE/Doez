using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yad2.Services.Interfaces;

namespace Yad2.Services.Messages
{
    public class GetListRequest<T>
    {
        public int CategoryId { get; set; }
        public int Page { get; set; }
        public int ItemsPerPage { get; set; }
        public IFilterObject<T> FilterObject { get; set; }
    }
}
