using Microsoft.AspNetCore.Mvc.Rendering;
using Sehmus.CoreLayer.DataAccess.EntityFramework;
using Sehmus.DataAccessLayer.Abstract;
using Sehmus.DataAccessLayer.Concrete.Context;
using Sehmus.EntitiesLayer.Concrete;
using Sehmus.EntitiesLayer.Dtos.AdminDtos;

namespace Sehmus.DataAccessLayer.Concrete
{
    public class SkillDal : EfEntityRepositoryBase<Skill>, ISkillDal
    {
        public SkillDal(ProjeContextDb context) : base(context)
        {
            Context = context;
        }

        public ProjeContextDb Context { get; }

        public List<SkillListDto> GetSkillListDal()
        {
            var a = Context.Skills.Select(skill => new SkillListDto()
            {
                Id = skill.Id,
                Title = skill.Title,
                Number=skill.Number,
                LastUpdatedAt = skill.LastUpdatedAt,
                CreatedFullName = skill.AppUser.Name,

            });
            return a.ToList();
        }

        public List<SelectListItem> UserListDal()
        {
            var deger = (from x in Context.Users.ToList()
                         select new SelectListItem
                         {
                             Text = x.Name,
                             Value = x.Id.ToString()
                         }).ToList();
            return deger;
        }
    }
}
