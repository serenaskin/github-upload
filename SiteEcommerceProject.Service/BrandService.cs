using SiteEcommerceProject.Entity.BrandModels;
using SiteEcommerceProject.Service.DbContextService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SiteEcommerceProject.Service
{
    public class BrandService
    {

        DatabaseContext context = new DatabaseContext();

        public IEnumerable<Brand> GetAll()
        {

            return context.Brands.ToList();


        }

        //İstediğin ürünleri filtreleyerek aratma işlem yaptırma.
        public IEnumerable<Brand> Find(Expression<Func<Brand, bool>> predicate)
        {

            return context.Brands.Where(predicate);


        }


        public Brand Get(int id)
        {

            return context.Brands.Find(id);


        }

        public Brand Add(Brand brand)
        {

            return context.Brands.Add(brand);
            //context.SaveChanges();


        }


        public void SaveChanges()
        {
            context.SaveChanges();
        }
        public Brand Remove(Brand brand)
        {

            return context.Brands.Remove(brand);
            //context.SaveChanges();


        }


    }
}
