using Microsoft.AspNetCore.Mvc;
using Sehmus.BusinessLayer.Abstract;

namespace Sehmus.PresentationLayer.ViewComponents
{
    public class InformationViewComponent:ViewComponent
    {
        private readonly IInformationService _informationService;

        public InformationViewComponent(IInformationService informationService)
        {
            _informationService = informationService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var listele = _informationService.GetList();
            return View(listele);
        }
    }
}
