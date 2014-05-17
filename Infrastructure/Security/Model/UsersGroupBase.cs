using Infrastructure.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Security.Model
{
    public class UsersGroupBase : EntityBase<int>
    {
        public string Name { get; set; }
        public virtual ICollection<UserBase> Users { get; set; }

        protected override void Validate()
        {
            throw new NotImplementedException();
        }
    }
}
