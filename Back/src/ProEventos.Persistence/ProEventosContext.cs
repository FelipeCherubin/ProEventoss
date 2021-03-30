using Microsoft.EntityFrameworkCore;
using ProEventos.Domain;

namespace ProEventos.Persistence
{
    public class ProEventosContext : DbContext
    {
        public ProEventosContext(DbContextOptions<ProEventosContext> options) : base(options) {}
            
        
        public DbSet<Evento> Eventos { get; set; }
        public DbSet<Lote> Lotes { get; set; } 
        public DbSet<Palestrante> Palestrantes { get; set; } 
        public DbSet<PalestranteEvento> PalestranteEventos { get; set; } 
        public DbSet<RedesSociais> RedesSociais { get; set; }  

        protected override void OnModelCreating(ModelBuilder modelBuider)
        {
            modelBuider.Entity<PalestranteEvento>()
            .HasKey(pe => new {pe.EventoId, pe.PastranteId});
        }
    }
}