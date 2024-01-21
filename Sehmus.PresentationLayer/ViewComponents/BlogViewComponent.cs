using Microsoft.AspNetCore.Mvc;
using Sehmus.BusinessLayer.Abstract;

namespace Sehmus.PresentationLayer.ViewComponents
{
    public class BlogViewComponent:ViewComponent
    {
        private readonly IBlogService _blogService;
        public BlogViewComponent(IBlogService blogService)
        {
            _blogService = blogService;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var listele = _blogService.GetBlogListManager();
            return View(listele);
        }
    }
}
