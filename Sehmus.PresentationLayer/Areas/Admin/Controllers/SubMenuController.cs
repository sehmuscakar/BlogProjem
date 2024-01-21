using Microsoft.AspNetCore.Mvc;
using Sehmus.BusinessLayer.Abstract;
using Sehmus.EntitiesLayer.Concrete;

namespace Sehmus.PresentationLayer.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]/[action]")]
    [ResponseCache(Location = ResponseCacheLocation.None, NoStore = true)]
    public class SubMenuController : Controller
    {
        private readonly ISubMenuService _subMenuService;

        public SubMenuController(ISubMenuService subMenuService)
        {
            _subMenuService = subMenuService;
        }
        public ActionResult Index()
        {
            var list = _subMenuService.GetSubMenuListManager();
            return View(list);
        }

        // GET: SubMenuController/Create
        public ActionResult Create()
        {
            ViewBag.dgr2 = _subMenuService.Menu2ListManager();
            ViewBag.dgr = _subMenuService.UserListManager();
            return View();
        }
        // POST: SubMenuController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(SubMenu subMenu)
        {
            try
            {
                _subMenuService.Add(subMenu);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
        // GET: SubMenuController/Edit/5
        public ActionResult Edit(int id)
        {
            var dataGetir = _subMenuService.GetByID(id);
            return View(dataGetir);
        }
        // POST: SubMenuController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, SubMenu subMenu)
        {
            try
            {
                _subMenuService.Update(subMenu);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
        // GET: SubMenuController/Delete/5
        public ActionResult Delete(int id)
        {
            var dataGetir = _subMenuService.GetByID(id);
            return View(dataGetir);
        }
        // POST: SubMenuController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, SubMenu subMenu)
        {
            try
            {
                _subMenuService.Remove(subMenu);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
