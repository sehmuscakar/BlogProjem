using Autofac;
using Sehmus.BusinessLayer.Abstract;
using Sehmus.BusinessLayer.Concrete;
using Sehmus.DataAccessLayer.Abstract;
using Sehmus.DataAccessLayer.Concrete;
namespace Sehmus.BusinessLayer.DependencyResolvers.Autofac // bunun için Autofac kütüphanesini yuklemen lazım
{
    public class AutofacBusinessModule:Module
    {
        protected override void Load(ContainerBuilder builder) // overide load yaz otomatik doldurulur.
        {
            builder.RegisterType<HeroManager>().As<IHeroService>();//ben Interfaceyi ayzdığımda sen ilgili classı algıla anlamında
            builder.RegisterType<HeroDal>().As<IHeroDal>();

            builder.RegisterType<Menu1Manager>().As<IMenu1Service>();
            builder.RegisterType<Menu1Dal>().As<IMenu1Dal>();

            builder.RegisterType<Menu2Manager>().As<IMenu2Service>();
            builder.RegisterType<Menu2Dal>().As<IMenu2Dal>();

            builder.RegisterType<SubMenuManager>().As<ISubMenuService>();
            builder.RegisterType<SubMenuDal>().As<ISubMenuDal>();

            builder.RegisterType<InformationManager>().As<IInformationService>();
            builder.RegisterType<InformationDal>().As<IInformationDal>();

            builder.RegisterType<SkillManager>().As<ISkillService>();
            builder.RegisterType<SkillDal>().As<ISkillDal>();

            builder.RegisterType<ServiceManager>().As<IServiceService>();
            builder.RegisterType<ServiceDal>().As<IServiceDal>();

            builder.RegisterType<CounterManager>().As<ICounterService>();
            builder.RegisterType<CounterDal>().As<ICounterDal>();

            builder.RegisterType<PortfolioManager>().As<IPortfolioService>();
            builder.RegisterType<PortfolioDal>().As<IPortfolioDal>();

            builder.RegisterType<TestimonialManager>().As<ITestimonialService>();
            builder.RegisterType<TestimonialDal>().As<ITestimonialDal>();

            builder.RegisterType<BlogManager>().As<IBlogService>();
            builder.RegisterType<BlogDal>().As<IBlogDal>();

            builder.RegisterType<BlogCategoryManager>().As<IBlogCategoryService>();
            builder.RegisterType<BlogCategoryDal>().As<IBlogCategoryDal>();

            builder.RegisterType<BlogSliderManager>().As<IBlogSliderService>();
            builder.RegisterType<BlogSliderDal>().As<IBlogSliderDal>();

            builder.RegisterType<ContactManager>().As<IContactService>();
            builder.RegisterType<ContactDal>().As<IContactDal>();

            builder.RegisterType<ContactPostManager>().As<IContactPostService>();
            builder.RegisterType<ContactPostDal>().As<IContactPostDal>();
        }

    }
}
