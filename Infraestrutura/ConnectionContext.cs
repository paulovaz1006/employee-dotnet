using Microsoft.EntityFrameworkCore;
using PrimeiraApi.Models;

namespace PrimeiraApi.Infraestrutura
{
    public class ConnectionContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseNpgsql(
            "server=localhost;" +
            "Port=5432;Database=employee_sample;" +
            "User Id=postgress;" +
            "Password=123;");
    }
}
