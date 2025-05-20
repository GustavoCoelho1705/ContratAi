using ContratAi.Core.Entities.Servicos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ContratAi.Infrastructure.Configurations;
public class ServicoPrestadoConfiguration : IEntityTypeConfiguration<ServicoPrestado>
{
    public void Configure(EntityTypeBuilder<ServicoPrestado> builder)
    {
        builder.HasKey(sp => sp.Id);

        builder.Property(sp => sp.PrecoHora)
            .HasPrecision(10, 2);

        builder.Property(sp => sp.Descricao)
            .IsRequired()
            .HasMaxLength(500);

        builder.Property(sp => sp.HorasMinimas)
            .IsRequired();

        builder.HasOne(sp => sp.PrestadorServico)
            .WithMany(p => p.Servicos)
            .HasForeignKey(sp => sp.PrestadorServicoId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasOne(sp => sp.Servico)
            .WithMany(s => s.Prestadores)
            .HasForeignKey(sp => sp.ServicoId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}