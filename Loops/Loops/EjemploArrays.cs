using System;

namespace Loops
{
    public class EjemploArrays
    {
     public void Calificaciones()
        {
            ///<summary>
            ///Ejemplo de creacion de arrays
            /// </summary>
            int[] calificaciones = new int[5];
            calificaciones[0] = 10;
            calificaciones[1] = 9;
            calificaciones[2] = 8;
            calificaciones[3] = 6;
            calificaciones[4] = 7;
            Console.WriteLine("La primera calificacion es {0}", calificaciones[0]);

            ///<summary>
            ///Ejemplo de asignar valores a un array
            /// </summary>
            /*Console.WriteLine("Ingresa una calificacion");
            string respuesta = Console.ReadLine();
            calificaciones[0]= int.Parse(respuesta);
            Console.WriteLine("La primera calificacion es {0}", calificaciones[0]);*/

            ///<summary>
            ///Ejemplo de creacion de arrays de otra forma
            /// </summary>
            int [] faltas = {2,3,4,5 };

            ///<summary>
            ///Ejemplo de creacion de arrays de otra forma
            /// </summary>
            int [] creditos = new int[] {12,22,32,42 };
            Console.WriteLine("El array creditos tiene una longitud de {0}", creditos.Length);

            ///<summary>
            ///Ejemplo de lectura de un array con for
            /// </summary>
            int[] numeros = new int[5];
            //For para incorporar valores al array
            for (int i = 0; i < numeros.Length; i++) {
                numeros[i] = i; 
            }
            //Imprimir el contenido de los indices del array
            for (int j=0; j<numeros.Length;j++)
            {
                Console.WriteLine("El valor del indice {0} es {1}", j, numeros[j]);
            }

            ///<summary>
            ///Ejemplo for each
            ///Para cada uno de los casos que existe en el array ejecuta lo siguiente
            /// </summary>
            foreach(int i in numeros)
            {
                Console.WriteLine("El valor del indice {0} es {1} en un foreach", i, numeros[i]);
            }
            string[] amigos = {"Arvizu", "Paola", "Irene", "Estefania" };
            foreach(string s in amigos)
            {
                Console.WriteLine("Hola {0} TQM", s);
            }
            ///<summary>
            ///Ejemplo array Multidimencionales
            ///
            /// </summary>
            //declaracion de un array de dos simenciones
            string[,] matriz2d;
            string[,,] matriz3d;
            //inicializar array de 2d
            string[,] array2d = new string[,]
            {
                {"A", "B", "C"},
                {"C", "D", "E"},
                {"F", "G", "H"},

            };
            /*para imprimir un valor en especifico de un array bidireccional, 
            es necesario seleccionarlo como si fuera una coordenada x,y*/
            Console.WriteLine("Imprime el valor central {0}", array2d[1,1]);
            Console.WriteLine("imprime el valor de la esquina inferior derecha {0}", array2d[2,0]);

            //Ejemplo de inicializar un array de tres dimenciones
            string[,,] array3d = new string[,,]
            {
                {
                {"A", "B", "C"},
                {"C", "D", "E"},
                {"F", "G", "H"},
                },
                {
                {"I", "J", "K"},
                {"L", "M", "N"},
                {"O", "P", "Q"},
                },
                {
                {"R", "S", "T"},
                {"U", "V", "W"},
                {"X", "Y", "Z"},
                }

            };
            Console.WriteLine("el valor de M es {0}", array3d[1,1,1] );
            Console.WriteLine("el valor de M es {0}", array3d[1, 2,1]);

            ///<summary>
            ///otra forma de inicializar variables, de un array bidireccional de tres filas por dos columnas
            /// </summary>
            string[,] otroarray2d = new string[3, 2]
            {
                    {"A","B" },
                    {"C","D" },
                    {"E","F" }
             };
            //RETO: Modificar un valor de un array
            Console.WriteLine("Conoce el valor de la posicion (0,0) = {0}", otroarray2d[0,0] );
            Console.WriteLine("ingresa el valor a cambiar de la posicion (0,0)");
            otroarray2d[0, 0] = Console.ReadLine();
            Console.WriteLine("Conoce el nuevo valor de la posicion (0,0) = {0}", otroarray2d[0, 0]);
            //Para conocer las dimensiones del array
            int dimension = otroarray2d.Rank;
            Console.WriteLine("las dimensiones del array {0}", dimension);


        }

    }
}