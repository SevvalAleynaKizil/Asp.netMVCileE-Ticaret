using BussinuessLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PagedList;
using PagedList.Mvc;
using DataAccessLayer.Context;

namespace E_Shop.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        ProductRepository productRepository = new ProductRepository();
        DataContext db = new DataContext();
        public ActionResult Index(int sayfa = 1)
        {
            var product = productRepository.GetPopularProduct();
            ViewBag.popular = product;
            return View(productRepository.GetProductList().ToPagedList(sayfa, 3));
        }
    }
}