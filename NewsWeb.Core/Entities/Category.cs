using System.ComponentModel.DataAnnotations;

namespace NewsWeb.Core.Entities
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
