using SiteEcommerceProject.Service;
using SiteEcommerceProject.Entity.ProductModels;
using SiteEcommerceProject.Entity.CategoryModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.Ajax.Utilities;
using SiteEcommerceProject.Entity.PictureModels;
using System.IO;

namespace Admin.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
   
        ProductService productservice = new ProductService();
        CategoryService categoryservice = new CategoryService();
        BrandService brandservice = new BrandService();
        PictureService pictureservice = new PictureService();
        

     
        public ActionResult ProductList()
        {
            //Bunu yazdık ve sonra references kısmına service projesini seçip reference ını ekledik.
            var productservice = new ProductService();
            var products = productservice.GetAll().ToList();
            //products = Productservice.Find(f => f.Id == id);
            ////açıklama
            ////var pro = new Product() { Id = id };
            ////açıklama
            ////pro.Id = id;
            //var prdct = Productservice.Remove(new Product() { Id = id });

            //products.Add(new Product() { UrunAdi = "deneme ürünüdür", Aciklama = "test ürünü", Fiyat = 100 }); Örnek ilk yaptığımda deneme olsun diye çalışıp çalışmadığını ölçmek için ekledim. İşlemler olunca da yorum satırına aldım.
            return View(products);
        }



        public ActionResult ProductAdd()
        {

            Product prod = new Product();

            ViewBag.categoryservice = categoryservice.GetAll();
            ViewBag.brandservice = brandservice.GetAll();
            ViewBag.pictureservice = pictureservice.GetAll();

            //var productservice = new ProductService();
            //if (id != null)
            //{
            //    var urun = productservice.Find(x => x.Id == id).FirstOrDefault();
            //    ViewBag.categoryservice = categoryservice.GetAll();
            //    ViewBag.brandservice = brandservice.GetAll();
            //    ViewBag.pictureservice = pictureservice.GetAll();
            //    return View(urun);
            //}
            return View(prod);
            ////ViewBag.productservice = productservice.GetAll();
            //ViewBag.categoryservice = categoryservice.GetAll();
            //ViewBag.brandservice = brandservice.GetAll();
            //return View();
        }
        [HttpPost]
        public ActionResult ProductAdd(Product product) //Parameter: HttpPostedFileBase file ... Sildim
        {





            ViewBag.categoryservice = categoryservice.GetAll();
            ViewBag.brandservice = brandservice.GetAll();
            ViewBag.pictureservice = pictureservice.GetAll();


            var producr = productservice.Add(product);

            productservice.SaveChanges();




            //string pic = System.IO.Path.GetFileName(file.FileName);
            //string path = System.IO.Path.Combine(Server.MapPath("~/Content/NiceAdmin/img"), pic);
            //// file is uploaded
            //file.SaveAs(path);
            //string picturepath = "Content/NiceAdmin/img/" + pic;

            //product.Resim = picturepath;

            //productservice.Add(product);

            //productservice.SaveChanges();

            return RedirectToAction("UrunDetayi", "Product", new { @id = producr.Id });

            return RedirectToAction("UrunDetayi"  );
        }


        //public ActionResult ProductUpdate(int? productid)
        //{
        //    if (productid != null)
        //    {
        //        var prdct = productservice.Find(x => x.Id == productid).FirstOrDefault();

        //        return View(prdct);
        //    }
        //    return View("UrunDetayi");

        //}




        public ActionResult ProductUpdate()
        {


            int? id = 1;

            if (id!= null)
            {
                var urun = productservice.Find(x => x.Id == id).FirstOrDefault();
                ViewBag.categoryservice = categoryservice.GetAll();
                ViewBag.brandservice = brandservice.GetAll();
                return View(urun);
            }
            return View();

        }


        //[HttpPost]
        //public ActionResult ProductUpdate(Product product)
        //{
        //    var prdct =productservice.Find(x => x.Id == product.Id).FirstOrDefault();
        //    prdct.Id = product.Id;
        //    prdct.UrunAdi = product.UrunAdi;
        //    productservice.SaveChanges();



        //    //mvc post action
        //    return RedirectToAction("ProductUpdate");
        //}


        public ActionResult SilOk(int? id)
        {

            if (id != null)
            {

                Product prdct = productservice.Find(x => x.Id == id).FirstOrDefault();

                if (prdct != null)
                {
                    //Product pr = new Product() ;
                    //pr.Id = id;
                    //.remove(pr)
                    //kullanmak istersem.
                    productservice.Remove(prdct);
                }

                //productservice.Product.Remove();
                productservice.SaveChanges();
                //mvc post action
            }

            return RedirectToAction("ProductList");


            //Home Index sayfasına git..
            //return Json(JsonRequestBehavior.AllowGet);

        }

        [HttpPost]
        public ActionResult FileUpload(HttpPostedFileBase file)
        {
            if (file != null)
            {
                string pic = System.IO.Path.GetFileName(file.FileName);
                string path = System.IO.Path.Combine(
                Server.MapPath("~/Content/NiceAdmin/img"), pic);
                // file is uploaded
                file.SaveAs(path);

                // save the image path path to the database or you can send image 
                // directly to database
                // in-case if you want to store byte[] ie. for DB
            }
            // after successfully uploading redirect the user
            return RedirectToAction("Product", "ProductList");
        }
        public ActionResult UrunDetayi(int? id) 
        {
            if (id != null)
            {
                var urun = productservice.Find(x => x.Id == id).FirstOrDefault();
                ViewBag.categoryservice = categoryservice.GetAll();
                ViewBag.brandservice = brandservice.GetAll();
                ViewBag.pictureservice = pictureservice.GetAll();
                return View(urun);
            }
            return View("UrunDetayi");
        }


        [HttpPost]
        public ActionResult UrunDetayi(Product product,HttpPostedFileBase[] files) 
        {
            var prdct = productservice.Find(x => x.Id == product.Id).FirstOrDefault();
            prdct.Id = product.Id;
            prdct.UrunAdi = product.UrunAdi;
            prdct.Aciklama = product.Aciklama;
            prdct.Fiyat = product.Fiyat;
            prdct.pictures = product.pictures;
            productservice.SaveChanges();

            ViewBag.categoryservice = categoryservice.GetAll();
            ViewBag.brandservice = brandservice.GetAll();
            ViewBag.pictureservice = pictureservice.GetAll();


            //var pictures = pictureservice.GetAll();
            //foreach (var itempicture in pictures)
            //{
            //    pictureservice.Remove(itempicture);
            //}



            //iterating through multiple file collection 


            foreach (HttpPostedFileBase file in files)
            {
                //Checking file is available to save.  
                if (file != null)
                {
                    var InputFileName = Path.GetFileName(file.FileName);
                    var ServerSavePath = Path.Combine(Server.MapPath("~/Content/NiceAdmin/img/") + InputFileName);
                    //Save file to server folder  
                    file.SaveAs(ServerSavePath);
                    //assigning file uploaded status to ViewBag for showing message to user.  
                    ViewBag.UploadStatus = files.Count().ToString() + " Fotoğraf başarılı bir şekilde eklendi.";

                    pictureservice.Add(new Picture { ProductId = product.Id, PictureUrl = "/Content/NiceAdmin/img/" + file.FileName, Sort = 1 });
                    pictureservice.SaveChanges();
                }



            }



            return View(product);

        }
        [HttpPost]
        public JsonResult DropzoneDelete(int id)
        {
            try
            {
                Picture pics = pictureservice.Find(x => x.PictureId == id).FirstOrDefault();
                pictureservice.Remove(pics);
                pictureservice.SaveChanges();
                return Json("UrunDetayi", JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {

                throw ex;
            }

            
        }


        public ActionResult DropzoneImage(int id)
        {
            var productservice = new ProductService();
            var products = productservice.GetAll().ToList();
            var pro = new Product() { Id = id };
            ////açıklama
            pro.Id = id;
            return View(products);
        }
        public ActionResult UploadProductImages()
        {

            return View();
        }
   
        public ActionResult CkEditor() 
        {
            return View();
        }
        public ActionResult PartialForm()
        {
            return View();
        }
        public ActionResult DropzonePicture(Picture resim)
        {
            //https://www.youtube.com/watch?v=AVY45mqFBKo
            //var productservice = new ProductService();
            //if (Request.Files.Count > 0)
            //{
            //    var Durum = true;
            //    foreach(string file in Request.Files)
            //    {
            //        HttpPostedFileBase httpPostedFileBase = Request.Files[file];
            //        string TamYolu = "~/Content/NiceAdmin/img" + httpPostedFileBase.FileName; //Resmin yolunu değişkene atadım.. 
            //        try
            //        {
            //            Request.Files[file].SaveAs(Server.MapPath(TamYolu)); //Resmi fiziksel olarak kaydettim..

            //            resim.ProductId = httpPostedFileBase.FileName;
            //            resim.PictureId = httpPostedFileBase.FileName;
            //            resim.PictureUrl = TamYolu;
            //            resim.Sort = 
            //            Durum = true;
            //        }
            //        catch (Exception)
            //        {

            //            throw;
            //        }
            //    }
            //}
            //else
            //{

            //}
            //return ();
            return View();
        }
        //public JsonResult Uploadss()
        //{

        //    return Json(true,JsonRequestBehavior.AllowGet);
        //}
    }
}