using Microsoft.AspNetCore.Mvc;
using Sehmus.BusinessLayer.Abstract;

namespace Sehmus.PresentationLayer.ViewComponents
{
    public class BlogCategoryViewComponent:ViewComponent
    {
        private readonly IBlogCategoryService _blogCategoryService;
        public BlogCategoryViewComponent(IBlogCategoryService blogCategoryService)
        {
            _blogCategoryService = blogCategoryService;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var listele = _blogCategoryService.GetList();
            return View(listele);
        }
    }
}
