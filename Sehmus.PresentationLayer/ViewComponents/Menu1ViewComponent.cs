using Microsoft.AspNetCore.Mvc;
using Sehmus.BusinessLayer.Abstract;

namespace Sehmus.PresentationLayer.ViewComponents
{
    public class Menu1ViewComponent:ViewComponent
    {

        private readonly IMenu1Service _menu1Service;

        public Menu1ViewComponent(IMenu1Service menu1Service)
        {
            _menu1Service = menu1Service;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var listele = _menu1Service.GetList();
            return View(listele);
        }
    }
}
