using Microsoft.AspNetCore.Mvc.Rendering;
using Sehmus.EntitiesLayer.Concrete;
using Sehmus.EntitiesLayer.Dtos.AdminDtos;

namespace Sehmus.BusinessLayer.Abstract
{
    public interface ICounterService
    {
        List<CounterListDto> GetCounterListManager();
        List<SelectListItem> UserListManager();
        List<Counter> GetList();
        void Add(Counter counter);
        void Update(Counter counter);
        void Remove(Counter counter);
        Counter GetByID(int id);
    }
}
