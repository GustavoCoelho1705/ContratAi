using ContratAi.Core.Entities.Eventos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ContratAi.Infrastructure.Configurations;
public class EventoConfiguration : IEntityTypeConfiguration<Evento>
{
    public void Configure(EntityTypeBuilder<Evento> builder)
    {
        builder.HasKey(e => e.Id);

        builder.Property(e => e.Nome)
            .IsRequired()
            .HasMaxLength(200);

        builder.Property(e => e.Descricao)
            .IsRequired()
            .HasMaxLength(500);

        builder.Property(e => e.Localizacao)
            .IsRequired()
            .HasMaxLength(300);

        builder.Property(e => e.Capacidade)
            .IsRequired();

        builder.Property(e => e.Status)
            .IsRequired();

        builder.HasOne(e => e.Organizador)
            .WithMany(o => o.Eventos)
            .HasForeignKey(e => e.OrganizadorId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasMany(e => e.ServicosContratados)
            .WithOne(es => es.Evento)
            .HasForeignKey(es => es.EventoId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasMany(e => e.Convidados)
            .WithOne(c => c.Evento)
            .HasForeignKey(c => c.EventoId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}