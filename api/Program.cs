namespace api;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        var app = builder.Build();

        app.MapGet("/", () => "Página Principal");
        app.MapGet("/Produtos", () => "Lista de Produtos");

        app.Run();
    }
}
