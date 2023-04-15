using System.Linq;
using ClaudEventos.Data;
using ClaudEventos.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GFTickets.Controllers
{
        
    public class CompraController : Controller
    {
        private readonly ApplicationDbContext database;
        public CompraController(ApplicationDbContext database){
            this.database = database;
        }
        
        [Authorize]
        public IActionResult Comprar(Evento evento){
            return View();
        }

        [HttpPost]
        public IActionResult Evento(int id){
            if(id > 0){
                var evento = database.Eventos.Where(e=> e.status ==true).Include(e=> e.localDoEvento).Include(e=>e.tipoDeEvento).First(evento=>evento.Id == id);
                
                if(evento != null){
                    var estoque = database.Estoques.First(e=> e.EventoId == evento.Id);
                    if(estoque == null){
                        evento = null;
                    }
                }
                
                if(evento != null){
                    Response.StatusCode = 200;
                    return Json(evento);
                }else{
                    Response.StatusCode = 404;
                    return Json(null);
                }
            }else{
                Response.StatusCode = 404;
                return Json(null);
            }
            
        }
    }
}