using SiteEcommerceProject.Entity.CategoryModels;
using SiteEcommerceProject.Service;
using System;
using System.Collections.Generic;

using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Admin.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category
        CategoryService categoryservice = new CategoryService();
        public ActionResult PartialForm() {
            return View();
        }
        public ActionResult CategoryList()
        {
            //Bunu yazdık ve sonra references kısmına service projesini seçip reference ını ekledik.
            var categoryservice = new CategoryService();
            var categories = categoryservice.GetAll().ToList();
            //products = Productservice.Find(f => f.Id == id);
            ////açıklama
            ////var pro = new Product() { Id = id };
            ////açıklama
            ////pro.Id = id;
            //var prdct = Productservice.Remove(new Product() { Id = id });

            //products.Add(new Product() { UrunAdi = "deneme ürünüdür", Aciklama = "test ürünü", Fiyat = 100 }); Örnek ilk yaptığımda deneme olsun diye çalışıp çalışmadığını ölçmek için ekledim. İşlemler olunca da yorum satırına aldım.
            return View(categories);
        }

        public ActionResult CategoryAdd()
        {
            ViewBag.categoryservice = categoryservice.GetAll();
            return View();
        }
        [HttpPost]
        public ActionResult CategoryAdd(Category category)
        {
            categoryservice.Add(category);
            categoryservice.SaveChanges();
            return RedirectToAction("CategoryList");
        }


        public ActionResult CategoryUpdate(int? categoryid)
        {
            if (categoryid != null)
            {
                var ctgry = categoryservice.Find(x => x.Id == categoryid).FirstOrDefault();

                return View(ctgry);
            }
            return View();

        }

        [HttpPost]
        public ActionResult CategoryUpdate(Category category)
        {
            var ctgry = categoryservice.Find(x => x.Id == category.Id).FirstOrDefault();
            ctgry.Id = category.Id;
            ctgry.KategoriAdi = category.KategoriAdi;
            categoryservice.SaveChanges();



            //mvc post action
            return RedirectToAction("CategoryUpdate");
        }


        public ActionResult SilOk(int? id)
        {

            if (id != null)
            {

                Category ctgry = categoryservice.Find(x => x.Id == id).FirstOrDefault();

                if (ctgry != null)
                {
                    //Product pr = new Product() ;
                    //pr.Id = id;
                    //.remove(pr)
                    //kullanmak istersem.
                    categoryservice.Remove(ctgry);
                }

                //productservice.Product.Remove();
                categoryservice.SaveChanges();
                //mvc post action
            }

            return RedirectToAction("CategoryList");


            //Home Index sayfasına git..
            //return Json(JsonRequestBehavior.AllowGet);

        }

    }
}