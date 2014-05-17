using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yad2.Services.Messages
{
    public class GetAutoCompleteResponse : MessageBase
    {
        public IEnumerable<string> Values { get; set; }
    }
}
