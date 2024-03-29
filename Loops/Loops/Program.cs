﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    //Tipos de loops: For, While, Do-While, Foreach
    public class Program
    {
        static void Main(string[] args)
        {
            ///<summary>
            ///Reto:Crear un juego de Gato, que tenga lo siguiente:
            ///1. Turnos
            ///2. un ganador
            ///3. permita repetir el proceso, por si quieren llegar a repetirlo
            ///4. Hacer las multiples combinaciones que se realizan en ungato
            /// </summary>
            //Turnos
            Gato_Ta_Te_Ti gato = new Gato_Ta_Te_Ti();
            gato.Turnos();



            ///<summary>
            ///Ejemplo de creaciones de instacias
            /// </summary>
            Humano humano = new Humano();
            Humano humano1 = new Humano();
            Caja caja = new Caja();
            ///<summary>
            ///Ejemplo de la utilizacion de Propiedades en un constructor
            /// </summary>
            Caja caja1 = new Caja(2, 3, 3);
            
            /*Console.WriteLine("El volumen es {0}", caja1.Volumen);
            Console.WriteLine("La superficie frontal es {0}", caja1.Superficiefrontal);*/

            /// <summary>
            /// Ejemplo utilizando constructores y destructores
            /// </summary>
            Miembros miembros = new Miembros();
           // miembros.Amigo(true);
          
            ///<summary>
            ///Ejemplo de acceder a una variable y asignarle un valor
            /// </summary>
            humano.prmiernombre = "Julio";
            humano.apellido = "Huerta";
            humano1.prmiernombre="Cesar";
            humano1.apellido = "Estrada";
            ///<summary>
            ///Ejemplo de llamada de metodos en una instancia
            /// </summary>

            /*humano.Presentarme();//llamamos a un metodo de la clase humano
            humano1.Presentarme();*/

            ///<summary>
            ///Ejemplo de utilizacion de arrays
            /// </summary>
            EjemploArrays calificaciones = new EjemploArrays();
            //calificaciones.Calificaciones();

            ///<summary>
            ///Ejemplo de llamada de muchos constructores con diferentes parametros
            /// </summary>
            Humano Constructor = new Humano("Mayra", "Martinez", 1, "Cafes");//Cargamos el constructor parametrizado
            Humano Constructor2 = new Humano("Alexis", "Martinez", 25, "Cafes");
            Humano Constructor3 = new Humano("Casilda", 15000);
            Humano Constructor4 = new Humano("Daniel", "Licenciatura");
           /* Constructor.Presentarme();
            Constructor2.Presentarme();
            Constructor3.Presentarme();
            Constructor4.Presentarme();*/

            ///<summary>
            ///Ejemplo de llamar a metodos de la misma clase
            /// </summary>
            //PromedioAlumno();
            //NumerosImpares();
            //EjemploContinue();
            // EjemploBreak();
            //EjemplosFor();
            // EjemplosDoWhile();
            // EjemplosWhile();
            Console.Read();
        }
        public static void EjemplosWhile()
        {
            //Primero revisa la condicions y luego ejecuta (no imprime sin revisar)
            Console.WriteLine("***************Ejemplos con While*****************");
            int pulsaciones = 0;
            Console.WriteLine("Presiona enter");
            string enter = Console.ReadLine();
            string textoingresado = "";
            while (enter == textoingresado)
            {
                Console.WriteLine("Numero de personas en el bus {0}", pulsaciones);
                enter = Console.ReadLine();
                pulsaciones++;
            }
        }
        public static void EjemplosFor()
        {
            Console.WriteLine("Ejemplo con For");
            for (int contador = 0; contador < 10; contador += 2)
            {
                Console.WriteLine("El valor de contador es: {0}", contador);
            }
            Console.WriteLine("Numeros impares");
            for (int contador = 1; contador < 20; contador += 2)
            {
                Console.WriteLine("El numero impar es: {0}", contador);
            }
        }
        public static void EjemplosDoWhile()
        {
            //Primero ejecuta y luego revisa la condicions (por lo menos una  vez imprime sin revisar)
            int contador = 15;
            do
            {
                contador++;
                Console.WriteLine("Contador {0}", contador);
            }
            while (contador < 5);

            int largodetexto = 0;
            string textocompleto = "";
            do
            {

                Console.WriteLine("Ingresa el nombre de un amigo");
                string noombreamaigo = Console.ReadLine();
                int largoactual = noombreamaigo.Length;
                largodetexto += largoactual;
                textocompleto += noombreamaigo;
            }
            while (largodetexto < 20);
            Console.WriteLine("Gracias, el texto completo fue {0} y la cantidad de letras fueron {1}", textocompleto, largodetexto);
        }
        /***********************************************BREAK***************************************/
        /// <summary>
        /// En esta clase de ejemplo con Break, lo que hace el programa es TERMINAR el programa hasta que llega 
        /// al numero tres, especificada en la condicion.
        /// </summary>
        public static void EjemploBreak()
        {
            for (int cont = 0; cont < 10; cont++)
            {
                Console.WriteLine(cont);
                if (cont == 3)
                {
                    Console.WriteLine("Al tres nos detenemos {0}", cont);
                    break;
                }
            }
        }
        /***********************************************CONTINUE***************************************/
        /// <summary>
        /// En esta clase de Ejemplo con comtinue, lo que hace es SALTARSE el numero tres y muestra todo el recorrido 
        /// al ultimo.
        /// </summary>
        public static void EjemploContinue()
        {
            for (int cont = 0; cont<10; cont++)
            {
                //Console.WriteLine(cont);
                if (cont == 2)
                {
                    Console.WriteLine("Nos saltamos este numero {0}", cont);
                    continue;
                }
                Console.WriteLine(cont);
            }
        }
       /// <summary>
       /// El siguiente programa imprime solo los numeros impares, anteponinedo una leyenda de que el proximo numero sera impar
       /// </summary>
        public static void NumerosImpares()
        {
            for (int cont = 0; cont <10; cont++)
            {
                if (cont%2 == 0)
                {
                    Console.WriteLine("El proximo es impar");
                    continue;
                }
                Console.WriteLine(cont);
            }
        }
   
        /// <summary>
        /// Imagina que eres un desarrollador y obtienes un trabajo en el que necesitas crear un programa para un maestro. 
        ///Él necesita un programa escrito en C# que calcule el puntaje promedio de un estudiante. 
        ///Por lo tanto, quiere poder ingresar cada puntaje de ese alumno individualmente.
        ///Cuando termine de cargar todas las calificaciones del alumno, debe escribir la palabra "fin" para que el programa
        ///le devuelva el promedio que ese alumno ha logrado.
        ///Por lo tanto, la herramienta debe verificar si la entrada es un número y agregarlo a la suma.
        ///Finalmente, una vez que haya terminado de ingresar puntajes, el programa debe escribir en la consola cuál es el
        ///puntaje promedio.
        ///Los números ingresados solo pueden estar entre 1 y 10. Asegúrate de que el programa no se bloquee si el
        ///maestro ingresa un valor incorrecto.
        ///Testea tu programa para asegurarte de que no tenga errores.
        /// </summary>
        public static void PromedioAlumno()
        {
            Console.WriteLine("Bienvenido al sistema de calificaciones");
            Console.WriteLine("Ingresa las calificaciones del alumno");
            string calificacion = Console.ReadLine();
            int pulsaciones = 0;
           
            int calif, suma= 0;
            double promedio;
            while (calificacion != "fin")
            {
               
                if (int.TryParse(calificacion, out calif) && calif>=0 && calif <=10) {
                    Console.WriteLine(" Suma de calificaciones:{0} ", suma += calif);
                    Console.WriteLine("Ingresa otra calificacion del alumno"); 
                    calificacion = Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Has ingresado un dato no valido y por lo tanto finalizo el ejercicio");
                    break;
                   
                }
                pulsaciones++;
            }
            try
            {
                promedio = suma / pulsaciones;/// error detectado
                Console.WriteLine("Promedio : {0}", promedio);
            }
            catch (Exception) { Console.WriteLine("Error"); }


            




        }

    }
}
