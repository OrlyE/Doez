using Infrastructure.Domain;
using Infrastructure.Security.Interfaces;
using Infrastructure.Security.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yad2.EFRepositories;
using Yad2.Model.Entities;
using Yad2.Model.Entities.BaseEntities;
using Yad2.Services.Interfaces;
using Yad2.Services.Messages.SellerServiceMessages;
using Yad2.Services.SettingsObjects;
using Yad2.Services.ViewModels.Posts;

namespace Yad2.Services.Implementations
{
    public class PostsService<T> : IPostsService<T> where T : PostBase ,IVisiblePost
    {
        IRepository<PicOfPost, int> _picsRepo;
        IRepository<Category, int> _categoryRepo;
        IRepository<Seller, int> _sellerRepo;
        IRepository<T, int> _repository;
        ISecurityService _iSecurityService;
        public PostsService(IRepository<T, int> repo, IRepository<PicOfPost, int> picsRepository, IRepository<Category, int> categoryRepository,
        IRepository<Seller, int> sellerRepository, ISecurityService ISecurityService)
        {
            _repository = repo;
            _picsRepo = picsRepository;
            _sellerRepo = sellerRepository;
            _categoryRepo = categoryRepository;
            _iSecurityService = ISecurityService;
        }

        public PublishPostResponse<T> PublishPost(PublishPostRequest<T> request)
        {
            PublishPostResponse<T> response = new PublishPostResponse<T>()
           {
               Message = "Success",
               Success = true
           };

            if (request == null || request.Post == null)
            {
                response.Success = false;
                response.Message = "Error in request";
                return response;
            }

            request.Post.Created = DateTime.Now;
            request.Post.LastModified = DateTime.Now;
            int? categoryId = GetCategoryIdByTypeName<T>();
            if (categoryId.HasValue) request.Post.CategoryId = categoryId.Value;
            else
            {
                response.Success = false;
                response.Message = "Error in category";
                return response;
            }
            request.Post.LastPopedUp = DateTime.Now;
            Seller seller = _sellerRepo.FindAll().FirstOrDefault(s => s.UserId == request.UserId);
            if (seller != null) request.Post.SellerId = seller.Id;
            else
            {
                response.Success = false;
                response.Message = "Error in seller data";
                return response;
            }
            //IEnumerable<BusinessRule> brokenRules = request.Post.GetBrokenRules();
            //if (brokenRules.Count() > 0)
            //{
            //    response.Message = "Error(s): ";
            //    foreach (BusinessRule br in brokenRules)
            //    {
            //        response.Message += br.Property + " - " + br.Rule + "   ";
            //    }

            //    response.Success = false;

            //}
            //else
            //{
            try
            {
                _repository.Add(request.Post);
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.Message = "Filter Error - " + ex.Message;
            }
            //}
            return response;
        }


        public GetSellerPostsListResponse<T> GetList(GetSellerPostsListRequest<T> request)
        {
            GetSellerPostsListResponse<T> response = new GetSellerPostsListResponse<T>()
            {
                Success = true,
                Message = "Success"
            };
            
            UserBase user = _iSecurityService.GetUser();
            if (user != null && request.UserId == user.Id)
            {
                try
                {

                   // IEnumerable<T> allItemsAfterFilter = _repository.FindAll().OrderBy(i => i.Id);
                   // response.Posts = allItemsAfterFilter
                   //                         .Skip(request.ItemsPerPage * (request.Page - 1))
                   //                         .Take(request.ItemsPerPage)
                   //                         .Select(r => r.ToListItemViewModel());

                   // //response.FilterObject = request.FilterObject;
                   // response.TotalPages = (int)Math.Ceiling((double)allItemsAfterFilter.Count() / request.ItemsPerPage);
                   // response.ItemsPerPage = request.ItemsPerPage;
                   // response.CurrentPage = request.Page;
                   //// response.SettingsObject = SettingsObjectsFactory.Create<T>();

                    //List<SecondHandListViewModle> SecondHandPosts = new List<SecondHandListViewModle>();

                    
                    //List<SecondHandListViewModle> SecondHandPosts = (from c in _repository.FindAll()
                    //                                                 select new SecondHandListViewModle()).ToList<SecondHandListViewModle>();
                    //if (typeof(T).IsAssignableFrom(typeof(SecondHand)))
                    //{

                    //    GetSellerPostsListResponse<SecondHand> response = new GetSellerPostsListResponse<SecondHand>();
                    //    response.Posts = SecondHandPosts;
                    //}





                    //List<SecondHandListViewModle> SecondHandPosts = (from c in _repository.FindAll()
                    //                                                 select new SecondHandListViewModle()).ToList<SecondHandListViewModle>();

                    //  SecondHandPosts.AsEnumerable();response.Posts = _repository.FindAll().Where(p => p.Seller.User.Id == user.Id).Take(5).ToArray();
                    response.Posts = _repository.FindAll().Where(p => p.Seller.User.Id == user.Id).Take(5).ToArray();
                }
                catch (Exception ex)
                {
                    response.Success = false;
                    response.Message = "Provider Error";
                }
            }
            return response;
        }

        public UpdatePostResponse<T> UpdatePost(UpdatePostRequest<T> request)
        {

            UpdatePostResponse<T> response = new UpdatePostResponse<T>()
            {
                Success = true,
                Message = "Success"
            };

            UserBase user = _iSecurityService.GetUser();
            if (user != null && request.UserId == user.Id)
            {


                //IEnumerable<BusinessRule> brokenRules = request.Post.GetBrokenRules();
                //if (brokenRules.Count() > 0)
                //{
                //    response.Message = "Error(s): ";
                //    foreach (BusinessRule br in brokenRules)
                //    {
                //        response.Message += br.Property + " - " + br.Rule + "   ";
                //    }

                //    response.Success = false;

                //}
                //else
                //{

                response.Post = request.Post;
                //}
                try
                {
                    _repository.Update(request.Post);
                }
                catch (Exception ex)
                {
                    response.Success = false;
                    response.Message = "Provider Error";
                }
            }
            return response;


        }

        public RemovePostResponse RemovePost(RemovePostRequest request)
        {
            RemovePostResponse response = new RemovePostResponse()
            {
                Success = true,
                Message = "Success"
            };

            
            UserBase currentUser= _iSecurityService.GetUser();
            
            if (request.UserId== currentUser.Id)
            {
                try
                {
                    T existPost = _repository.FindBy(request.Id);
                    if (existPost != null)
                        _repository.Remove(existPost);

                }
                catch (Exception ex)
                {
                    response.Success = false;
                    response.Message = "Filter Error - " + ex.Message;
                }
               
            }
            return response;
        }

        public ISettingsObj<T> GetSettings()
        {
            return SettingsObjectsFactory.Create<T>();
        }
        private int? GetCategoryIdByTypeName<T>()
        {
            string typeName = typeof(T).ToString();
            if (typeName.Contains("."))
            {
                int lastIndexOfDot = typeName.LastIndexOf(".");
                typeName = typeName.Substring(lastIndexOfDot + 1, typeName.Length - lastIndexOfDot - 1);
            }

            Category cat;

            int? categoryId = null;


            switch (typeName.ToLower())
            {
                case "car":
                    cat = _categoryRepo.FindAll().FirstOrDefault(c => c.Name == "Cars");
                    if (cat != null) categoryId = cat.Id;
                    break;

                case "secondhand":
                    cat = _categoryRepo.FindAll().FirstOrDefault(c => c.Name == "Secondhands");
                    if (cat != null) categoryId = cat.Id;
                    break;

            }

            return categoryId;
        }
    }
}

