using Ninject.Modules;
using PlatePass.Business.Abstract;
using PlatePass.Business.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlatePass.Business.DI
{
    public class BusinessModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IPlateService>().To<PlateManager>().InSingletonScope();
            Bind<IUserService>().To<UserManager>().InSingletonScope();
        }
    }
}
