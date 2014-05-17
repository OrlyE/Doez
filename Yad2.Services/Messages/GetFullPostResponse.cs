using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yad2.Services.Interfaces;

namespace Yad2.Services.Messages
{
    public class GetFullPostResponse : MessageBase
    {
        public string[] Item { get; set; }
        public string[] ItemPics { get; set; }
    }
}
