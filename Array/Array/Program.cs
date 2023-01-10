using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;


namespace Array
{
    /// <summary>
    /// Array: Almacena una cantidad fija de elementos. Solo elementos del mismo tipo entre si.
    /// Ideal para almacenar una coleccion de datos
    /// </summary>
    public class Program
    {
        public static void SintaxisArrays()
        {
            //Sintaxis para declarar una matriz
            int[] nuemeros;
            //Sintaxis para inicializar una matriz
            int[] nuemeros2 = new int[5];//indica cuantos elementos debe tener una matriz
            nuemeros2[0] = 7;//Sintaxis para asignar valores a un array
            nuemeros2[1] = 6;//Indica que el inidce 1 se le asigna el valor 6
            int[] edades = { 0, 15, 10, 17 };// Sintaxis para crear un array asignando valores 
            int[] faltas = new int[] { 1, 5, 3, 7, 9, 4 };//Sintaxis para crear un array, inicializarlo y asignarle valores
            Console.WriteLine("Numero de faltas {0}",faltas.Length);//Sintaxis para obtener el largo de un array
            int[,] matriz2D;//sintaxis para declarar un array de 2 dimensiones
            int[,,] matriz3D;//sintaxis para declarar un array de 3 dimensiones
            //Sintaxis para declarar , inicializar y asignar valores un array 2d
            int[,] array2D = new int[,]
            {
            {1,2,3 },
            {4,5,6 },
            { 7,8,9}
            };
            //Sintaxis para declarar, inicizalizar y asignar valores a una matriz en 2D
            int[,] array22D = new int[3,2] //3 filas 2 columnas
            {
            {1,2 },
            {3,4 },
            {5,6 } 
            };

            //Sintaxis para encontrar un valor(y,x)(de arriba a abajo y de izq a der)
            Console.WriteLine("El valor  es {0}", array2D[2,2]);
            //sintaxis para declarar , inicializar y asignar valores un array 3d
            int[,,] array3D = new int[,,] {
            {
            {1,2,3 },
            {4,5,6 },
            { 7,8,9}
            },
            {
            {10,11,12 },
            {13,14,15 },
            {16,17,18}
            },
            {
            {19,20,21 },
            {22,23,24 },
            { 25,26,27}
            }
            };
            //Sintaxis para encontrar un valoren una matriz 3D(tabla, y,x)
            Console.WriteLine("El valor buscado es{0}", array3D[2,1,0]);
            int dimensiones = array22D.Rank;//sintaxis para obtener el numero de dimensiones de un array
            Console.WriteLine("Las dimensiones del array son {0}", dimensiones);
            int[,] matrix2d = { {1,2 },{3,4} };//sintaxis para crear un array sin especificar las dimensiones

        }
        
        public static void Calificaciones()
        {
            int[] calificaciones = new int[5];
            calificaciones[0] = 10;
            calificaciones[1] = 9;
            calificaciones[2] = 8;
            calificaciones[3] = 7;
            calificaciones[4] = 5;
            string ingreso = Console.ReadLine();
            calificaciones[0]= int.Parse(ingreso);
            Console.WriteLine("Primera calificacion {0}", calificaciones[0]);
        }

        //El loop For-each lo podemos usar para obtener los valores del araid o asignar valores
        public static void LoopForinArrays()
        {
            int[] numeros = new int[16];
            //asigamos valores empleando el loop for:
            for (int i=0; i < numeros.Length; i++)
            {
                numeros[i] = i+2;
            }
            //para imprimir los valores asignados al loop
            for (int j=0; j<numeros.Length; j++)
            {
                Console.WriteLine("La posicion {0} tiene asignado {1}",j, numeros[j]);
            }

        }
        public static void LoopForEachinArrays()
        {
            int[] numeros = new int[10];
            //asignar valores
            for (int i = 0; i< numeros.Length; i++)
            {
                numeros[i] = i;//el valor del indice i es ?
            }
            foreach (int k in numeros)
            {
                Console.WriteLine("El indice {0} contiene el valor {1}",k, numeros[k] );
            }
        }
        
        /// <summary>
        ///El desafio consiste en declarar el nombre de 5 amigos y dedicarle un saludo a cada uno de ellos
        /// </summary>
        public static void Desafio1()
        {
            //declarar el array
            string[] amigos = { "Iris", "Paola","Arvizu","Sunun","Erick"};
            // recorra el array 
            foreach(string k in amigos)
            {
                Console.WriteLine("Hola {0}",k);
            }

        }
        /// <summary>
        /// El lina codigo, permita modificar el valor de un array bidimencional
        /// </summary>
        public static void Desafio2()
        {
            

            Console.WriteLine("Modifica el valor");
            string modificado = Console.ReadLine();
            int[,] array2d = new int[3, 2] 
            {
            {1,2 },
            {3,4 },
            {5,6 } 
            };
            Console.WriteLine("El valor encontrado es {0}", array2d[2, 1]);
            array2d[2, 1] = int.Parse(modificado);
            Console.WriteLine("El valor modificado es {0}", array2d[2, 1]);
        }
     
        
        static void Main(string[] args)
        {

            /*SintaxisArrays();
            Desafio1();
            LoopForEachinArrays();
            LoopForinArrays()
            
            Calificaciones();
            Desafio2();*/
            JuegoGato juegoGato = new JuegoGato();
            
            juegoGato.IniciarJuego();
            

            Console.Read();
        }

    }
}
