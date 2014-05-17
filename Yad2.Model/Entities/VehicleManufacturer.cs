using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infrastructure.Domain;

namespace Yad2.Model.Entities
{
    public class VehicleManufacturer : EntityBase<int>
    {
        public string Name { get; set; }
        public int Type { get; set; }
        public ICollection<VehicleModel> Models { get; set; }
        protected override void Validate()
        {
            throw new NotImplementedException();
        }
    }   
}
