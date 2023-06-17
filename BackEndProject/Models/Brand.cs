﻿using System.ComponentModel.DataAnnotations;

namespace BackEndProject.Models
{
    public class Brand : BaseEntity
    {
        [StringLength(255)]
        public string Name { get; set; }
        public IEnumerable<Product>? Products { get; set; }
    }
}
