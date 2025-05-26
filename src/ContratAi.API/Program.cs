using ContratAi.API.Extensions.Endpoints;
using ContratAi.API.GraphQL;
using ContratAi.Application.Interfaces;
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
builder.Services.AddScoped<IConvidadoAppService, ConvidadoAppService>();
builder.Services.AddScoped<IEventoAppService, EventoAppService>();
builder.Services.AddScoped<IPrestadorAppService, PrestadorAppService>();
builder.Services.AddScoped<IServicoAppService, ServicoAppService>();

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

app.RegisterConvidadoEndpoints();
app.RegisterEventoEndpoints();
app.RegisterPrestadorEndpoints();
app.RegisterServicoEndpoints(); 

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.MapGraphQL("/graphql");
app.MapHealthChecks("/health");

app.Run();
