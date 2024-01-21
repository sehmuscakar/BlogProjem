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
    public interface IContactService
    {
        List<ContactListDto> GetContactListManager();
        List<SelectListItem> UserListManager();
        List<Contact> GetList();
        void Add(Contact contact);
        void Update(Contact contact);
        void Remove(Contact contact);
        Contact GetByID(int id);
    }
}
