using ClaudEventos.Data;
using ClaudEventos.DTO;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace ClaudEventos.Controllers
{
    [Authorize(Policy ="Administrador")]
    public class GestaoController : Controller
    {
        private readonly ApplicationDbContext database;

        public GestaoController(ApplicationDbContext database){
            this.database = database;
        }
        
        public IActionResult Index(){
            return View();
        }

        public IActionResult TipoEvento(){
            var tipos = database.TipoEventos.Where(tipo => tipo.Status == true).ToList();
            return View(tipos);
        }

        public IActionResult NovoTipoEvento(){
            return View();
        }

        public IActionResult EditarTipoEvento(int id){
            var tipo = database.TipoEventos.First(tipo => tipo.Id == id);
            TipoEventoDTO tipoEventoView = new TipoEventoDTO();
            tipoEventoView.Id = tipo.Id;
            tipoEventoView.Nome = tipo.Nome;

            return View(tipoEventoView);
        }
         public IActionResult LocalEvento(){
            var local = database.LocalEventos.Where(local => local.Status == true).ToList();
            return View(local);
        }

        public IActionResult NovoLocalEvento(){
            return View();
        }

        public IActionResult EditarLocalEvento(int id){
            var local = database.LocalEventos.First(local => local.Id == id);
            LocalEventoDTO localEventoView = new LocalEventoDTO();
            localEventoView.Id = local.Id;
            localEventoView.Nome = local.Nome;
            localEventoView.Endereco = local.Endereco;

            return View(localEventoView);
        }

        public IActionResult Eventos(){
            var evento = database.Eventos.Where(evento => evento.status == true).Include(e => e.tipoDeEvento).Include(e => e.localDoEvento).ToList();
            return View(evento);
        }

        public IActionResult NovoEvento(){
            ViewBag.LocalEventos = database.LocalEventos.ToList();
            ViewBag.TipoEventos = database.TipoEventos.ToList();
            return View();
        }

        public IActionResult EditarEvento(int id){
            var evento = database.Eventos.Include(e => e.tipoDeEvento).Include(e => e.localDoEvento).First(e => e.Id == id);
            EventoDTO eventoView = new EventoDTO();
            eventoView.Id = evento.Id;
            eventoView.Nome = evento.Nome;
            eventoView.capacidadeDoEvento = evento.capacidadeDoEvento;
            eventoView.dataDoEvento = evento.dataDoEvento;
            eventoView.valorDoIngresso = evento.valorDoIngresso;
            eventoView.fotoURL = evento.fotoURL;
            eventoView.localDoEventoID = evento.localDoEvento.Id;
            eventoView.tipoDeEventoID = evento.tipoDeEvento.Id;

            ViewBag.LocalEventos = database.LocalEventos.ToList();
            ViewBag.TipoEventos = database.TipoEventos.ToList();            

            return View(eventoView);
        }

        public IActionResult Estoque(){
            var listaEstoque = database.Estoques.Include(e=> e.Evento).ToList();
            return View(listaEstoque);
        }

        public IActionResult NovoEstoque(){
            ViewBag.Eventos = database.Eventos.ToList();
            return View();
        }

        public IActionResult EditarEstoque(int id){
            var estoque = database.Estoques.Include(e=>e.Evento).First(e => e.Id == id);
            EstoqueDTO estoqueView = new EstoqueDTO();
            estoqueView.Id = estoque.Id;
            estoqueView.EventoId = estoque.Id;
            estoqueView.Quantidade = estoque.Quantidade;
            

            return View(estoqueView);
            
        }
        
    }
}