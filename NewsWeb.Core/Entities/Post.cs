using System.ComponentModel.DataAnnotations.Schema;

namespace NewsWeb.Core.Entities
{
    public class Post
    {
        public int Id { get; set; }
        public int SubCategoryId { get; set; }
        [ForeignKey("SubCategoryId")]
        public virtual SubCategory Order { get; set; }

        public string Slug { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageLink { get; set; }
        public string Content { get; set; }
    }
}
