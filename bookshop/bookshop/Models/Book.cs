using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;


namespace bookshop.Models
{
    public class Book : BaseModel
    {
        public int CategoryId { get; set; }
       
        public virtual Category ?Category { get; set; }
        public double Price { get; set; }
        public int AuthorId { get; set; }
        public byte Image { get; set; }
        
        public virtual Author ?Author { get; set; }
    }
}
