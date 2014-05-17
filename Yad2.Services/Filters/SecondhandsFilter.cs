using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yad2.Model.Entities;
using Yad2.Services.Interfaces;

namespace Yad2.Services.Filters
{
    public class SecondhandsFilter : IFilterObject<SecondHand>
    {
        public int? RegionId { get; set; }
        public int? PriceMin { get; set; }
        public int? PriceMax { get; set; }
        public int? Category { get; set; }
        public int? SubCategory { get; set; }
        public int? State { get; set; }
        public string Text { get; set; }



        public IEnumerable<SecondHand> Filter(IEnumerable<SecondHand> allItems)
        {
            //validation:


            IEnumerable<SecondHand> filteredItems = null;


            // regular filter
            filteredItems = allItems.Where(c =>
               (!RegionId.HasValue || RegionId.Value == c.RegionId)
               && (!PriceMin.HasValue || c.Price >= PriceMin)
               && (!PriceMax.HasValue || c.Price <= PriceMax)
               && (!Category.HasValue || Category == c.TypeId)
               && (!SubCategory.HasValue || SubCategory == c.SubTypeId)

                && (string.IsNullOrEmpty(Text) ||
                            c.Category.Name.Contains(Text) ||
                            Text.Contains(c.Category.Name) ||
                            c.SubType.Name.Contains(Text) ||
                            Text.Contains(c.SubType.Name)
                            )
                 


               );


            return filteredItems;
        }
    }
}
