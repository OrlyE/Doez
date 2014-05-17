using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using Ninject;
using Yad2.Model.Entities;
using Yad2.Services.Interfaces;
using Infrastructure.Domain;
using Yad2.EFRepositories.Repositories;
using Yad2.Model.Entities.BaseEntities;
using Yad2.Services.Implementations;
using Infrastructure.Security.Interfaces;
using Yad2.Services.SecuritySvc;
using Infrastructure.Web.Security.Interfaces;
using Infrastructure.Web.Security.Implementations;
using Infrastructure.Security.Model;



namespace Yad2.Web.Mvc.UI.Infrastructure
{
    public class NinjectControllerFactory : DefaultControllerFactory
    {
        private IKernel ninjectKernel;
        public NinjectControllerFactory()
        {
            ninjectKernel = Yad2.Services.Ioc.IocManager.GetNinjectKernel(); //new StandardKernel();
            AddBindings();
        }
        protected override IController GetControllerInstance(RequestContext requestContext, Type controllerType)
        {
            return controllerType == null
            ? null
            : (IController)ninjectKernel.Get(controllerType);
        }
        private void AddBindings()
        {

            // put bindings here
            ninjectKernel.Bind<ICatalogService<SecondHand>>().To<CatalogService<SecondHand>>();
            ninjectKernel.Bind<ICatalogService<Car>>().To<CatalogService<Car>>();
            ninjectKernel.Bind<ICatalogService<Jeep>>().To<CatalogService<Jeep>>();
            ninjectKernel.Bind<ICatalogService<Commercial>>().To<CatalogService<Commercial>>();
            ninjectKernel.Bind<ICatalogService<Motorcycle>>().To<CatalogService<Motorcycle>>();
            ninjectKernel.Bind<ICatalogService<Scooter>>().To<CatalogService<Scooter>>();

            ninjectKernel.Bind<IPostsService<SecondHand>>().To<PostsService<SecondHand>>();
            ninjectKernel.Bind<IPostsService<Car>>().To<PostsService<Car>>();

            ninjectKernel.Bind<IRepository<Car, int>>().To<EfRepositoryBase<Car>>();
            ninjectKernel.Bind<IRepository<Jeep, int>>().To<EfRepositoryBase<Jeep>>();
            ninjectKernel.Bind<IRepository<Commercial, int>>().To<EfRepositoryBase<Commercial>>();
            ninjectKernel.Bind<IRepository<Trucks, int>>().To<EfRepositoryBase<Trucks>>();
            ninjectKernel.Bind<IRepository<Motorcycle, int>>().To<EfRepositoryBase<Motorcycle>>();
            ninjectKernel.Bind<IRepository<VehicleManufacturer, int>>().To<EfRepositoryBase<VehicleManufacturer>>();
            ninjectKernel.Bind<IRepository<VehicleModel, int>>().To<EfRepositoryBase<VehicleModel>>();
            ninjectKernel.Bind<IRepository<Category, int>>().To<EfRepositoryBase<Category>>();
            ninjectKernel.Bind<IRepository<City, int>>().To<EfRepositoryBase<City>>();
            ninjectKernel.Bind<IRepository<PicOfPost, int>>().To<EfRepositoryBase<PicOfPost>>();
            ninjectKernel.Bind<IRepository<Region, int>>().To<EfRepositoryBase<Region>>();
            ninjectKernel.Bind<IRepository<Seller, int>>().To<EfRepositoryBase<Seller>>();
            ninjectKernel.Bind<IRepository<Scooter, int>>().To<EfRepositoryBase<Scooter>>();
            ninjectKernel.Bind<IRepository<SecondHand, int>>().To<EfRepositoryBase<SecondHand>>();
            ninjectKernel.Bind<IRepository<UserBase, int>>().To<EfRepositoryBase<UserBase>>();
            ninjectKernel.Bind<IRepository<UsersGroupBase, int>>().To<EfRepositoryBase<UsersGroupBase>>();

            ninjectKernel.Bind<ICurrentSessionUser>().To<AspNetCustomCurrentSessionUser>();
            ninjectKernel.Bind<ISecurityService>().To<SecurityService>();
            ninjectKernel.Bind<IAccountDTL>().To<UserAccountService>();




        }
    }
}