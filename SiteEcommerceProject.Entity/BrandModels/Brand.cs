using SiteEcommerceProject.Entity.ProductModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteEcommerceProject.Entity.BrandModels

{
    [Table("Brand")]
    public class Brand
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [StringLength(50)]
        public string BrandName { get; set; }

        public virtual List<Product> BrandsProduct { get; set; }
    }
}
