using Microsoft.AspNetCore.Mvc.Rendering;
using Sehmus.EntitiesLayer.Concrete;
using Sehmus.EntitiesLayer.Dtos.AdminDtos;

namespace Sehmus.BusinessLayer.Abstract
{
    public interface IBlogSliderService
    {
        List<BlogSliderListDto> GetBlogSliderListManager();
        List<SelectListItem> UserListManager();
        List<BlogSlider> GetList();
        void Add(BlogSlider blogSlider);
        void Update(BlogSlider blogSlider);
        void Remove(BlogSlider blogSlider);
        BlogSlider GetByID(int id);
    }
}
