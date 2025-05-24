using ContratAi.API.GraphQL;
using ContratAi.Application.Mappings;
using ContratAi.Application.Services;
using ContratAi.Core.Interfaces;
using ContratAi.Infrastructure;
using ContratAi.Infrastructure.Configurations.Dapper;
using ContratAi.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

var configuration = new ConfigurationBuilder()
    .AddJsonFile("appsettings.json")
    .Build();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
    options.UseNpgsql(configuration.GetConnectionString("DefaultConnection"));
}, ServiceLifetime.Scoped);

builder.Services.AddScoped<DbConnectionProvider>(sp =>
{
    var configuration = sp.GetRequiredService<IConfiguration>();
    var connectionString = configuration.GetConnectionString("DefaultConnection");
    return new DbConnectionProvider(connectionString);
});

builder.Services.AddScoped<IConvidadoRepository, ConvidadoRepository>();
builder.Services.AddScoped<IEventoRepository, EventoRepository>();
builder.Services.AddScoped<IPrestadorRepository, PrestadorRepository>();
builder.Services.AddScoped<IServicoRepository, ServicoRepository>();
builder.Services.AddScoped<ConvidadoAppService>();
builder.Services.AddScoped<EventoAppService>();
builder.Services.AddScoped<PrestadorAppService>();
builder.Services.AddScoped<ServicoAppService>();

builder.Services.AddGraphQLServer().AddQueryType<EventoQuery>()
    .AddMutationType<EventoMutation>();

builder.Services.AddAutoMapper(typeof(EventoMappingProfile).Assembly);

builder.Services.AddHealthChecks()
    .AddNpgSql(
        configuration.GetConnectionString("DefaultConnection"),
        name: "PostgreSQL",
        tags: new[] { "db", "sql", "postgres" }
    );

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapGet("/eventos", async (EventoAppService eventoService)
    => await eventoService.ListarTodosEventosAsync());

app.MapGet("/eventos/{id}", async (Guid id, EventoAppService eventoService)
    => await eventoService.ListarEventoPorId(id));

app.MapGet("/eventos/organizador/{id}", async (Guid colaboradorId, EventoAppService eventoService)
    => await eventoService.ListarEventosPorIdOrganizador(colaboradorId));

app.MapGet("/prestador", async (PrestadorAppService prestadorService)
    => await prestadorService.ListarTodosPrestadores());

app.MapGet("/prestador/{id}", async (Guid id, PrestadorAppService prestadorService)
    => await prestadorService.ListarPrestadorPorId(id));

app.MapGet("/prestador/categoria/{id}", async (Guid colaboradorId, PrestadorAppService prestadorService)
    => await prestadorService.ListarPrestadoresPorCategoria(colaboradorId));

app.MapGet("/servicos", async (ServicoAppService servicoService)
    => await servicoService.ListarTodosServicos());

app.MapGet("/servicos/categoria/{id}", async(Guid categoriaId, ServicoAppService servicoAppService)
    => await servicoAppService.ListarServicosPorCategoria(categoriaId));

app.MapGet("/convidados/{idEvento}", async (Guid idEvento, ConvidadoAppService convidadoAppService)
    => await convidadoAppService.ListarConvidadoPorIdEvento(idEvento));


app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.MapGraphQL("/graphql");
app.MapHealthChecks("/health");

app.Run();
