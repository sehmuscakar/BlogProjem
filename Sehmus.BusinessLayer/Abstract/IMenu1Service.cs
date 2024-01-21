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
    public interface IMenu1Service
    {
        List<Menu1ListDto> GetMenu1ListManager();
        List<SelectListItem> UserListManager();
        List<Menu1> GetList();
        void Add(Menu1 menu1);
        void Update(Menu1 menu1);
        void Remove(Menu1 menu1);
        Menu1 GetByID(int id);
    }
}
