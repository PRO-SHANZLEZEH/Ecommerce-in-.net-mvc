using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FlowerShop.Models;

namespace FlowerShop.Repository
{
    public class OrdersDetailRepository : IOrdersDetailRepository
    {
        private EcommercEntities ecommercEntities = new EcommercEntities();

        public void creat(OrdersDetail orderDetail)
        {
           this.ecommercEntities.OrdersDetails.Add(orderDetail);
            this.ecommercEntities.SaveChanges();
        }
    }
}