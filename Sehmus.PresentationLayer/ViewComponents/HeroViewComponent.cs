using Microsoft.AspNetCore.Mvc;
using Sehmus.BusinessLayer.Abstract;

namespace Sehmus.PresentationLayer.ViewComponents
{
    public class HeroViewComponent:ViewComponent
    {
        private readonly IHeroService _heroService;

        public HeroViewComponent(IHeroService heroService)
        {
            _heroService = heroService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var listele = _heroService.GetList();
            return View(listele);
        }
    }
}
