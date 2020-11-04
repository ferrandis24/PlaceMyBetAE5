using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Models;

namespace WebApplication1.Models
{
    public class PlaceMyBetContext : DbContext
    {
        public DbSet<Usuario> Usuario { get; set; } 
        public DbSet<Cuenta> Cuenta{ get; set; }
        public DbSet<Mercado> Mercado { get; set; }
        public DbSet<Eventos> Eventos { get; set; }
        public DbSet<Apuesta> Apuesta { get; set; }

        public PlaceMyBetContext()
        {
        }

        public PlaceMyBetContext(DbContextOptions options)
        : base(options)
        {
        }

        //Mètode de configuració
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySql("Server = 127.0.0.1; Port = 3306; Database = placemybet; Uid = root; password =; SslMode = none");

            }
        }

        //Inserció inicial de dades
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuario>().HasData(new Usuario( "ok", "manolo", 30,"manolito@gmail.com",1));
            modelBuilder.Entity<Usuario>().HasData(new Usuario("vale", "Carlos", 24, "Carlos@gmail.com",2));
            modelBuilder.Entity<Usuario>().HasData(new Usuario("si", "pepe", 25, "pepe@gmail.com",3));
            modelBuilder.Entity<Cuenta>().HasData(new Cuenta(1, "2354687", "Bankia", 25));
            modelBuilder.Entity<Cuenta>().HasData(new Cuenta(2, "2352687", "Bankia", 24));
            modelBuilder.Entity<Cuenta>().HasData(new Cuenta(3, "2354887", "Bankia", 22));
        }
    }
}