using SiteEcommerceProject.Entity.OrdersModels;
using SiteEcommerceProject.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
namespace Admin.Controllers
{
    public class OrderController : Controller
    {
        // GET: Order
        public ActionResult OrderList(int id)
        {
            var Orderservice = new ProductService();
            var order = Orderservice.GetAll();
            //order = Orderservice.Find(f => f.Id == id);
            //var ordr = Orderservice.Remove(new Order() { Id = id });

            return View();
        }
    }
}