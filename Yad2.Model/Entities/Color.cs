using Infrastructure.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yad2.Model.Entities
{
    public class Color : EntityBase<int>
    {
      public string Name { get;set;}

      protected override void Validate()
      {
          throw new NotImplementedException();
      }
    }
}
