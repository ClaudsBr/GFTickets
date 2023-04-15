using System.Linq;
using ClaudEventos.Data;
using ClaudEventos.DTO;
using ClaudEventos.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ClaudEventos.Controllers
{
    public class EventosController:Controller
    {
        private readonly ApplicationDbContext database;
        public EventosController(ApplicationDbContext database){
            this.database = database;
        }
        [HttpPost]
        public IActionResult Salvar(EventoDTO eventoTemporario){
            if(ModelState.IsValid){
                Evento evento = new Evento();
                evento.Nome = eventoTemporario.Nome;
                evento.capacidadeDoEvento = eventoTemporario.capacidadeDoEvento;
                evento.dataDoEvento = eventoTemporario.dataDoEvento;
                evento.valorDoIngresso = eventoTemporario.valorDoIngresso; 
                evento.fotoURL = eventoTemporario.fotoURL;                
                evento.localDoEvento = database.LocalEventos.First(local => local.Id == eventoTemporario.localDoEventoID);
                evento.tipoDeEvento = database.TipoEventos.First(tipo => tipo.Id == eventoTemporario.tipoDeEventoID);
                evento.status = true;
                database.Eventos.Add(evento);
                database.SaveChanges();
                return RedirectToAction("Eventos", "Gestao");
            }else{
                ViewBag.LocalEventos = database.LocalEventos.ToList();
                ViewBag.TipoEventos = database.TipoEventos.ToList();
                return View("../Gestao/NovoEvento");
            }            
        }

        public IActionResult Atualizar(EventoDTO eventoTemporario){
            if(ModelState.IsValid){
                var evento = database.Eventos.First(evento => evento.Id == eventoTemporario.Id);
                evento.Nome = eventoTemporario.Nome;
                evento.capacidadeDoEvento = eventoTemporario.capacidadeDoEvento;
                evento.dataDoEvento = eventoTemporario.dataDoEvento;
                evento.valorDoIngresso = eventoTemporario.valorDoIngresso;
                evento.fotoURL = eventoTemporario.fotoURL;                
                evento.localDoEvento = database.LocalEventos.First(local => local.Id == eventoTemporario.localDoEventoID);
                evento.tipoDeEvento = database.TipoEventos.First(tipo => tipo.Id == eventoTemporario.tipoDeEventoID);
                database.SaveChanges();
                return RedirectToAction("Eventos", "Gestao");
            }else{
                return RedirectToAction("Eventos", "Gestao");
            }
        }

        public IActionResult Deletar(int id){
            if(id >0){
                var evento = database.Eventos.First( e => e.Id == id);
                evento.status = false;
                database.SaveChanges();
            }
            return RedirectToAction("Eventos", "Gestao");
        }   

        
    }
}