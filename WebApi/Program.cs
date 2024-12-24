using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Agregar servicios al contenedor
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();  // Habilitar la exploración de endpoints para Swagger


builder.Services.AddSwaggerGen(c =>
{
    // Agregar información de la versión de la API
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


var app = builder.Build();

// Configuración de Swagger UI
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();  // Habilitar Swagger
    app.UseSwaggerUI(c =>
    {
        // Swagger UI estará disponible en /clinica
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "Mi API");
        c.RoutePrefix = string.Empty;  // Swagger UI estará disponible en /clinica
    });
}

// Middleware que maneja las solicitudes https y http
app.UseHttpsRedirection();
app.UseAuthorization();

// Asegúrate de mapear los controladores
app.MapControllers();

app.Run();
