using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using Yad2.Model.Entities;
using Yad2.Services.Interfaces;
using Yad2.Controllers.Controllers;
using Infrastructure.Security.Interfaces;

namespace Yad2.Controllers.Controllers
{
    public class MotorcycleController : CatalogBaseController<Motorcycle>
    {
        //
        // GET: /Motorcycle/

        public MotorcycleController(ICatalogService<Motorcycle> svc, ISecurityService ISecuritySvc)
            : base(svc, ISecuritySvc)
        {

        }

    }
}
