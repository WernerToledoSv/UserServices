using Application;
using Infraestructure;
using Microsoft.OpenApi.Models;
using Serilog;
using System.Text.Json.Serialization;
using WebApi.Helpers;


var builder = WebApplication.CreateBuilder(args);


var services = builder.Services;

services.AddControllers()
    .AddJsonOptions(options =>
    {
        options.JsonSerializerOptions.DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull;
        options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
    });
builder.Services.AddEndpointsApiExplorer();  // Habilitar la exploraci�n de endpoints para Swagger

services.AddApplication();
services.AddPersistence();

builder.Services.AddSwaggerGen(c =>
{
    // Agregar informaci�n de la versi�n de la API
    c.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "User Service",
        Version = "v1",
        Description = "Microservicio para administrar al usuario" +
        "",
        Contact = new OpenApiContact
        {
            Name = "Werner Toledo",
            Email = "werner.toledo.diaz@gmail.com",
            Url = new Uri("https://www.tu-sitio.com")
        }
    });
});


try
{
    var app = builder.Build();
    var logger = app.Logger;

    // Configuraci�n de Swagger UI
    if (app.Environment.IsDevelopment())
    {
        app.UseSwagger();  // Habilitar Swagger
        app.UseSwaggerUI(c =>
        {
            // Swagger UI estar� disponible en /clinica
            c.SwaggerEndpoint("/swagger/v1/swagger.json", "Mi API");
            c.RoutePrefix = string.Empty;  // Swagger UI estar� disponible en /clinica
        });
    }

    // Middleware que maneja las solicitudes https y http
    app.UseHttpsRedirection();
    app.UseAuthorization();

    // Aseg�rate de mapear los controladores
    app.MapControllers();

    logger.LogInformation("> Starting web host...");
    ConsoleHelpers.ConfigurationDefaultCulture(logger);


    app.Run();
}
catch (Exception ex)
{
    Log.Fatal(ex.Message);
}

