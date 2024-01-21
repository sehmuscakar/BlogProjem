using Microsoft.AspNetCore.Mvc.Rendering;
using Sehmus.BusinessLayer.Abstract;
using Sehmus.DataAccessLayer.Abstract;
using Sehmus.EntitiesLayer.Concrete;
using Sehmus.EntitiesLayer.Dtos;
using Sehmus.EntitiesLayer.Dtos.AdminDtos;

namespace Sehmus.BusinessLayer.Concrete
{
    public class BlogManager : IBlogService
    {
        private readonly IBlogDal _blogDal;

        public BlogManager(IBlogDal blogDal)
        {
            _blogDal = blogDal;
        }
        public void Add(Blog blog)
        {
            blog.CreatedDate= DateTime.Now;
           _blogDal.Add(blog);
        }

        public List<SelectListItem> BlogCategoryListManager()
        {
            return _blogDal.BlogCategoryListDal();
        }

        public BlogDto BlogGetByIdService(int id)
        {
            return _blogDal.BlogGetById(id);
        }

        public List<BlogListDto> GetBlogListManager()
        {
            return _blogDal.GetBlogListDal();
        }

        public Blog GetByID(int id)
        {
            var result = _blogDal.Get(p => p.Id == id);
            return result;
        }

        public List<Blog> GetList()
        {
            return _blogDal.GetAll();
        }

        public void Remove(Blog blog)
        {        
            _blogDal.Delete(blog);
        }

        public void Update(Blog blog)
        {
            blog.LastUpdatedAt= DateTime.Now;
            _blogDal.Update(blog);
        }

        public List<SelectListItem> UserListManager()
        {
            return _blogDal.UserListDal();
        }
    }
}
