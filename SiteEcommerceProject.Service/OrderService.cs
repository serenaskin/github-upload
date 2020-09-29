using SiteEcommerceProject.Entity.OrdersModels;
using SiteEcommerceProject.Service.DbContextService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SiteEcommerceProject.Service
{
    public class OrderService
    {
        DatabaseContext context = new DatabaseContext();

        public IEnumerable<Order> GetAll()
        {

            return context.Orders.ToList();


        }

        //İstediğin ürünleri filtreleyerek aratma işlem yaptırma.
        public IEnumerable<Order> Find(Expression<Func<Order, bool>> predicate)
        {

            return context.Orders.Where(predicate);


        }


        public Order Get(int id)
        {

            return context.Orders.Find(id);


        }

        public Order Add(Order order)
        {

            return context.Orders.Add(order);
            //context.SaveChanges();


        }


        public void SaveChanges()
        {
            context.SaveChanges();
        }
        public Order Remove(Order order)
        {

            return context.Orders.Remove(order);
            //context.SaveChanges();


        }
    }
}
