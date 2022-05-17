using Microsoft.EntityFrameworkCore;
using SistemaPalestra.API.Models;

namespace SistemaPalestra.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options){}
        public DbSet<Evento> Eventos { get; set; }
    }
}