using Microsoft.AspNetCore.Mvc.Rendering;
using Sehmus.CoreLayer.DataAccess;
using Sehmus.EntitiesLayer.Concrete;
using Sehmus.EntitiesLayer.Dtos.AdminDtos;

namespace Sehmus.DataAccessLayer.Abstract
{
    public interface IInformationDal:IEntityRepository<Information>
    {
        List<SelectListItem> UserListDal();
        List<InformationListDto> GetInformationListDal();
    }
}
