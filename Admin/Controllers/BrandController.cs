using SiteEcommerceProject.Entity.BrandModels;
using SiteEcommerceProject.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Admin.Controllers
{
    public class BrandController : Controller
    {
        // GET: Brand
        BrandService brandservice = new BrandService();
        public ActionResult BrandList()
        {
            var Brandservice = new BrandService();
            var brands = Brandservice.GetAll();
            //brands = Brandservice.Find(f => f.Id == id);
            //var brnd = Brandservice.Remove(new Brand() { Id = id });
            return View(brands);
        }
        public ActionResult BrandAdd()
        {
            ViewBag.brandservice = brandservice.GetAll();
            return View();
        }
        [HttpPost]
        public ActionResult BrandAdd(Brand brand)
        {
            brandservice.Add(brand);
            brandservice.SaveChanges();
            return RedirectToAction("BrandList");
        }


        public ActionResult BrandUpdate(int? brandid)
        {
            if (brandid != null)
            {
                var brnd = brandservice.Find(x => x.Id == brandid).FirstOrDefault();

                return View(brnd);
            }
            return View();

        }

        [HttpPost]
        public ActionResult BrandUpdate(Brand brand)
        {
            var brnd = brandservice.Find(x => x.Id == brand.Id).FirstOrDefault();
            brnd.Id = brand.Id;
            brnd.BrandName = brand.BrandName;
            brandservice.SaveChanges();



            //mvc post action
            return RedirectToAction("BrandUpdate");
        }


        public ActionResult SilOk(int? id)
        {

            if (id != null)
            {

                Brand brnd = brandservice.Find(x => x.Id == id).FirstOrDefault();

                if (brnd != null)
                {
                    //Product pr = new Product() ;
                    //pr.Id = id;
                    //.remove(pr)
                    //kullanmak istersem.
                    brandservice.Remove(brnd);
                }

                //productservice.Product.Remove();
                brandservice.SaveChanges();
                //mvc post action
            }

            return RedirectToAction("BrandList");


            //Home Index sayfasına git..
            //return Json(JsonRequestBehavior.AllowGet);

        }
    }
}