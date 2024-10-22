﻿using SiteEcommerceProject.Entity.ProductModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteEcommerceProject.Entity.PictureModels
{
    [Table("Picture")]
    public class Picture
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PictureId { get; set; }
        public string PictureUrl { get; set; }
        public int Sort { get; set; }

        [ForeignKey("Product")]
        public int ProductId { get; set; }

        public virtual Product Product { get; set; }


    }

}
