using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Infrastructure.Domain;

namespace Yad2.Model.Entities.BaseEntities
{
    public class City : EntityBase<int>
    {
        public string Name { get; set; }
        public int RegionId { get; set; }
        public Region Region { get; set; }

        protected override void Validate()
        {
            throw new NotImplementedException();
        }
    }
}
