using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ClaudEventos.Models;

namespace ClaudEventos.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<TipoEvento> TipoEventos {get; set;}
        public DbSet<LocalEvento> LocalEventos {get; set;}

        public DbSet<Evento> Eventos {get; set;}
        public DbSet<Estoque> Estoques {get; set;}

        
        
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
