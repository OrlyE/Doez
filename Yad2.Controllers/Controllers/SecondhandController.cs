using Infrastructure.Security.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using Yad2.Model.Entities;
using Yad2.Services.Interfaces;

namespace Yad2.Controllers.Controllers
{
    public class SecondHandController : CatalogBaseController<SecondHand>
    {

        public SecondHandController(ICatalogService<SecondHand> svc, ISecurityService ISecuritySvc)
            : base(svc, ISecuritySvc)
        {

        }

    }
}
