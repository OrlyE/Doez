using Infrastructure.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yad2.Model.Entities.BaseEntities
{
    public class SeconHandTyep : EntityBase<int>
    {
        public string Name { get; set; }
        public int? ParentId { get; set; }
        public SeconHandTyep SeconHandTye { get; set; }
        public ICollection<SeconHandTyep> ChildSeconHand { get; set; }

        protected override void Validate()
        {
            throw new NotImplementedException();
        }
    }
}
