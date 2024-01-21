using Microsoft.AspNetCore.Mvc;
using Sehmus.BusinessLayer.Abstract;
using Sehmus.BusinessLayer.Concrete;
using Sehmus.EntitiesLayer.Concrete;

namespace Sehmus.PresentationLayer.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]/[action]")]
    public class InformationController : Controller
    {
        private readonly IInformationService _informationService;

        public InformationController(IInformationService informationService)
        {
            _informationService = informationService;
        }

        // GET: InformationController
        public ActionResult Index()
        {
            var resultList = _informationService.GetInformationListManager();
            return View(resultList);
        }


        // GET: InformationController/Create
        public ActionResult Create()
        {
            ViewBag.dgr = _informationService.UserListManager();
            return View();
        }

        // POST: InformationController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Information ınformation, IFormFile? ImageUrl)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    if (ImageUrl is not null)
                    {
                        string klasor1 = Directory.GetCurrentDirectory() + "/wwwroot/Img/" + ImageUrl.FileName;
                        using var stream1 = new FileStream(klasor1, FileMode.Create);
                        ImageUrl.CopyTo(stream1);
                       ınformation.ImageUrl = ImageUrl.FileName;
                    }
                    _informationService.Add(ınformation);
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: InformationController/Edit/5
        public ActionResult Edit(int id)
        {
            var resultDataId = _informationService.GetByID(id);
            return View(resultDataId);
          
        }

        // POST: InformationController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Information ınformation, IFormFile? ImageUrl)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    if (ImageUrl is not null)
                    {
                        string klasor1 = Directory.GetCurrentDirectory() + "/wwwroot/Img/" + ImageUrl.FileName;
                        using var stream1 = new FileStream(klasor1, FileMode.Create);
                        ImageUrl.CopyTo(stream1);
                        ınformation.ImageUrl = ImageUrl.FileName;
                    }
                    _informationService.Update(ınformation);
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: InformationController/Delete/5
        public ActionResult Delete(int id)
        {
            var resultDataId = _informationService.GetByID(id);
            return View(resultDataId);
        }

        // POST: InformationController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Information ınformation)
        {
            try
            {
                _informationService.Remove(ınformation);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
