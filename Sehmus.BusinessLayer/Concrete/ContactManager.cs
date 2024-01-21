using Microsoft.AspNetCore.Mvc.Rendering;
using Sehmus.BusinessLayer.Abstract;
using Sehmus.DataAccessLayer.Abstract;
using Sehmus.EntitiesLayer.Concrete;
using Sehmus.EntitiesLayer.Dtos.AdminDtos;

namespace Sehmus.BusinessLayer.Concrete
{
    public class ContactManager : IContactService
    {

        private readonly IContactDal _contactDal;

        public ContactManager(IContactDal contactDal)
        {
            _contactDal = contactDal;
        }

        public void Add(Contact contact)
        {
          _contactDal.Add(contact);
        }

        public Contact GetByID(int id)
        {
            var result = _contactDal.Get(p => p.Id == id);
            return result;
        }

        public List<ContactListDto> GetContactListManager()
        {
            return _contactDal.GetContactListDal();
        }

        public List<Contact> GetList()
        {
            return _contactDal.GetAll();
        }

        public void Remove(Contact contact)
        {
           _contactDal.Delete(contact);
        }

        public void Update(Contact contact)
        {
            contact.LastUpdatedAt= DateTime.Now;
           _contactDal.Update(contact);
        }

        public List<SelectListItem> UserListManager()
        {
            return _contactDal.UserListDal();
        }
    }
}
