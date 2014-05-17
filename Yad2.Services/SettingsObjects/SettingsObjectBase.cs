using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yad2.Services.SettingsObjects
{
    public class SettingsObjectBase
    {
        public  IEnumerable<ListItem> Regions { get; set; }
        public IEnumerable<ListItem> Citeis { get; set; }
    }
}
