using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yad2.Model.Entities
{
    public class Commercial : Vehicle, IVisiblePost
    {
        public int GearTypeId { get; set; }
        public CarGearType GearType { get; set; }

        public string[] ToListItemViewModel()
        {
            return new string[] { Id.ToString(), Manufacturer.Name + " - " + Model.Name, EngineCapacity.ToString(), Year.ToString(), (Price.HasValue ? Price.Value.ToString("#,#") : ""), OwnersCount.ToString(), GearType.Name, Region.Name, (Pics != null && Pics.Count() > 0) ? "true" : "false", LastPopedUp.ToString("dd/MM/yy") };
        }


        public string[] ToFullPostViewModel()
        {

            throw new NotImplementedException();
        }


        public string ToAutoCompleteViewModel()
        {
            throw new NotImplementedException();
        }
    }
}
