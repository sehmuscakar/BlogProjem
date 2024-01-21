using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Sehmus.BusinessLayer.Abstract;
using Sehmus.EntitiesLayer.Concrete;

namespace Sehmus.PresentationLayer.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]/[action]")]
    [ResponseCache(Location = ResponseCacheLocation.None, NoStore = true)]
    public class Menu2Controller : Controller
    {
        private readonly IMenu2Service _menu2Service;

        public Menu2Controller(IMenu2Service menu2Service)
        {
            _menu2Service = menu2Service;
        }

        // GET: Menu2Controller
        public ActionResult Index()
        {
            var list = _menu2Service.GetMenu2ListManager();
            return View(list);
        }


        // GET: Menu2Controller/Create
        public ActionResult Create()
        {
            ViewBag.dgr = _menu2Service.UserListManager();
            return View();
        }

        // POST: Menu2Controller/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Menu2 menu2)
        {
            try
            {
                _menu2Service.Add(menu2);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Menu2Controller/Edit/5
        public ActionResult Edit(int id)
        {
            var veriGetir = _menu2Service.GetByID(id);
            return View(veriGetir);
        }

        // POST: Menu2Controller/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Menu2 menu2)
        {
            try
            {
                _menu2Service.Update(menu2);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Menu2Controller/Delete/5
        public ActionResult Delete(int id)
        {
            var veriGetir = _menu2Service.GetByID(id);
            return View(veriGetir);
        }

        // POST: Menu2Controller/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Menu2 menu2)
        {
            try
            {
                _menu2Service.Remove(menu2);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
