using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace MetodosconParametrosTipoArray
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] calificaciones = new int[] { 10, 9, 8, 9 };//creamos el array calificaciones
            double promresultado = ObtenerProm(calificaciones);//le pasamos el array al metodo y lo almacenamos en una varible
            Console.WriteLine("el promedio es {0}", promresultado);//imprimimos el valor de la varible
            foreach (int nota in calificaciones)//recorremos el array con un foreach
            {
                Console.WriteLine("la calificacion es {0}", nota);
            }

            ///<param name="args">
            ///Metodo para llamar a un array al cual se le van a agregar 200
            /// </param>
            int[]creditos = new int[] { 10, 9, 8, 9 };
            int resultado = AddCredito (creditos);
            foreach (int i in creditos)
            {
                Console.WriteLine("Nuevo credito {0}", i+200);
            }
            ArrayList();
            Listas();
            Console.Read();
        }
        /// <summary>
        /// Creamos un metodo en donde va a devover un double y se le va a pasar un array
        /// </summary>
        /// <param name="arraypuntajes"></param>
        /// <returns></returns>
        static double ObtenerProm(int[] arraypuntajes)
        {
            int cantidad = arraypuntajes.Length;//almacenamos en una variable el tamanio del array
            double promedio;
            int suma = 0;
            for (int i = 0; i < cantidad; i++)
            {
                suma += arraypuntajes[i];//igual a si misma mas arraypuntajes en posicion 1
            }
            promedio = (double)suma / cantidad;//sacamos el promedio
            return promedio;

        }
        static int AddCredito(int[] arraycredito)
        {
            int cantidades = arraycredito.Length;
            
            int suma = 0;
            for (int i = 0; i < cantidades; i++)
            {
                suma += arraycredito[i];
            }
            int cred = suma + 200;
            return cred;
        }
        public static void ArrayList()
        {
            double suma = 0;
            ArrayList nombre = new ArrayList();//Creacion de un arraylist
            nombre.Add(25);//Para agregar un entero al arraylist 
            nombre.Add("Me");//Para agregar un string al arraylist
            nombre.Add(120.2);//Para garegar un double al arraylist
            nombre.Add('A');//Para agregar un char al array list
            nombre.RemoveAt(2);
            Console.WriteLine(nombre.Count);
            foreach (object obj in nombre)
            {
                if(obj is int)
                {
                    suma += Convert.ToDouble(obj);
                }else if (obj is double)
                {
                    suma+=(double)obj;
                }else if (obj is string)
                {
                    Console.WriteLine(obj);
                }
            }
            Console.WriteLine(suma);
        }
        public static void Listas()
        {
            var numeros = new List<int>();//Declaracion de una lista
            var numeros2 = new List<int> { 1, 2, 3, 3, 4 };//Declaracion de una lista con parametros
            numeros2.Add(21);//para agregar un valor 

            int indice = 0552;//agrega este en el ultimo lugar de la lista
            numeros2.Add(indice);
            int valor = numeros2[1];//agrega el valor del indice 2 en la ultimo lugar
            numeros2.Add(valor);
            //numeros2.Clear();//Eliminar todos los elementos de la lista
            numeros2.Sort();//Para ordenar de menor a mayor
            Console.WriteLine("Existe el valor 120? {0}",numeros2.Contains(120));//Para ver si  contiene un valor específico y devuelve un bool
            int indice2 = numeros2.FindIndex(x => x == 4);
            Console.WriteLine("Para verificar si existe el valor {0} en la lista",numeros2[indice2]);
            foreach (int elemento in numeros2)
            {
                Console.WriteLine(elemento);

            }






        }

    }
}
