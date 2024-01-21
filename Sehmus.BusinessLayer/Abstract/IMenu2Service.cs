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
    public interface IMenu2Service
    {

        List<Menu2ListDto> GetMenu2ListManager();
        List<SelectListItem> UserListManager();
        List<Menu2> GetList();
        void Add(Menu2 menu2);
        void Update(Menu2 menu2);
        void Remove(Menu2 menu2);
        Menu2 GetByID(int id);
    }
}
