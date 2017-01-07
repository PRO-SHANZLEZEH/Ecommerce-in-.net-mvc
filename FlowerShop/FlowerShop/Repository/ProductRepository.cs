using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FlowerShop.Models;

namespace FlowerShop.Repository
{
    public class ProductRepository : IProductRepository
    {
        private EcommercEntities ecommercEntities = new EcommercEntities();

        public List<Product> FeaturedProducts(int n)
        {
            return ecommercEntities.Products.Where(p => p.specials == true).OrderByDescending(p => p.id).Take(n).ToList();
        }

        public Product find(int id)
        {
            return ecommercEntities.Products.Find(id);
        }

        public List<Product> LatestProducts(int n)
        {
            return ecommercEntities.Products.OrderByDescending(p => p.id).Take(n).ToList();
        }

        public List<Product> RelatedProducts(Product product, int n)
        {
            return ecommercEntities.Products.Where(p => p.categoryId == product.categoryId &&
            p.id != product.id).Take(n).ToList();
        }
    }
}