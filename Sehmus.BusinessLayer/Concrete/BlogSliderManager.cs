using Microsoft.AspNetCore.Mvc.Rendering;
using Sehmus.BusinessLayer.Abstract;
using Sehmus.DataAccessLayer.Abstract;
using Sehmus.EntitiesLayer.Concrete;
using Sehmus.EntitiesLayer.Dtos.AdminDtos;

namespace Sehmus.BusinessLayer.Concrete
{
    public class BlogSliderManager : IBlogSliderService
    {
        private readonly IBlogSliderDal _blogSliderDal;

        public BlogSliderManager(IBlogSliderDal blogSliderDal)
        {
            _blogSliderDal = blogSliderDal;
        }

        public void Add(BlogSlider blogSlider)
        {
            _blogSliderDal.Add(blogSlider);
        }

        public List<BlogSliderListDto> GetBlogSliderListManager()
        {
            return _blogSliderDal.GetBlogSliderListDal();
        }

        public BlogSlider GetByID(int id)
        {
            var result = _blogSliderDal.Get(p => p.Id == id);
            return result;
        }

        public List<BlogSlider> GetList()
        {
            return _blogSliderDal.GetAll();
        }
        public void Remove(BlogSlider blogSlider)
        {
            _blogSliderDal.Delete(blogSlider);
        }
        public void Update(BlogSlider blogSlider)
        {
            blogSlider.LastUpdatedAt= DateTime.Now;
            _blogSliderDal.Update(blogSlider);
        }

        public List<SelectListItem> UserListManager()
        {
            return _blogSliderDal.UserListDal();
        }
    }
}
