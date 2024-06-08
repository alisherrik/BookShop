using bookshop.Repositories.interfaces;
using Microsoft.EntityFrameworkCore;

namespace bookshop.Repositories
{
    public class DataRepository<T> : IDataRepository<T> where T : class
    {
        private readonly AppDbContext _context;
        private readonly DbSet<T> _dbSet;

        public DataRepository(AppDbContext context)
        {
            _context = context;
            _dbSet = context.Set<T>();
        }
        public void add(T entity)
        {
           _dbSet.Add(entity);
           _context.SaveChanges();
        }

        public void delete(T entity)
        {

            _dbSet.Remove(entity);
            _context.SaveChanges();


        }

        public IQueryable<T> GetAll()
        {
            return _dbSet;
        }

        public  T GetById(int id)
        {
            return _dbSet.Find(id);
        }

        public void update(T entity)
        {
            _context.Attach(entity).State =EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
