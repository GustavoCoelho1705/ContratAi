using ContratAi.Core.Entities.Usuarios;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ContratAi.Infrastructure.Configurations;
public class UsuarioFuncaoConfiguration : IEntityTypeConfiguration<UsuarioFuncao>
{
    public void Configure(EntityTypeBuilder<UsuarioFuncao> builder)
    {
        builder.HasKey(uf => new { uf.UsuarioId, uf.FuncaoId });

        builder.HasOne(uf => uf.Usuario)
            .WithMany(u => u.Funcoes)
            .HasForeignKey(uf => uf.UsuarioId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasOne(uf => uf.Funcao)
            .WithMany(f => f.Usuarios)
            .HasForeignKey(uf => uf.FuncaoId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}