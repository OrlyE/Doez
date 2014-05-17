using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yad2.Model.Entities.BaseEntities;

namespace Yad2.Model.Entities
{
    public class SecondHand : PostBase, IVisiblePost
    {
        public int StateId { get; set; }
        public SecondHandState State { get; set; }

        public int TypeId { get; set; }
        public SecondHandType Type { get; set; }

        public int? SubTypeId { get; set; }
        public SecondHandType SubType { get; set; }

        protected override void Validate()
        {
            base.Validate();
        }


        public string[] ToListItemViewModel()
        {
            return new string[] { Id.ToString(), Type.Name + " - " + SubType.Name, Region.Name, Desc.Length > 33 ? Desc.Substring(0, 30) + "..." : Desc, (Price.HasValue ? Price.Value.ToString("#,#") : ""), (Pics != null && Pics.Count() > 0) ? "true" : "false", LastPopedUp.ToString("dd/MM/yy") };
        }

        public string[] ToFullPostViewModel()
        {
            //Id.ToString(), Seller.Name, Phone1, Phone2, Region.Name, Desc, Title, (Pics != null && Pics.Count() > 0) ? "true" : "false",(Price.HasValue ? Price.Value.ToString("#,#") : ""),
            return new string[] { Id.ToString(), Type.Name + " - " + SubType.Name, Seller.Name, Phone1, Phone2, Region.Name,Title, Desc.Length > 33 ? Desc.Substring(0, 30) + "..." : Desc, (Price.HasValue ? Price.Value.ToString("#,#") : ""), (Pics != null && Pics.Count() > 0) ? "true" : "false", LastPopedUp.ToString("dd/MM/yy"),
        };
        }


        public string ToAutoCompleteViewModel()
        {
            throw new NotImplementedException();
        }
    }
}
