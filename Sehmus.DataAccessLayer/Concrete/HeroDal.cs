using Microsoft.AspNetCore.Mvc.Rendering;
using Sehmus.CoreLayer.DataAccess.EntityFramework;
using Sehmus.DataAccessLayer.Abstract;
using Sehmus.DataAccessLayer.Concrete.Context;
using Sehmus.EntitiesLayer.Concrete;
using Sehmus.EntitiesLayer.Dtos.AdminDtos;

namespace Sehmus.DataAccessLayer.Concrete
{
    public class HeroDal : EfEntityRepositoryBase<Hero>, IHeroDal
    {
        public HeroDal(ProjeContextDb context) : base(context)
        {
            Context = context;
        }
        public ProjeContextDb Context { get; }

        public List<HeroListDto> GetHeroListDal()
        {
                var a = Context.Heroes.Select(hero => new HeroListDto()
                {
                    Id = hero.Id,
                    Title = hero.Title,
                    ExpertItem=hero.ExpertItem, 
                    ImageUrl = hero.ImageUrl,      
                    LastUpdatedAt = hero.LastUpdatedAt,
                    CreatedFullName = hero.AppUser.Name,
                
                });
                return a.ToList();
            }
        

        public List<SelectListItem> UserListDal()
        {
          var deger=  (from x in Context.Users.ToList()
             select new SelectListItem
             {
                 Text = x.Name,
                 Value = x.Id.ToString()
             }).ToList();
            return deger;             
        }
    }
}
