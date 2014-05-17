using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Yad2.Services.Filters;

namespace Yad2.Web.Mvc.UI.CustomModelBinders
{
    public class SecondhandsFilterModelBinder : IModelBinder
    {
        public object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
        {
            SecondhandsFilter model = new SecondhandsFilter();
            // HttpContext.Current.Request.QueryString

            model.Category = bindingContext.GetValue<int?>("cat");
            model.SubCategory = bindingContext.GetValue<int?>("subcat");
            model.State = bindingContext.GetValue<int?>("state");
            model.RegionId = bindingContext.GetValue<int?>("reg");
            model.PriceMin = bindingContext.GetValue<int?>("pmin");
            model.PriceMax = bindingContext.GetValue<int?>("pmax");
            model.Text = bindingContext.GetValue<string>("txt");


            return model;
        }

    }


}
