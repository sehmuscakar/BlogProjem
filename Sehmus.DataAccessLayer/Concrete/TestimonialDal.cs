using Microsoft.AspNetCore.Mvc.Rendering;
using Sehmus.CoreLayer.DataAccess.EntityFramework;
using Sehmus.DataAccessLayer.Abstract;
using Sehmus.DataAccessLayer.Concrete.Context;
using Sehmus.EntitiesLayer.Concrete;
using Sehmus.EntitiesLayer.Dtos.AdminDtos;

namespace Sehmus.DataAccessLayer.Concrete
{
    public class TestimonialDal : EfEntityRepositoryBase<Testimonial>, ITestimonialDal
    {
        public TestimonialDal(ProjeContextDb context) : base(context)
        {
            Context = context;
        }
        public ProjeContextDb Context { get; }

        public List<TestimonialListDto> GetTestimonialListDal()
        {
            var a = Context.Testimonials.Select(testimonial => new TestimonialListDto()
            {
                Id = testimonial.Id,
                ImageUrl= testimonial.ImageUrl,
                Title = testimonial.Title,
                Description= testimonial.Description,
                LastUpdatedAt = testimonial.LastUpdatedAt,
                CreatedFullName = testimonial.AppUser.Name,
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
