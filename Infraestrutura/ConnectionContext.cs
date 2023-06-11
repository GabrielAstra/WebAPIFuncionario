using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Npgsql;
using TesteAPI.Model;

namespace TesteAPI.Infraestrutura
{
    public class ConnectionContext : DbContext
    {
        public DbSet<Employee>? Employees { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(
                "Server=localhost;" +
                "Port=----;Database=Employe;" +
                "User Id=postgres;" +
                "Password=teste;"
            );
        }
    }
}
