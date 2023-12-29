using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmigosFiesta
{
    public class Program
    {
        static void Main(string[] args)
        {
            var listaamigos = new List<string> { "Maria","Ana", "Martina", "Juan", "Leonardo", "Carlos", "Mariaelena" };
            var amigosseleccionados = NombreAmigos(listaamigos, 6);
            foreach (var i in amigosseleccionados) 
            {
                Console.WriteLine(i);
            }
            Console.Read();
        }
      /// <summary>
      /// Metodo para agregar a una nueva lista los amigos seleccionados 
      /// </summary>
      /// <param name="listaamigos"></param>
      /// <param name="valor"></param>
      /// <returns>los amigos seleccionados</returns>
       public static List<string> NombreAmigos(List<string>listaamigos, int valor)
        {
            //variable que contendra la nueva lista de amigos
            var amigosfiesta = new List<string>();
            //loop para cargar la lista hasta el limite de personas establecidas en el valor de la variable "valor"
            while (amigosfiesta.Count < valor)
            {
                var amigoactual = AmigosAsistentes(listaamigos);// variable en donde se le agregan los amigos selecccionados
                amigosfiesta.Add(amigoactual);// agregar un valor a la lista vacia
                listaamigos.Remove(amigoactual);//eliminar de la lista actual
            }
            return amigosfiesta;
        }
      /// <summary>
      /// Metodo para seleccionar el amigo con el nombre mas corto
      /// </summary>
      /// <param name="amigos"></param>
      /// <returns> retorna el nombre del amigo con el nombre mas corto </returns>
        public static string AmigosAsistentes(List<string>amigos)
        {
            string mascorto = amigos[0];
            for (int i = 0; i<amigos.Count; i++)
            {
                if (amigos[i].Length < mascorto.Length) 
                {
                    mascorto = amigos[i];
                }
            }
            return mascorto;
        }



    }
}
