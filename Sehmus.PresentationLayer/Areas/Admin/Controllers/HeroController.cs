using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Sehmus.BusinessLayer.Abstract;
using Sehmus.EntitiesLayer.Concrete;
namespace Sehmus.PresentationLayer.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]/[action]")]
    [ResponseCache(Location = ResponseCacheLocation.None, NoStore = true)]
    public class HeroController : Controller
    {
        private readonly IHeroService _heroService;
        public HeroController(IHeroService heroService)
        {
            _heroService = heroService;
        }
        // GET: HeroController
        public ActionResult Index()
        {
            var resultList = _heroService.GetHeroListManager();
            return View(resultList);
        }

        // GET: HeroController/Create
        public ActionResult Create()
        {
          ViewBag.dgr=  _heroService.UserListManager();
            return View();
        }

        // POST: HeroController/Create
        [HttpPost]
       [ValidateAntiForgeryToken]
        public ActionResult Create(Hero hero, IFormFile? ImageUrl)
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
                        hero.ImageUrl = ImageUrl.FileName;
                    }
                    _heroService.Add(hero);
                }
                return RedirectToAction(nameof(Index));
            }
            catch (Exception hata)
            {
                Console.WriteLine("Mesaj : " + hata.Message);
                return View();
            }
        }


        // GET: HeroController/Edit/5
        public ActionResult Edit(int id)
        {
           // ViewBag.dgr = _heroService.UserListManager();
            var resultDataId = _heroService.GetByID(id);
            return View(resultDataId);
        }

        // POST: HeroController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Hero hero, IFormFile? ImageUrl)
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
                        hero.ImageUrl = ImageUrl.FileName;
                    }
                 
                    _heroService.Update(hero);
                }
                return RedirectToAction(nameof(Index));
            }
            catch (Exception hata)
            {
                Console.WriteLine("Mesaj : " + hata.Message);
                return View();
            }
        }

        // GET: HeroController/Delete/5
        public ActionResult Delete(int id)
        {
            var resultDataId = _heroService.GetByID(id);
            return View(resultDataId);
        }

        // POST: HeroController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id,Hero hero)
        {
            try
            {
                _heroService.Remove(hero);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception hata)
            {
                Console.WriteLine("Mesaj : " + hata.Message);
                return View();
            }
        }
    }
}
