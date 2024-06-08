using bookshop.Models;
using bookshop.Repositories;
using bookshop.Services.interfaces;

namespace bookshop.Services
{
    public class BookService : DataRepository<Book>, IBookService
    {
        public BookService(AppDbContext context) : base(context)
        {
        }
    }
}
