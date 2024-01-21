using Microsoft.AspNetCore.Mvc.Rendering;
using Sehmus.BusinessLayer.Abstract;
using Sehmus.DataAccessLayer.Abstract;
using Sehmus.EntitiesLayer.Concrete;
using Sehmus.EntitiesLayer.Dtos.AdminDtos;

namespace Sehmus.BusinessLayer.Concrete
{
    public class BlogCategoryManager : IBlogCategoryService
    {
        private readonly IBlogCategoryDal _blogCategoryDal;

        public BlogCategoryManager(IBlogCategoryDal blogCategoryDal)
        {
            _blogCategoryDal = blogCategoryDal;
        }

        public void Add(BlogCategory blogCategory)
        {
            _blogCategoryDal.Add(blogCategory);
        }

        public List<BlogCategoryListDto> GetBlogCategoryListManager()
        {
            return _blogCategoryDal.GetBlogCategoryListDal();
        }

        public BlogCategory GetByID(int id)
        {
            var result = _blogCategoryDal.Get(p => p.Id == id);
            return result;
        }

        public List<BlogCategory> GetList()
        {
            return _blogCategoryDal.GetAll();
        }

        public void Remove(BlogCategory blogCategory)
        {
            _blogCategoryDal.Delete(blogCategory);
        }

        public void Update(BlogCategory blogCategory)
        {
            blogCategory.LastUpdatedAt = DateTime.Now;
            _blogCategoryDal.Update(blogCategory);
        }

        public List<SelectListItem> UserListManager()
        {
            return _blogCategoryDal.UserListDal();
        }
    }
}
