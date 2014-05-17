using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yad2.Services.Interfaces
{
    public interface IAutoCompleteFilterObject<T>
    {
        string Value { get; set; }
        IEnumerable<string> Filter(IEnumerable<T> allItems);
    }
}
