using Microsoft.AspNetCore.Mvc;
using Sehmus.BusinessLayer.Abstract;
using Sehmus.EntitiesLayer.Concrete;

namespace Sehmus.PresentationLayer.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]/[action]")]
    public class ContactPostController : Controller
    {
        private readonly IContactPostService _contactPostService;

        public ContactPostController(IContactPostService contactPostService)
        {
            _contactPostService = contactPostService;
        }

        // GET: ContactPostController
        public ActionResult Index()
        {
            var resultList = _contactPostService.GetList();
            return View(resultList);
        }

      

        // GET: ContactPostController/Delete/5
        public ActionResult Delete(int id)
        {
            var resultDataId = _contactPostService.GetByID(id);
            return View(resultDataId);
        }

        // POST: ContactPostController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, ContactPost contactPost)
        {
            try
            {
                _contactPostService.Remove(contactPost);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
