﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BulkyBook.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(30)]
        [Required]
        [DisplayName("Category Name")]
        public string Name { get; set; }

        [Range(1,100)]
        [DisplayName("Display Order")]
        public int  DisplayOrder { get; set; }
    }
}
