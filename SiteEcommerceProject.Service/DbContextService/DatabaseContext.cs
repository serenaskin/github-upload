using SiteEcommerceProject.Entity.BrandModels;
using SiteEcommerceProject.Entity.CategoryModels;
using SiteEcommerceProject.Entity.OrdersModels;
using SiteEcommerceProject.Entity.PictureModels;
using SiteEcommerceProject.Entity.ProductModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteEcommerceProject.Service.DbContextService
{
  public  class DatabaseContext : DbContext
    {
        public DatabaseContext() : base("SiteEcommerce")
        {
            //Database.SetInitializer(new MigrateDatabaseToLatestVersion<DatabaseContext, Migrations.Configuration>());
            //Database.SetInitializer(new MyInitializer());
        }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Picture> Pictures { get; set; }


    }
}
