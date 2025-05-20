using ContratAi.Core.Entities.Eventos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ContratAi.Infrastructure.Configurations;
public class EventoServicoConfiguration : IEntityTypeConfiguration<EventoServico>
{
    public void Configure(EntityTypeBuilder<EventoServico> builder)
    {
        builder.HasKey(es => es.Id);

        builder.Property(es => es.DataContratacao)
            .IsRequired();

        builder.Property(es => es.HorasContratadas)
            .IsRequired();

        builder.Property(es => es.ValorTotal)
            .HasPrecision(10, 2);

        builder.Property(es => es.Status)
            .IsRequired();

        builder.HasOne(es => es.Evento)
            .WithMany(e => e.ServicosContratados)
            .HasForeignKey(es => es.EventoId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasOne(es => es.ServicoPrestado)
            .WithMany()
            .HasForeignKey(es => es.ServicoPrestadoId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}