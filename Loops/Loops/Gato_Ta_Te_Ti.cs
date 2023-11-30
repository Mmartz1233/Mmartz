using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    public class Gato_Ta_Te_Ti
    {
        int turno = 2;
        int ingreso = 0;

        public void Turnos()
        {
            do
            {
                if (turno == 1)
                {
                    turno = 2;
                    if (turno == 2)
                    {
                        turno = 1;
                    }
                }

                //switch (turno)
                //{
                //    case 1:  
                //            switch (ingreso)
                //            {
                            
                //            }
                                
                                 
                //}

              
            }
            while (true);

        }

       

            static string[,] arrai = new string[,]
            {
                {"1", "2", "3"},
                {"4", "5", "6"},
                {"7", "8", "0"},

            };
        
        public static void CrearMatriz()
        {
            Console.WriteLine("___|___|___");
            Console.WriteLine("_{0}_|_{1}_|_{2}_", arrai[0, 0], arrai[0, 1], arrai[1, 1]);
            Console.WriteLine("_{0}_|_{1}_|_{2}_", arrai[1, 0], arrai[1, 1], arrai[1, 1]);
            Console.WriteLine("_{0}_|_{1}_|_{2}_", arrai[2, 0], arrai[2, 1], arrai[2, 1]);
            Console.WriteLine("___|___|___");

        }



    }
}
