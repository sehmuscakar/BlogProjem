using Microsoft.AspNetCore.Mvc.Rendering;
using Sehmus.EntitiesLayer.Concrete;
using Sehmus.EntitiesLayer.Dtos.AdminDtos;

namespace Sehmus.BusinessLayer.Abstract
{
    public interface IHeroService
    {
        List<HeroListDto> GetHeroListManager();
        List<SelectListItem> UserListManager();
        List<Hero> GetList();
        void Add(Hero hero);
        void Update(Hero hero);
        void Remove(Hero hero);
        Hero GetByID(int id);
    }
}
