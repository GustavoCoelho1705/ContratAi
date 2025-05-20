using ContratAi.Core.Entities.Usuarios;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ContratAi.Infrastructure.Configurations;
public class PrestadorServicoConfiguration : IEntityTypeConfiguration<PrestadorServico>
{
    public void Configure(EntityTypeBuilder<PrestadorServico> builder)
    {
        builder.HasKey(p => p.Id);

        builder.Property(p => p.CNPJ)
            .IsRequired()
            .HasMaxLength(20);

        builder.Property(p => p.AreaAtuacao)
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(p => p.DescricaoServicos)
            .IsRequired()
            .HasMaxLength(500);

        builder.Property(p => p.AvaliacaoMedia)
            .HasPrecision(3, 2);

        builder.HasOne(p => p.Usuario)
            .WithOne(u => u.PrestadorServico)
            .HasForeignKey<PrestadorServico>(p => p.UsuarioId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasMany(p => p.Servicos)
            .WithOne(sp => sp.PrestadorServico)
            .HasForeignKey(sp => sp.PrestadorServicoId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasMany(p => p.Avaliacoes)
            .WithOne(a => a.PrestadorServico)
            .HasForeignKey(a => a.PrestadorServicoId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}
