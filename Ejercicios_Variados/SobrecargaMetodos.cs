internal class Program
{
    private static void Main(string[] args)
    {
        // la operación para el método que devuelve un valor entero
        Console.WriteLine(Suma(10, 7));

        // la operación devuelve un valor de tipo double y recibe dos parámetros de tipo double
        Console.WriteLine(Suma(3.3, 2.5));

        // la operación para el método devuelve un valor con punto decimal
        // enviamos un parámetro entero y los demás como double
        Console.WriteLine(Suma(45, 9.2, 9.9));

        // la operación devuelve un valor de tipo double
        // y le enviamos cuatro parámetros con punto decimal
        Console.WriteLine(Suma(3.2, 4.4, 9.2, 91.1));
    }

    // Sobrecargando el metodo suma y utilizando funciones lambda

    // Con dos parametros y devolviendo un valor de tipo entero
    static int Suma(int num1, int num2) => num1 + num2;

    // Con dos parametros devolviendo un valor de tipo double
    static double Suma(double num1, double num2) => num1 + num2;

    // Con tres parametros y devolviendo valores de tipo double
    static double Suma(int num1, double num2, double num3) => num1 + num2 + num3;

    // Con cuatro parametros y devolviendo datos de tipo double al igual que recibiendolos
    static double Suma(double num1, double num2, double num3, double num4) => num1 + num2 + num3 + num4;
}