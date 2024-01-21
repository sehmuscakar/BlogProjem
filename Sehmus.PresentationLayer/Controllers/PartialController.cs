using Microsoft.AspNetCore.Mvc;

namespace Sehmus.PresentationLayer.Controllers
{
    public class PartialController : Controller
    {
        public PartialViewResult HeadPartial()
        {
            return PartialView();
        }

        public PartialViewResult HeaderPartial()
        {
            return PartialView();
        }

        public PartialViewResult ScriptPartial()
        {
            return PartialView();
        }
    }
}
