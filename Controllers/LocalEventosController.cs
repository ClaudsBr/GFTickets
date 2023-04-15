using ClaudEventos.Data;
using ClaudEventos.DTO;
using ClaudEventos.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace ClaudEventos.Controllers
{
    public class LocalEventosController : Controller
    {

        private readonly ApplicationDbContext database;
        public LocalEventosController(ApplicationDbContext database){
            this.database = database;
        }
        
        [HttpPost]
        public IActionResult Salvar(LocalEventoDTO localTemporario){
            if(ModelState.IsValid){
                LocalEvento localEvento = new LocalEvento();
                localEvento.Nome = localTemporario.Nome;
                localEvento.Endereco = localTemporario.Endereco;
                localEvento.Status = true;
                database.LocalEventos.Add(localEvento);
                database.SaveChanges();
                return RedirectToAction("LocalEvento", "Gestao");
            }else{
                return View("../Gestao/NovoLocalEvento"); 
            }            
        }

        [HttpPost]
        public IActionResult Atualizar(LocalEventoDTO localTemporario){
            if(ModelState.IsValid){
                var local = database.LocalEventos.First(local => local.Id == localTemporario.Id);
                local.Nome = localTemporario.Nome;
                local.Endereco = localTemporario.Endereco;
                database.SaveChanges();
                return RedirectToAction("LocalEvento", "Gestao");
            }else{
                return View("../Gestao/EditarLocalEvento");
            }
        }

        [HttpPost]
        public IActionResult Deletar(int id){
            if (id > 0){
                var local = database.LocalEventos.First(local => local.Id == id);
                local.Status = false;
                database.SaveChanges();
            }
            return RedirectToAction("LocalEvento", "Gestao");
        }
    }
}