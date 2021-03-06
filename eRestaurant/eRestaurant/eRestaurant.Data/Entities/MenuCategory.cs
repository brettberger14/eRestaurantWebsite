﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace eRestaurant.Data
{
    public class MenuCategory
    {
        public int MenuCategoryID { get; set; }
        [Required(ErrorMessage = "A Description is required (5-35 characters)")]
        [StringLength(35, MinimumLength = 5, ErrorMessage = "Descriptions must be from 5 to 35 characters in length")]
        public string Description { get; set; }

        public virtual ICollection<Item> MenuItems { get; set; }
    }
}
