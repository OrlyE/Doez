using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yad2.Model.Entities;
using Yad2.Services.Interfaces;

namespace Yad2.Services.Filters
{
    public class CommercialFilter : IFilterObject<Commercial>
    {
        public bool? IsAdvancedFilter { get; set; }

        public int? Model { get; set; }
        public int? YearMin { get; set; }
        public int? YearMax { get; set; }
        public int? RegionId { get; set; }
        public int? CityId { get; set; }
        public int? Manufacturer { get; set; }
        public int? PriceMin { get; set; }
        public int? PriceMax { get; set; }
        public int? OwnersCount { get; set; }
        public int? KilometerMin { get; set; }
        public int? KilometerMax { get; set; }
        public int? EngineCapacity { get; set; }
        public int? OwnershipType { get; set; }
        public int? Color { get; set; }
        public int? GearType { get; set; }
        public string Text { get; set; }


        public IEnumerable<Commercial> Filter(IEnumerable<Commercial> allItems)
        {
            //validation:

            if (YearMax < YearMin) throw new ArgumentOutOfRangeException("Year max is lower than year min");


            IEnumerable<Commercial> filteredCars = null;

            if (IsAdvancedFilter.HasValue && IsAdvancedFilter.Value)
            { // advanced filter
                filteredCars = allItems.Where(c =>
                  (!CityId.HasValue || CityId.Value == c.CityId)
                  && (!RegionId.HasValue || RegionId.Value == c.RegionId || RegionId.Value == c.Region.ParentId)
                  && (!PriceMin.HasValue || c.Price >= PriceMin)
                  && (!PriceMax.HasValue || c.Price <= PriceMax)
                  && (!Manufacturer.HasValue || c.ManufacturerId == Manufacturer.Value)
                 && (!Model.HasValue || c.ModelId == Model.Value)
                    && (!KilometerMin.HasValue || c.Kilometer == KilometerMin.Value || KilometerMin <= KilometerMax)
                    && (!KilometerMax.HasValue || c.Kilometer == KilometerMax.Value)
                    && (!YearMin.HasValue || c.Year == YearMin.Value || YearMin <= YearMax)
                    && (!YearMax.HasValue || c.Year == YearMax || YearMin <= YearMax)
                    && (!GearType.HasValue || c.GearTypeId == GearType.Value)
                  && (OwnersCount.HasValue || c.OwnersCount == OwnersCount.Value)
                 && (!Color.HasValue || c.Color == Color.Value));
            }
            else
            { // regular filter
                filteredCars = allItems.Where(c =>
                   (!CityId.HasValue || CityId.Value == c.CityId)
                   && (!RegionId.HasValue || RegionId.Value == c.RegionId || RegionId.Value == c.Region.ParentId)
                   && (!PriceMin.HasValue || c.Price >= PriceMin)
                   && (!PriceMax.HasValue || c.Price <= PriceMax)
                   && (!Manufacturer.HasValue || c.ManufacturerId == Manufacturer.Value)
                   && (!GearType.HasValue || c.GearTypeId == GearType.Value)
                                      && (!Model.HasValue || c.ModelId == Model.Value)
                                        && (!Model.HasValue || c.ModelId == Model.Value)
         && (string.IsNullOrEmpty(Text) || 
                            c.Manufacturer.Name.Contains(Text) ||
                            Text.Contains(c.Manufacturer.Name) ||
                            c.Model.Name.Contains(Text) ||
                            Text.Contains(c.Model.Name) 
                            )
                 
                 
                 
                 


                   );
            }

            return filteredCars;
        }
    }
}
