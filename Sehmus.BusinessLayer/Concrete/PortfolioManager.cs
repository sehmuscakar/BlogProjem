using Microsoft.AspNetCore.Mvc.Rendering;
using Sehmus.BusinessLayer.Abstract;
using Sehmus.DataAccessLayer.Abstract;
using Sehmus.EntitiesLayer.Concrete;
using Sehmus.EntitiesLayer.Dtos.AdminDtos;

namespace Sehmus.BusinessLayer.Concrete
{
    public class PortfolioManager : IPortfolioService
    {
        private readonly IPortfolioDal _portfolioDal;

        public PortfolioManager(IPortfolioDal portfolioDal)
        {
            _portfolioDal = portfolioDal;
        }

        public void Add(Portfolio portfolio)
        {
          _portfolioDal.Add(portfolio);
        }

        public Portfolio GetByID(int id)
        {
            var result = _portfolioDal.Get(p => p.Id == id);
            return result;
        }

        public List<Portfolio> GetList()
        {
            return _portfolioDal.GetAll();
        }

        public List<PortfolioListDto> GetPortfolioListManager()
        {
            return _portfolioDal.GetPortfolioListDal();
        }

        public void Remove(Portfolio portfolio)
        {
            _portfolioDal.Delete(portfolio);
        }

        public void Update(Portfolio portfolio)
        {//DateTime.Now.Date
            portfolio.LastUpdatedAt= DateTime.Now;
            _portfolioDal.Update(portfolio);
        }

        public List<SelectListItem> UserListManager()
        {
            return _portfolioDal.UserListDal();
        }
    }
}
