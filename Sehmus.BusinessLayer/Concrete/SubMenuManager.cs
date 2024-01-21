using Microsoft.AspNetCore.Mvc.Rendering;
using Sehmus.BusinessLayer.Abstract;
using Sehmus.DataAccessLayer.Abstract;
using Sehmus.EntitiesLayer.Concrete;
using Sehmus.EntitiesLayer.Dtos.AdminDtos;

namespace Sehmus.BusinessLayer.Concrete
{
    public class SubMenuManager : ISubMenuService
    {
        private readonly ISubMenuDal _subMenuDal;
        public SubMenuManager(ISubMenuDal subMenuDal)
        {
            _subMenuDal = subMenuDal;
        }
        public void Add(SubMenu subMenu)
        {
            _subMenuDal.Add(subMenu);
        }
        public SubMenu GetByID(int id)
        {
           var dataGetir=_subMenuDal.Get(p=>p.Id == id);
            return dataGetir;
        }
        public List<SubMenu> GetList()
        {
            return _subMenuDal.GetAll();
        }

        public List<SubMenuListDto> GetSubMenuListManager()
        {
            return _subMenuDal.GetSubMenuListDal();
        }

        public List<SelectListItem> Menu2ListManager()
        {
            return _subMenuDal.Menu2ListDal();
        }

        public void Remove(SubMenu subMenu)
        {

            _subMenuDal.Delete(subMenu);
        }
        public void Update(SubMenu subMenu)
        {
            subMenu.LastUpdatedAt= DateTime.Now;
            _subMenuDal.Update(subMenu);
        }

        public List<SelectListItem> UserListManager()
        {
            return _subMenuDal.UserListDal();
        }
    }
}
