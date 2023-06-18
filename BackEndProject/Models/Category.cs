using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BackEndProject.Models
{
    public class Category : BaseEntity
    {
        [StringLength(255)]
        public string Name { get; set; }
        public bool IsMain { get; set; }
        [StringLength(255)]
        public string? Child { get; set; }
        [StringLength(255)]
        public string? Hidden { get; set; }
        [StringLength(255)]
        public string? Mega { get; set; }

        public int? ParentId { get; set; }
        public Category? Parent { get; set; }
        public IEnumerable<Category>? Children { get; set; }
        public IEnumerable<Product>? Products { get; set; }

        [NotMapped]
        public IFormFile? File { get; set; }
    }
}
