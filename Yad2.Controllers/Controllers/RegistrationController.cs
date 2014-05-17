using Infrastructure.Security.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using Yad2.Services.Implementations;
using Yad2.Services.Messages.SellerServiceMessages;

namespace Yad2.Controllers.Controllers
{
    public class RegistrationController : Controller
    {
        ISecurityService _iSecuritySvc = null;
        IAccountDTL _iAccountDTL;
        public RegistrationController(ISecurityService iSecSvc,IAccountDTL iAccountSvc )
        {
            _iSecuritySvc= iSecSvc;
            _iAccountDTL = iAccountSvc;
        }
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Registration()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Registration(CreateSellerRequest request)
        {
            
            if(request.Seller !=null & request.User != null)
            {
                
                if ( request.Pass == request.PassConfirm)
                {
                    return Json(_iAccountDTL.CreateSeller(request));
                }
            }
            return Json(new { Success = false, Message = "Error in server data" });
        }

    }
}
