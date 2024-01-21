using Microsoft.AspNetCore.Mvc;
using Sehmus.BusinessLayer.Abstract;
using Sehmus.EntitiesLayer.Concrete;

namespace Sehmus.PresentationLayer.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]/[action]")]
    public class CounterController : Controller
    {
        private readonly ICounterService _counterService;

        public CounterController(ICounterService counterService)
        {
            _counterService = counterService;
        }

        // GET: CounterController
        public ActionResult Index()
        {
            var resultList = _counterService.GetCounterListManager();
            return View(resultList);
        }

        // GET: CounterController/Create
        public ActionResult Create()
        {
            ViewBag.dgr = _counterService.UserListManager();
            return View();
        }

        // POST: CounterController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Counter counter)
        {
            try
            {
                _counterService.Add(counter);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CounterController/Edit/5
        public ActionResult Edit(int id)
        {
            var resultDataId = _counterService.GetByID(id);
            return View(resultDataId);
        }

        // POST: CounterController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Counter counter)
        {
            try
            {
                _counterService.Update(counter);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CounterController/Delete/5
        public ActionResult Delete(int id)
        {
            var resultDataId = _counterService.GetByID(id);
            return View(resultDataId);
        }

        // POST: CounterController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Counter counter)
        {
            try
            {
                _counterService.Remove(counter);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
