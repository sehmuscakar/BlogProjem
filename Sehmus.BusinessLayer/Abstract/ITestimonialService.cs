using Microsoft.AspNetCore.Mvc.Rendering;
using Sehmus.EntitiesLayer.Concrete;
using Sehmus.EntitiesLayer.Dtos.AdminDtos;

namespace Sehmus.BusinessLayer.Abstract
{
    public interface ITestimonialService
    {
        List<TestimonialListDto> GetTestimonialListManager();
        List<SelectListItem> UserListManager();
        List<Testimonial> GetList();
        void Add(Testimonial testimonial);
        void Update(Testimonial testimonial);
        void Remove(Testimonial testimonial);
        Testimonial GetByID(int id);
    }
}
