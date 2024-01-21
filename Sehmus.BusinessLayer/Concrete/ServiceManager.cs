using Microsoft.AspNetCore.Mvc.Rendering;
using Sehmus.BusinessLayer.Abstract;
using Sehmus.DataAccessLayer.Abstract;
using Sehmus.EntitiesLayer.Concrete;
using Sehmus.EntitiesLayer.Dtos.AdminDtos;

namespace Sehmus.BusinessLayer.Concrete
{
    public class ServiceManager : IServiceService
    {

        private readonly IServiceDal _serviceDal;

        public ServiceManager(IServiceDal serviceDal)
        {
            _serviceDal = serviceDal;
        }

        public void Add(Service service)
        {
            _serviceDal.Add(service);
        }

        public Service GetByID(int id)
        {
            var result = _serviceDal.Get(p => p.Id == id);
            return result;
        }

        public List<Service> GetList()
        {
            return _serviceDal.GetAll();
        }

        public List<ServiceListDto> GetServiceListManager()
        {
            return _serviceDal.GetServiceListDal();
        }

        public void Remove(Service service)
        {
            _serviceDal.Delete(service);
        }

        public void Update(Service service)
        {
            service.LastUpdatedAt = DateTime.Now;
            _serviceDal.Update(service);
        }

        public List<SelectListItem> UserListManager()
        {
            return _serviceDal.UserListDal();
        }
    }
}
