using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Sehmus.CoreLayer.DataAccess.EntityFramework;
using Sehmus.DataAccessLayer.Abstract;
using Sehmus.DataAccessLayer.Concrete.Context;
using Sehmus.EntitiesLayer.Concrete;
using Sehmus.EntitiesLayer.Dtos.AdminDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sehmus.DataAccessLayer.Concrete
{
    public class Menu1Dal : EfEntityRepositoryBase<Menu1>, IMenu1Dal
    {
        public Menu1Dal(ProjeContextDb context) : base(context)
        {
            Context = context;
        }

        public ProjeContextDb Context { get; }

        public List<Menu1ListDto> GetMenu1ListDal()
        {
            var a = Context.Menus1.Select(menu1 => new Menu1ListDto()
            {
                Id = menu1.Id,
                Name= menu1.Name,
                Link= menu1.Link,
                LastUpdatedAt = menu1.LastUpdatedAt,
                CreatedFullName = menu1.AppUser.Name,
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
