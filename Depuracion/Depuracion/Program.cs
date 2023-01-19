using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Security.Principal;
//para la eliminacion de errores
namespace Depuracion
{
    public class Program
    {
        static void Main(string[] args)
        {
            ObtenerAmigosFiesta();
            Console.Read();
        }
        public static void ObtenerAmigosFiesta()
        {
            var amigos = new List<string> {"Arvizu","Estefhania","Liz","Lu", "Irene", "Paola", "Iris", "Diego","kat"};
            var listaNuevosAmigos = new List<string> { };
            var nombremascorto = amigos[4];
            Console.WriteLine("La cantidad de letras que tiene el nombre mas corto es: {0}",amigos[4].Length);
            for (var i = 0; i< amigos.Count;i++)//Listar a todos los amigos
            {
                
                if (amigos.Count < nombremascorto.Length)//si alguno de los amigos tiene el nombre mas corto que el amigo designado
                {
                    Console.WriteLine("El nombre mas corto es {0}", nombremascorto = amigos[i]); //asigna los nombres mas cortos a la lista general
                    listaNuevosAmigos.Add(nombremascorto = amigos[i]);
                    foreach (var a in listaNuevosAmigos)
                    {

                        Console.WriteLine("Los nuevos amigos invitados son: {0}", a);
                    }
                }
            }
           
        }
    }
}
 