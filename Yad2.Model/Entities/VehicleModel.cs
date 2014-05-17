using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infrastructure.Domain;

namespace Yad2.Model.Entities
{
    public class VehicleModel : EntityBase<int>
    {
        public string Name { get; set; }
        public int ManufacturerId { get; set; }
        public VehicleManufacturer Manufacturer { get; set; }

        protected override void Validate()
        {
            throw new NotImplementedException();
        }
    }
}
