﻿using EShop.Domain.DomainModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.Domain.DomainModels
{
    public class Product : BaseEntity 
    {
        
        [Required]
        public string? ProductName { get; set; }
        [Required]
        public string? ProductDescription { get; set; }
        [Required]
        public string? ProductImage { get; set; }
        [Required]
        public double ProductPrice { get; set; }
        [Required]
        public double Rating { get; set; }
        public virtual ICollection<ProductInShoppingCart>? AllShoppingCarts { get; set; }
    }
}
