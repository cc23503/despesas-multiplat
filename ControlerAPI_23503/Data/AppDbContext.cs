using Microsoft.EntityFrameworkCore;
using ControlerAPI_23503.Models;

namespace ControlerAPI_23503.Data
{
    public class AppDbContext : DbContext
    {

        public DbSet<Despesa> Despesas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(
                "Server=regulus.cotuca.unicamp.br;Database=BD23503;User Id=BD23503;Password=BD23503;MultipleActiveResultSets=true;Encrypt=YES;TrustServerCertificate=YES"
            );
        }
    }}