using System.ComponentModel.DataAnnotations;

namespace BackEndProject.Models
{
    public class Slider : BaseEntity
    {
        [StringLength(255)]
        public string Title { get; set; }
        [StringLength(255)]
        public string Description { get; set; }
        [StringLength(255)]
        public string Image { get; set; }
        [StringLength(255)]
        public string Link { get; set; }
    }
}
