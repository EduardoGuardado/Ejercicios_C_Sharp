using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LlamadaClase
{
    /*
     * Utilizaré esta clase para realizar la medición
     * de la distancia entre dos puntos
     * utilizando el teorema de Pitágoras.
     */
    internal class Punto
    {
        // Defino las variables de las coordenadas
        private int x, y;

        // Defino el constructor para definir el origen de los puntos
        public Punto()
        {
            this.x = 0;
            this.y = 0;
        }

        /* Defino la sobrecarga del constructor para darle los parámetros
         * de la distancia en la que se encuentran los puntos
         */
        public Punto(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        /* Defino el método que se encargará de realizar la operación matemática
         * para calcular la distancia entre los dos puntos que he definido en los
         * constructores el cual se hará a través del teorema de Pitágoras.
         * 
         * A éste método le paso un parámetro de tipo OBJETO para que utilice el 
         * constructor con parámetros para recibir las coordenadas de cada punto y
         * operarlo con el teoréma de Pitágoras.
         */
        public double DistanciaHasta(Punto otroPunto)
        {
            // Operamos los atrubutos de la clase que no tienen valor con los parámetros que le pasamos al constructor
            int xDif = this.x - otroPunto.x;
            int yDif = this.y - otroPunto.y;

            /* Realizamos la operación utilizando la clase Math con el teorema de Pitágoras
             * Calculando la raíz cuadrada de los dos puntos elevados al cuadrado
             */
            double distanciaPuntos = Math.Sqrt(Math.Pow(xDif, 2) + Math.Pow(yDif, 2));

            // Devolvemos el resultado de la operación
            return distanciaPuntos;
        }
    }
}
