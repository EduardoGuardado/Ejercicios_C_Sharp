internal class Program
{
    private static void Main(string[] args)
    {
        // Variables principales
        float a, b, h;

        // Inicialización de las variables
        b = 10;
        h = 5;
        // Operaciones
        Console.WriteLine("** Areas de figuras geometricas **");
        Console.WriteLine("** Rectángulo **");
        Console.WriteLine($"Base: {b}, Altura: {h}");
        a = b * h;
        Console.WriteLine($"Área: {b} x {h} = {a}\n");
        Console.WriteLine("** Triángulo **");
        Console.WriteLine($"Base: {b}, Altura: {h}");
        a = h * b / 2;
        Console.WriteLine($"Área: {b} x {h} / 2 = {a}\n");
    }
}