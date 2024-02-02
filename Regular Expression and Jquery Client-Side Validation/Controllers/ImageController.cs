using Microsoft.AspNetCore.Mvc;
using Regular_Expression_and_Jquery_Client_Side_Validation.Models;

namespace Regular_Expression_and_Jquery_Client_Side_Validation.Controllers
{
    public class ImageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public string Index(Img img)
        {
            if(!ModelState.IsValid)
            {
                return "Desteklenen dosya biçimi (png, jpg, gif)";
            }
            return "Dosya Girişiniz Başarılı.";
        }
    }
}
