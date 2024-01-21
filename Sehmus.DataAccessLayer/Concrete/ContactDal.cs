using Microsoft.AspNetCore.Mvc.Rendering;
using Sehmus.CoreLayer.DataAccess.EntityFramework;
using Sehmus.DataAccessLayer.Abstract;
using Sehmus.DataAccessLayer.Concrete.Context;
using Sehmus.EntitiesLayer.Concrete;
using Sehmus.EntitiesLayer.Dtos.AdminDtos;

namespace Sehmus.DataAccessLayer.Concrete
{
    public class ContactDal : EfEntityRepositoryBase<Contact>, IContactDal
    {
        public ContactDal(ProjeContextDb context) : base(context)
        {
            Context = context;
        }

        public ProjeContextDb Context { get; }

        public List<ContactListDto> GetContactListDal()
        {
            var a = Context.Contacts.Select(contact => new ContactListDto()
            {
                Id = contact.Id,
               Description=contact.Description,
               Address= contact.Address,
               Phone= contact.Phone,
               Mail= contact.Mail,
               SocialMedia1= contact.SocialMedia1,
               SocialMedia2= contact.SocialMedia2,
               SocialMedia3= contact.SocialMedia3,
                LastUpdatedAt = contact.LastUpdatedAt,
                CreatedFullName = contact.AppUser.Name,

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
