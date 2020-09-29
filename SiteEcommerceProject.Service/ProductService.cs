using SiteEcommerceProject.Entity.OrdersModels;
using SiteEcommerceProject.Entity.ProductModels;
using SiteEcommerceProject.Service.DbContextService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SiteEcommerceProject.Service
{
    public class ProductService
    {

        DatabaseContext context = new DatabaseContext();

        public object Current { get; set; }

        public IEnumerable<Product> GetAll()
        {
            //var products = context.Products.Include("ProductAdd");

            return context.Products.ToList();


        }

        //public bool Remove(Order order)
        //{
        //    context.Products.Remove();
        //    return true;
        // }

        //İstediğin ürünleri filtreleyerek aratma işlem yaptırma.
        public IEnumerable<Product> Find(Expression<Func<Product, bool>> predicate)
        {

            return context.Products.Where(predicate);


        }


        public Product Get(int id)
        {

            return context.Products.Find(id);


        }

        public Product Add (Product product)
        {

            return context.Products.Add(product);
            //context.SaveChanges();


        }


        public void SaveChanges()
        {
            context.SaveChanges();
        }
        public Product Remove(Product product)
        {

            return context.Products.Remove(product);
            //context.SaveChanges();




        }



    }
}
