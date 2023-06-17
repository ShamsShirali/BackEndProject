using System.ComponentModel.DataAnnotations;

namespace BackEndProject.Models
{
    public class Tag : BaseEntity
    {
        [StringLength(255)]
        public string Name { get; set; }
    }
}
