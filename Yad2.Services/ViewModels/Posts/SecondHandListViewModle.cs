using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yad2.Services.ViewModels.Posts
{
    public class SecondHandListViewModle
    {
        public int Id { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public decimal? Price { get; set; }
        public string Pic { get; set; }
        public DateTime LastPopedUp { get; set; }
        public DateTime UploadDate { get; set; }
        // public DateTime Status { get; set; }

    }
}
