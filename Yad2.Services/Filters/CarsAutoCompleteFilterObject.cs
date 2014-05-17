using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yad2.Model.Entities;
using Yad2.Services.Interfaces;

namespace Yad2.Services.Filters
{
    public class CarsAutoCompleteFilterObject : IAutoCompleteFilterObject<Car>
    {
        public string Value { get; set; }
    
        public IEnumerable<string> Filter(IEnumerable<Car> allItems)
        {
            IEnumerable<string> autoCompleteResults = null;

            autoCompleteResults = allItems.Where(c =>
                c.Manufacturer.Name.StartsWith(Value)
                || c.Model.Name.StartsWith(Value)
                || c.Title.StartsWith(Value)


                ).Select(c => string.Format("{0} {1} - {2}...",c.Manufacturer.Name,c.Model.Name, c.Title.Substring(0,7)) )
                .Take(7);

            return autoCompleteResults;
        }

        
    }
}
