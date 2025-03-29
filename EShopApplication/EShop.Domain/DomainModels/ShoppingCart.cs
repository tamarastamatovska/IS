﻿using EShop.Domain.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.Domain.DomainModels
{
    public class ShoppingCart
    {
        [Key]
        public Guid Id { get; set; }
        public string? OwnerId { get; set; }
        public EShopUser? Owner { get; set; }
        public virtual ICollection<ProductInShoppingCart>? AllProducts { get; set; }
    }
}
