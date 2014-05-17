using Infrastructure.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Security.Model
{
    public class UserBase : EntityBase<int>
    {
        public string UserName { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public bool IsActive { get; set; }
        public DateTime Created { get; set; }
        public DateTime? LastVisited { get; set; }
        public bool HasToChangePass { get; set; }
        public virtual ICollection<UsersGroupBase> UserGroups { get; set; }

        protected override void Validate()
        {
            return;
            throw new NotImplementedException();
        }
    }
}
