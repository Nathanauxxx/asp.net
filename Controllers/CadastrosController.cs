using Microsoft.AspNetCore.Mvc;

namespace ControleDeCadastros.Controllers
{
    public class CadastrosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Criar()
        {
            return View();
        }
        public IActionResult Editar()
        {
            return View();
        }
        public IActionResult ApagarCadastro()
        {
            return View();
        }
    }
}
