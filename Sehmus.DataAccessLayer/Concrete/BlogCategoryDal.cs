using Microsoft.AspNetCore.Mvc.Rendering;
using Sehmus.CoreLayer.DataAccess.EntityFramework;
using Sehmus.DataAccessLayer.Abstract;
using Sehmus.DataAccessLayer.Concrete.Context;
using Sehmus.EntitiesLayer.Concrete;
using Sehmus.EntitiesLayer.Dtos.AdminDtos;

namespace Sehmus.DataAccessLayer.Concrete
{
    public class BlogCategoryDal : EfEntityRepositoryBase<BlogCategory>, IBlogCategoryDal
    {
        public BlogCategoryDal(ProjeContextDb context) : base(context)
        {
            Context = context;
        }

        public ProjeContextDb Context { get; }

        public List<BlogCategoryListDto> GetBlogCategoryListDal()
        {
            var a = Context.BlogCategories.Select(blogCatgeory => new BlogCategoryListDto()
            {
                Id = blogCatgeory.Id,
                Name= blogCatgeory.Name,
                Link= blogCatgeory.Link,
                LastUpdatedAt = blogCatgeory.LastUpdatedAt,
                CreatedFullName = blogCatgeory.AppUser.Name,

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
