internal class Program
{
    private static void Main(string[] args)
    {
        Random numero = new Random();
        int aleatorio = numero.Next(0,100);
        int minumero = 101;
        int intentos = 0;

        Console.WriteLine("Introduce un numero entre 0 y 100");
        while(aleatorio != minumero)
        {
            intentos++;

            minumero = int.Parse(Console.ReadLine());

            if (minumero > aleatorio) Console.WriteLine("El numero es mas bajo");

            if (minumero < aleatorio) Console.WriteLine("El numero es mas alto");
        }
        Console.WriteLine($"Correcto! Has necesitado {intentos} intentos para encontrar el numero.");
    }
}