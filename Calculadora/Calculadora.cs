internal class Program
{
    private static void Main(string[] args)
    {
        // Creamos la variable "salir" para terminar el bucle que muestra el menú
        bool salir = false;

        // Iniciamos el menú de opciones para nuestras operaciones matemáticas
        while (!salir)
        {
            // Mostramos el menú en pantalla
            Console.WriteLine("****** CALCULADORA ******");
            Console.WriteLine("*** 1. Sumar       ******");
            Console.WriteLine("*** 2. Restar      ******");
            Console.WriteLine("*** 3. Multiplicar ******");
            Console.WriteLine("*** 4. Dividir     ******");
            Console.WriteLine("*** 5. Salir       ******");
            Console.WriteLine("*************************");
            Console.Write("Escriba el número correspondiente a su opción: ");

            // Le pedimos al usuario que añada la opción y la almacenamos en una variable.
            string opcionStr = Console.ReadLine();

            // Convertimos el dato de entrada del usuario a un número entero
            if (int.TryParse(opcionStr, out int opcion))
            {
                // Ahora ejecutamos la opción que el usuario ha seleccionado
                switch (opcion)
                {
                    case 1:
                        RealizarOperacion("Suma", (a, b) => a + b);
                        break;
                    case 2:
                        RealizarOperacion("Resta", (a, b) => a - b);
                        break;
                    case 3:
                        RealizarOperacion("Multiplicación", (a, b) => a * b);
                        break;
                    case 4:
                        RealizarOperacion("División", (a, b) => b != 0 ? (double)a / b : double.NaN);
                        break;
                    case 5:
                        Console.WriteLine("Saliendo...");
                        salir = true;
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Por favor, seleccione una opción válida.");
                        break;
                }
            }
            else
            {
                // En caso de que la entrada sea diferente de un número le mostramos este mensaje
                Console.WriteLine("Opción no válida. Por favor, seleccione una opción válida.");
            }

            // Esperamos a que el usuario presione una tecla para continuar
            Console.WriteLine("Presione cualquier tecla para continuar...");
            Console.ReadKey();
            Console.Clear(); // Limpiamos la pantalla para mostrar el menú nuevamente
        }
    }

    static void RealizarOperacion(string nombreOperacion, Func<int, int, double> operacion)
    {
        Console.WriteLine($"Ha seleccionado {nombreOperacion}.");

        Console.Write("Ingrese el primer número: ");
        int num1 = int.Parse(Console.ReadLine());

        Console.Write("Ingrese el segundo número: ");
        int num2 = int.Parse(Console.ReadLine());

        double resultado = operacion(num1, num2);

        if (double.IsNaN(resultado))
        {
            Console.WriteLine("Error: No se puede dividir por cero.");
        }
        else
        {
            Console.WriteLine($"El resultado de la {nombreOperacion.ToLower()} es: {resultado}");
        }
    }
}