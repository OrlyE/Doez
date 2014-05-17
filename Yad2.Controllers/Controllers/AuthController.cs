using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using Infrastructure.Security.Interfaces;
using Infrastructure.Security.Model;
using Yad2.Model.Entities.BaseEntities;
using Yad2.Services.Interfaces;
using Yad2.Services.Messages.SellerService;

namespace Yad2.Controllers.Controllers
{
    public class AuthController : Controller
    {

        ISecurityService _securityService;
        ISellerService _sellerService;
        public AuthController(ISecurityService securitySvc, ISellerService sellerSvc)
        {
            _securityService = securitySvc;
            _sellerService = sellerSvc;
        }

        public ViewResult NewSeller()
        {
            return View();
        }

        [HttpPost]
        public ActionResult NewSeller(CreateSellerRequest request)
        {
            CreateSellerResponse response = _sellerService.CreateSeller(request);

            if (response.Success)
            {
                UserBase user = _securityService.Authenticate(request.User.UserName, request.Pass);

                if (Request.IsAjaxRequest()) return Json(response);
                else return RedirectToAction("Index", "Seller");   //  RedirectToAction("Login", "Auth");
            }
            else
            {
                if (Request.IsAjaxRequest()) return Json(response);
                else return View(response);
            }
        }


        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(string username,string password)
        {
            UserBase user = _securityService.Authenticate(username, password);
            if (user != null)
            {

                if (Request.IsAjaxRequest())
                    return Json(new { Success = true, Url = "/Seller/Index" });
                else
                    return RedirectToAction("Index","Seller");
            }
            else
            {
                if (Request.IsAjaxRequest())
                    return Json(new { Success = false });
                else
                {
                    ViewBag.UserName = username;
                    ViewBag.Success = false;
                    return View();
                }
            }
        }

    }
}
