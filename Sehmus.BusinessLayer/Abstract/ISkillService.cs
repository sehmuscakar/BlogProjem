using Microsoft.AspNetCore.Mvc.Rendering;
using Sehmus.EntitiesLayer.Concrete;
using Sehmus.EntitiesLayer.Dtos.AdminDtos;

namespace Sehmus.BusinessLayer.Abstract
{
    public interface ISkillService
    {
        List<SkillListDto> GetSkillListManager();
        List<SelectListItem> UserListManager();
        List<Skill> GetList();
        void Add(Skill skill);
        void Update(Skill skill);
        void Remove(Skill skill);
        Skill GetByID(int id);
    }
}
