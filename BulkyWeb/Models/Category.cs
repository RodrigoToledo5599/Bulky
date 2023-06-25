﻿using System.ComponentModel.DataAnnotations;

namespace BulkyWeb.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        
       
        
        [Required]
        [StringLength(30)]
        public string Name { get; set; }
        
        

        [Required]
        public int DisplayOrder { get; set; }


    }
}
