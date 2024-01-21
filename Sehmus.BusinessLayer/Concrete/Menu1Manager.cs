using Microsoft.AspNetCore.Mvc.Rendering;
using Sehmus.BusinessLayer.Abstract;
using Sehmus.DataAccessLayer.Abstract;
using Sehmus.EntitiesLayer.Concrete;
using Sehmus.EntitiesLayer.Dtos.AdminDtos;

namespace Sehmus.BusinessLayer.Concrete
{
    public class Menu1Manager : IMenu1Service
    {
        private readonly IMenu1Dal _menu1Dal;

        public Menu1Manager(IMenu1Dal menu1Dal)
        {
            _menu1Dal = menu1Dal;
        }

        public void Add(Menu1 menu1)
        {
            _menu1Dal.Add(menu1);
        }

        public Menu1 GetByID(int id)
        {
            var result = _menu1Dal.Get(p => p.Id == id);
            return result;
        }

        public List<Menu1> GetList()
        {
            return _menu1Dal.GetAll();
        }

        public List<Menu1ListDto> GetMenu1ListManager()
        {
            return _menu1Dal.GetMenu1ListDal();
        }

        public void Remove(Menu1 menu1)
        {
            _menu1Dal.Delete(menu1);
        }

        public void Update(Menu1 menu1)
        {
            menu1.LastUpdatedAt= DateTime.Now;
            _menu1Dal.Update(menu1);
        }

        public List<SelectListItem> UserListManager()
        {
            return _menu1Dal.UserListDal();
        }
    }
}
