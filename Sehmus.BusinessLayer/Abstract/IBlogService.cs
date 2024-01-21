using Microsoft.AspNetCore.Mvc.Rendering;
using Sehmus.EntitiesLayer.Concrete;
using Sehmus.EntitiesLayer.Dtos;
using Sehmus.EntitiesLayer.Dtos.AdminDtos;

namespace Sehmus.BusinessLayer.Abstract
{
    public interface IBlogService
    {
        List<BlogListDto> GetBlogListManager();
        List<SelectListItem> UserListManager();
        List<SelectListItem> BlogCategoryListManager();
        BlogDto BlogGetByIdService(int id);
        List<Blog> GetList();
        void Add(Blog blog);
        void Update(Blog blog);
        void Remove(Blog blog);
        Blog GetByID(int id);
    }
}
