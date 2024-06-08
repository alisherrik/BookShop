
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace bookshop.Models
{
    public class Author:BaseModel
    {
        [JsonIgnore]
        public virtual ICollection<Book> ?Books { get; set; }
    }
}
