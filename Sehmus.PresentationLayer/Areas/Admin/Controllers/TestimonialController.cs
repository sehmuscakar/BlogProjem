using Microsoft.AspNetCore.Mvc;
using Sehmus.BusinessLayer.Abstract;
using Sehmus.EntitiesLayer.Concrete;

namespace Sehmus.PresentationLayer.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]/[action]")]
    public class TestimonialController : Controller
    {
        private readonly ITestimonialService _testimonialService;

        public TestimonialController(ITestimonialService testimonialService)
        {
            _testimonialService = testimonialService;
        }

        // GET: TestimonialController
        public ActionResult Index()
        {
            var list = _testimonialService.GetTestimonialListManager();
            return View(list);
        }

        // GET: TestimonialController/Create
        public ActionResult Create()
        {
            ViewBag.dgr = _testimonialService.UserListManager();
            return View();
        }

        // POST: TestimonialController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Testimonial testimonial, IFormFile? ImageUrl)
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
                       testimonial.ImageUrl = ImageUrl.FileName;
                    }
                    _testimonialService.Add(testimonial);
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: TestimonialController/Edit/5
        public ActionResult Edit(int id)
        {
            var resultDataId = _testimonialService.GetByID(id);
            return View(resultDataId);
        }

        // POST: TestimonialController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Testimonial testimonial, IFormFile? ImageUrl)
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
                        testimonial.ImageUrl = ImageUrl.FileName;
                    }
                    _testimonialService.Update(testimonial);
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: TestimonialController/Delete/5
        public ActionResult Delete(int id)
        {
            var resultDataId = _testimonialService.GetByID(id);
            return View(resultDataId);
        }

        // POST: TestimonialController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Testimonial testimonial)
        {
            try
            {
                _testimonialService.Remove(testimonial);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
