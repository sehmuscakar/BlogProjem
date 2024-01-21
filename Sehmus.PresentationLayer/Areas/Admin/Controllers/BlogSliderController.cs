using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Sehmus.BusinessLayer.Abstract;
using Sehmus.EntitiesLayer.Concrete;

namespace Sehmus.PresentationLayer.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]/[action]")]
    public class BlogSliderController : Controller
    {
        private readonly IBlogSliderService _blogSliderService;

        public BlogSliderController(IBlogSliderService blogSliderService)
        {
            _blogSliderService = blogSliderService;
        }

        // GET: BlogSliderController
        public ActionResult Index()
        {
            var resultList = _blogSliderService.GetBlogSliderListManager();
            return View(resultList);
        }


        // GET: BlogSliderController/Create
        public ActionResult Create()
        {
            ViewBag.dgr = _blogSliderService.UserListManager();
            return View();
        }

        // POST: BlogSliderController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(BlogSlider blogSlider, IFormFile? ImageUrl)
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
                        blogSlider.ImageUrl = ImageUrl.FileName;
                    }
                   _blogSliderService.Add(blogSlider);
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: BlogSliderController/Edit/5
        public ActionResult Edit(int id)
        {
            var resultDataId = _blogSliderService.GetByID(id);
            return View(resultDataId);
        }

        // POST: BlogSliderController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, BlogSlider blogSlider, IFormFile? ImageUrl)
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
                        blogSlider.ImageUrl = ImageUrl.FileName;
                    }
                    _blogSliderService.Update(blogSlider);
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: BlogSliderController/Delete/5
        public ActionResult Delete(int id)
        {
            var resultDataId = _blogSliderService.GetByID(id);
            return View(resultDataId);
        }

        // POST: BlogSliderController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, BlogSlider blogSlider)
        {
            try
            { 
                _blogSliderService.Remove(blogSlider);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
