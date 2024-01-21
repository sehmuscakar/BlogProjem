using Microsoft.AspNetCore.Mvc;
using Sehmus.BusinessLayer.Abstract;

namespace Sehmus.PresentationLayer.ViewComponents
{
    public class Menu2ViewComponent:ViewComponent
    {

        private readonly IMenu2Service _menu2Service;

        public Menu2ViewComponent(IMenu2Service menu2Service)
        {
            _menu2Service = menu2Service;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var listele = _menu2Service.GetList();
            return View(listele);
        }
    }
}
