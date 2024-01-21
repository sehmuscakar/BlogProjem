using Microsoft.AspNetCore.Mvc.Rendering;
using Sehmus.BusinessLayer.Abstract;
using Sehmus.DataAccessLayer.Abstract;
using Sehmus.EntitiesLayer.Concrete;
using Sehmus.EntitiesLayer.Dtos.AdminDtos;

namespace Sehmus.BusinessLayer.Concrete
{
    public class HeroManager : IHeroService
    {
        private readonly IHeroDal _heroDal;
        public HeroManager(IHeroDal heroDal)
        {
            _heroDal = heroDal;
        }
        public void Add(Hero hero)
        {
          _heroDal.Add(hero);
        }
        public Hero GetByID(int id)
        {
            var result=_heroDal.Get(p => p.Id==id);
            return result;
        }
        public List<HeroListDto> GetHeroListManager()
        {
            return _heroDal.GetHeroListDal();
        }

        public List<Hero> GetList()
        {
            return _heroDal.GetAll();
        }
        public void Remove(Hero hero)
        {
          _heroDal.Delete(hero);
        }
        public void Update(Hero hero)
        {
            hero.LastUpdatedAt= DateTime.Now;
            _heroDal.Update(hero);
        }

        public List<SelectListItem> UserListManager()
        {
            return _heroDal.UserListDal();
        }
    }
}
