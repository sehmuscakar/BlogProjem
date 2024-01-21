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
    public class CounterDal : EfEntityRepositoryBase<Counter>, ICounterDal
    {
        public CounterDal(ProjeContextDb context) : base(context)
        {
            Context = context;
        }

        public ProjeContextDb Context { get; }

        public List<CounterListDto> GetCounterListDal()
        {
            var a = Context.Counters.Select(counter => new CounterListDto()
            {
                Id = counter.Id,
                Icon= counter.Icon,
                Title= counter.Title,
                Number= counter.Number,
                LastUpdatedAt = counter.LastUpdatedAt,
                CreatedFullName = counter.AppUser.Name,
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
