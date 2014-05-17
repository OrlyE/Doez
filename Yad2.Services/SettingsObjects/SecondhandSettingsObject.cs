using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yad2.Model.Entities;
using Yad2.Services.Interfaces;

namespace Yad2.Services.SettingsObjects
{
    public class SecondhandSettingsObject : SettingsObjectBase, ISettingsObj<SecondHand>
    {
        public IEnumerable<ListItem> Categories { get; set; }
        public IEnumerable<ListItem> SubCategories { get; set; }
        public IEnumerable<ListItem> States { get; set; }
    }
}
