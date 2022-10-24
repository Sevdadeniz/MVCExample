using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using MVCExample.Models;
using System.Collections.Generic;

namespace MVCExample.Controllers
{
    public class ProductController : Controller
    {
        //action türleri dönüş tipleri

        /*
        Bildiğiniz üzere client ten gelen requestleri controllerımız karşılayıp
        uygun actiona yönlendirmekteydi
        Actionda ihtiyacımıza göre operasyonu yönetiyordu.
        İşte bu durumlarda action metodumuun farklı türleri olabilmekte

         */
        #region JsonResult
        public JsonResult GetProduct()
        {
            //JSon tipine çevirip gönderme 
            JsonResult result = Json(new Product
            {
                Id = 1,
                ProductName = "IPHONE",
                ProductPrice = 150

            });
            return result;
        }
        #endregion

        public IActionResult Index()

        {
            var products = new List<Product>
            {
                new Product {Id= 1,ProductName= "SAMSUNG",ProductPrice= 160},
                new Product {Id= 2,ProductName= "VESTEL",ProductPrice= 120},
                new Product {Id= 3,ProductName= "OPPO",ProductPrice= 180},

            };
            #region MODEL ESASLI VERİ GÖNDERİMİ
           // return View(products);
            #endregion

            #region ViewBag
            //Taşınacak olan veriyi dinamik bir şekilde almamızı sağlayan yapıdır.(değişkenle)
            

            ViewBag.products = products;

            #endregion


            #region VİEWDATA
            //Bu yapıda viewbag gibi veri taşımamıza yarar ancak farklı olarak
            //boxing ve unboxing işlemleri vardır.
            ViewData["products"] = products;


            #endregion

            return View();
        }
        
        //Get alanı - listeleme burada yapılıyor
        //ekrana sayfayı taşıyan defaultunda get olan alttaki action
        public IActionResult CreateProduct()
        {


            return View();
        }

        //post alanı
        //bu yapı kullanıcıdan parametrelerle verileri karşıladı
        [HttpPost]
        public IActionResult CreateProduct(string txtName,string txtProductPrice)
        {


            return View();
        }
    }
}
