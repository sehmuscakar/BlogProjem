using Microsoft.AspNetCore.Mvc;
using Sehmus.BusinessLayer.Abstract;

namespace Sehmus.PresentationLayer.ViewComponents
{
    public class SkillViewComponent:ViewComponent
    {
        private readonly ISkillService _skillService;

        public SkillViewComponent(ISkillService skillService)
        {
            _skillService = skillService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var listele = _skillService.GetList();
            return View(listele);
        }
    }
}
