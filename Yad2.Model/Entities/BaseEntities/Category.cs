using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infrastructure.Domain;

namespace Yad2.Model.Entities.BaseEntities
{
    public class Category : EntityBase<int>
    {
        public string Name { get; set; }
        public string Desc { get; set; }
       
        public int? ParentId { get; set; }
        public Category Parent { get; set; }

        public ICollection<Category> ChildCategories { get; set; }

        protected override void Validate()
        {
            throw new NotImplementedException();
        }
    }
}
