using Microsoft.AspNetCore.Mvc.Rendering;
using Sehmus.EntitiesLayer.Concrete;
using Sehmus.EntitiesLayer.Dtos.AdminDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sehmus.BusinessLayer.Abstract
{
   public interface ISubMenuService
    {
        List<SubMenuListDto> GetSubMenuListManager();
        List<SelectListItem> UserListManager();
        List<SelectListItem> Menu2ListManager();
        List<SubMenu> GetList();
        void Add(SubMenu subMenu);
        void Update(SubMenu subMenu);
        void Remove(SubMenu subMenu);
        SubMenu GetByID(int id);
    }
}
