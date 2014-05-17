using Infrastructure.Security.Interfaces;
using Infrastructure.Security.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using System.Web.UI;
using Yad2.Model.Entities;
using Yad2.Services.Filters;
using Yad2.Services.Implementations;
using Yad2.Services.Interfaces;
using Yad2.Services.Ioc;
using Yad2.Services.Messages;
using Yad2.Services.Messages.SellerServiceMessages;
using Ninject;
using Yad2.Model.Entities.BaseEntities;
using Yad2.Services.ViewModels.Posts;

namespace Yad2.Controllers.Controllers
{
    public class CatalogBaseController<T> : Controller where T : IVisiblePost
    {
        ICatalogService<T> _service = null;
        //IPostsService<T> _iPostSvc = null;
        ISecurityService _iSecuritySvc = null;
        public CatalogBaseController(ICatalogService<T> svc, ISecurityService ISecuritySvc)
        {
            _service = svc;
            // _iPostSvc = iPostService;
            _iSecuritySvc = ISecuritySvc;
        }

        [HttpGet]
        public ActionResult Index(IFilterObject<T> filterObj, int? p, int? ipp)
        {
            //  UpdateModel<IFilterObject<T>>(request.FilterObject);
            GetListRequest<T> request = new GetListRequest<T>();
            request.FilterObject = filterObj;
            request.Page = p.HasValue ? p.Value : 1;
            request.ItemsPerPage = ipp.HasValue ? ipp.Value : 8;
            return View(_service.GetList(request));
        }

        // [OutputCache(Duration = 86400, VaryByParam = "*", Location = OutputCacheLocation.Client)]
        public ActionResult GetSettings()
        {
            if (Request.IsAjaxRequest())
            {
                return Json(_service.GetSettings(), JsonRequestBehavior.AllowGet);
            }

            return Json("null", JsonRequestBehavior.AllowGet);
        }

        public ActionResult GetSellerPostsList()
        {
            //GetSellerPostsListRequest<T>  request = new GetSellerPostsListRequest<T>();
            GetSellerPostsListResponse<SecondHand> response = new GetSellerPostsListResponse<SecondHand>();
            UserBase user = _iSecuritySvc.GetUser();
            if (user != null)
            {
                if (Request.IsAjaxRequest())
                {
                    
                    return Json(IocManager.GetNinjectKernel()
                    .Get<IPostsService<SecondHand>>()
                    .GetList(new GetSellerPostsListRequest<SecondHand>() { UserId = user.Id }), JsonRequestBehavior.AllowGet);//JsonRequestBehavior.AllowGet);

                    //List<SecondHandListViewModle> SecondHandPosts =
                    //response.Posts = IocManager.GetNinjectKernel()
                    //.Get<IPostsService<SecondHand>>()
                    //.GetList(new GetSellerPostsListRequest<SecondHand>() { UserId = user.Id };

                    //request.UserId = user.Id;
                    //IocManager.GetNinjectKernel()
                    //.Get<IPostsService<SecondHand>>()
                    //.GetList(new GetSellerPostsListRequest<T>() { UserId = user.Id }) where T : PostBase);//JsonRequestBehavior.AllowGet);
                    //if (typeof(T).IsAssignableFrom(typeof(PostBase)))
                    //{
                    //    return Json(SellerPostsType<T>(request), JsonRequestBehavior.AllowGet);

                    //} 
                }
            }
            return Json("null", JsonRequestBehavior.AllowGet);
        }

        private GetSellerPostsListResponse<T> SellerPostsType<T>(GetSellerPostsListRequest<T> request) where T : PostBase
        {

            GetSellerPostsListResponse<T> response = new GetSellerPostsListResponse<T>();
            IocManager.GetNinjectKernel()
                        .Get<IPostsService<T>>()
                        .GetList(request);
            return response;

        }
        public ActionResult AutoComplete(IFilterObject<T> filterObj)
        {
            if (Request.IsAjaxRequest())
            {

                return Json(_service.GetAutoComplete(new GetAutoCompleteRequest<T>() { FilterObject = filterObj }), JsonRequestBehavior.AllowGet);
            }

            return Json("null", JsonRequestBehavior.AllowGet);
        }

        public ActionResult GetMarkedPosts(GetMarkedPostsRequest request)
        {
            if (Request.IsAjaxRequest())
            {
                return Json(_service.GetMarkedPosts(request), JsonRequestBehavior.AllowGet);
            }

            return Json("null", JsonRequestBehavior.AllowGet);
        }
        public ActionResult GetFullPost(GetFullPostRequest request)
        {
            if (Request.IsAjaxRequest())
            {
                return Json(_service.GetFullPost(request), JsonRequestBehavior.AllowGet);
            }

            return Json("null", JsonRequestBehavior.AllowGet);
        }


    }
}
