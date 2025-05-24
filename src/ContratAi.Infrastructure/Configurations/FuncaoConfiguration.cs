using ContratAi.Core.Entities.Usuarios;
using ContratAi.Core.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ContratAi.Infrastructure.Configurations;
public class FuncaoConfiguration : IEntityTypeConfiguration<Funcao>
{
    public void Configure(EntityTypeBuilder<Funcao> builder)
    {
        builder.HasKey(f => f.Id);

        builder.Property(f => f.Tipo)
            .IsRequired();

        builder.Property(f => f.Descricao)
            .IsRequired()
            .HasMaxLength(100);

        builder.HasMany(f => f.Usuarios)
            .WithOne(uf => uf.Funcao)
            .HasForeignKey(uf => uf.FuncaoId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasData(
            new Funcao { Tipo = TipoFuncao.Admin, Descricao = "Administrador" },
            new Funcao { Tipo = TipoFuncao.OrganizadorEvento, Descricao = "Organizador de Eventos" },
            new Funcao { Tipo = TipoFuncao.PrestadorServico, Descricao = "Prestador de Serviços" }
        );
    }
}