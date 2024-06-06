using SuperCalc;

internal class Program
{
    private static void Main(string[] args)
    {
        // Variables
        bool salir = false;                                                     // encargada de controlar el bucle del programa
        int opcion;                                                             // encargada de comprobar la opción que se ha elegido en el menú
        int n1, n2;                                                             // encargadas de las operaciones aritméticas
        double r;                                                               // encargada de almacenar el valor de las operaciones

        // Objetos a utilizar
        OperacionesBasicas operacionBasica;

        /* 
         * El bucle que se encarga de mostrar el menú en pantalla
         * mientras no elegimos una opción o finalizamos el programa
         * 
         */
        while (!salir)
        {
            // Mostramos el menú en la pantalla
            Console.WriteLine("******** CALCULADORA ********\n" +
                              "* 1. Operaciones básicas    *\n" +
                              "* 2. Operaciones avanzadas  *\n" +
                              "* 3. Conversiones           *\n" +
                              "* 4. Salir                  *\n" +
                              "*****************************");
            Console.WriteLine("Escriba su opción:");

            // Creamos una excepción para evitar errores de entrada de datos
            try 
            {
                opcion = int.Parse(Console.ReadLine());                         // Obtenemos el dato de entrada y lo convertimos en un valor numérico
            }
            catch (Exception e) 
            {
                Console.WriteLine(e.Message + "\nIntroduzca un valor numérico.\n");
                opcion = 0;
            }
            // Se analiza la opción que el usuario ha introducido y se selecciona
            switch (opcion)
            {
                case 1:
                    // Creamos el menú para la primera opción que corresponde a las operaciones básicas
                    string op;
                    Console.WriteLine("a. Suma\n" +
                                      "b. Resta\n" +
                                      "c. Multiplicación\n" +
                                      "d. División\n" +
                                      "e. Salir");
                    Console.WriteLine("Elija una operación:");
                    op = Console.ReadLine();

                    switch (op)
                    {
                        case "a":
                            operacionBasica = new OperacionesBasicas();                     // Instanciamos la clase para realizar las operaciones básicas
                            Console.WriteLine("Introduzca el valor del primer número:");    // Le pedimos al usuario el primer valor
                            n1 = int.Parse(Console.ReadLine());                             // Lo almacenamos en la primera variable
                            Console.WriteLine("Introduzca el valor del segundo número:");   // Le pedimos al usuario el segundo valor
                            n2 = int.Parse(Console.ReadLine());                             // Lo almacenamos en la segunda variable
                            r = operacionBasica.Suma(n1, n2);                               // Le pasamos los valores al método de la clase y almacenamos el resultado
                            Console.WriteLine($"El resultado de la suma es: {r}");          // Escribimos el resultado y finalizamos la operación
                            break;
                        case "e":
                            Console.WriteLine("Saliendo...");
                            break;
                        default:
                            Console.WriteLine("Elija una opción dentro del rango del menú.");
                            break;
                    }
                    break;
                case 2:
                    Console.WriteLine("Opcion 2");
                    break;
                case 3:
                    Console.WriteLine("Opcion 3");
                    break;
                case 4:
                    Console.WriteLine("Saliendo del programa...");
                    salir = true;
                    break;
                default:
                    Console.WriteLine("Elija una opción valida dentro del rango de menú.\n");
                    break;
            }

            Console.WriteLine("Presione cualquier tecla para continuar.");      // Realizamos una pausa para comprobar que el usuario presione la tecla antes de continuar
            Console.ReadKey();                                                  // Leemos la entrada de teclado
            Console.Clear();                                                    // Limpiamos la pantalla
        }
    }
}
