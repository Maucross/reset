using Microsoft.AspNetCore.Mvc;

namespace Pro_ResetProgra.Controllers
{
     public class LicitacionController : Controller
     {
         public IActionResult RegistrarLicitacion()
        {
            return View();
        }
         public IActionResult EvaluarLicitacion()
        {
            return View();
        }
         
        public IActionResult ConsultarLicitacion()
        {
            return View();
        }

     }
}