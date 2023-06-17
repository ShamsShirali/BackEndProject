using System.ComponentModel.DataAnnotations;

namespace BackEndProject.Models
{
    public class Author:BaseEntity
    {
        [StringLength(255)]
        public string Name { get; set; }
    }
}
