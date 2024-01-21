using Microsoft.AspNetCore.Mvc.Rendering;
using Sehmus.CoreLayer.DataAccess;
using Sehmus.EntitiesLayer.Concrete;
using Sehmus.EntitiesLayer.Dtos.AdminDtos;

namespace Sehmus.DataAccessLayer.Abstract
{
    public interface ITestimonialDal:IEntityRepository<Testimonial>
    {
        List<SelectListItem> UserListDal();
        List<TestimonialListDto> GetTestimonialListDal();
    }
}
