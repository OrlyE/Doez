using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yad2.Model.Entities.BaseEntities;

namespace Yad2.Model.Entities
{
    public class Vehicle : PostBase
    {
        public int EngineCapacity { get; set; }
        public int Year { get; set; }
        public int ManufacturerId { get; set; }
        public VehicleManufacturer Manufacturer { get; set; }
        public int ModelId { get; set; }
        public VehicleModel Model { get; set; }
        public int OwnersCount { get; set; }
        public int Type { get; set; }
        public int Color { get; set; }
        public DateTime LastTest { get; set; }
        public int Kilometer { get; set; }
        public int OwnershipType { get; set; }
    }
}
