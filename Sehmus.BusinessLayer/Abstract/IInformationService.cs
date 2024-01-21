using Microsoft.AspNetCore.Mvc.Rendering;
using Sehmus.EntitiesLayer.Concrete;
using Sehmus.EntitiesLayer.Dtos.AdminDtos;

namespace Sehmus.BusinessLayer.Abstract
{
    public interface IInformationService
    {
        List<InformationListDto> GetInformationListManager();
        List<SelectListItem> UserListManager();
        List<Information> GetList();
        void Add(Information ınformation);
        void Update(Information ınformation);
        void Remove(Information ınformation);
        Information GetByID(int id);
    }
}
