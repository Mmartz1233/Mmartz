using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoDeGato
{
    public  class Program
    {
        int jugador = 2;
        int ingresos = 0;
        char signo = ' ';
        int turnos=0;
        bool ingresoCorrecto = true;
        static char[,] matriz =
        {
            {'1', '2', '3'},
            {'4', '5', '6'},
            {'7', '8', '9'}
        }; 
        public static void CrearMatriz()
        {
            Console.WriteLine("___|___|___");
            Console.WriteLine("_{0}_|_{1}_|_{2}_", matriz[0,0], matriz[0,1], matriz[1,1]);
            Console.WriteLine("_{0}_|_{1}_|_{2}_");
            Console.WriteLine("_{0}_|_{1}_|_{2}_");
            Console.WriteLine("___|___|___");

        }
        static void Main(string[] args)
        {
        }
    }
}
