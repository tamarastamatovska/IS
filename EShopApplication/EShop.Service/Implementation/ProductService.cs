using EShop.Domain.DomainModels;
using EShop.Repository.Interface;
using EShop.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.Service.Implementation
{
    public class ProductService : IProductService
    {
        private readonly IRepository<Product> _productRepository;
        private readonly IRepository<ProductInShoppingCart> _productInShoppingCartRepository;
        private readonly IShoppingCartService _shoppingCartService;

        public ProductService(IRepository<Product> productRepository, IRepository<ProductInShoppingCart> productInShoppingCartRepository, IShoppingCartService shoppingCartService)
        {
            _productRepository = productRepository;
            _productInShoppingCartRepository = productInShoppingCartRepository;
            _shoppingCartService = shoppingCartService;
        }



    }
}

