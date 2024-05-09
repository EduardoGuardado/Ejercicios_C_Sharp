internal class Program
{
    private static void Main(string[] args)
    {
        // Variables
        float num1 = 7.0f;
        float num2 = 5.0f;
        float res = 0.0f;
        // Mostrando las cuatro operaciones matemáticas básicas
        Console.WriteLine("Las cuatro operaciones matemáticas básicas");
        Console.WriteLine($"Números a operar: {num1} y {num2} ");
        
        Console.WriteLine("** Suma **");
        res = num1 + num2;
        Console.WriteLine($"{num1} + {num2} = {res} \n");
        
        Console.WriteLine("** Resta **");
        res = num1 - num2;
        Console.WriteLine($"{num1} - {num2} = {res} \n");
        
        Console.WriteLine("** Multiplicación **");
        res = num1 * num2;
        Console.WriteLine($"{num1} * {num2} = {res} \n");
        
        Console.WriteLine("** División **");
        res = num1 / num2;
        Console.WriteLine($"{num1} / {num2} = {res} \n");
        
        Console.WriteLine("** Módulo **");
        res = num1 % num2;
        Console.WriteLine($"{num1} % {num2} = {res} \n");
        Console.WriteLine("**************");
    }
}