using SiteEcommerceProject.Entity.BrandModels;
using SiteEcommerceProject.Entity.CategoryModels;
using SiteEcommerceProject.Entity.PictureModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace SiteEcommerceProject.Entity.ProductModels
{
    [Table("Product")]

    public class Product
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [StringLength(50), Required]
        public string UrunAdi { get; set; }
        public decimal Fiyat { get; set; }
        [AllowHtml]
        public string Aciklama { get; set; }
        public string Subtitle { get; set; }
        public bool Guaranteed { get; set; }
        public int StokAmount { get; set; }
        [Required]
        public string StockCode { get; set; }
        public string BarkodCode { get; set; }
        public decimal CargoPrice { get; set; }
        public int CargoAmount { get; set; }
        public string ProductCargoNote { get; set; }

        [Display(Name = "Product Image")]
        public string Resim { get; set; }

        public bool Onay { get; set; }



        [ForeignKey("Brand")]
        public int Brand_Id { get; set; }
        public virtual Brand Brand { get; set; }
     

        [ForeignKey("Category")]
        public int Category_Id { get; set; }

        public virtual Category Category { get; set; }


        public   virtual IList<Picture>  pictures  { get; set; }
    }
}
