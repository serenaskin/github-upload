using SiteEcommerceProject.Entity.ProductModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteEcommerceProject.Entity.CategoryModels
{
    [Table("Category")]
    public class Category
    {
        public int Id { get; set; }
        public string KategoriAdi { get; set; }


        public virtual List<Product> Products { get; set; }
    }

}
