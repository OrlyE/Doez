using Infrastructure.Security.Interfaces;
using Infrastructure.Security.Model;
using Infrastructure.Web.FacebookAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Yad2.Model.Entities.BaseEntities;
using Yad2.Services.Implementations;
using Yad2.Services.Messages;
using Yad2.Services.Messages.SellerServiceMessages;

namespace Yad2.Controllers.Controllers
{
    public class LoginController: Controller
    {
        ISecurityService _svc = null;
        IAccountDTL _iAccountDTL;
        public LoginController(ISecurityService service,IAccountDTL IAccountDTL)
        {
            _svc = service;
            _iAccountDTL = IAccountDTL;
        }
      


        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
       
        public ActionResult Login(string username, string password)
        {
            _iAccountDTL.CreatTempUser();
            UserBase user = _svc.Authenticate(username, password);
            if (user != null)
            {
               
                HttpCookie cookie = new HttpCookie("un", username);

                HttpContext.Response.Cookies.Set(cookie);

                return Json(new { Success = true, Url = "/PersonalArea/Index" });
               // return RedirectToAction("Index", "PersonalArea");
            }
            else
            {
                return Json(new { Success = false, Message = "No User connected" });
            }
        }



        public ActionResult FaceBook(string usernamefacebook)
        {
            // _iAccountDTL.CreatTempUser();
            UserBase facebookuser = _svc.GetUser(usernamefacebook);
            if (facebookuser != null)
            {

                HttpCookie cookie = new HttpCookie("un", facebookuser.Email);

                HttpContext.Response.Cookies.Set(cookie);

                // return Json(new { Success = true, Url = "/PersonalArea/Index" });
                // RedirectToAction("Login", "Login", new { username = usernamefacebook, password = facebookuser.PasswordHash });
                return RedirectToAction("Index", "PersonalArea");
            }
            else
            {
                return Json(new { Success = false, Message = "No User connected" });
            }
        }

        [HttpGet]
        public ActionResult FacebookLogin(string code, string error)
        {
            OAuth fb_oauth = new OAuth("1432360427020241", "10526e6246161475f25a243ff3b3a779");

            if (string.IsNullOrEmpty(error))
            {

                if (string.IsNullOrEmpty(code))
                {
                    Response.Redirect(fb_oauth.UrlRedirect(AbsolutePathForFB("~/Login/FacebookLogin")));
                    //Response.Redirect(fb_oauth.UrlRedirect("https://localhost:57425/Login/FacebookLogin"));
                }
                else
                {
                    var user = fb_oauth.UserData(code, AbsolutePathForFB("~/Login/FacebookLogin"));
                    //var user = fb_oauth.UserData(code, "https://localhost:57425/Login/FacebookLogin");

                    if (user != null)
                    {
                        string username = "Facebook" + "_" + user.id + "_" + user.first_name;
                        UserBase userFb = _svc.GetUser(username);
                        if (userFb == null)
                        {
                            userFb = new UserBase()
                            {
                                UserName = user.name,
                                Created = DateTime.Now,
                                Email = user.email,
                                HasToChangePass = false,
                                IsActive = true,
                                LastVisited = DateTime.Now,

                            };


                            _svc.CreateUser(userFb);
                            _svc.AddUserToGroup(userFb, "Sellers");
                            _svc.Authenticate(userFb);


                            Seller newSeller = new Seller();
                            //newSeller.Name = user.first_name;
                            //newSeller.UserId = userFb.Id;
                            newSeller.Name = userFb.UserName != null ? userFb.UserName : userFb.Email;
                            newSeller.UserId = userFb.Id;
                            _iAccountDTL.CreateSeller(new CreateSellerRequest() { IsOuterSeller = true, User = userFb, Seller = newSeller });

                        }
                        else
                        {
                            _svc.Authenticate(userFb);

                            return RedirectToAction("FaceBook", "Login", new { usernamefacebook = username });
                        }

                        // todo: enter to DB


                        //CreateAuthCookieFor(user.id, false, AuthMethod.Facebook);

                        return RedirectToAction("Index", "PersonalArea");
                    }
                    else
                    {
                        // redirect to message : the login with facebook failed
                    }
                }
            }

            return View();
        }

        public string AbsolutePathForFB(string path)
        {

            Uri uri = new Uri(path, UriKind.RelativeOrAbsolute);
            if (!uri.IsAbsoluteUri)
            {
                Uri requestUrl = Url.RequestContext.HttpContext.Request.Url;
                UriBuilder builder = new UriBuilder(requestUrl.Scheme, requestUrl.Host, requestUrl.Port);
                builder.Path = VirtualPathUtility.ToAbsolute(path);
                uri = builder.Uri;

            }
            return uri.ToString();
        }

        [HttpPost]
        public ActionResult Logout()
        {
            MessageBase response = new MessageBase()
            {
                Success = false
            };

            _svc.SignOut();

            if (_svc.GetUser() != null)
            {
                response.Success = true;
                response.Message = "User Loged out";
            }
            return Json(response);
        }

    }
}
