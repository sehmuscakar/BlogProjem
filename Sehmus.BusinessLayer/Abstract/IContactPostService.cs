using Sehmus.EntitiesLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sehmus.BusinessLayer.Abstract
{
    public interface IContactPostService
    {
        List<ContactPost> GetList();
        void Add(ContactPost contactPost);
        void Update(ContactPost contactPost);
        void Remove(ContactPost contactPost);
        ContactPost GetByID(int id);
    }
}
