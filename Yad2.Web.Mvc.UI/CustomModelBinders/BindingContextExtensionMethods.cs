using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Yad2.Web.Mvc.UI.CustomModelBinders
{
    public static class BindingContextExtensionMethods
    {
        public static T GetValue<T>(this ModelBindingContext bindingContext, string key)
        {
            try
            {
                var converter = TypeDescriptor.GetConverter(typeof(T));
                if (converter != null)
                {
                    ValueProviderResult r = bindingContext.ValueProvider.GetValue(key);
                    if (r != null && !string.IsNullOrEmpty(r.AttemptedValue))
                    {
                        //Cast ConvertFromString(string text) : object to (T)
                        return (T)converter.ConvertFromString(r.AttemptedValue);
                    }
                }
            }
            catch
            {
                return default(T);
            }

            return default(T);
        }
    }
}