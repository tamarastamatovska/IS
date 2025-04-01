using EShop.Domain.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.Service.Interface
{
    public interface IShoppingCartService
    {
        ShoppingCart? GetByUserId(Guid userId);
        ShoppingCartDTO GetByUserIdWithIncludedPrducts(Guid userId);
    }
}
