using System.Text.Json.Serialization;

namespace bookshop.Models
{
    public class Category : BaseModel   
    {
        [JsonIgnore]
        public virtual List<Book> ?Books { get; set; }
    }
}
