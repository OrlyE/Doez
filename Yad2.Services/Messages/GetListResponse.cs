using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yad2.Model.Entities;
using Yad2.Services.Interfaces;

namespace Yad2.Services.Messages
{
    public class GetListResponse<T> : MessageBase   where T : IVisiblePost
    {
        public IEnumerable<string[]> Items { get; set; }

        public int CurrentPage { get; set; }
        public int TotalPages { get; set; }
        public int ItemsPerPage { get; set; }
        public IFilterObject<T> FilterObject { get; set; }
        public ISettingsObj<T> SettingsObject { get; set; }

    }
}
