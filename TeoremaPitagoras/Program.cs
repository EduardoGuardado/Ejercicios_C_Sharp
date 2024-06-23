using LlamadaClase;

internal class Program
{
    private static void Main(string[] args)
    {
        // Llamamos al método "realizarTarea" para ver el resultado.
        realizarTarea();
    }

    // Creamos un método vacío para realizar las operaciones con la clase Punto
    static void realizarTarea()
    {
        // Instanciamos la clase en dos objetos diferentes "origen" y "destino"
        Punto origen = new Punto(); // origen no tiene parámetros
        Punto destino = new Punto(128, 10); // destino recibe dos parámetros

        /* Almacenamos el valor de la operación en la clase Punto dentro de una variable de tipo DOUBLE.
         * 
         * Para obtener la distancia primero utilizamos el objeto "origen" para llamar al método "DistanciaHasta"
         * que se encarga de la operación y debido a que recibe un parámetro de tipo OBJETO le pasamoes el objeto "destino"
         * para que realice la operación de los parámetros que tiene el objeto utilizando el Constructor PUNTO.
         */
        double distancia = origen.DistanciaHasta(destino);

        // Imprimimos por consola el valor que nos devuelve la clase Punto.
        Console.WriteLine($"La distancia entre los dos puntos es: {distancia}");
    }
}
