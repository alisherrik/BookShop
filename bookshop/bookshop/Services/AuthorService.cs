using bookshop.Models;
using bookshop.Repositories;
using bookshop.Services.interfaces;

namespace bookshop.Services
{
    public class AuthorService : DataRepository<Author>, IAuthorService
    {
        public AuthorService(AppDbContext context) : base(context)
        {
        }
    }
}
