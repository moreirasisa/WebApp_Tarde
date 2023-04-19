using Microsoft.AspNetCore.Mvc;
using WebApp_Tarde.Models;

namespace WebApp_Tarde.Controllers
{
    public class ClientesController : Controller
    {
        public static List<ClientesViewModel> db = new List<ClientesViewModel>();
        public IActionResult Lista()
        {
            ClientesViewModel c1 = new ClientesViewModel();
            c1.Id = 1;
            c1.Telefone = "991340447";
            c1.Nome = "Fernando";

            ClientesViewModel c2 = new ClientesViewModel();
            c2.Id = 2;
            c2.Nome = "Joao Garcia";
            c2.Telefone = "16789432456";

            db.Add(c1);
            db.Add(c2);
            return View(db);
        }

        public IActionResult Cadastro()
        {
            return View();
        }

        public IActionResult teste()
        {
            return View();
        }
    }
}
