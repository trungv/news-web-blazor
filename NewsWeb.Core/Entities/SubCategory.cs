using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NewsWeb.Core.Entities
{
    public class SubCategory
    {
        [Key]
        public int Id { get; set; }
        
        public int CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        public virtual Category Category { get; set; }

        public string Name { get; set; }
    }
}
