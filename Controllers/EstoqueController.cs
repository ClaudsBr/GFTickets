using ClaudEventos.Data;
using ClaudEventos.Models;
using Microsoft.AspNetCore.Mvc;

namespace GFTickets.Controllers
{
    
    public class EstoqueController:Controller
    {
        private readonly ApplicationDbContext database;
    
        public EstoqueController(ApplicationDbContext database){
            this.database = database;
        }

        [HttpPost]
        public IActionResult Salvar(Estoque estoqueTemp){
            database.Estoques.Add(estoqueTemp);
            database.SaveChanges();
            return RedirectToAction("Estoque", "Gestao");
        }

        
    }
}