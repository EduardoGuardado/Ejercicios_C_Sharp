internal class Program
{
    private static void Main(string[] args)
    {
        Random numero = new Random();
        int aleatorio = numero.Next(0,100);
        int minumero = 101;
        int intentos = 0;

        Console.WriteLine("Introduce un numero entre 0 y 100");
        do
        {
            intentos++;

            try
            {
                minumero = int.Parse(Console.ReadLine());
            }
            catch (FormatException e)
            {
                Console.WriteLine("No has introducido un valor numerico valido, se toma el 0 como valor introducido.");
                minumero = 0;
            }
            catch (OverflowException e)
            {
                Console.WriteLine("Has introducido un valor numerico demasiado alto, se toma el 0 como valor introducido");
                minumero = 0;
            }

            if (minumero > aleatorio) Console.WriteLine("El numero es mas bajo");

            if (minumero < aleatorio) Console.WriteLine("El numero es mas alto");
        }while(aleatorio != minumero);

        Console.WriteLine($"Correcto! Has necesitado {intentos} intentos para encontrar el numero.");
    }
}