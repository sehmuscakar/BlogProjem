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
   public interface IServiceService
    {
        List<ServiceListDto> GetServiceListManager();
        List<SelectListItem> UserListManager();
        List<Service> GetList();
        void Add(Service service);
        void Update(Service service);
        void Remove(Service service);
        Service GetByID(int id);
    }
}
