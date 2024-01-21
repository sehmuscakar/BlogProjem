using Microsoft.AspNetCore.Mvc;
using Sehmus.BusinessLayer.Abstract;
using Sehmus.EntitiesLayer.Concrete;

namespace Sehmus.PresentationLayer.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]/[action]")]
    public class PortfolioController : Controller
    {
        private readonly IPortfolioService _portfolioService;

        public PortfolioController(IPortfolioService portfolioService)
        {
            _portfolioService = portfolioService;
        }

        // GET: PortfolioController
        public ActionResult Index()
        {
            var resultList = _portfolioService.GetPortfolioListManager();
            return View(resultList);
        }

        // GET: PortfolioController/Create
        public ActionResult Create()
        {
            ViewBag.dgr = _portfolioService.UserListManager();
            return View();
        }

        // POST: PortfolioController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Portfolio portfolio, IFormFile? ImageUrl)
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
                        portfolio.ImageUrl = ImageUrl.FileName;
                    }
                    _portfolioService.Add(portfolio);
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PortfolioController/Edit/5
        public ActionResult Edit(int id)
        {
            var resultDataId = _portfolioService.GetByID(id);
            return View(resultDataId);
        }

        // POST: PortfolioController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Portfolio portfolio, IFormFile? ImageUrl)
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
                        portfolio.ImageUrl = ImageUrl.FileName;
                    }
                    _portfolioService.Update(portfolio);
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PortfolioController/Delete/5
        public ActionResult Delete(int id)
        {
            var resultDataId = _portfolioService.GetByID(id);
            return View(resultDataId);
        }

        // POST: PortfolioController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Portfolio portfolio)
        {
            try
            {
                _portfolioService.Remove(portfolio);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
