using Microsoft.EntityFrameworkCore;
using Sehmus.CoreLayer.DataAccess.EntityFramework;
using Sehmus.DataAccessLayer.Abstract;
using Sehmus.DataAccessLayer.Concrete.Context;
using Sehmus.EntitiesLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sehmus.DataAccessLayer.Concrete
{
    public class ContactPostDal : EfEntityRepositoryBase<ContactPost>, IContactPostDal
    {
        public ContactPostDal(ProjeContextDb context) : base(context)
        {

        }
    }
}
