using Microsoft.EntityFrameworkCore;
using Gerenciador_de_Departamentos.Models;

namespace Gerenciador_de_Departamentos.Data
{
    public class DepartContext : DbContext
    {
        public DbSet<Departamento> Departamentos { get; set; }
        public DbSet<Funcionario> Funcionarios { get; set; }

        public DepartContext(DbContextOptions<DepartContext> options) : base(options) { }
    }
}
