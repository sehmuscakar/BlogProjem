using Microsoft.AspNetCore.Mvc.Rendering;
using Sehmus.CoreLayer.DataAccess.EntityFramework;
using Sehmus.DataAccessLayer.Abstract;
using Sehmus.DataAccessLayer.Concrete.Context;
using Sehmus.EntitiesLayer.Concrete;
using Sehmus.EntitiesLayer.Dtos.AdminDtos;

namespace Sehmus.DataAccessLayer.Concrete
{
    public class ServiceDal : EfEntityRepositoryBase<Service>,IServiceDal
    {
        public ServiceDal(ProjeContextDb context) : base(context)
        {
            Context = context;
        }

        public ProjeContextDb Context { get; }

        public List<ServiceListDto> GetServiceListDal()
        {
            var a = Context.Services.Select(service => new ServiceListDto()
            {
                Id = service.Id,
                IconUrl= service.IconUrl,
                Title= service.Title,
                Description= service.Description,
                LastUpdatedAt = service.LastUpdatedAt,
                CreatedFullName = service.AppUser.Name,

            });
            return a.ToList();
        }

        public List<SelectListItem> UserListDal()
        {
            var deger = (from x in Context.Users.ToList()
                         select new SelectListItem
                         {
                             Text = x.Name,
                             Value = x.Id.ToString()
                         }).ToList();
            return deger;
        }
    }
}
