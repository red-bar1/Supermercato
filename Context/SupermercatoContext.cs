using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week6.SupermercatoEF.Models;

namespace Week6.SupermercatoEF.Context
{
    public class SupermercatoContext : DbContext
    {
        public DbSet<Dipendente> Dipendenti { get; set; }
        public DbSet<Reparto> Reparti { get; set; }
        public DbSet<Prodotto> Prodotti { get; set; }
        public DbSet<Vendita> Vendite { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optBuilder)
        {
            optBuilder.UseSqlServer(@"Persist Security Info = False; Integrated Security = True; 
                                    Initial Catalog = Supermercato; Server = .\SQLEXPRESS");
        }

        public SupermercatoContext() : base() { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration<Dipendente>(new DipendenteConfiguration());
            builder.ApplyConfiguration<Reparto>(new RepartoConfiguration());
            builder.ApplyConfiguration<Prodotto>(new ProdottoConfiguration());
            builder.ApplyConfiguration<Vendita>(new VenditaConfiguration());
        }
    }
}
