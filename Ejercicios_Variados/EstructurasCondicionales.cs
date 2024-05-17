internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Comprobar Ingreso");
        Console.WriteLine("¿Qué edad tienes?");
        int edad = Int32.Parse(Console.ReadLine());

        if (edad >= 18)
        {
            Console.WriteLine("¿Tienes documento de identificación? (s/n)");
            string documento = Console.ReadLine();
            if (documento == "s")
            {
                Console.WriteLine("¡Bienvenido!");
            }
            else
            {
                Console.WriteLine("¡Vuelve la próxima semana!");
            }
        }
        else
        {
            Console.WriteLine("¡No puedes entrar!");
        }
    }
}