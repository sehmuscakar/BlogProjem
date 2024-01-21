using Microsoft.AspNetCore.Mvc;
using Sehmus.BusinessLayer.Abstract;
using Sehmus.EntitiesLayer.Concrete;

namespace Sehmus.PresentationLayer.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]/[action]")]
    public class SkillController : Controller
    {
        private readonly ISkillService _skillService;

        public SkillController(ISkillService skillService)
        {
            _skillService = skillService;
        }

        // GET: SkillController
        public ActionResult Index()
        {
            var resultList = _skillService.GetSkillListManager();
            return View(resultList);
        }

        // GET: SkillController/Create
        public ActionResult Create()
        {
            ViewBag.dgr = _skillService.UserListManager();
            return View();
        }

        // POST: SkillController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Skill skill)
        {
            try
            {
                _skillService.Add(skill);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: SkillController/Edit/5
        public ActionResult Edit(int id)
        {
            var resultDataId = _skillService.GetByID(id);
            return View(resultDataId);
        }

        // POST: SkillController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Skill skill)
        {
            try
            {
                _skillService.Update(skill);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: SkillController/Delete/5
        public ActionResult Delete(int id)
        {
            var resultDataId = _skillService.GetByID(id);
            return View(resultDataId);
        }

        // POST: SkillController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Skill skill)
        {
            try
            {
                _skillService.Remove(skill);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
