using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
namespace Sehmus.CoreLayer.DataAccess.EntityFramework
{
    public class EfEntityRepositoryBase<TEntity> : IEntityRepository<TEntity>
     where TEntity : class, new()
    {
        protected readonly DbContext _context;

        public EfEntityRepositoryBase(DbContext context)
        {
            _context = context;
        }

        public void Add(TEntity entity)
        {
            var addedEntity = _context.Entry(entity);
            addedEntity.State = EntityState.Added;
            _context.SaveChanges();
        }
        public void Delete(TEntity entity)
        {
            var addedEntity = _context.Entry(entity);
            addedEntity.State = EntityState.Deleted;
            _context.SaveChanges();
        }
        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            return _context.Set<TEntity>().SingleOrDefault(filter);
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            {
                return filter == null
                    ? _context.Set<TEntity>().ToList() // eğer filterım boş ise bu kodu döndür
                    : _context.Set<TEntity>().Where(filter).ToList(); //buda eğer filterım eğer doluysa bana getirsin

            }
        }

        public void Update(TEntity entity)
        {
            var addedEntity = _context.Entry(entity);
            addedEntity.State = EntityState.Modified;
            _context.SaveChanges();
        }
    }

}
