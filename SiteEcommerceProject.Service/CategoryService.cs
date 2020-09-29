using SiteEcommerceProject.Entity.CategoryModels;
using SiteEcommerceProject.Service.DbContextService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SiteEcommerceProject.Service
{
    public class CategoryService
    {
        DatabaseContext context = new DatabaseContext();

        public IEnumerable<Category> GetAll()
        {
          

            return context.Categories.ToList();


        }

        //İstediğin ürünleri filtreleyerek aratma işlem yaptırma.
        public IEnumerable<Category> Find(Expression<Func<Category, bool>> predicate)
        {

            return context.Categories.Where(predicate);


        }


        public Category Get(int id)
        {

            return context.Categories.Find(id);


        }

        public Category Add(Category category)
        {

            return context.Categories.Add(category);
            //context.SaveChanges();


        }


        public void SaveChanges()
        {
            context.SaveChanges();
        }
        public Category Remove(Category category)
        {

            return context.Categories.Remove(category);
            //context.SaveChanges();


        }
    }
}
