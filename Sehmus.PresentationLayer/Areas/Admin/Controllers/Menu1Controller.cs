using Microsoft.AspNetCore.Mvc;
using Sehmus.BusinessLayer.Abstract;
using Sehmus.EntitiesLayer.Concrete;

namespace Sehmus.PresentationLayer.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]/[action]")]
    [ResponseCache(Location = ResponseCacheLocation.None, NoStore = true)]
    public class Menu1Controller : Controller
    {
        private readonly IMenu1Service _menu1Service;

        public Menu1Controller(IMenu1Service menu1Service)
        {
            _menu1Service = menu1Service;
        }

        // GET: Menu1Controller
        public ActionResult Index()
        {
         var list=_menu1Service.GetMenu1ListManager();
            return View(list);
        }

        // GET: Menu1Controller/Create
        public ActionResult Create()
        {
            ViewBag.dgr = _menu1Service.UserListManager();
            return View();
        }

        // POST: Menu1Controller/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Menu1 menu1)
        {
            try
            {
                _menu1Service.Add(menu1);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Menu1Controller/Edit/5
        public ActionResult Edit(int id)
        {
            var veriGetir = _menu1Service.GetByID(id);
            return View(veriGetir);
        }

        // POST: Menu1Controller/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Menu1 menu1)
        {
            try
            {
                _menu1Service.Update(menu1);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Menu1Controller/Delete/5
        public ActionResult Delete(int id)
        {
            var veriGetir = _menu1Service.GetByID(id);
            return View(veriGetir);
        }

        // POST: Menu1Controller/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id,Menu1 menu1)
        {
            try
            {
                _menu1Service.Remove(menu1);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
