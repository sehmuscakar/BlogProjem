using Microsoft.AspNetCore.Mvc.Rendering;
using Sehmus.CoreLayer.DataAccess.EntityFramework;
using Sehmus.DataAccessLayer.Abstract;
using Sehmus.DataAccessLayer.Concrete.Context;
using Sehmus.EntitiesLayer.Concrete;
using Sehmus.EntitiesLayer.Dtos.AdminDtos;

namespace Sehmus.DataAccessLayer.Concrete
{
    public class PortfolioDal : EfEntityRepositoryBase<Portfolio>, IPortfolioDal
    {
        public PortfolioDal(ProjeContextDb context) : base(context)
        {
            Context = context;
        }

        public ProjeContextDb Context { get; }

        public List<PortfolioListDto> GetPortfolioListDal()
        {
            var a = Context.Portfolios.Select(portfolio => new PortfolioListDto()
            {
                Id = portfolio.Id,
                ImageUrl= portfolio.ImageUrl,
                Category= portfolio.Category,
                Client= portfolio.Client,
                ProjectUrl= portfolio.ProjectUrl,
                Description= portfolio.Description,
                LastUpdatedAt = portfolio.LastUpdatedAt,
                CreatedFullName = portfolio.AppUser.Name,

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
