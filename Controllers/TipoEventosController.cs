using ClaudEventos.Data;
using ClaudEventos.DTO;
using ClaudEventos.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace ClaudEventos.Controllers
{
    public class TipoEventosController : Controller
    {
        private readonly ApplicationDbContext database;
        public TipoEventosController(ApplicationDbContext database){
            this.database = database;
        }

        [HttpPost]
        public IActionResult Salvar(TipoEventoDTO eventoTemporario){
            if(ModelState.IsValid){
                TipoEvento tipoEvento = new TipoEvento();
                tipoEvento.Nome = eventoTemporario.Nome;
                tipoEvento.Status = true;
                database.TipoEventos.Add(tipoEvento);
                database.SaveChanges();
                return RedirectToAction("TipoEvento", "Gestao");
            }else{
                return View("../Gestao/NovoTipoEvento");
            }            
        }

        [HttpPost]
        public IActionResult Atualizar(TipoEventoDTO tipoTemporario){
            if(ModelState.IsValid){
                var tipo = database.TipoEventos.First(tipo => tipo.Id == tipoTemporario.Id);
                tipo.Nome = tipoTemporario.Nome;
                database.SaveChanges();
                return RedirectToAction("TipoEvento", "Gestao");
            }else{
                return View("../Gestao/EditarTipoEvento");
            }
        }

        [HttpPost]
        public IActionResult Deletar(int id){
            if(id > 0){
                var tipo = database.TipoEventos.First(tipo => tipo.Id == id);
                tipo.Status = false;
                database.SaveChanges();
            }
            return RedirectToAction("TipoEvento", "Gestao");
        }
    }
}