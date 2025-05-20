using ContratAi.Core.Entities.Servicos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ContratAi.Infrastructure.Configurations;
public class CategoriaServicoConfiguration : IEntityTypeConfiguration<CategoriaServico>
{
    public void Configure(EntityTypeBuilder<CategoriaServico> builder)
    {
        builder.HasKey(c => c.Id);

        builder.Property(c => c.Nome)
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(c => c.Descricao)
            .HasMaxLength(300);

        builder.HasMany(c => c.Servicos)
            .WithOne(s => s.Categoria)
            .HasForeignKey(s => s.CategoriaId)
            .OnDelete(DeleteBehavior.Restrict);

        // Seed de categorias comuns para eventos
        builder.HasData(
            new CategoriaServico
            {
                Nome = "Buffet",
                Descricao = "Serviços de alimentação e bebidas para eventos."
            },
            new CategoriaServico
            {
                Nome = "Fotografia",
                Descricao = "Serviços de fotografia e filmagem."
            },
            new CategoriaServico
            {
                Nome = "Garçom",
                Descricao = "Serviços de garçons e atendimento."
            },
            new CategoriaServico
            {
                Nome = "Decoração",
                Descricao = "Serviços de decoração de ambientes para eventos."
            },
            new CategoriaServico
            {
                Nome = "Som e Iluminação",
                Descricao = "Serviços de sonorização e iluminação para eventos."
            }
        );
    }
}