using Microsoft.AspNetCore.Mvc.Rendering;
using Sehmus.EntitiesLayer.Concrete;
using Sehmus.EntitiesLayer.Dtos.AdminDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sehmus.BusinessLayer.Abstract
{
   public interface IPortfolioService
    {
        List<PortfolioListDto> GetPortfolioListManager();
        List<SelectListItem> UserListManager();
        List<Portfolio> GetList();
        void Add(Portfolio portfolio);
        void Update(Portfolio portfolio);
        void Remove(Portfolio portfolio);
        Portfolio GetByID(int id);
    }
}
