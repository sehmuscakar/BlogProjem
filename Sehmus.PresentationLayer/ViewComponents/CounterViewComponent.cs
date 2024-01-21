using Microsoft.AspNetCore.Mvc;
using Sehmus.BusinessLayer.Abstract;

namespace Sehmus.PresentationLayer.ViewComponents
{
    public class CounterViewComponent:ViewComponent
    {
        private readonly ICounterService _counterService;

        public CounterViewComponent(ICounterService counterService)
        {
            _counterService = counterService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var listele = _counterService.GetList();
            return View(listele);
        }
    }
}
