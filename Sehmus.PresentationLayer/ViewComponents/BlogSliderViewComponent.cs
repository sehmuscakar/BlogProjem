using Microsoft.AspNetCore.Mvc;
using Sehmus.BusinessLayer.Abstract;

namespace Sehmus.PresentationLayer.ViewComponents
{
    public class BlogSliderViewComponent:ViewComponent
    {
        private readonly IBlogSliderService _blogSliderService;

        public BlogSliderViewComponent(IBlogSliderService blogSliderService)
        {
            _blogSliderService = blogSliderService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var listele = _blogSliderService.GetList();
            return View(listele);
        }
    }
}
