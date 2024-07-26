using API.Application.Interfaces;
using API.Application.Services;
using API.Domain.Entity;
using API.Domain.Interfaces.Repository;
using API.Infrastructure.Data.Context;
using API.Infrastructure.Data.Repository;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Configuraci�n de servicios
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowSpecificOrigin",
        builder => builder.WithOrigins("http://localhost:4200")
                          .AllowAnyHeader()
                          .AllowAnyMethod());
});

builder.Services.AddControllers();

// Configuraci�n de la base de datos
builder.Services.AddDbContext<MenuContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Registro de servicios y repositorios
builder.Services.AddScoped<IRepositoryBase<MenuEntity, int>, MenuRepository>();
builder.Services.AddScoped<IMenuService, MenuService>();

// Configuraci�n de controladores y otros servicios
builder.Services.AddControllers().AddJsonOptions(options =>
{
    options.JsonSerializerOptions.ReferenceHandler = System.Text.Json.Serialization.ReferenceHandler.Preserve;
});

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Construir la aplicaci�n
var app = builder.Build();

// Configuraci�n del middleware
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("AllowSpecificOrigin"); // Aplicar la pol�tica CORS
app.UseAuthorization();
app.MapControllers();

app.Run();
