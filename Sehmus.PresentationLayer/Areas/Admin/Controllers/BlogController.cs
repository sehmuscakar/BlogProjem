using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Sehmus.BusinessLayer.Abstract;
using Sehmus.EntitiesLayer.Concrete;
using System.Reflection.Metadata;

namespace Sehmus.PresentationLayer.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]/[action]")]
    public class BlogController : Controller
    {
        private readonly IBlogService _blogService;

        public BlogController(IBlogService blogService)
        {
            _blogService = blogService;
        }

        // GET: BlogController
        public ActionResult Index()
        {
            var resultList = _blogService.GetBlogListManager();
            return View(resultList);
        }

        // GET: BlogController/Create
        public ActionResult Create()
        {
            ViewBag.dgr2 = _blogService.BlogCategoryListManager();
            ViewBag.dgr = _blogService.UserListManager();
            return View();
        }

        // POST: BlogController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Blog blog,IFormFile BlogImage)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    if (BlogImage is not null)
                    {
                        string klasor1 = Directory.GetCurrentDirectory() + "/wwwroot/Img/" + BlogImage.FileName;
                        using var stream1 = new FileStream(klasor1, FileMode.Create);
                        BlogImage.CopyTo(stream1);
                        blog.BlogImage = BlogImage.FileName;
                    }
                    _blogService.Add(blog);
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: BlogController/Edit/5
        public ActionResult Edit(int id)
        {
            var resultDataId = _blogService.GetByID(id);
            return View(resultDataId);
        }

        // POST: BlogController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Blog blog, IFormFile BlogImage)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    if (BlogImage is not null)
                    {
                        string klasor1 = Directory.GetCurrentDirectory() + "/wwwroot/Img/" + BlogImage.FileName;
                        using var stream1 = new FileStream(klasor1, FileMode.Create);
                        BlogImage.CopyTo(stream1);
                        blog.BlogImage = BlogImage.FileName;
                    }
                    _blogService.Update(blog);
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: BlogController/Delete/5
        public ActionResult Delete(int id)
        {
            var resultDataId = _blogService.GetByID(id);
            return View(resultDataId);
        }

        // POST: BlogController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Blog blog)
        {
            try
            {
                _blogService.Remove(blog);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
