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
                Descricao = "Servi�os de alimenta��o e bebidas para eventos."
            },
            new CategoriaServico
            {
                Nome = "Fotografia",
                Descricao = "Servi�os de fotografia e filmagem."
            },
            new CategoriaServico
            {
                Nome = "Gar�om",
                Descricao = "Servi�os de gar�ons e atendimento."
            },
            new CategoriaServico
            {
                Nome = "Decora��o",
                Descricao = "Servi�os de decora��o de ambientes para eventos."
            },
            new CategoriaServico
            {
                Nome = "Som e Ilumina��o",
                Descricao = "Servi�os de sonoriza��o e ilumina��o para eventos."
            }
        );
    }
}