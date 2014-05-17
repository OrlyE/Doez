using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yad2.Model.Entities;
using Yad2.Services.Messages;

namespace Yad2.Services.Interfaces
{
    public interface ICatalogService<T> where T : IVisiblePost
    {
        GetListResponse<T> GetList(GetListRequest<T> request);
        GetFullPostResponse GetFullPost(GetFullPostRequest request);
        GetAutoCompleteResponse GetAutoComplete(GetAutoCompleteRequest<T> request);
        GetMarkedPostsResponse GetMarkedPosts(GetMarkedPostsRequest request);
        ISettingsObj<T> GetSettings();
    }
}
