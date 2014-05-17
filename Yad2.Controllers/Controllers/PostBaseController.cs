using Infrastructure.Security.Interfaces;
using Infrastructure.Security.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using Yad2.Model.Entities;
using Yad2.Model.Entities.BaseEntities;
using Yad2.Services.Interfaces;
using Yad2.Services.Messages;
using Yad2.Services.Messages.SellerServiceMessages;
using Yad2.Services.Ioc;
using Ninject;

namespace Yad2.Controllers.Controllers
{
    public class PostBaseController: Controller 
    {
        
       
       // ICatalogService<T> _catalogService = null;
        ISecurityService _iSecuritySvc= null;
        public enum PostAction
        {
            Add,
            Update,
            Remove
        }

        public PostBaseController( ISecurityService svc)
        {
          
           // _catalogService = _catalogSvc;
            _iSecuritySvc = svc;
        }

        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        //[HttpPost]
        //public ActionResult PublishPost(PublishPostRequest<T> publishPostRequest)
        //{
            //UserBase user = _iSecuritySvc.GetUser();
            //if (user!= null && publishPostRequest.UserId == user.Id) publishPostRequest.UserId = user.Id;
            //else return Json(new { Success = false, Message = "No User connected" });
            
            //if (publishPostRequest.Post!=null)
            //{
            //    publishPostRequest.UserId = user.Id;
            //    //if (Request.IsAjaxRequest())
            //     return Json(_PsostService.PublishPost(publishPostRequest));
                
                
            //}
            //else return Json(new { Success = false, Message = "Error in data" });
        //}

        [HttpPost]
        public ActionResult PublishPost(string type)
        {

            MessageBase MessageBaseReply = null;

            if (!string.IsNullOrEmpty(type) && type.Length > 0)
            {
                switch (type.ToLower())
                {
                    case "car":
                        MessageBaseReply = Post<Car>(PostAction.Add);
                        break;

                    case "secondhand":
                        MessageBaseReply = Post<SecondHand>(PostAction.Add);
                        break;
                }
            }

            return Json(MessageBaseReply);
        }
        //[HttpPost]
        //public ActionResult UpdatePost(UpdatePostRequest<T> updatePostRequest)
        //{
        //    UserBase user = _iSecuritySvc.GetUser();
        //    if (updatePostRequest.Post != null&& updatePostRequest.UserId==user.Id)
        //    {
        //        //if (Request.IsAjaxRequest())
                
        //            return Json(_PsostService.UpdatePost(updatePostRequest));
                
               
        //    }
        //    else return Json(new { Success = false, Message = "Error in data" });

        //}
        [HttpPost]
        public ActionResult UpdatePost(string type)
        {

            MessageBase MessageBaseReply = null;

            if (!string.IsNullOrEmpty(type) && type.Length > 0)
            {
                switch (type.ToLower())
                {
                    case "car":
                        MessageBaseReply = Post<Car>(PostAction.Update);
                        break;

                    case "secondhand":
                        MessageBaseReply = Post<SecondHand>(PostAction.Update);
                        break;
                }
            }

            return Json(MessageBaseReply);

        }
        //[HttpPost]
        //public ActionResult RemovePost(RemovePostRequest removePostRequest)
        //{
        //    UserBase user = _iSecuritySvc.GetUser();
        //    MessageBase MessageBaseResponse = null;

        //    if (removePostRequest.UserId==user.Id)
        //    {
        //        if (removePostRequest.Id== null)
                
        //            return Json(_PsostService.RemovePost(removePostRequest));
             
               
        //    }
        //    else return Json( MessageBaseResponse.Success = false,MessageBaseResponse.Message = "Error in data" );
        //    return Json(MessageBaseResponse);
        //}
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

    }
}
