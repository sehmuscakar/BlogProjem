using Microsoft.AspNetCore.Mvc.Rendering;
using Sehmus.CoreLayer.DataAccess.EntityFramework;
using Sehmus.DataAccessLayer.Abstract;
using Sehmus.DataAccessLayer.Concrete.Context;
using Sehmus.EntitiesLayer.Concrete;
using Sehmus.EntitiesLayer.Dtos.AdminDtos;

namespace Sehmus.DataAccessLayer.Concrete
{
    public class SubMenuDal : EfEntityRepositoryBase<SubMenu>, ISubMenuDal
    {
        public SubMenuDal(ProjeContextDb context) : base(context)
        {
            Context = context;
        }

        public ProjeContextDb Context { get; }

        public List<SubMenuListDto> GetSubMenuListDal()
        {
            var a = Context.SubMenus.Select(subMenu => new SubMenuListDto()
            {
                Id = subMenu.Id,
                Name = subMenu.Name,
                Link = subMenu.Link,
                Menu2Name = subMenu.Menu2.Name,
                LastUpdatedAt = subMenu.LastUpdatedAt,
                CreatedFullName = subMenu.AppUser.Name,

            });
            return a.ToList();
        }

        public List<SelectListItem> Menu2ListDal()
        {
            var deger = (from x in Context.Menus2.ToList()
                         select new SelectListItem
                         {
                             Text = x.Name,
                             Value = x.Id.ToString()
                         }).ToList();
            return deger;
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
