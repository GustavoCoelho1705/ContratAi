using ContratAi.Core.Entities.Eventos;
using ContratAi.Core.Entities.Servicos;
using ContratAi.Core.Entities.Usuarios;
using Microsoft.EntityFrameworkCore;

namespace ContratAi.Infrastructure
{
    public class ApplicationDbContext : DbContext
    {
        private readonly string _connectionString;

        public ApplicationDbContext() { }

        public ApplicationDbContext(string connectionString)
        {
            _connectionString = connectionString;
        }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<PrestadorServico> PrestadoresServico { get; set; }
        public DbSet<OrganizadorEvento> OrganizadoresEvento { get; set; }
        public DbSet<Funcao> Funcoes { get; set; }
        public DbSet<UsuarioFuncao> UsuariosFuncoes { get; set; }
        public DbSet<Servico> Servicos { get; set; }
        public DbSet<CategoriaServico> CategoriasServico { get; set; }
        public DbSet<ServicoPrestado> ServicosPrestados { get; set; }
        public DbSet<Evento> Eventos { get; set; }
        public DbSet<Convidado> Convidados { get; set; }
        public DbSet<EventoServico> EventosServicos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseNpgsql(_connectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
        }
    }
}
