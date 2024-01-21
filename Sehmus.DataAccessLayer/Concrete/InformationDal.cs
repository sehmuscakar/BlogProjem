using Microsoft.AspNetCore.Mvc.Rendering;
using Sehmus.CoreLayer.DataAccess.EntityFramework;
using Sehmus.DataAccessLayer.Abstract;
using Sehmus.DataAccessLayer.Concrete.Context;
using Sehmus.EntitiesLayer.Concrete;
using Sehmus.EntitiesLayer.Dtos.AdminDtos;

namespace Sehmus.DataAccessLayer.Concrete
{
    public class InformationDal : EfEntityRepositoryBase<Information>, IInformationDal
    {
        public InformationDal(ProjeContextDb context) : base(context)
        {
            Context = context;
        }

        public ProjeContextDb Context { get; }

        public List<InformationListDto> GetInformationListDal()
        {
            var a = Context.Informations.Select(ınformation => new InformationListDto()
            {
                Id = ınformation.Id,
                ImageUrl=ınformation.ImageUrl,
                Degree=ınformation.Degree,
                About=ınformation.About,
                LastUpdatedAt = ınformation.LastUpdatedAt,
                CreatedFullName = ınformation.AppUser.Name,

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
