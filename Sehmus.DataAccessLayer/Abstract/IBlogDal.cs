using Microsoft.AspNetCore.Mvc.Rendering;
using Sehmus.CoreLayer.DataAccess;
using Sehmus.EntitiesLayer.Concrete;
using Sehmus.EntitiesLayer.Dtos;
using Sehmus.EntitiesLayer.Dtos.AdminDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sehmus.DataAccessLayer.Abstract
{
    public interface IBlogDal:IEntityRepository<Blog>
    {
        BlogDto BlogGetById(int id);
        List<SelectListItem> UserListDal();
        List<BlogListDto> GetBlogListDal();

        List<SelectListItem> BlogCategoryListDal();
    }
}
