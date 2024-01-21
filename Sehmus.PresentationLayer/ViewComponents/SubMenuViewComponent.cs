using Microsoft.AspNetCore.Mvc;
using Sehmus.BusinessLayer.Abstract;

namespace Sehmus.PresentationLayer.ViewComponents
{
    public class SubMenuViewComponent:ViewComponent
    {

        private readonly ISubMenuService _subMenuService;

        public SubMenuViewComponent(ISubMenuService subMenuService)
        {
            _subMenuService = subMenuService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var listele = _subMenuService.GetList();
            return View(listele);
        }
    }
}
