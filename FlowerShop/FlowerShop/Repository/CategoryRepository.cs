using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FlowerShop.Models;

namespace FlowerShop.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        private EcommercEntities ecommercEntities = new EcommercEntities();

        public Category find(int id)
        {
            return ecommercEntities.Categories.Find(id);
        }

        public List<Category> findAll()
        {
            return ecommercEntities.Categories.ToList();
        }
    }
}