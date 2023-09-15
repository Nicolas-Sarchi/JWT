using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.Extensions.Configuration;

namespace Persistencia.Data.Configurations;

public class ProductoConfiguration : IEntityTypeConfiguration<Producto>
{
    public void Configure(EntityTypeBuilder<Producto> builder)
    {
        builder.ToTable("producto");

        builder.Property(p => p.Nombre)
        .IsRequired()
        .HasMaxLength(100);

        builder.Property(p => p.Precio)
        .IsRequired()
        .HasColumnType("decimal(18,2)");

        builder.Property(p => p.FechaCreacion)
        .IsRequired();

        builder.HasOne(p => p.Categoria)
        .WithMany(p => p.Productos)
        .HasForeignKey(p => p.IdCategoriaFk);

        builder.HasOne(p => p.Marca)
        .WithMany(p => p.Productos)
        .HasForeignKey(p => p.IdMarcaFk);

    }
}
