using Microsoft.AspNetCore.Mvc;
using MVCExample.Models;
using System.Collections.Generic;
using System.Linq;

namespace MVCExample.Controllers
{
	public class CustomerController : Controller
	{
        public IActionResult Index()

        {
            var customers = new List<Customer>
            {
                new Customer {CustomerId= 1,CustomerName= "Sevda",CustomerSurname= "Deniz"},
                new Customer {CustomerId= 2,CustomerName= "Ali",CustomerSurname= "Kaya"},
                new Customer {CustomerId= 3,CustomerName= "Ayşe",CustomerSurname= "Çiçek"},

            };
           
            #region ViewBag

            ViewBag.customers = customers;

            #endregion


            #region VİEWDATA
           
            ViewData["customers"] = customers;


            #endregion

            return View();
        }



        //Get alanı 
        public IActionResult CreateCustomer()
        {


            return View();
        }

        //post alanı
        [HttpPost]
        public IActionResult CreateCustomer(string txtName, string txtSurname)
        {


            return View();
        }


        public IActionResult MusteriDogrulama()
        {

            return View();
        }




        [HttpPost]
        public IActionResult MusteriDogrulama(Customer model)
        {
            if (!ModelState.IsValid) {

                ViewBag.HataMesaj = ModelState.Values.FirstOrDefault(x => x.ValidationState == Microsoft.AspNetCore.Mvc.ModelBinding.ModelValidationState.Invalid).Errors[0].ErrorMessage;
            }

            return View(model); 
        }



    }
}
