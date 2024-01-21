using Microsoft.AspNetCore.Mvc.Rendering;
using Sehmus.BusinessLayer.Abstract;
using Sehmus.DataAccessLayer.Abstract;
using Sehmus.EntitiesLayer.Concrete;
using Sehmus.EntitiesLayer.Dtos.AdminDtos;

namespace Sehmus.BusinessLayer.Concrete
{
    public class CounterManager : ICounterService
    {
        private readonly ICounterDal _counterDal;

        public CounterManager(ICounterDal counterDal)
        {
            _counterDal = counterDal;
        }

        public void Add(Counter counter)
        {
           _counterDal.Add(counter);
        }

        public Counter GetByID(int id)
        {
            var result = _counterDal.Get(p => p.Id == id);
            return result;
        }

        public List<CounterListDto> GetCounterListManager()
        {
            return _counterDal.GetCounterListDal();
        }

        public List<Counter> GetList()
        {
            return _counterDal.GetAll();
        }

        public void Remove(Counter counter)
        {
            _counterDal.Delete(counter);
        }

        public void Update(Counter counter)
        {
            counter.LastUpdatedAt= DateTime.Now;
            _counterDal.Update(counter);
        }

        public List<SelectListItem> UserListManager()
        {
            return _counterDal.UserListDal();
        }
    }
}
