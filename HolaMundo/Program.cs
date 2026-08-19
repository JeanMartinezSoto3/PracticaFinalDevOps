using Microsoft.Graph;

var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.MapGet("/", () => "Hola Mundo - Practica Final DevOps CI/CD");

app.MapGet("/saludo", () => SaludoService.ObtenerSaludo());

app.Run();

public static class SaludoService
{
    public static string ObtenerSaludo()
    {
        return "Hola Mundo";
    }
}

public partial class Program { }