using Microsoft.AspNetCore.Mvc.Rendering;
using Sehmus.CoreLayer.DataAccess;
using Sehmus.EntitiesLayer.Concrete;
using Sehmus.EntitiesLayer.Dtos.AdminDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sehmus.DataAccessLayer.Abstract
{
   public interface ISkillDal:IEntityRepository<Skill>
    {
        List<SelectListItem> UserListDal();
        List<SkillListDto> GetSkillListDal();
    }
}
