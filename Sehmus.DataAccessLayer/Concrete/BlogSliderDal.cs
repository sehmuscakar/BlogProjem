using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Sehmus.CoreLayer.DataAccess.EntityFramework;
using Sehmus.DataAccessLayer.Abstract;
using Sehmus.DataAccessLayer.Concrete.Context;
using Sehmus.EntitiesLayer.Concrete;
using Sehmus.EntitiesLayer.Dtos.AdminDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sehmus.DataAccessLayer.Concrete
{
    public class BlogSliderDal : EfEntityRepositoryBase<BlogSlider>, IBlogSliderDal
    {
        public BlogSliderDal(ProjeContextDb context) : base(context)
        {
            Context = context;
        }

        public ProjeContextDb Context { get; }

        public List<BlogSliderListDto> GetBlogSliderListDal()
        {
            var a = Context.BlogSliders.Select(blogSlider => new BlogSliderListDto()
            {
                Id = blogSlider.Id,
                Title1 = blogSlider.Title1,
                Title2 = blogSlider.Title2,
                ImageUrl = blogSlider.ImageUrl,
                Description=blogSlider.Description,
                LastUpdatedAt = blogSlider.LastUpdatedAt,
                CreatedFullName = blogSlider.AppUser.Name,

            });
            return a.ToList();
        }

        public List<SelectListItem> UserListDal()
        {
            var deger = (from x in Context.Users.ToList()
                         select new SelectListItem
                         {
                             Text = x.Name,
                             Value = x.Id.ToString()
                         }).ToList();
            return deger;
        }
    }
}
