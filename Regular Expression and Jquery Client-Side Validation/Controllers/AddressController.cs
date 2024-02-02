using Microsoft.AspNetCore.Mvc;
using Regular_Expression_and_Jquery_Client_Side_Validation.Models;

namespace Regular_Expression_and_Jquery_Client_Side_Validation.Controllers
{
    public class AddressController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Address address)
        {
            return Ok("Adresiniz sisteme kayıt edilmiştir");
        }
    }
}
