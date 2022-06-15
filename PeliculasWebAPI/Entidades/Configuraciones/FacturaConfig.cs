using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace PeliculasWebAPI.Entidades.Configuraciones {
    public class FacturaConfig : IEntityTypeConfiguration<Factura> {
        public void Configure(EntityTypeBuilder<Factura> builder){
            builder.HasMany(typeof(FacturaDetalle))
                   .WithOne();

            builder.Property(f => f.NumFactura)
                   .HasDefaultValueSql("NEXT VALUE FOR factura.NumFactura");
        }
    }
}
