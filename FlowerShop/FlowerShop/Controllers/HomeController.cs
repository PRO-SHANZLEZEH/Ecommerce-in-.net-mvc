using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FlowerShop.Repository;

namespace FlowerShop.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        private IProductRepository iProductRepository = new ProductRepository();
        public ActionResult Index()
        {
            ViewBag.latestProducts = iProductRepository.LatestProducts(3);
            ViewBag.featuredProducts = iProductRepository.FeaturedProducts(2);

            return View();
        }
    }
}