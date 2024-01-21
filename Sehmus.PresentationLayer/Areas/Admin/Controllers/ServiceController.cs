using Microsoft.AspNetCore.Mvc;
using Sehmus.BusinessLayer.Abstract;
using Sehmus.EntitiesLayer.Concrete;

namespace Sehmus.PresentationLayer.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]/[action]")]
    public class ServiceController : Controller
    {
        private readonly IServiceService _serviceService;

        public ServiceController(IServiceService serviceService)
        {
            _serviceService = serviceService;
        }

        public ActionResult Index()
        {
            var list = _serviceService.GetServiceListManager();
            return View(list);
        }

        // GET: ServiceController/Create
        public ActionResult Create()
        {
            ViewBag.dgr = _serviceService.UserListManager();
            return View();
        }

        // POST: ServiceController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Service service)
        {
            try
            {
                _serviceService.Add(service);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ServiceController/Edit/5
        public ActionResult Edit(int id)
        {
            var resultDataId = _serviceService.GetByID(id);
            return View(resultDataId);
        }

        // POST: ServiceController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Service service)
        {
            try
            {
                _serviceService.Update(service);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ServiceController/Delete/5
        public ActionResult Delete(int id)
        {
            var resultDataId = _serviceService.GetByID(id);
            return View(resultDataId);
        }

        // POST: ServiceController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Service service)
        {
            try
            {
                _serviceService.Remove(service);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
