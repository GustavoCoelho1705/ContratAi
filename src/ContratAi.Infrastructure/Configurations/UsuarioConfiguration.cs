using ContratAi.Core.Entities.Usuarios;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContratAi.Infrastructure.Configurations
{
    public class UsuarioConfiguration : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.HasKey(u => u.Id);

            builder.Property(u => u.Nome)
                .IsRequired()
                .HasMaxLength(200);

            builder.Property(u => u.Email)
                .IsRequired()
                .HasMaxLength(200);

            builder.Property(u => u.SenhaHash)
                .IsRequired();

            builder.Property(u => u.Telefone)
                .HasMaxLength(20);

            builder.HasMany(u => u.Funcoes)
                .WithOne(uf => uf.Usuario)
                .HasForeignKey(uf => uf.UsuarioId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(u => u.PrestadorServico)
                .WithOne(ps => ps.Usuario)
                .HasForeignKey<PrestadorServico>(ps => ps.UsuarioId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(u => u.OrganizadorEvento)
                .WithOne(oe => oe.Usuario)
                .HasForeignKey<OrganizadorEvento>(oe => oe.UsuarioId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
