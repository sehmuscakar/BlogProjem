using Sehmus.BusinessLayer.Abstract;
using Sehmus.DataAccessLayer.Abstract;
using Sehmus.EntitiesLayer.Concrete;

namespace Sehmus.BusinessLayer.Concrete
{
    public class ContactPostManager : IContactPostService
    {

        private readonly IContactPostDal _contactPostDal;

        public ContactPostManager(IContactPostDal contactPostDal)
        {
            _contactPostDal = contactPostDal;
        }

        public void Add(ContactPost contactPost)
        {
            _contactPostDal.Add(contactPost);
        }

        public ContactPost GetByID(int id)
        {
            var result = _contactPostDal.Get(p => p.Id == id);
            return result;
        }

        public List<ContactPost> GetList()
        {
            return _contactPostDal.GetAll();
        }

        public void Remove(ContactPost contactPost)
        {
            _contactPostDal.Delete(contactPost);
        }

        public void Update(ContactPost contactPost)
        {
            _contactPostDal.Update(contactPost);
        }
    }
}
