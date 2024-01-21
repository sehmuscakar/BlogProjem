using Microsoft.AspNetCore.Mvc.Rendering;
using Sehmus.CoreLayer.DataAccess.EntityFramework;
using Sehmus.DataAccessLayer.Abstract;
using Sehmus.DataAccessLayer.Concrete.Context;
using Sehmus.EntitiesLayer.Concrete;
using Sehmus.EntitiesLayer.Dtos;
using Sehmus.EntitiesLayer.Dtos.AdminDtos;

namespace Sehmus.DataAccessLayer.Concrete
{
    public class BlogDal : EfEntityRepositoryBase<Blog>, IBlogDal
    {
        public BlogDal(ProjeContextDb context) : base(context)
        {
            Context = context;
        }

        public ProjeContextDb Context { get; }

        public BlogDto BlogGetById(int id)
        {
            var blog = Context.Blogs
                       .Where(b => b.Id == id)
                       .Select(blog => new BlogDto
                       {
                           Title = blog.Title,
                           BlogImage = blog.BlogImage,
                           BlogCategoryName = blog.BlogCategory.Name,
                           Description = blog.Description,
                           DescriptionDetails=blog.DescriptionDetails,                       
                           CreatedDate = blog.CreatedDate
                       })
                       .FirstOrDefault();

            return blog;
        }

        public List<BlogListDto> GetBlogListDal()
        {
            var a = Context.Blogs.Select(blog => new BlogListDto()
            {
                Id = blog.Id,
                Title = blog.Title,
                BlogImage= blog.BlogImage,
                BlogCategoryName=blog.BlogCategory.Name,
                Description = blog.Description,
                DescriptionDetails=blog.DescriptionDetails,
                CreatedDate=blog.CreatedDate,
                LastUpdatedAt = blog.LastUpdatedAt,
                CreatedFullName = blog.AppUser.Name,

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

        public List<SelectListItem> BlogCategoryListDal()
        {
            var deger = (from x in Context.BlogCategories.ToList()
                         select new SelectListItem
                         {
                             Text = x.Name,
                             Value = x.Id.ToString()
                         }).ToList();
            return deger;
        }
    }
}
