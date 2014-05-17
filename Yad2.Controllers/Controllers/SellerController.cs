using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using Infrastructure.Security.Interfaces;
using Infrastructure.Security.Model;
using Yad2.Model.Entities;
using Yad2.Model.Entities.BaseEntities;
using Yad2.Services.Interfaces;
using Yad2.Services.Messages;
using Yad2.Services.Messages.SellerService;
using Ninject;
using Yad2.Services.Implementations;
using Yad2.Services.Ioc;

namespace Yad2.Controllers.Controllers
{
    public class SellerController : Controller
    {

        ISecurityService _securityService;
        ISellerService _sellerService;
        public SellerController(ISecurityService securitySvc, 
                                ISellerService sellerSvc)
        {
            _securityService = securitySvc;
            _sellerService = sellerSvc;
        }

        public ViewResult Index()
        {
            return View();
        }


        public ActionResult GetProfile()
        {
            UserBase user = _securityService.GetUser();
            GetProfileRequest request = new GetProfileRequest()
            {
                User = user
            };

            return Json(_sellerService.GetProfile(request));
        }

        public ActionResult UpdateProfile(Seller seller,string Email)
        {
            UserBase user = _securityService.GetUser();
            if (user != null)
            {
                user.Email = Email;
            }
            UpdateProfileRequest request = new UpdateProfileRequest()
            {
                Seller = seller,
                User = user
            };

            return Json(_sellerService.UpdateProfile(request));
        }


        [HttpGet]
        public ActionResult UpdatePassword()
        {
            return View();
        }

        [HttpPost]
        public ActionResult UpdatePassword(string oldPass,string newPass, string newPassConfirm)
        {

            MessageBase response = new MessageBase()
            {
                Success = false
            };


            UserBase user = _securityService.GetUser();
            if (user != null)
            {
                UserBase userForPassCheck = _securityService.Authenticate(user.UserName, oldPass);
                if (userForPassCheck != null) // && pass is valid
                {
                    if (newPass == newPassConfirm)
                    {
                        _securityService.SetNewPasswordForUser(newPass);
                        response.Success = true;
                        response.Message = "Password Changed";
                    }
                    else response.Message = "new passwords not match";
                }
                else response.Message = "old password not correct";
            }
            else
            {
                response.Message = "Not Authenticated";
            }

            if (Request.IsAjaxRequest())
                return Json(response);
            else
                return View(response);
        }


        public ActionResult NewPost(string type)
        {
            
            UserBase user = _securityService.GetUser();

            switch(type.ToLower())
            {
                case "car":
                    Car post = new Car();
                    if (TryUpdateModel<Car>(post))
                    {
                        return Json(IocManager.GetNinjectKernel()
                                    .Get<ISellerPostsService<Car>>()
                                    .AddPost(new AddPostRequest<Car>() { Post = post, UserId = user.Id }));
                    }
                    break;
            }

            return Json(new MessageBase() { Success = false, Message = "No such type" });
        }

    }
}
