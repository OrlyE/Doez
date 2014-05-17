using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infrastructure.Domain;
using Yad2.Model.Entities;
using Yad2.Model.Entities.BaseEntities;
using Yad2.Services.Interfaces;
using Yad2.Services.Messages;
using Yad2.Services.SettingsObjects;


namespace Yad2.Services.Implementations
{
    public class CatalogService<T> : ICatalogService<T> where T : IVisiblePost
    {
        IRepository<PicOfPost, int> picsRepository;
        IRepository<T, int> repository;
        
        //Seller
       // IRepository<PicOfPost, int> picsRepository;

        public CatalogService(IRepository<T, int> repo, IRepository<PicOfPost, int> picsRepo)
        {
            repository = repo;
            picsRepository = picsRepo;
        }

        public GetListResponse<T> GetList(GetListRequest<T> request)
        {
            GetListResponse<T> response = new GetListResponse<T>()
            {
                 Message = "Success",
                 Success = true
            };

            try
            {
                IEnumerable<T> allItemsAfterFilter = request.FilterObject.Filter(repository.FindAll().OrderBy(i => i.Id));
                response.Items = allItemsAfterFilter
                                        .Skip(request.ItemsPerPage * (request.Page - 1))
                                        .Take(request.ItemsPerPage)
                                        .Select(r => r.ToListItemViewModel());

                response.FilterObject = request.FilterObject;
                response.TotalPages = (int)Math.Ceiling((double)allItemsAfterFilter.Count() / request.ItemsPerPage);
                response.ItemsPerPage = request.ItemsPerPage;
                response.CurrentPage = request.Page;
                response.SettingsObject = SettingsObjectsFactory.Create<T>(); //GetSettings();
            }
            catch(Exception ex)
            {
                response.Success = false;
                response.Message = "Filter Error - " + ex.Message;
            }

            return response;
        }

        public virtual GetFullPostResponse GetFullPost(GetFullPostRequest request)
        {
            GetFullPostResponse response = new GetFullPostResponse()
            {
                Message = "Success",
                Success = true
            };

            T item = repository.FindBy(request.PostId);
            response.Item = item.ToListItemViewModel();
            response.ItemPics = picsRepository.FindAll().Where(p => p.CategoryId == item.CategoryId && p.PostId == item.Id).Select(p => p.Filename).ToArray();


            if (response.Item == null)
            {
                response.Success = false;
                response.Message = "Id does not exist";
            }

            return response;
        }

        public  GetAutoCompleteResponse GetAutoComplete(GetAutoCompleteRequest<T> request)
        {
            GetAutoCompleteResponse response = new GetAutoCompleteResponse()
            {
                Message = "Success",
                Success = true
            };

            response.Values = request.FilterObject.Filter(repository.FindAll()).Select(i => i.ToAutoCompleteViewModel()).Take(7);

            return response;
        }

        public GetMarkedPostsResponse GetMarkedPosts(GetMarkedPostsRequest request)
        {
            //throw new NotImplementedException();
          
            GetMarkedPostsResponse response = new GetMarkedPostsResponse()
            {
                Message = "Success",
                Success = true
            };

           
            List<string[]> mark = new List<string[]>();
            if (request.PostsIds.Length > 0)
            {

                for (var marks = 1; marks < request.PostsIds.Length; marks++)
                {


                    mark.Add(repository.FindBy(request.PostsIds[marks]).ToListItemViewModel());
                    //mark.Add(repository.FindBy(request.PostsIds[marks]).ToListItemViewModel());
                
                }

                
                response.Items = mark;
            }
            return response;
            
        }


        public ISettingsObj<T> GetSettings()
        {
            return SettingsObjectsFactory.Create<T>();
        }
    }
}
