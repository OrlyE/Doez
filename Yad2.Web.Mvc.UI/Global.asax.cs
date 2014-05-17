using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Yad2.Model.Entities;
using Yad2.Services.Interfaces;
using Yad2.Web.Mvc.UI.CustomModelBinders;
using Yad2.Web.Mvc.UI.Infrastructure;

namespace Yad2.Web.Mvc.UI
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            ModelBinders.Binders.Add(typeof(IFilterObject<Car>), new CarsFilterModelBinder());
            ModelBinders.Binders.Add(typeof(IFilterObject<Jeep>), new JeepsFilterModelBinder());
            ModelBinders.Binders.Add(typeof(IFilterObject<SecondHand>), new SecondhandsFilterModelBinder());

            ModelBinders.Binders.Add(typeof(IFilterObject<Commercial>), new CommercialsFilterModelBinder());


            ModelBinders.Binders.Add(typeof(IFilterObject<Motorcycle>), new MotorcycleFilterModelBinder());
           // ModelBinders.Binders.Add(typeof(IFilterObject<Trucks>), new TrucksFilterModelBinder());

            ModelBinders.Binders.Add(typeof(IFilterObject<Scooter>), new ScooterFilterModelBinder());

            ControllerBuilder.Current.SetControllerFactory(new NinjectControllerFactory());

            WebApiConfig.Register(GlobalConfiguration.Configuration);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);


            if (ConfigurationManager.AppSettings["generateDb"] == "true") GenerateBaseDB.GenerateInitialValuesIntoDB();

            EFRepositories.EFContext.Get();
        }
    }
}