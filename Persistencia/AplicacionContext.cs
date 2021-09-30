using Microsoft.EntityFrameworkCore;
using Dominio;


namespace Persistencia
{
    public class AplicacionContext : DbContext
    {
        private const string connectionString = @"Data Source=localhost\sqlexpress02;Initial Catalog = DBEMPRESAS;Integrated Security = True";
        
        public DbSet<Empleado> Empleados { get; set; }
        
        public DbSet<Persona> personas { get; set; }

        public DbSet<Cliente> clientes { get; set; }

        public DbSet<Empresa> empresas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
            if(!optionsBuilder.IsConfigured){
                optionsBuilder
                .UseSqlServer(connectionString);
            }
        }
        
    }
}