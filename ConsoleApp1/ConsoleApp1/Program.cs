using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Security.Permissions;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Cambiar el color de la consola:
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear(); //limpia las ordenes anteriores

            string minombre = "Mayra";
            Console.WriteLine("Hola mundo ya regrese");
            Console.WriteLine("Hola "+minombre);

            /*************************************************************Variables****************************************************************/
            int numero = 10;
            Console.WriteLine("el numero escrito fue "+ numero);
            int numero2 = 15;
            int suma = numero + numero2;
            Console.WriteLine("La suma de los dos numeros "+suma);


            double doble1 = 1.5;
            double doble2 = 2.8;
            double sumadoble = doble1 + numero; 
            Console.WriteLine("La suma de los dos numeros dobles es "+ sumadoble);


            float float1 = 3.5f;
            float float2 = 6.8f;
            float sumafloat = float1 + float2;
            Console.WriteLine("La suma de los dos numero flotantes es: "+sumafloat);


            string cadena1 = "Mayra ";
            string cadena2 = "Martinez";
            Console.WriteLine("Mi nombre es: "+cadena1.ToUpper()+cadena2.ToLower());
            /*******************************************************Llamando metodos*********************************************************/
            EscribeAlgo();
            EscribeAlgoEspecifico("soy un argumento y me llamaron desde un metodo");
            Sumar(5, 8);
            Console.WriteLine(Sumar(5,8));
            Console.WriteLine("La multiplicacion de dos numeros es: "+Multiplicar(8,6));
            Console.WriteLine("La Division de dos numeros es: " + Division(8, 6));
            string Amigo1 = "Iris";
            string Amigo2 = "Paola";
            string Amigo3 = "Arvizu";
            SaludarAmigo(Amigo3);
            IngresosDeUsuario1();
            Console.WriteLine("El resultado es: "+IngresosDeUsuario());
            ManejoErrores();
            Console.Clear(); //limpia las ordenes anteriores
            Operadores();




            Console.ReadLine();
        }
            /*************************************************************Metodos****************************************************************/
        public static void EscribeAlgo()
        {
            Console.WriteLine("Yo naci de un metodo");
            Console.Clear(); //limpia las ordenes anteriores
        }
        public static void EscribeAlgoEspecifico(string miTexto)
        {
            Console.WriteLine(miTexto);
            Console.Clear(); //limpia las ordenes anteriores
        }
        public static int Sumar(int parametro1, int pametro2)
        {
            return pametro2+parametro1;
            
        }
        public static int Multiplicar(int parametro1, int parametro2)
        {
            return parametro1*parametro2;

        }
        public static double Division(double parametro1, double parametro2)
        {
            return parametro1 / parametro2;
        }
        public static string SaludarAmigo(string nombreAmigo)
        {
            string saludo = "Hola " + nombreAmigo;
            Console.WriteLine(saludo);
            return saludo;
        }
        /*********************************************************INGRESOS DE USUARIOS***************************************************************/

       
        public static void IngresosDeUsuario1()
        {
            Console.WriteLine("Ingresa un valor numerico");
            string input1 = Console.ReadLine();//alamacena el valor ingresado
            Console.WriteLine("Ingresa otro valor numerico");
            string input2 = Console.ReadLine();
            int valor1 = int.Parse(input1);
            int valor2 = int.Parse(input2);
            int suma = valor1 + valor2;
            Console.WriteLine("La suma es: "+suma);
           
        }

        public static int IngresosDeUsuario()
        {
            Console.WriteLine("Ingresa un valor numerico");
            string input1 = Console.ReadLine();//alamacena el valor ingresado
            Console.WriteLine("Ingresa otro valor numerico");
            string input2 = Console.ReadLine();
            int valoralm1 = int.Parse(input1);
            int valor2alm2= int.Parse(input2);
            int suma = valoralm1 + valor2alm2;
            return suma;
        }
        /*********************************************************MANEJO DE ERRORES***************************************************************/
        public static void ManejoErrores()
        {
            Console.WriteLine("Manejo de errores con void");
            Console.WriteLine("Ingresa un valor numerico");
            string input1 = Console.ReadLine();//alamacena el valor ingresado
            Console.WriteLine("Ingresa otro valor numerico");
            string input2 = Console.ReadLine();
            int valor1,valor2, suma;
            try
            {
                 valor1 = int.Parse(input1);
                 valor2 = int.Parse(input2);
                 suma = valor1 + valor2;
                 Console.WriteLine("La suma es: " + suma);
            }
            catch (Exception)
            {
                Console.WriteLine("Ingresa el valor correcto");
            }
            finally 
            { 
                Console.WriteLine("Esto sucedera pase lo que pase");
            }

        }
        /*********************************************************OPERADORES***************************************************************/
        
        public static void Operadores()
        {
            int num1 = 3;
            int num2 = 5;
            int num3 =- num1; //cambiamos el valor a lo opuesto del numero del lado opuesto.
            Console.WriteLine("el valor de num3 es: "+num3);

            bool mybool = true;
            bool mybool2 = !mybool;
            Console.WriteLine("Hay sol? {0}",mybool2);

            Console.WriteLine("*****Operadores de adicion*********");
            int num4 = 0;
            num4++;
            Console.WriteLine("La adicion de 0 a: {0}",num4);
            num4++;
            Console.WriteLine("La adicion del de arriba a: {0}", num4++); //este formato aplica a la siguiente linea.
            Console.WriteLine("La adicion del de arriba a: {0}", num4);
            num4--;
            Console.WriteLine("La susbtraccion del numero de arriba es {0}", num4);
            Console.WriteLine("La susbtraccion del numero de arriba es {0}", --num4);//este formato aplica a la linea en curso.
            Console.WriteLine("La susbtraccion del numero de arriba es {0}", --num4);

            Console.WriteLine("*****Operadores matematicos*********");
            int num5 = 4;
            int num6 = 5;
            int suma = num5 + num6;
            int resta = num5 - num6;
            int mult = num5 - num6;
            int div = num5 - num6;
            int modular = num5 % num6;//muestra lo que sobro
            Console.WriteLine("el modulo de: "+modular);

            Console.WriteLine("*****Operadores relacionales*********");
            bool esMenor = true;
            esMenor = num5 < num4;
            Console.WriteLine("La comparacion es: "+esMenor);

            Console.WriteLine("*****Operadores de igualdad*********");
            bool esIgual = true;
            esIgual = num5 == num4;
            Console.WriteLine("La comparacion es: " + esIgual);
            Console.WriteLine("La comparacion es lo opuesto: " + !esIgual);

            Console.WriteLine("*****Operadores condicionales*********");
            bool esMenorySoleado = esMenor && mybool; 
            Console.WriteLine("La operacion es {0} y hay sol {1} es igual a {2}", esMenor,mybool, esMenorySoleado);
             esMenorySoleado = esMenor || mybool;
            Console.WriteLine("La operacion es {0} y hay sol {1} es igual a {2}", esMenor, mybool, esMenorySoleado);
        }



    }
}
