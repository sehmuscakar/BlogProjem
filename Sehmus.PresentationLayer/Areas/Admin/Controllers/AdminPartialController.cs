using Microsoft.AspNetCore.Mvc;

namespace Sehmus.PresentationLayer.Areas.Admin.Controllers
{
    [Area("Admin")]
 //   [Route("Admin/[controller]/[action]")]
    public class AdminPartialController : Controller
    {
   
        public PartialViewResult AdminHeadPartial()
        {
            return PartialView();
        }

        public PartialViewResult AdminHeaderPartial()
        {
            return PartialView();
        }

        public PartialViewResult AdminScriptPartial()
        {
            return PartialView();
        }
    }
}
