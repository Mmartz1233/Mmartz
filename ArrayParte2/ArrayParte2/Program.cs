using System;
using System.Collections.Generic;//Namespace para agregar listas
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;//Namespace para agregar arraysList


namespace ArrayParte2
{
    public class Program
    {
        public static void CreacionArrays()
        {
            //Sintaxis para crear un array irregular
            int[][] irregular = new int[3][];
            //Sintaxis para inicializar un array
            irregular[0] = new int[5];
            irregular[1] = new int[3];
            irregular[2] = new int[2];
            //Sintaxis para asignar valores a un array
            irregular[0] = new int[] { 1,2,3,4,5};
            irregular[1] = new int[] { 1,2,3};
            irregular[2] = new int[] {1,2 };

            //Sintaxis para crear un array, inicializarlo y asignarle valores
            int[][] irregular2 = new int[][] {
            new int[] { 1,2,3,4,5},
            new int[] { 1, 2, 3 },
            new int[] { 1, 2 }
            };

            //Sintaxis para encontrar un valor en un array 
            Console.WriteLine("El valor del medio del primer array es {0}", irregular2[0][2]);//se ingresa el valor del array y la posicion del valor

        }
        /// <summary>
        /// Este desafio consiste en recorrer los dos arrays iiregulares 
        /// El primer array [0] tiene dos valores (1,20)
        /// El segundo array[1] tiene tres valores (3,4,5)
        /// 
        /// </summary>
        public static void Desafio()
        {
            int[][] matrizIrregular = new int[2][];
            matrizIrregular[0] = new int[2] {1,20};
            matrizIrregular[1] = new int[3] {3,4,5};
        
            //El primer array recorre toda la matriz y se los asigna a "i"
            for  (int i = 0; i < matrizIrregular.Length; i++)
            {
                Console.WriteLine("los valores del array son  {0}", i);
                //El segundo array recorre los valores asignados a "i"
                for (int j = 0; j < matrizIrregular[i].Length; j++)
                {
                    Console.WriteLine("ver {0}", matrizIrregular[i][j]);//Imprime las ubicaciones del array
                }
            }
        }
        /// <summary>
        /// Desafio: fiesta 
        /// 3 familias (2)(4)(3)
        /// 4 lineas la presentacion entre dos miembroos de diferentes familias 
        /// </summary>
        public static void DesafioFiesta()
        {
            //creamos un array irregular
            string[][] familia = new string[3][];
            familia[0] = new string[2] { "Julio", "Mayra" };
            familia[1] = new string[4] { "Martha", " Javier", " Tona", "Cuau" };
            familia[2] = new string[3] { "Casilda", "Daniel", "Alexis" };
            //Creamos un for que recorre el array familia tres veces
            for( int i = 0; i< familia.Length; i++)
            {
                //Creamos un for que recorre el el contenido de los arrays antes impresos
                for(int j = 0; j < familia[i].Length; j++)
                {
                    if (familia[i][j] != familia[i][1])
                    {
                        Console.WriteLine("Hola como estas {0} yo soy {1} ", familia[i][j], familia[i][1]);
                    }
                   
                }
            }

        }
        /// <summary>
        /// Este metodo devuelve el promedio de un array de numeros, en donde al recorrer todos los numeros lo va sumando
        /// </summary>
        static int suma=0;
        public static double Promedio(int[] numeros)
        {
            
            double promedio;
            int cantidad = numeros.Length;

            for (int i = 0; i < cantidad; i++)
            {
                suma += numeros[i];
                Console.WriteLine(numeros[i]);
                
            }
            promedio = (double)suma / cantidad;
            Console.WriteLine("El promedio es: {0}", promedio);
           return promedio;
        }

      //banco que saldo tiene 4 clientes , metodo darles un credito de 200 
      public static void DesafioBanco()
        {
            int credito = 200;
            int suma = 0;
            int[][] clientes = new int[4][];
            clientes[0] = new int[4] { 120, 102, 012, 1200 };
            clientes[1] = new int[3] {100,200,300};
            clientes[2] = new int[2] { 500,1000};
            clientes[3] = new int[5] { 89,65,63,88,17 };

            for (int i= 0; i< clientes.Length; i++)
            {
                for (int j = 0; j < clientes[i].Length; j++)
                {
                    
                    Console.WriteLine("{0}",clientes[i][j]);
                    Console.WriteLine("la suma es {0}", clientes[i][j] + credito);
                }
            }

        }
        /// <summary>
        /// En este metodo se expondran las sintaxis para la declaracion de arrayList
        /// </summary>
        public static void ArraisList()
        {
            //Sintaxis para crear un arraylist indeterminado (Puede tener un numero indeterminado de valores)
            ArrayList miarraylist = new ArrayList();

            //Sintaxis para crear un arraylist determinado (Puede tener un numero especifico de valores )
            ArrayList miarraylist2 = new ArrayList(100);

            //Sintaxis para agregar valores al arraylist
            miarraylist.Add(20);
            miarraylist.Add("Hola");
            miarraylist.Add(2.0);
            miarraylist.Add('a');
            miarraylist.Add("Hi");
            miarraylist.Add(100);
            miarraylist.Add(3.5);

            //Sintaxis para eliminar valores al arraylist
            miarraylist.Remove(2.0);
            //sintaxis para eliminar valores por posicion
            miarraylist.RemoveAt(0);
            //Sintaxis para contar los elementos que hay en un arraylist 
            Console.WriteLine("contador {0}",miarraylist.Count);

            //Sintaxis para recorrer los elementos de un arraylist dentro de un loop
            foreach (object obj in miarraylist)
            {
                Console.WriteLine("ver {0}",obj);
            }

        }
        /// <summary>
        /// Este metodo contiene sintaxis de las diferentes formas de declarar una lista
        /// </summary>
        public static void Listas()
        {
            
            //Sintaxis para declarar una lista 
            var numeros = new List<int>();
            List<int> lista = new List<int>() { 1, 9, 2, 3, 4, 5, 5 ,89};
            //Sintaxis para ordenar una lista
            lista.Sort();
            //Sintaxis para crear una lista con valores
            var numeros2 = new List<int> { 1, 2, 3, 4 };
            //sintaxis para agregar valores a una lista
            numeros.Add(7);
            //Sintaxis para eliminar un rango de datos (uno es el indice y otro son los datos a eliminar a la derecha)
            lista.RemoveRange(0, 2);
            
            //sintaxis para eliminar valores de una lista
            numeros.Remove(7);
            //Sintaxis para remover un elemento de una posicion especificada por indices
            int indice = 0;
           //numeros.RemoveAt(indice);
            //Sintaxis para asignar a una variable el valor del indice 0 en la lista 25
            numeros.Add(8);
            //int valor = numeros[1];
            //Sintaxis para limpiar o vacear una lista
            numeros.Clear();
            //Sintaxis para mostrar el valor de las listas utlizado foreach
            var numeros3 = new List<int> { 1, 2, 3, 4, 5, 56, 2 };
            foreach(int elemento in numeros3)
            {
                Console.WriteLine("Elemento:{0}",elemento);
            }
            //Sintaxis para mostrar el valor de las listas utlizado for
            for (int i = 0; i < numeros3.Count; i++)
            {
                Console.WriteLine("Elemento:{0}",numeros3[i]);
            }

            foreach (int item in lista)
            {
                Console.WriteLine("item {0}", item);
            }
            //Sintaxis para encontrar un valor en una lista
            Console.WriteLine("Esta lista contiene el valor 89? {0}", lista.Contains(89));

            //Sintaxis para obtener el inidice de un valor determinado 
            int ind = lista.FindIndex(x => x == 89);
            Console.WriteLine("El valor 84 esta en la posicion: {0}", lista[ind]);

            //Sintaxis para imprimir valores utilizando foreach con una expresion lamda en una lista
            lista.ForEach(i => Console.WriteLine("El contenido de la lista es: {0}", i));

        }


        static void Main(string[] args)
        {
            int[] numeros = new int[] { 9, 9, 9, 9, 9, 9, 9, 9 };
            //Promedio(numeros);
            //DesafioFiesta();
            //Desafio();
            //CreacionArrays();
            //DesafioBanco();
            //ArraisList();
            Listas();
            Console.Read();
        }
    }
}
