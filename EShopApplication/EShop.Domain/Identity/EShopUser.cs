using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace EShop.Domain.Identity
{
    public class EShopUser : IdentityUser
    {
        public String? FirstName { get; set; }
        public String? LastName { get; set; }
        public String? Address { get; set; }
       
    }
}
