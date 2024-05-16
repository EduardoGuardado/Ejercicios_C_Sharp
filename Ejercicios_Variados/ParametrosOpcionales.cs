internal class Program
{
    private static void Main(string[] args)
    {
        // Al momento de enviar los parámetros, puedo evitar pasar el tercer parámetro
        // Ya que en la función está inicializado por defecto con un valor que operará
        Console.WriteLine(Multiplicacion(4.2,2.5));

        // Enviando parámetros a la función de cuatro parámetros
        Console.WriteLine(Multiplicacion(2.1,8.0,1.2));
    }

    // Función que hará la operación utilizando los parámetros que reciba, pero el tercer parámetro es opcional
    static double Multiplicacion(double num1, double num2, double num3 = 0.0)
    {
        // Debido a que es una multiplicación, cualquier dato que le pasemos en los parámetros
        // si no hemos agregado un dato en el tercer parámetro lo multiplicará por cero
        // dando un resultado de cero
        return num1 * num2 * num3;
    }

    // Para este caso la función recibe cuatro parámetros, pero el cuarto es opcional y está inicializado en 1.1
    static double Multiplicacion(double num1, double num2, double num3, double num4 = 1.1)
    {
        // Ahora sí devolverá el valor que deseamos en caso de omitir el cuarto parámetro
        // ya que multiplicará los tres valores anteriores por uno y eso devuelve el mismo valor de la operación
        // utilizando solo los tres parámetros, si le pasamos el cuarto parámetro nos dará otro resultado
        // pero ya no multiplicará por uno debido a que el valor del parámetro cuatro se sustituye por el
        // valor que le hayamos pasado
        return num1 * num2 * num3 * num4;
    }
}