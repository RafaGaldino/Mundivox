using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.WebEncoders.Testing;
using Torneio.Models;


namespace Torneio.Controllers
{
    public class CadastroController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public string Adicionar(string nome)
        {
            Time t1 = new Time(1, nome);
            return $"{t1.Nome}";
        }


    }
}
