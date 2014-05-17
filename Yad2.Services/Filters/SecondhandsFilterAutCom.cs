using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yad2.Services.Interfaces;
using Yad2.Model.Entities;
namespace Yad2.Services.Filters
{
    public class SecondhandsFilterAutCom : IAutoCompleteFilterObject<SecondHand>
    {

        public string Value { get; set; }

        public IEnumerable<string> Filter(IEnumerable<SecondHand> allItems)
        {
            IEnumerable<string> autoCompleteResults = null;

            autoCompleteResults = allItems.Where(c =>
                c.Category.Name.StartsWith(Value)
                || c.SubType.Name.StartsWith(Value)
                || c.Title.StartsWith(Value)


                ).Select(c => string.Format("{0} {1} - {2}...", c.SubType.Name, c.Category.Name, c.Title.Substring(0, 7)))
                .Take(7);

            return autoCompleteResults;
        }
    }
}