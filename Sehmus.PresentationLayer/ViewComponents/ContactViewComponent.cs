using Microsoft.AspNetCore.Mvc;
using Sehmus.BusinessLayer.Abstract;

namespace Sehmus.PresentationLayer.ViewComponents
{
    public class ContactViewComponent:ViewComponent
    {
        private readonly IContactService _contactService;
        public ContactViewComponent(IContactService contactService)
        {
            _contactService = contactService;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var listele = _contactService.GetList();
            return View(listele);
        }
    }
}
