using ContratAi.API.GraphQL;
using ContratAi.Application.Services;
using ContratAi.Core.Interfaces;
using ContratAi.Infrastructure;
using ContratAi.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

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

builder.Services.AddScoped<IEventoRepository, EventoRepository>();
builder.Services.AddScoped<EventoAppService>();

builder.Services.AddGraphQLServer().AddQueryType<EventoQuery>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}


app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.MapGet("/api/eventos", async (EventoAppService appService) =>
{
    var eventos = await appService.ListarTodosEventosAsync();
    return Results.Ok(eventos);
})
.WithName("ListarTodosEventos")
.WithTags("Eventos");

app.MapGraphQL("/graphql");

app.Run();
