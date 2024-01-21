using Microsoft.AspNetCore.Mvc;
using Sehmus.BusinessLayer.Abstract;
using Sehmus.EntitiesLayer.Concrete;

namespace Sehmus.PresentationLayer.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]/[action]")]
    public class BlogCategoryController : Controller
    {
        private readonly IBlogCategoryService _blogCategoryService;

        public BlogCategoryController(IBlogCategoryService blogCategoryService)
        {
            _blogCategoryService = blogCategoryService;
        }

        // GET: BlogCategoryController
        public ActionResult Index()
        {
            var resultList = _blogCategoryService.GetBlogCategoryListManager() ;
            return View(resultList);
        }

        // GET: BlogCategoryController/Create
        public ActionResult Create()
        {
            ViewBag.dgr = _blogCategoryService.UserListManager();
            return View();
        }

        // POST: BlogCategoryController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(BlogCategory blogCategory)
        {
            try
            {
                _blogCategoryService.Add(blogCategory);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: BlogCategoryController/Edit/5
        public ActionResult Edit(int id)
        {
            var resultDataId =_blogCategoryService.GetByID(id);
            return View(resultDataId);
        }

        // POST: BlogCategoryController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, BlogCategory blogCategory)
        {
            try
            {
                _blogCategoryService.Update(blogCategory);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: BlogCategoryController/Delete/5
        public ActionResult Delete(int id)
        {
            var resultDataId = _blogCategoryService.GetByID(id);
            return View(resultDataId);
        }

        // POST: BlogCategoryController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, BlogCategory blogCategory)
        {
            try
            {
                _blogCategoryService.Remove(blogCategory);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
