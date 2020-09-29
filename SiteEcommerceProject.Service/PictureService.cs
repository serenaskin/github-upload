using SiteEcommerceProject.Entity.PictureModels;
using SiteEcommerceProject.Service.DbContextService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SiteEcommerceProject.Service
{
   public class PictureService
    {



        DatabaseContext context = new DatabaseContext();

        public object Current { get; set; }

        public IEnumerable<Picture> GetAll()
        {
            //var products = context.Products.Include("ProductAdd");

            return context.Pictures.ToList();


        }

        //public bool Remove(Order order)
        //{
        //    context.Products.Remove();
        //    return true;
        // }

        //İstediğin ürünleri filtreleyerek aratma işlem yaptırma.
        public IEnumerable<Picture> Find(Expression<Func<Picture, bool>> predicate)
        {

            return context.Pictures.Where(predicate);


        }


        public Picture Get(int id)
        {

            return context.Pictures.Find(id);


        }

        public Picture Add(Picture picture)
        {

            return context.Pictures.Add(picture);
            //context.SaveChanges();


        }


        public void SaveChanges()
        {
            context.SaveChanges();
        }
        public Picture Remove(Picture picture)
        {

            return context.Pictures.Remove(picture);
            //context.SaveChanges();




        }

    }
}
