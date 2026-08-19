using Microsoft.AspNetCore.Mvc;

namespace aulasMVC;

public class ClientesController : Controller
{
    public IActionResult Cadastrar()
    {
        return View();
    }
}
