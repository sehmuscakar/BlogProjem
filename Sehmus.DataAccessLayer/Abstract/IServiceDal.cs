using Microsoft.AspNetCore.Mvc.Rendering;
using Sehmus.CoreLayer.DataAccess;
using Sehmus.EntitiesLayer.Concrete;
using Sehmus.EntitiesLayer.Dtos.AdminDtos;

namespace Sehmus.DataAccessLayer.Abstract
{
    public interface IServiceDal:IEntityRepository<Service>
    {
        List<SelectListItem> UserListDal();
        List<ServiceListDto> GetServiceListDal();
    }
}
