using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yad2.Model.Entities;
using Yad2.Model.Entities.BaseEntities;
using Yad2.Services.Messages.SellerServiceMessages;

namespace Yad2.Services.Interfaces
{
    public interface IPostsService<T> where T : PostBase
    {
        PublishPostResponse<T> PublishPost(PublishPostRequest<T> request);
        GetSellerPostsListResponse<T> GetList(GetSellerPostsListRequest<T> request);
        UpdatePostResponse<T> UpdatePost(UpdatePostRequest<T> request);
        RemovePostResponse RemovePost(RemovePostRequest request);
        ISettingsObj<T> GetSettings();
    }
}
