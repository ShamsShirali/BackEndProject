using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BackEndProject.Models
{
    public class Product : BaseEntity
    {
        [StringLength(255)]
        public string Title { get; set; }
        [StringLength(1000)]
        public string Description { get; set; }
        [Column(TypeName = "money")]
        public double ExTax { get; set; }
        [Column(TypeName = "money")]
        public double Price { get; set; }
        [Column(TypeName = "money")]
        public double DiscountedPrice { get; set; }
        public int Count { get; set; }
        public bool IsFeaturedProducts { get; set; }
        public bool IsNewArrivals { get; set; }
        public bool IsMostViewProducts { get; set; }
        [StringLength(4)]
        public string Seria { get; set; }
        public int Code { get; set; }
        public int RewardPoints { get; set; }
        [StringLength(255)]
        public string? HoverImage { get; set; }
        [StringLength(255)]
        public string? MainImage { get; set; }

        public int? AuthorId { get; set; }
        public Author? Author { get; set; }
        public int? BrandId { get; set; }
        public Brand? Brand { get; set; }
        public int? CategoryId { get; set; }
        public Category? Category { get; set; }
        public IEnumerable<ProductImage> ProductImages { get; set; }
    }
}
