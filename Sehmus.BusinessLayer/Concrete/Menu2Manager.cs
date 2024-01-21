using Microsoft.AspNetCore.Mvc.Rendering;
using Sehmus.BusinessLayer.Abstract;
using Sehmus.DataAccessLayer.Abstract;
using Sehmus.EntitiesLayer.Concrete;
using Sehmus.EntitiesLayer.Dtos.AdminDtos;

namespace Sehmus.BusinessLayer.Concrete
{
    public class Menu2Manager : IMenu2Service
    {
        private readonly IMenu2Dal _menu2Dal;
        public Menu2Manager(IMenu2Dal menu2Dal)
        {
            _menu2Dal = menu2Dal;
        }
        public void Add(Menu2 menu2)
        {
            _menu2Dal.Add(menu2);
        }
        public Menu2 GetByID(int id)
        {
           var result=_menu2Dal.Get(p=>p.Id== id);
            return result;
        }
        public List<Menu2> GetList()
        {
            return _menu2Dal.GetAll();
        }

        public List<Menu2ListDto> GetMenu2ListManager()
        {
            return _menu2Dal.GetMenu2ListDal();
        }

        public void Remove(Menu2 menu2)
        {
            _menu2Dal.Delete(menu2);
        }
        public void Update(Menu2 menu2)
        {
            menu2.LastUpdatedAt= DateTime.Now;  
            _menu2Dal.Update(menu2);
        }

        public List<SelectListItem> UserListManager()
        {
            return _menu2Dal.UserListDal();
        }
    }
}
