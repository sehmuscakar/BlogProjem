using Microsoft.AspNetCore.Mvc.Rendering;
using Sehmus.BusinessLayer.Abstract;
using Sehmus.DataAccessLayer.Abstract;
using Sehmus.EntitiesLayer.Concrete;
using Sehmus.EntitiesLayer.Dtos.AdminDtos;

namespace Sehmus.BusinessLayer.Concrete
{
    public class InformationManager : IInformationService
    {
        private readonly IInformationDal _ınformationDal;
        public InformationManager(IInformationDal ınformationDal)
        {
            _ınformationDal = ınformationDal;
        }
        public void Add(Information ınformation)
        {
            _ınformationDal.Add(ınformation);
        }
        public Information GetByID(int id)
        {
           var verigGetir=_ınformationDal.Get(p=>p.Id== id);
            return verigGetir;
        }
        public List<InformationListDto> GetInformationListManager()
        {
            return _ınformationDal.GetInformationListDal();
        }

        public List<Information> GetList()
        {
            return _ınformationDal.GetAll();
        }
        public void Remove(Information ınformation)
        {
            _ınformationDal.Delete(ınformation);
        }
        public void Update(Information ınformation)
        {
            ınformation.LastUpdatedAt= DateTime.Now;
            _ınformationDal.Update(ınformation);
        }

        public List<SelectListItem> UserListManager()
        {
            return _ınformationDal.UserListDal();
        }
    }
}
