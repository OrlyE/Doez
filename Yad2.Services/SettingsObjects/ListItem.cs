using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yad2.Services.SettingsObjects
{
    public class ListItem
    {
        public int? PId { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }

        public string Filename { get; set; }
        public string Pics { get; set; }
        public int PostId { get; set; }
        //public int? Type { get; set; }

    }
}
