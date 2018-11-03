using Microsoft.AspNetCore.Mvc;


namespace  Pro_ResetProgra.Controllers
{
    public class VentaController : Controller
    {
        public IActionResult RegistrarOrdenCompra()
        {
           return View();
        }
        public IActionResult GenerarComprobante()
        {
           return View();
        }
    }
}