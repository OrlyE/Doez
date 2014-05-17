using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infrastructure.Domain;
using Infrastructure.Security.Model;

namespace Yad2.Model.Entities.BaseEntities
{
    public class Seller : EntityBase<int>
    {

        public string Name { get; set; }
        public string Phone1 { get; set; }
        public string Phone2 { get; set; }
        public string FullAddress { get; set; }

        public int UserId { get; set; }
        public UserBase User { get; set; }

        protected override void Validate()
        {
            throw new NotImplementedException();
        }
    }
}
