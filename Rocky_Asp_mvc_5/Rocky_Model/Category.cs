﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Rocky_Model
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
        [DisplayName("Display Order")]
        [Required]
        [Range(1,int.MaxValue,ErrorMessage ="Display Order for category must be greather than 0")]
        public int DisplayOrder { get; set; }
    }
}
