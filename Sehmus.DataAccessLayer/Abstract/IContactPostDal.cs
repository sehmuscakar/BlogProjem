using Sehmus.CoreLayer.DataAccess;
using Sehmus.DataAccessLayer.Concrete;
using Sehmus.EntitiesLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sehmus.DataAccessLayer.Abstract
{
    public interface IContactPostDal:IEntityRepository<ContactPost>
    {

    }
}
