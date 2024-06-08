using bookshop.Models;
using bookshop.Repositories.interfaces;

namespace bookshop.Services.interfaces
{
    public interface ICategoryService:IDataRepository<Category>
    {
    }
}
