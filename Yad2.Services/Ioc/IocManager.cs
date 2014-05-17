using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;

namespace Yad2.Services.Ioc
{
    public class IocManager
    {
        private static IKernel ninjectKernel = null;

        public static IKernel GetNinjectKernel()
        {
            if(ninjectKernel == null)
            {
                ninjectKernel = new StandardKernel();
            }
            return ninjectKernel;
        }
    }
}
