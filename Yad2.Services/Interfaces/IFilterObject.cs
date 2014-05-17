using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yad2.Services.Interfaces
{
    public interface IFilterObject<T>
    {
        IEnumerable<T> Filter(IEnumerable<T> allItems);
    }
}
