using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infrastructure.Domain;

namespace Yad2.Model.Entities.BaseEntities
{
    public class PicOfPost : EntityBase<int>
    {
        public string Filename { get; set; }

        public int PostId { get; set; }

        public int CategoryId { get; set; }
        
        protected override void Validate()
        {
            throw new NotImplementedException();
        }
    }
}
