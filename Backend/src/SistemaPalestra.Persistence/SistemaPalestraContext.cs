using Microsoft.EntityFrameworkCore;
using SistemaPalestra.Domain;

namespace SistemaPalestra.Persistence
{
    public class SistemaPalestraContext : DbContext
    {
        public SistemaPalestraContext(DbContextOptions<SistemaPalestraContext> options) : base(options){}
        public DbSet<Evento> Eventos { get; set; }
        public DbSet<Lote>  Lotes { get; set; }
        public DbSet<Palestrante> Palestrantes { get; set; }
        public DbSet<PalestranteEvento> PalestranteEventos { get; set; }
        public DbSet<RedesSocial> RedesSociais { get; set; }

        //junção de muitos para muitos
        protected override void OnModelCreating(ModelBuilder modelBuilder){
            modelBuilder.Entity<PalestranteEvento>()
                    .HasKey(X => new {X.EventoId, X.PalestranteId});
        }

    }
}