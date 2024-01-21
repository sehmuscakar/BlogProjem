using Microsoft.AspNetCore.Mvc.Rendering;
using Sehmus.BusinessLayer.Abstract;
using Sehmus.DataAccessLayer.Abstract;
using Sehmus.EntitiesLayer.Concrete;
using Sehmus.EntitiesLayer.Dtos.AdminDtos;

namespace Sehmus.BusinessLayer.Concrete
{
    public class TestimonialManager : ITestimonialService
    {
        private readonly ITestimonialDal _testimonialDal;

        public TestimonialManager(ITestimonialDal testimonialDal)
        {
            _testimonialDal = testimonialDal;
        }

        public void Add(Testimonial testimonial)
        {
           _testimonialDal.Add(testimonial);
        }

        public Testimonial GetByID(int id)
        {
            var result = _testimonialDal.Get(p => p.Id == id);
            return result;
        }

        public List<Testimonial> GetList()
        {
            return _testimonialDal.GetAll();
        }

        public List<TestimonialListDto> GetTestimonialListManager()
        {
            return _testimonialDal.GetTestimonialListDal();
        }
        public void Remove(Testimonial testimonial)
        {
            _testimonialDal.Delete(testimonial);
        }
        public void Update(Testimonial testimonial)
        {
            testimonial.LastUpdatedAt= DateTime.Now;
            _testimonialDal.Update(testimonial);
        }
        public List<SelectListItem> UserListManager()
        {
            return _testimonialDal.UserListDal();
        }
    }
}
