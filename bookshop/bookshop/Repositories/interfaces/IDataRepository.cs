namespace bookshop.Repositories.interfaces
{
    public interface IDataRepository<T> where T : class
    {
        T GetById(int id);
        IQueryable<T> GetAll();
        void add(T entity); 
        void update(T entity);
        void delete(T entity);

    }
}
