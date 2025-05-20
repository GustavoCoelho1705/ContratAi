using ContratAi.Core.Entities.Usuarios;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ContratAi.Infrastructure.Configurations;
public class OrganizadorEventoConfiguration : IEntityTypeConfiguration<OrganizadorEvento>
{
    public void Configure(EntityTypeBuilder<OrganizadorEvento> builder)
    {
        builder.HasKey(o => o.Id);

        builder.Property(o => o.Empresa)
            .HasMaxLength(200);

        builder.Property(o => o.CNPJ)
            .HasMaxLength(20);

        builder.HasOne(o => o.Usuario)
            .WithOne(u => u.OrganizadorEvento)
            .HasForeignKey<OrganizadorEvento>(o => o.UsuarioId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasMany(o => o.Eventos)
            .WithOne(e => e.Organizador)
            .HasForeignKey(e => e.OrganizadorId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}