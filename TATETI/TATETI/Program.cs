using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TATETI
{
    public class Program
    {
        /// <summary>
        /// Declaracion de variables
        /// </summary>
        static int jugador = 2;
        static int ingreso;
        static bool ingresocorrecto=true;
        static char signo;
        static int turnos;
        static char[] cadasigno = new char[] { 'X', 'O' };//Declaracion de un array que va allenar el tablero con X o O 
        static char[,] conttablero = new char[,] //Creamos el tablero
         {
        { '1', '2','3'},
        { '4', '5','6'},
        { '7', '8','9'}
        };
        static char[,] conttableroinicial = new char[,]//Creamos un tablero identico al inicial, solo que este se va llamar cuando se haya reiniciado el juego
        {
        { '1', '2','3'},
        { '4', '5','6'},
        { '7', '8','9'}
         };

        static void Main(string[] args)
        {
        ///<summary>
        ///Declaramos un do - while para que se ejecute siempre y luego verifique si el usuario es correcto
        /// </summary>

            do
            {
                ///<summary>
                ///Creamos un if - else para hacer el cambio de jugador 
                if(jugador == 2) { //si jugador es igual a 2 entonces cambiara a jugador 1
                    jugador = 1;
                    PonerXoO(jugador, ingreso);//invocamos el metodo que va a definir por que valor sustiturilo 
                }
                else if (jugador == 1)
                {
                    jugador = 2;
                    PonerXoO(jugador, ingreso);
                }
                Tablero();//Llamamos al metodo cada que ingresemos un valor en el tablero 
                do {
                    Console.WriteLine("Jugador {0} Por favor elija un casillero", jugador);
                   
                    turnos++;
                    try
                    {
                        //Verificamos el tipo de ingreso, si es igual a algun numero del 1-9 se le asigna el ingreso a la colocacion 
                        ingreso = Convert.ToInt32(Console.ReadLine());
                        if((ingreso == 1) && (conttablero[0, 0] == '1')) { ingresocorrecto=true;}
                        else if ((ingreso == 2) && (conttablero[0, 1] == '2')) { ingresocorrecto = true; }
                        else if ((ingreso == 3) && (conttablero[0, 2] == '3')) { ingresocorrecto = true; }
                        else if ((ingreso == 4) && (conttablero[1, 0] == '4')) { ingresocorrecto = true; }
                        else if ((ingreso == 5) && (conttablero[1, 1] == '5')) { ingresocorrecto = true; }
                        else if ((ingreso == 6) && (conttablero[1, 2] == '6')) { ingresocorrecto = true; }
                        else if ((ingreso == 7) && (conttablero[2, 0] == '7')) { ingresocorrecto = true; }
                        else if ((ingreso == 8) && (conttablero[2, 1] == '8')) { ingresocorrecto = true; }
                        else if ((ingreso == 9) && (conttablero[2, 2] == '9')) { ingresocorrecto = true; }
                        else
                        {
                            Console.WriteLine("Ingrese otro numero", ingresocorrecto=false); //atrapa un error en caso de no haber ingresado un nuemro
                        }
                        foreach (char signo in cadasigno)// llenamos el tablero  verificando que si cumple con alguna de las siguinetes reglas, el jugador habra ganado
                        {
                            if ((conttablero[0, 0] == signo) && (conttablero[0, 1] == signo) && (conttablero[0, 2] == signo) ||
                                (conttablero[1, 0] == signo) && (conttablero[1, 1] == signo) && (conttablero[1, 2] == signo) ||
                                (conttablero[2, 0] == signo) && (conttablero[2, 1] == signo) && (conttablero[2, 2] == signo) ||
                                (conttablero[0, 0] == signo) && (conttablero[1, 0] == signo) && (conttablero[2, 0] == signo) ||
                                (conttablero[0, 1] == signo) && (conttablero[1, 1] == signo) && (conttablero[2, 1] == signo) ||
                                (conttablero[0, 2] == signo) && (conttablero[1, 2] == signo) && (conttablero[2, 2] == signo) ||
                                (conttablero[0, 0] == signo) && (conttablero[1, 1] == signo) && (conttablero[2, 2] == signo) ||
                                (conttablero[0, 2] == signo) && (conttablero[1, 1] == signo) && (conttablero[2, 0] == signo))
                            {
                                Console.WriteLine("Felicitaciones tenemos un ganador");
                                if (signo == 'X')
                                {
                                    Console.WriteLine("Ha ganado el jugador 2");
                                }
                                else
                                {
                                    Console.WriteLine("Ha ganado el jugador 1");
                                }
                                Console.WriteLine("Presione cualquier tecla para reiniciar el juego");
                                Console.ReadLine();
                                ingreso = 0;
                                Resetear();
                                break;

                            }else if (turnos == 10)
                            {
                                Console.WriteLine("Empate, presione cualquier tecla para reiniciar");
                                Console.ReadLine();
                                Resetear();
                                break;
                            }

                        }
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Por favor ingresa un numero");
                     
                    }
                
                } while (!ingresocorrecto);

            } while (true);


         
          
            Console.Read();
        }
    
        /// <summary>
        /// Creamos Tablero
        /// </summary>
        public static void Tablero()
        {
            Console.Clear();
            Console.WriteLine(" {0} | {1} | {2} ", conttablero[0,0], conttablero[0,1], conttablero[0,2]);
            Console.WriteLine("___  |___  |___  ");
            Console.WriteLine(" {0} | {1} | {2} ", conttablero[1, 0], conttablero[1, 1], conttablero[1, 2]);
            Console.WriteLine("___  |___  |___");
            Console.WriteLine(" {0} | {1} | {2} ", conttablero[2, 0], conttablero[2, 1], conttablero[2, 2]);
          
        }
        /// <summary>
        /// Creamos un metodo en donde le pasamos el numero de jugador y el valor de lo que ingreso
        /// </summary>
        /// <param name="jugador"></param>
        /// <param name="ingreso"></param>
        public static void PonerXoO(int jugador, int ingreso)
        {
            
            if (jugador == 1) // si jugador es igual a 1 entoces se pone una X
            {
                signo = 'X';
            }else if (jugador == 2) // si jugador es igual a 2 entoces se pone una O
            {
                signo = 'O';
            }
            switch (ingreso)//una vez que se define el jugador, verificamos la posicion del ingreso y le agregamos el signo correspondiente 
            {
                case 1:conttablero[0,0]= signo; break;
                case 2: conttablero[0, 1] = signo; break;
                case 3: conttablero[0, 2] = signo; break;
                case 4: conttablero[1, 0] = signo; break;
                case 5: conttablero[1, 1] = signo; break;
                case 6: conttablero[1, 2] = signo; break;
                case 7: conttablero[2, 0] = signo; break;
                case 8: conttablero[2, 1] = signo; break;
                case 9: conttablero[2, 2] = signo; break;
            }

        }
        public static void Resetear()
        {
            conttablero = conttableroinicial;
            Tablero();
            turnos = 0;
        }
     
    }
}
