using bookshop.Models;
using bookshop.Repositories;
using bookshop.Repositories.interfaces;
using bookshop.Services.interfaces;

namespace bookshop.Services
{
    public class CategoryService : DataRepository<Category>, ICategoryService
    {
        public CategoryService(AppDbContext context) : base(context)
        {
        }

       
    }
}
