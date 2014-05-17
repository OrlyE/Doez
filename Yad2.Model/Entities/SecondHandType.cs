using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infrastructure.Domain;

namespace Yad2.Model.Entities
{
    public class SecondHandType : EntityBase<int>
    {
        public int? ParentTypeId { get; set; }
        public SecondHandType ParentType { get; set; }
        public string Name { get; set; }
        public bool HasManufacturer { get; set; }

        public ICollection<SecondHandType> ChildTypes { get; set; }
        protected override void Validate()
        {
            throw new NotImplementedException();
        }
    }
}
