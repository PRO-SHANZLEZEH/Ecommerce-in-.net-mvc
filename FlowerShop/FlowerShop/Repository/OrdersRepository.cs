using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FlowerShop.Models;

namespace FlowerShop.Repository
{
    public class OrdersRepository : IOrdersRepository
    {
        private EcommercEntities ecommercEntities = new EcommercEntities();

        public int creat(Order order)
        {
            this.ecommercEntities.Orders.Add( order);
            this.ecommercEntities.SaveChanges();
            return order.id;
        }
    }
}