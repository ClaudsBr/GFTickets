using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ClaudEventos.Models;
using ClaudEventos.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;
using ClaudEventos.DTO;

namespace ClaudEventos.Controllers
{
    
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext database;

       

        public HomeController(ApplicationDbContext database){
            this.database = database;
        }

        public IActionResult Index()
        {
            return View(database.Eventos.Where(e=>e.status == true).Include(e => e.localDoEvento).Include(e=> e.tipoDeEvento).ToList());
            
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Eventos(){
            var lista = database.Eventos.Where(e=>e.status==true).ToList();
            var estoque = database.Estoques.ToList();
            return View(lista);
            
        }
        [Authorize]
        public IActionResult Comprar(){
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
