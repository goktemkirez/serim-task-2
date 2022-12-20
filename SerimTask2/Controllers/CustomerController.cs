using Microsoft.AspNetCore.Mvc;
using SerimTask2.Models;
using System.Text.Json;

namespace SerimTask2.Controllers
{
    public class CustomerController : Controller
    {
        private readonly Context _context;
        public CustomerController(Context context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }


        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public JsonResult Create(Customer customer)
        {
            DateTime temp = (DateTime)customer.BirthDate;
            long tc = long.Parse(customer.IdentificationNumber);

            if (ModelState.IsValid)
            {
                bool result;

                using (ServiceReference2.KPSPublicSoapClient servis = new ServiceReference2.KPSPublicSoapClient(ServiceReference2.KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap))
                {
                    result = servis.TCKimlikNoDogrulaAsync(tc, customer.FirstName, customer.LastName, temp.Year).Result.Body.TCKimlikNoDogrulaResult;
                }

                if (result)
                {
                    //customer.OrganizationId = "9DCA312E-18C8-4DAE-AE65-01FEAD558739";
                    //customer.CountryId = "FFDF7C31-4DD1-42E7-B02F-49B76F1C3894";
                    //customer.ActivationId = "C5E6BD4A-11F0-4A9F-9F7B-966BCB1A41AF";
                    //customer.Mobile = "5555555555";
                    //customer.Gender = 1;
                    //customer.EMail = "test@gmail.com";
                    //customer.CustomerNumber = "109";
                    //customer.AreaCode = 90;
                    //customer.CreatedOn = DateTime.Now;
                    //customer.Status = true;
                    //_context.Add(customer);
                    //_context.SaveChanges();
                    return Json(customer);
                }
                else {
                    return Json("Bu bilgilere ait kişi bulunamadı !");
                }
            }

            return Json("Hatalı giriş yapıldı");
        }
    }
}
