using System.Data.Entity;

namespace TallerFinal.DAL.EntityFramework
{
    internal class OperacionDbContext : DbContext
    {
        public DbSet<Dominio.Operacion> Operacion { get; set; }
    }
}