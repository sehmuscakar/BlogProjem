using Microsoft.AspNetCore.Mvc;
using Sehmus.BusinessLayer.Abstract;

namespace Sehmus.PresentationLayer.ViewComponents
{
    public class TestimonialViewComponent:ViewComponent
    {
        private readonly ITestimonialService _testimonialService;

        public TestimonialViewComponent(ITestimonialService testimonialService)
        {
            _testimonialService = testimonialService;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var listele = _testimonialService.GetList();
            return View(listele);
        }
    }
}
