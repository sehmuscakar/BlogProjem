using Microsoft.AspNetCore.Mvc.Rendering;
using Sehmus.EntitiesLayer.Concrete;
using Sehmus.EntitiesLayer.Dtos.AdminDtos;

namespace Sehmus.BusinessLayer.Abstract
{
    public interface IBlogCategoryService
    {
        List<BlogCategoryListDto> GetBlogCategoryListManager();
        List<SelectListItem> UserListManager();
        List<BlogCategory> GetList();
        void Add(BlogCategory blogCategory);
        void Update(BlogCategory blogCategory);
        void Remove(BlogCategory blogCategory);
        BlogCategory GetByID(int id);
    }
}
