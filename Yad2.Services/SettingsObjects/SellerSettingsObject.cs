using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yad2.Model.Entities;
using Yad2.Model.Entities.BaseEntities;
using Yad2.Services.Interfaces;

namespace Yad2.Services.SettingsObjects
{
    class SellerSettingsObject : ISettingsObj<Seller>
    {
        public string[] Seller { get; set; }
    }
}
