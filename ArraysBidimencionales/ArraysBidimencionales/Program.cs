using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace ArraysBidimencionales
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Creacion de un array bidimencional
            int[][] irregular = new int[3][];
            //inicializar valores
            irregular[0] = new int[5];// el prim. array tiene 5 valores
            irregular[1] = new int[3];
            irregular[2] = new int[2];
            //asignar valores 
            irregular[0] = new int[] { 1, 2, 3, 4, 5 };
            irregular[1] = new int[] { 1, 2, 3 };
            irregular[2] = new int[] { 1, 2 };

            //Creacion de unarrays bidimencional de mandera simplificada
            int[][] irregular2 = new int[3][] {
            new int []{ 1,2,3,4,5}, 
            new int []{ 1,2,3},
            new []{ 1,2},
            };

            //Para imprimir un valor
            Console.WriteLine("El valor del medio del primer array es {0}", irregular2[0][2]);

            // Crear un loop for para acceder a todos los valores del array
            for (int i = 0; i < irregular2.Length; i++)
            {
                Console.WriteLine("los valores del array son {0}", irregular2.Count());
                for (int j = 0; j < irregular2[i].Length; j++)
                {
                    Console.WriteLine("El valor de j es {0}", irregular2[i][j]);
                }
            }

            // CREAR UN ARRAY IRREGULAR QUE TENGA 3 ARRAYS INTERNOS DE DIF TAMAOS Y PONER NOMBRES DE PERSONAS EL 1ER DE 2, 4,3
            //IMPRIMR 4 LINAS COMO MIN EN DONDE SE PRESENTEN DOS PERSONA, DE FAMILIAS DISTINTAS

            string[] familiaMay = new string[] {"Casilda", "Daniel" };//creamos otro array simple para poder agregarlo al array llamado familia
            string[][] familia = new string[][]
            {

                new string []{"May","Jul" },
                new string[]{"Alex", "Arvizu","Pao", "Iris" },
                new string[]{"Cesar", "Fany", "Zara"},
                familiaMay//agragamos el array  externo (importante: Hay que declararlo antes del array principal)
            };
            Console.WriteLine("Hola soy {0} mucho gusto soy {1}", familia[0][0], familia[1][0]);
            Console.WriteLine("Hola soy {0} mucho gusto soy {1}", familia[0][1], familia[2][1]);
            Console.WriteLine("Hola soy {0} mucho gusto soy {1}", familia[1][2], familia[0][1]);
            Console.WriteLine("Hola soy {0} mucho gusto soy {1}", familia[2][0], familia[1][2]);
            Console.WriteLine("Hola soy {0} mucho gusto soy {1}", familia[3][0], familia[1][2]);//llamamos al array 4 pero con el nombre de la familia grande (llamo los datos de FamiliaMay con el nombre de familia)

           



            Console.Read();
        }
    }
}
