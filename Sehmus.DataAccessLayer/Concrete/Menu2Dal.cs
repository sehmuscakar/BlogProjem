using Microsoft.AspNetCore.Mvc.Rendering;
using Sehmus.CoreLayer.DataAccess.EntityFramework;
using Sehmus.DataAccessLayer.Abstract;
using Sehmus.DataAccessLayer.Concrete.Context;
using Sehmus.EntitiesLayer.Concrete;
using Sehmus.EntitiesLayer.Dtos.AdminDtos;

namespace Sehmus.DataAccessLayer.Concrete
{
    public class Menu2Dal : EfEntityRepositoryBase<Menu2>, IMenu2Dal
    {
        public Menu2Dal(ProjeContextDb context) : base(context)
        {
            Context = context;
        }

        public ProjeContextDb Context { get; }

        public List<Menu2ListDto> GetMenu2ListDal()
        {
            var a = Context.Menus2.Select(menu2 => new Menu2ListDto()
            {
                Id = menu2.Id,
                Name= menu2.Name,
                Link=menu2.Link,
                LastUpdatedAt = menu2.LastUpdatedAt,
                CreatedFullName = menu2.AppUser.Name,
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

// var menus=Context.Menus.Include(menu=>menu.SubMenus).ToList();
//return menus;