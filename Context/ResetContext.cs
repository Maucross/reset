using Microsoft.EntityFrameworkCore;

namespace Pro_ResetProgra.Context
{
    public class ResetContext :  DbContext
    {
          public ResetContext(DbContextOptions<ResetContext> options) : base (options) 
        {
        }
        public DbSet<Models.cliente> cliente { get; set; }
        public DbSet<Models.comprobante> comprobante { get; set; }
        public DbSet<Models.cotizacion> cotizacion { get; set; }
        public DbSet<Models.detalles_comprobante> detalles_comprobante { get; set; }
        public DbSet<Models.detalles_cotizacion> detalles_cotizacion { get; set; }
        public DbSet<Models.detalles_licitacion> detalles_licitacion { get; set; }
        public DbSet<Models.detalles_orden_compra> detalles_orden_compra { get; set; }
        public DbSet<Models.licitacion> licitacion { get; set; }
        public DbSet<Models.marca> marca { get; set; }
        public DbSet<Models.orden_compra> orden_compra { get; set; }
        public DbSet<Models.piezas> piezas { get; set; }
        public DbSet<Models.usuario> usuario { get; set; }

    }
}