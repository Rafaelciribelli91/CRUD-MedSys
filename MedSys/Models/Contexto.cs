using Microsoft.EntityFrameworkCore;

namespace MedSys.Models
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {
        }
        public DbSet<Medicamentos> Medicamentos { get; set; }
        public DbSet<Fabricantes> Fabricantes { get; set; }
        public DbSet<Reacoes> Reacoes { get; set; }
    }
}
