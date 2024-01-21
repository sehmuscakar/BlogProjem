using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Sehmus.BusinessLayer.Abstract;

namespace Sehmus.PresentationLayer.ViewComponents
{
    public class ServiceViewComponent:ViewComponent
    {
        private readonly IServiceService _serviceService;

        public ServiceViewComponent(IServiceService serviceService)
        {
            _serviceService = serviceService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var listele = _serviceService.GetList();
            return View(listele);
        }
    }
}
