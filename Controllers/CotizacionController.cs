using Microsoft.AspNetCore.Mvc;

namespace Pro_ResetProgra.Controllers
{
     public class CotizacionController : Controller
     {
         public IActionResult EvaluarCotizacion()
        {
            return View();
        }
       
         public IActionResult GenerarCotizacion()
        {
            return View();
        }
        public IActionResult ConsultarCotizacion()
        {
            return View();
        }
  
     }
}