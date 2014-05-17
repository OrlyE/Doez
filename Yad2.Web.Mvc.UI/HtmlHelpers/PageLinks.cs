using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace Yad2.Web.Mvc.UI.HtmlHelpers
{
    public static class PagingHelpers
    {
        public static MvcHtmlString PageLinks(this HtmlHelper html, int CurrentPage , int TotalPages, Func<int, string> pageUrl)
        {
            int startPage = CurrentPage - 5 < 1 ? 1 : CurrentPage - 5;
            int endPage = CurrentPage + 5 > TotalPages ? TotalPages : CurrentPage + 5;
            if (endPage - startPage < 11 && TotalPages >= 11)
            {
                if (endPage < 11 ) endPage = 11;

                if (CurrentPage > TotalPages - 5) startPage = TotalPages - 10;
            }


            StringBuilder result = new StringBuilder();
            for (int i = startPage; i <= endPage; i++)
            {
                TagBuilder tag = new TagBuilder("a"); // Construct an <a> tag 
                tag.MergeAttribute("href", pageUrl(i));
                tag.InnerHtml = i.ToString();
                if (i == CurrentPage)
                    tag.AddCssClass("selected");
                result.Append(tag.ToString());
            }
            return MvcHtmlString.Create(result.ToString());
        }
    }
}