using Microsoft.AspNetCore.Mvc.Rendering;
using Sehmus.BusinessLayer.Abstract;
using Sehmus.DataAccessLayer.Abstract;
using Sehmus.EntitiesLayer.Concrete;
using Sehmus.EntitiesLayer.Dtos.AdminDtos;

namespace Sehmus.BusinessLayer.Concrete
{
    public class SkillManager : ISkillService
    {
        private readonly ISkillDal _skillDal;

        public SkillManager(ISkillDal skillDal)
        {
            _skillDal = skillDal;
        }

        public void Add(Skill skill)
        {
            _skillDal.Add(skill);
        }

        public Skill GetByID(int id)
        {
            var veriGetir=_skillDal.Get(p=>p.Id== id);
        return veriGetir;
        }

        public List<Skill> GetList()
        {
            return _skillDal.GetAll();
        }

        public List<SkillListDto> GetSkillListManager()
        {
            return _skillDal.GetSkillListDal();
        }

        public void Remove(Skill skill)
        {
            _skillDal.Delete(skill);
        }

        public void Update(Skill skill)
        {
            skill.LastUpdatedAt= DateTime.Now;
            _skillDal.Update(skill);
        }

        public List<SelectListItem> UserListManager()
        {
            return _skillDal.UserListDal();
        }
    }
}
