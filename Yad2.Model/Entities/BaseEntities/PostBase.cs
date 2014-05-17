using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infrastructure.Domain;

namespace Yad2.Model.Entities.BaseEntities
{
    public class PostBase : EntityBase<int>
    {
        public int SellerId { get; set; }
        public Seller Seller { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public string Title { get; set; }
        public string Desc { get; set; 
        }

        public int RegionId { get; set; }
        public Region Region { get; set; }

        public int? CityId { get; set; }
        public City City { get; set; }

        public string Phone1 { get; set; }
        public string Phone2 { get; set; }
        public DateTime Created { get; set; }
        public DateTime LastPopedUp { get; set; }
        public DateTime LastModified { get; set; }
        public decimal? Price { get; set; }

        public ICollection<PicOfPost> Pics { get; set; }

        protected override void Validate()
        {
            throw new NotImplementedException();
        }
    }
}
