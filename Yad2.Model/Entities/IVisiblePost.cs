using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yad2.Model.Entities.BaseEntities;

namespace Yad2.Model.Entities
{
    public interface IVisiblePost
    {
        int Id { get; set; }
        int CategoryId { get; set; }
        string[] ToListItemViewModel();
        string[] ToFullPostViewModel();
        string ToAutoCompleteViewModel();
    }
}
