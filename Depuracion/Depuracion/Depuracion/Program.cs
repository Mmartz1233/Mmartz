using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Depuracion
{
    class Program
    {
        //Para ver el orden de ejecucion de un programa: Depurar> Ventana> Obtener pilla de llamadas
        //Para ver los puntos de depuracion:  Depurar> Ventanas>Puntos de interrupccion
        static void Main(string[] args)
        {
            // variable que almacena la lista completa de amigos
           var amigos = new List<string> { "María", "Ana", "Martina", "Juan", "Leonardo", "Carlos", "Marianela"};
            //var amigos = new List<string>();
            // variable que contiene los amigos que irán a la fiesta
            var amigosFiesta = ObtenerAmigosFiesta(amigos, 3);

            // loop para mostrar en pantalla los nombres de los amigos que irán a la fiesta
      

            foreach (var nombre in amigosFiesta)
                Console.WriteLine(nombre);
            Console.Read();

        }

        /// <summary>
        /// Método para cargar la lista de amigos que irán a la fiesta
        /// </summary>
        /// <param name="lista"></param>
        /// <param name="cuenta"></param>
        /// <returns></returns>
        public static List<string> ObtenerAmigosFiesta(List<string> lista, int cuenta)
        {
            if (lista == null)
                throw new ArgumentNullException("lista", "La lista no puede ser vacia");
            //verificamos que tenga la cantidad de la cuenta no sea mas grande que los de la lista
            if (cuenta > lista.Count || cuenta <= 0)
                throw new ArgumentOutOfRangeException("Cuenta", "La cuenta no puede ser mas grande que la lista o menor a cero");

            var amuleto = new List<string>(lista);
            // variable que contendrá la lista de amigos
            var amigosFiesta = new List<string>();

            // Loop para cargar la lista hasta el límite de personas
            while(amigosFiesta.Count < cuenta)
            {
                var amigoActual = ObtenerAmigoFiesta(amuleto);
                amigosFiesta.Add(amigoActual);
                amuleto.Remove(amigoActual);
            }
            return amigosFiesta;
        }

        // Método para elegir cada amigo que asistirá
        public static string ObtenerAmigoFiesta(List<string> lista)
        {
            // Variable que contendrá el emigo con el nombre más corto
            string nombreMasCorto = lista[0];
            // Loop para revisar la lista y detectar al que tiene el nombre más corto
            for(var i = 0; i<lista.Count; i++)
            {
                if(lista[i].Length > nombreMasCorto.Length)
                {
                    nombreMasCorto = lista[i];
                }
            }
            return nombreMasCorto;
        }
    }
}
