using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TomaDeDesiciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor=ConsoleColor.Black;
            Console.ForegroundColor=ConsoleColor.Cyan;
            CondicionesIf();
            CondicionesConIngresosUsr();
            Console.Read();
        }
        public static void CondicionesIf()
        {
            int temp = 5;
            if (temp < 10)
            {
                Console.WriteLine("Abrigate!");
            }
            if (temp > 10)
            {
                Console.WriteLine("La temperatura mayor a 10");
            }
            if (temp == 10)
            {
                Console.WriteLine("La temperatura es de 10");
            }
        }
        //ingrese una temperatura y emita una recomendacion
        public static void CondicionesConIngresosUsr()
        {
            Console.WriteLine("Recomendaciones de ropa para el clima!!");
            Console.WriteLine("Ingresa la temperatura en la ciudad de Mexico");
            string tem = Console.ReadLine();
            int temnumerico;
            try { 
                temnumerico = int.Parse(tem);
                if (temnumerico < 0)
                {
                    Console.WriteLine("Deberias usar ropa termica, hace muchi frio");
                }
                if (temnumerico > 0 && temnumerico < 20)
                {
                    Console.WriteLine("Deberias usar sueteres, hace un poco de frio");
                }
                if (temnumerico > 20 && temnumerico < 40)
                {
                    Console.WriteLine("Deberias usar ropa comoda, el clima esta templado");
                }
                if (temnumerico > 40)
                {
                    Console.WriteLine("Deberias usar ropa ligera, hace mucha calor");
                }

            }
            catch (Exception e)
            {
                Console.WriteLine("Ingresa un dato numerico!!");

            }
            finally
            {
                Console.WriteLine("Fin!");
            }
          

        }
        /**********************************************************METODOS TRY PARSE*****************************************************************/
        //Convertir un string a entero
        public static void ConvertirStringAEntero()
        {
            string numerol = "1238";
            int valorParseado;
        }

    }
}
