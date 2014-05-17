using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Yad2.Services.Filters;

namespace Yad2.Web.Mvc.UI.CustomModelBinders
{
    public class JeepsFilterModelBinder : IModelBinder
    {
        public object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
        {
            JeepFilter model = new JeepFilter();
            // HttpContext.Current.Request.QueryString
            model.IsAdvancedFilter = bindingContext.GetValue<bool?>("iadv");

            model.Model = bindingContext.GetValue<int?>("mdl");
            model.YearMin = bindingContext.GetValue<int?>("ymin");
            model.YearMax = bindingContext.GetValue<int?>("ymax");
            model.RegionId = bindingContext.GetValue<int?>("reg");
            model.CityId = bindingContext.GetValue<int?>("cid");
            model.Manufacturer = bindingContext.GetValue<int?>("man");
            model.PriceMin = bindingContext.GetValue<int?>("pmin");
            model.PriceMax = bindingContext.GetValue<int?>("pmax");
            model.OwnersCount = bindingContext.GetValue<int?>("oc");
            model.KilometerMin = bindingContext.GetValue<int?>("kmin");
            model.KilometerMax = bindingContext.GetValue<int?>("kmax");
            model.EngineCapacity = bindingContext.GetValue<int?>("ec");
            model.OwnershipType = bindingContext.GetValue<int?>("ot");
            model.Color = bindingContext.GetValue<int?>("clr");
            model.GearType = bindingContext.GetValue<int?>("gt");
            model.Text = bindingContext.GetValue<string>("txt");

            return model;
        }

    }


}
