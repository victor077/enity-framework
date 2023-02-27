using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CursoEFCore.Data.Configurations;
using CursoEFCore.Domain;
using Microsoft.EntityFrameworkCore;

namespace CursoEFCore.Data
{
    public class AplicationContext : DbContext
    {

        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<PedidoItem> PedidoItems { get; set; }
        public DbSet<Produto> Produtos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=CursoEFCore;Integrated Security=True;TrustServerCertificate=True;").EnableDetailedErrors();

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AplicationContext).Assembly);

            // modelBuilder.ApplyConfiguration(new ProdutoConfiguration());
        }
    }
}