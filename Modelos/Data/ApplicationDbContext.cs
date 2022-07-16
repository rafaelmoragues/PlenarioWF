using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using SistemasPlenario.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos.Data
{
    public class ApplicationDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json");
            var configuration = builder.Build();
            optionsBuilder.UseSqlServer(configuration["ConnectionStrings:DefaultConnection"]);
        }
        public DbSet<Persona> Personas { get; set; }
        public DbSet<Telefono> Telefonos { get; set; }
    }
}
