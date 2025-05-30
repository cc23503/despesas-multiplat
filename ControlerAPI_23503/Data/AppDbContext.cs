using Microsoft.EntityFrameworkCore;
using ControlerAPI_23503.Models;

namespace ControlerAPI_23503.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Despesa> Despesas { get; set; }
    }
}