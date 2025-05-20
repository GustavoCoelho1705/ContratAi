using ContratAi.Core.Entities.Eventos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ContratAi.Infrastructure.Configurations;
public class ConvidadoConfiguration : IEntityTypeConfiguration<Convidado>
{
    public void Configure(EntityTypeBuilder<Convidado> builder)
    {
        builder.HasKey(c => c.Id);

        builder.Property(c => c.Nome)
            .IsRequired()
            .HasMaxLength(200);

        builder.Property(c => c.Email)
            .IsRequired()
            .HasMaxLength(200);

        builder.Property(c => c.Telefone)
            .HasMaxLength(20);

        builder.Property(c => c.Confirmado)
            .IsRequired();

        builder.HasOne(c => c.Evento)
            .WithMany(e => e.Convidados)
            .HasForeignKey(c => c.EventoId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}