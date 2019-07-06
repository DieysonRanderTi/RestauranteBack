using Microsoft.EntityFrameworkCore;
using Rest.Domain.Ententies;
using Rest.Infra.Data.Map;
using System;
using System.Collections.Generic;
using System.Text;

namespace Rest.Infra.Data.Context
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions options): base(options)
        {

        }
        public DbSet<Prato> Pratos { get; set; }
        public DbSet <Restaurante> Restaurantes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new PratoMap());
            modelBuilder.ApplyConfiguration(new RestauranteMap());
            base.OnModelCreating(modelBuilder);

        }
    }
}
