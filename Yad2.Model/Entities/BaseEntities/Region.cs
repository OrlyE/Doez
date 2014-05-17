using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Infrastructure.Domain;

namespace Yad2.Model.Entities.BaseEntities
{
    public class Region : EntityBase<int>
    {
        public string Name { get; set; }
        public int? ParentId { get; set; }
        public Region Parent { get; set; }

        public ICollection<Region> ChildRegions { get; set; }
        public ICollection<City> Cities { get; set; }

        protected override void Validate()
        {
            throw new NotImplementedException();
        }
    }
}
