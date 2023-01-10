using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Array
{
    /// <summary>
    /// Desafio: Consiste en poner a 2 jugadores a jugar el juego del gato, utlizando un array bidimencional
    /// </summary>
    public class JuegoGato
    {
        int jugador = 2;
        int ingreso = 0;
        char XoX = ' ';
        static int turnos = 0;
        bool ingresoCorrecto = true;
        /// <summary>
        /// Se crea una matriz bidereccional
        /// </summary>
        static char[,] matriz =
        {
            {'1','2','3' },
            {'4','5','6' },
            {'7','8','9' }
        };
        /// <summary>
        /// Se vuelve a crear una matriz para reasignar los valores una vez que exista algun ganador 
        /// </summary>
        static char[,] matrizinicial =
       {
            {'1','2','3' },
            {'4','5','6' },
            {'7','8','9' }
        };
        /// <summary>
        /// Se crea una matriz y se le concatena los valores del array  con su ubicacion
        /// </summary>
        public  static void CrearMatriz()
        {
            Console.Clear();
            Console.WriteLine(" _   _   _");
            Console.WriteLine("|{0}| |{1}| |{2}|", matriz[0,0], matriz[0,1], matriz[0,2]);
            Console.WriteLine(" _   _   _");
            Console.WriteLine("|{0}| |{1}| |{2}|", matriz[1, 0], matriz[1, 1], matriz[1, 2]);
            Console.WriteLine(" _   _   _");
            Console.WriteLine("|{0}| |{1}| |{2}|", matriz[2, 0], matriz[2, 1], matriz[2, 2]);
            Console.WriteLine(" _   _   _");
            turnos++;
        }
        /// <summary>
        /// Se inicia el juego, de la siguiente manera:
        /// 1/o. Se crea un bucle para seleeccionar los turnos, siempre que la consola registre un ingreso (como un enter)
        /// 2/o. Se llama a la matriz
        /// 3/o. Se crea otro bucle para ingresar un numero de la matriz, siempre y cuando el valor se pueda convertir a numero 
        /// </summary>
        public void IniciarJuego()
        {
            
            do
            {
                if (jugador == 1)
                {
                    jugador = 2;
                    Console.WriteLine("Jugador 2");
                    PosiblesIngresos(2, ingreso);

                }else if (jugador == 2)
                {
                    jugador = 1;
                    Console.WriteLine("Jugador 1");
                    PosiblesIngresos(1, ingreso);
                }

          
            CrearMatriz();
                #region Matriz de posibilidades ganadoras
                //Se crea una matriz de dos signos 
                char[] signos = { 'X', 'O' };
                //Se recorre una letra en el array de signos
               foreach(char xox in signos)
                {
                    //Si la letra es igual a las tres posiciones en la matriz 
                    if (  (matriz[0,0] == xox) && (matriz[0,1] == xox) && (matriz[0,2] == xox)//--
                        ||(matriz[1,0] == xox) && (matriz[1, 1] == xox) && (matriz[1, 2] == xox)//--
                        ||(matriz[2, 0] == xox) && (matriz[2,1] == xox) && (matriz[2,2] == xox)//--
                        || (matriz[0, 0] == xox) && (matriz[1, 0] == xox) && (matriz[2, 0] == xox)//|
                        || (matriz[0, 1] == xox) && (matriz[1, 1] == xox) && (matriz[2, 1] == xox)//|
                        || (matriz[0, 2] == xox) && (matriz[1, 2] == xox) && (matriz[2, 2] == xox)//|
                        || (matriz[0, 0] == xox) && (matriz[1, 1] == xox) && (matriz[2, 2] == xox)// /
                        || (matriz[2, 0] == xox) && (matriz[2, 1] == xox) && (matriz[2, 2] == xox))
                       
                    {
                        if (xox == 'O')
                       Console.WriteLine("\nFelicidades ha ganado el jugador 1");
                        
                        else
                        Console.WriteLine("\nFelicidades ha ganado el jugador 2");
                        Console.WriteLine("Presione cualquier tecla para reiniciar el juego");
                        Console.Read();
                        ingreso = 0;//se reinician los ingresos en ceros
                        Resetear();//Se llama al metodo resetear
                        break;
                    }else if (turnos == 10)//Si los turnos es igual a 10 ingresos, entonces se considera empate
                    {
                        Console.WriteLine("\nEmpates!!");
                        Console.WriteLine("Presione cualquier tecla para reiniciar el juego");
                        Console.Read();
                        ingreso = 0;
                        Resetear();
                        break;
                    }
                   
                }
                #endregion

                do
                {
                Console.WriteLine("ERES EL JUGADOR {0} INGRESA UN VALOR.....", jugador);
                
                    try
                    {
                        ingreso = Convert.ToInt32(Console.ReadLine());//    Se registran los ingresos y se atrapa el valor erroneo ingresado en la matriz
                    }catch(Exception ) { Console.WriteLine("Ingresa un valor correcto!"); }

                    #region compara valores que ya existen
                    //Aqui el programa compara si el valor ingresado ya existe, si no existe continua con la ejecucion 
                    //y en caso contrario si, si existe le pide que ingrese otro valor 
                    if ((ingreso == 1) && (matriz[0, 0]) == '1')
                        ingresoCorrecto = true;
                    else if (ingreso == 2 && matriz[0, 1] == '2')
                        ingresoCorrecto = true;
                    else if (ingreso == 3 && matriz[0, 2] == '3')
                        ingresoCorrecto = true;
                    else if (ingreso == 4 && matriz[1, 0] == '4')
                        ingresoCorrecto = true;
                    else if (ingreso == 5 && matriz[1, 1] == '5')
                        ingresoCorrecto = true;
                    else if (ingreso == 6 && matriz[1, 2] == '6')
                        ingresoCorrecto = true;
                    else if (ingreso == 7 && matriz[2, 0] == '7')
                        ingresoCorrecto = true;
                    else if (ingreso == 8 && matriz[2, 1] == '8')
                        ingresoCorrecto = true;
                    else if (ingreso == 9 && matriz[2, 2] == '9')
                        ingresoCorrecto = true;
                    else
                    {
                        Console.WriteLine("\nIngresa otro valor...");
                        ingresoCorrecto = false;
                    }
                    #endregion

                   
                } while (!ingresoCorrecto);//Si el ingreso es correcto, continua la ejecucion

            } while (true);//Mientras se siga registrando una entrada, este continuara ejecutandose

        }
        /// <summary>
        /// Este metodo realiza las siguientes funciones:
        /// 1/o. Se asigna un signo de acuerdo al jugador seleccionado
        /// 2/o. Se asigna el signo a la posicion de la matriz 
        /// </summary>
        /// <param name="jugador"></param>
        /// <param name="ingresos"></param>
        public void PosiblesIngresos(int jugador, int ingresos)
        {
            char XoO = ' ';
            if (jugador == 1)
            {
                XoO = 'X';
            }else if (jugador == 2)
            {
                XoO = 'O';
            }
            
            switch (ingresos)
            {
                case 1:
                    matriz[0, 0] = XoO;
                    break;
                case 2:
                    matriz[0, 1] = XoO;
                    break;
                case 3:
                    matriz[0, 2] = XoO;
                    break;
                case 4:
                    matriz [1,0] = XoO;
                    break;
                case 5:
                    matriz[1,1] = XoO;
                    break;
                case 6:
                    matriz[1,2] = XoO;
                    break;
                case 7:
                    matriz[2, 0] = XoO;
                    break;
                case 8:
                    matriz[2,1] = XoO;
                    break;
                case 9:
                    matriz[2,2] = XoO;
                    break;

            }
        }
        /// <summary>
        /// Este metodo le asigna los valores reseteados a la matriz modificada
        /// 
        /// </summary>
      public static void Resetear()
        {
          
            matriz = matrizinicial;
            CrearMatriz();
            turnos = 0;
          
        }

        
    }
}
