using Infrastructure.Security.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Yad2.Controllers.Controllers;
using Yad2.Model.Entities;
using Yad2.Services.Interfaces;

namespace Yad2.Controllers.Controllers
{

    public class TrucksController : CatalogBaseController<Trucks>
    {
        //
        // GET: /Motorcycle/

        public TrucksController(ICatalogService<Trucks> svc, ISecurityService ISecuritySvc)
            : base(svc, ISecuritySvc)
        {

        }

    }
}

