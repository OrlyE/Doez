using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yad2.Model.Entities;
using Infrastructure.Domain;
using Yad2.Model.Entities.BaseEntities;
using System.Web.Mvc;
using System.Web.UI;
using Infrastructure.Web.Security.Interfaces;
using Yad2.EFRepositories;
using Yad2.Services.Implementations;
using Infrastructure.Security.Interfaces;
using Infrastructure.Security.Model;
using Yad2.Services.Messages.SellerServiceMessages;
using System.Web;
using Yad2.Services.Interfaces;
using Yad2.Services.Messages;
using Yad2.Services.Ioc;
using Ninject;
using Yad2.Services.ViewModels;


namespace Yad2.Controllers.Controllers
{

    public class PersonalAreaController : Controller
    {

        IAccountDTL _iAccountDTL;
        ISecurityService _iSecuritySvc = null;
        IPostsService<PostBase> _ipostSvc = null;
        IRepository<Seller, int> _iSellerRepository;
        public enum PostAction
        {
            GetList,
            Add,
            Update,
            Remove
        }
        public PersonalAreaController(ISecurityService ISecuritySvc, IAccountDTL iac, IPostsService<PostBase> iPostSvc, IRepository<Seller, int> iSellerRepo )
        {

            _iSecuritySvc = ISecuritySvc;
            _iAccountDTL = iac;
            _ipostSvc = iPostSvc;
            _iSellerRepository = iSellerRepo;
        }


        public ActionResult Index()
        {
            //UserBase user = _iSecuritySvc.GetUser();
            //if (user != null)
            //{
            //    return View();
            //}
            //else return Json("No user Connected");
            return View();

        }
        [HttpPost]
        public ActionResult GetSeller(string username)
        {
            UserBase user = _iSecuritySvc.GetUser();

            if (user != null)
            {
                GetSellerDTLRequest request = new GetSellerDTLRequest() { User = user };


                return Json(_iAccountDTL.GetSellerDtl(request));

            }
            return Json("null");
        }

        [HttpPost]
        public ActionResult UpdateSeller(UpdateSellerDTLRequest request)
        {
            if (request != null)
            {
                //if (Request.IsAjaxRequest()) 
                return Json(_iAccountDTL.UpdateSeller(request));
                // else  return RedirectToAction("Index", "PersonalArea");
            }

            else
            {
                //if (Request.IsAjaxRequest()) 
                return Json(new { Success = false, Message = "No User connected" });
            }
        }

        [HttpPost]
        public ActionResult SetUserPassword(SetUserPasswordRequest setUserPassRequest)
        {
            UserBase user = _iSecuritySvc.GetUser();
            setUserPassRequest.user = user;
            if (user != null)
            {
                //if (Request.IsAjaxRequest()) 
                if (setUserPassRequest.password == setUserPassRequest.confirmPassword) return Json(_iAccountDTL.SetUserPassword(setUserPassRequest));
                else return Json(new { Success = false, Message = "Passwords do not match" });
                //else return RedirectToAction("Index", "PersonalArea");
            }
            else return Json(new { Success = false, Message = "No seller" });

        }
        [HttpPost]
        public ActionResult CreateSeller(CreateSellerRequest createSellerRequest)
        {
            if (createSellerRequest.Seller != null && createSellerRequest.User != null)
            {
                if (createSellerRequest.Pass == createSellerRequest.PassConfirm) return Json(_iAccountDTL.CreateSeller(createSellerRequest));
                else return Json(new { Success = false, Message = "Error in data" });
            }
            else return Json(new { Success = false, Message = "No seller" });
        }

        [HttpPost]
        public ActionResult GetList(string type)
        {

            UserBase user = _iSecuritySvc.GetUser();
            if (user != null)
            {
                if (!string.IsNullOrEmpty(type) && type.Length > 0)
                {
                    if (type.ToLower() == "cars")
                    {
                        return Json(IocManager.GetNinjectKernel()
                              .Get<IPostsService<Car>>()
                              .GetList(new GetSellerPostsListRequest<Car>() { UserId = user.Id }));

                    }
                    else if (type.ToLower() == "secondhand")
                    {
                        return Json(IocManager.GetNinjectKernel()
                              .Get<IPostsService<SecondHand>>()
                              .GetList(new GetSellerPostsListRequest<SecondHand>() { UserId = user.Id }));

                    }
                }
                //GetSellerPostsListResponse<Car> response = new GetSellerPostsListResponse<Car>();
                //response = IocManager.GetNinjectKernel()
                //   .Get<IPostsService<Car>>()
                //   .GetList(new GetSellerPostsListRequest<Car>() { UserId = user.Id });
                //return Json(response, JsonRequestBehavior.AllowGet);

                //switch (type.ToLower())
                //{
                //    case "cars":
                //        return Json(((Yad2.Model.Entities.Car[])(GetSellerPosts<Car>(user.Id).Posts)).ToList());
                //        break;

                //    case "secondhand":
                //        return Json(GetSellerPosts<Car>(user.Id), JsonRequestBehavior.AllowGet);
                //        break;
                //}


            }
            return Json("null");
        }

        //[OutputCache(Duration = 86400, VaryByParam = "*", Location = OutputCacheLocation.Client)]
        [HttpPost]
        public ActionResult GetSettings(string type)
        {
            if (!string.IsNullOrEmpty(type) && type.Length > 0)
            {
                if (type.ToLower() == "car")
                {
                    return Json(IocManager.GetNinjectKernel()
                          .Get<IPostsService<Car>>().GetSettings());
                }
                else if (type.ToLower() == "secondhand")
                {
                    return Json(IocManager.GetNinjectKernel()
                          .Get<IPostsService<SecondHand>>().GetSettings());
                }
            }

            return Json("null");
        }

        [HttpPost]
        public ActionResult PublishPost(string type, HttpPostedFileBase file1, HttpPostedFileBase file2, HttpPostedFileBase file3, HttpPostedFileBase file4)
        {

            MessageBase MessageBaseReply = null;

            if (!string.IsNullOrEmpty(type) && type.Length > 0)
            {
                switch (type.ToLower())
                {
                    case "car":
                        MessageBaseReply = Post<Car>(PostAction.Add);
                        break;

                    case "motorcycle":
                        MessageBaseReply = Post<Motorcycle>(PostAction.Add);
                        break;

                    case "trucks":
                        MessageBaseReply = Post<Trucks>(PostAction.Add);
                        break;

                    case "scooter":
                        MessageBaseReply = Post<Scooter>(PostAction.Add);
                        break;

                    case "jeep":
                        MessageBaseReply = Post<Jeep>(PostAction.Add);
                        break;

                    case "secondhand":
                        MessageBaseReply = Post<SecondHand>(PostAction.Add);
                        break;
                }
            }

            return Json(MessageBaseReply);
        }
        [HttpPost]
        public ActionResult UpdatePost(string type)
        {

            MessageBase MessageBaseReply = null;

            if (!string.IsNullOrEmpty(type) && type.Length > 0)
            {
                switch (type.ToLower())
                {
                    case "cars":
                        MessageBaseReply = Post<Car>(PostAction.Update);
                        break;

                    case "secondhand":
                        MessageBaseReply = Post<SecondHand>(PostAction.Update);
                        break;
                }
            }

            return Json(MessageBaseReply);

        }
        public ActionResult RemovePost(string type)
        {
            MessageBase MessageBaseReply = null;

            if (!string.IsNullOrEmpty(type) && type.Length > 0)
            {
                switch (type.ToLower())
                {
                    case "car":
                        MessageBaseReply = Post<Car>(PostAction.Remove);
                        break;

                    case "secondhand":
                        MessageBaseReply = Post<SecondHand>(PostAction.Remove);
                        break;
                }
            }

            return Json(MessageBaseReply);
        }
        private MessageBase Post<T>(PostAction action) where T : PostBase
        {
            MessageBase MessageBaseReply = null;

            UserBase user = _iSecuritySvc.GetUser();
            T post = Activator.CreateInstance<T>();

            if (TryUpdateModel((T)post))
            {
                switch (action)
                {
                    case PostAction.Add:
                        MessageBaseReply = IocManager.GetNinjectKernel()
                           .Get<IPostsService<T>>()
                           .PublishPost(new PublishPostRequest<T>() { Post = (T)post, UserId = user.Id });
                        break;
                    case PostAction.Update:
                        MessageBaseReply = IocManager.GetNinjectKernel()
                           .Get<IPostsService<T>>()
                           .UpdatePost(new UpdatePostRequest<T>() { Post = (T)post, UserId = user.Id });
                        break;
                    case PostAction.Remove:
                        MessageBaseReply = IocManager.GetNinjectKernel()
                           .Get<IPostsService<T>>()
                           .RemovePost(new RemovePostRequest() { UserId = user.Id, Id = post.Id });
                        break;
                    default:
                        MessageBaseReply = new MessageBase() { Success = false, Message = "no action" };
                        break;
                }
            }
            else
            {
                MessageBaseReply = new MessageBase() { Success = false, Message = "no such type" };
            }

            return MessageBaseReply;
        }
        private GetSellerPostsListResponse<T> GetSellerPosts<T>(int userId) where T : PostBase
        {

            GetSellerPostsListResponse<T> response = new GetSellerPostsListResponse<T>();
            response = IocManager.GetNinjectKernel()
                           .Get<IPostsService<T>>()
                           .GetList(new GetSellerPostsListRequest<T>() { UserId = userId });
            return response;
        }
        [HttpPost]
        public ActionResult NewPost(string type, HttpPostedFileBase file1, HttpPostedFileBase file2, HttpPostedFileBase file3, HttpPostedFileBase file4)
        {
            if (!string.IsNullOrEmpty(type) && type.Length > 0)
            {

                List<HttpPostedFileBase> files = new List<HttpPostedFileBase>();
                if (file1 != null) files.Add(file1);
                if (file2 != null) files.Add(file2);
                if (file3 != null) files.Add(file3);
                if (file4 != null) files.Add(file4);

                switch (type.ToLower())
                {
                    case "car":
                        return Json(AddPost<Car>(files.ToArray()));

                    case "secondhand":
                        return Json(AddPost<SecondHand>(files.ToArray()));

                    case "motorcycle":
                        return Json(AddPost<Motorcycle>(files.ToArray()));

                }
            }
            return Json(new MessageBase() { Success = false, Message = "No such type" });

        }
        private PublishPostResponse AddPost<T>(HttpPostedFileBase[] files) where T : PostBase
        {
            PublishPostResponse response = null;

            UserBase user = _iSecuritySvc.GetUser();
            T post = Activator.CreateInstance<T>();

            TryUpdateModel((T)post);

            try
            {

                ISellerPostsService<T> svc = IocManager.GetNinjectKernel().Get<ISellerPostsService<T>>();
                response = svc.AddPost(new AddPostRequest<T>() { Post = (T)post, UserId = user.Id });
                int? catId = svc.GetCategoryIdByTypeName<T>();


                if (response.Success && catId.HasValue)
                {
                    foreach (var file in files)
                    {
                        string extension = file.FileName.Substring(file.FileName.LastIndexOf("."));
                        string filename = Guid.NewGuid().ToString() + extension;
                        string PicsDir = ConfigurationManager.AppSettings["picsDir"];
                        string pathAndFilename = Server.MapPath("~/" + PicsDir);
                        if (!pathAndFilename.EndsWith("\\")) pathAndFilename += "\\";
                        pathAndFilename += filename;
                        file.SaveAs(pathAndFilename);

                        // add to db:
                        svc.AddPicToPost(filename, response.PostId, catId.Value);
                    }

                }
            }
            catch (Exception ex)
            {
                response = new AddPostResponse()
                {
                    Success = false,
                    Message = "Error"
                };
            }
            return response;
        }
    }
}
