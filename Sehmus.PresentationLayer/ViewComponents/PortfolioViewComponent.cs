using Microsoft.AspNetCore.Mvc;
using Sehmus.BusinessLayer.Abstract;

namespace Sehmus.PresentationLayer.ViewComponents
{
    public class PortfolioViewComponent:ViewComponent
    {

        private readonly IPortfolioService _portfolioService;
        public PortfolioViewComponent(IPortfolioService portfolioService)
        {
            _portfolioService = portfolioService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var listele = _portfolioService.GetList();
            return View(listele);
        }
    }
}
