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
    public interface IMenu1Dal:IEntityRepository<Menu1>
    {
        List<SelectListItem> UserListDal();
        List<Menu1ListDto> GetMenu1ListDal();
    }
}
