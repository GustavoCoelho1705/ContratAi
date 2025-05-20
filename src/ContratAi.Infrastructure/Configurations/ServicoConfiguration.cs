using ContratAi.Core.Entities.Servicos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ContratAi.Infrastructure.Configurations;
public class ServicoConfiguration : IEntityTypeConfiguration<Servico>
{
    public void Configure(EntityTypeBuilder<Servico> builder)
    {
        builder.HasKey(s => s.Id);

        builder.Property(s => s.Nome)
            .IsRequired()
            .HasMaxLength(200);

        builder.Property(s => s.Descricao)
            .IsRequired()
            .HasMaxLength(500);

        builder.HasOne(s => s.Categoria)
            .WithMany(c => c.Servicos)
            .HasForeignKey(s => s.CategoriaId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasMany(s => s.Prestadores)
            .WithOne(sp => sp.Servico)
            .HasForeignKey(sp => sp.ServicoId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}