using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace TomaDeDesiciones
{
    public class Program
    {
        static string nombre;
        static string password;
        static void Main(string[] args)
        {
            
            Console.BackgroundColor=ConsoleColor.Black;
            Console.ForegroundColor=ConsoleColor.Cyan;
            OperacionesTernariasDesafio();
            //DeclaracionIfMejorada();
            //IngresoPuntajes();
            //JuegoPiedraPapelTijeras();
            //EjemploSwitchConIf();
            //EjemploSwitch();
            //Registro();
            //SistemaLogeo();
            //CondicionesIf();
            //CondicionesConIngresosUsr();
            //ConvertirStringAEntero();
            //ConvertirStringFloat();
            //CondicionesTryParse();

            Console.Read();
        }
        public static void CondicionesIf()
        {
            int temp = 5;
            if (temp < 10)
            {
                Console.WriteLine("Abrigate!");
            }
            else if (temp > 10)
            {
                Console.WriteLine("La temperatura mayor a 10");
            }
            else if (temp == 10)
            {
                Console.WriteLine("La temperatura es de 10");
            }
        }
        //Este es un metodo donde el usuario ingresa la temperatura y el programa emite una recomendacion; si el usuario ingresa un valor diferente
        //a un numero, este es captado atravez de un try-catch
        public static void CondicionesConIngresosUsr()
        {
            Console.WriteLine("Recomendaciones de ropa para el clima con excepciones try-catch!!");
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
                Console.WriteLine("Ingresa un dato numerico, excepcion atrapada con try-catch!!");

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
            string numerol = "128s";
            int valorParseado;
            bool funciona;
            funciona = int.TryParse(numerol, out valorParseado);
            Console.WriteLine("funcionara? {0}",funciona);

        }
        //Convertir un string a float
        public static void ConvertirStringFloat()
        {
            string numero2 = "12";
            float valorConvertido;//aqui se almacena el valor convertido
            bool funciona;
            funciona =float.TryParse(numero2 , out valorConvertido);
            Console.WriteLine("funcionara? {0} el valor fue: {1}", funciona, valorConvertido);

        }
        //Este es un metodo donde el usuario ingresa la temperatura y el programa emite una recomendacion; si el usuario ingresa un valor diferente
        //a un numero, este es captado atravez de un try-parse el cual tratara de cambiarlo y en caso de ser negativo el cambio, lanza un mensaje

        public static void CondicionesTryParse()
        {
            Console.WriteLine("Consulta de temperaturas con excepciones try-parse!");
            Console.WriteLine("Ingresa la temperatura actual: ");
            string tem = Console.ReadLine();
            int valortemp;
       
            if (int.TryParse(tem, out valortemp))
            {
                if (valortemp < 0)
                {
                    Console.WriteLine("Deberias usar ropa termica, hace muchi frio");
                }
                else if (valortemp > 0 && valortemp < 20)
                {
                    Console.WriteLine("Deberias usar sueteres, hace un poco de frio");
                }
                else if (valortemp > 20 && valortemp < 40)
                {
                    Console.WriteLine("Deberias usar ropa comoda, el clima esta templado");
                }
                else if (valortemp > 40)
                {
                    Console.WriteLine("Deberias usar ropa ligera, hace mucha calor");
                }
               
            }else
            {
                Console.WriteLine("Ingresa un numero, excepcion atrapada con try-pase! ");
            }
        }
        //sistema de logeo
        public static void SistemaLogeo()
        {
            bool admin = true;
            bool estaregistrado = true;
            Console.WriteLine("Sistema de logeo");
            Console.WriteLine("Ingresa tu nombre de usuario");
            string nombreusuario = Console.ReadLine();
            if (estaregistrado)
            {
                Console.WriteLine("Hola usuario registrado");
                if(nombreusuario != "")
                {
                    Console.WriteLine("Hola {0}", nombreusuario);
                    if (nombreusuario.Equals("admin")){
                        Console.WriteLine("Hola Admin");
                    }
                }
            }
        }
        /* D   E   S   A   F   I   O D   E   S   A   F   I   O D   E   S   A   F   I   O D   E   S   A   F   I   O D   E   S   A   F   I   O
        Crea un sistema de inicio de sesión de usuario, donde el usuario puede primero registrarse y luego iniciar sesión.
        El programa debe verificar si el usuario ha ingresado el nombre de usuario y la contraseña correctos al iniciar sesión 
        (por lo tanto, los mismos que utilizó al registrarse).
        Todavía no hemos explicado cómo hacer almacenamiento de datos, por lo tanto solo crea el programa de una manera que,
        al registrarse e iniciar sesión, ocurra en la misma ejecución del programa.
         */

        public static void Registro()
        {
            Console.WriteLine("Ingresa tu nombre");
            nombre = Console.ReadLine();
            Console.WriteLine("Ingresa tu password");
            password = Console.ReadLine();
            Login();
        }
        public static void Login()
        {
            Console.WriteLine("Para acceder ingresa tu nombre");
            string leernom = Console.ReadLine();
            Console.WriteLine("Ingresa tu password");
            string leepass = Console.ReadLine();
            if (nombre == leernom && password == leepass)
            {
                Console.WriteLine("Acceso exitoso!!");
            }else
            {
                Console.WriteLine("Sin acceso, deseas registrarte?");
                string resp = Console.ReadLine();
                if (resp.Equals("si"))
                {
                    Registro();
                }else
                {
                    Console.WriteLine("Sin acceso");
                }
            }
            


        }
        //FUNCION SWITCH
        public static void EjemploSwitch()
        {
           
            int auto = 15;
            switch (auto)
            {
                case 0:
                    Console.WriteLine("No pagas impuesto");
                    break;
                case 1:
                    Console.WriteLine("Pagas el 15% de impuesto");
                    auto = 2;   
                    break;
                case 2:
                    Console.WriteLine("Pagas impuesto del 30%");
                    break;
                default:
                    Console.WriteLine("De todas formas pagas impuesto!");
                    break;

            }
        }
        public static void EjemploSwitchConIf()
        {
            int auto = 15;
            if (auto == 0)
            {
                Console.WriteLine("No pagas impuesto");
            }
            else if (auto == 1)
            {
                Console.WriteLine("Pagas el 15% de impuesto");
            }
            else if (auto == 3)
            {
                Console.WriteLine("Pagas el 30% de impuesto");
            }
            else { 
                Console.WriteLine("De todas formas pagas impuesto"); 
            }
        }
        
        //Juego de piedra papel o tigeras utilizando switch case
        public static void JuegoPiedraPapelTijeras()
        {
            Console.WriteLine("Ingresa Piedra, papel o tijeras");
            string piedrapapeltijeras = Console.ReadLine();

            switch (piedrapapeltijeras)
            {
                case "piedra":
                    Console.WriteLine("Piedra mata a tijeras");
                    break ;
                case "papel":
                    Console.WriteLine("Papel mata a piedra ");
                    break;
                case "tijeras":
                    Console.WriteLine("Tijeras mata a papel");
                    break;
                default :
                    Console.WriteLine("No ingresaste lo que debias");
                    break;
            }
        }
        /*      D   E   S   A   F   I   O D   E   S   A   F   I   O D   E   S   A   F   I   O D   E   S   A   F   I   O D   E   S   A   F   I   O
         Crea una aplicación que maneje los puntajes de un juego imaginario. Tendrá un puntaje, un puntaje record y un jugador record.
         Crea un método que tenga dos parámetros, uno para el puntaje obtenido y otro para el nombre del jugador.
         Cuando se llama a ese método, se debe verificar si el puntaje del jugador es mayor que la puntuación más alta, si es así,
         que se escriba en la consola algo así como"La nueva puntuación más alta es " + puntuación. Y en otra línea 
         La puntuación más alta fue lograda por " + nombre del jugador.
         */
        public static void IngresoPuntajes()
        {
            Console.WriteLine("Ingresa tu puntuacion");
            string puntuacion = Console.ReadLine();
            double puntuaciondouble;
            try {
                puntuaciondouble = double.Parse(puntuacion);
                Console.WriteLine("Ingresa tu nombre");
                string nombre = Console.ReadLine();
                Puntajes(puntuaciondouble, nombre);
            }
            catch
            {
                Console.WriteLine("Ingresa un valor numerico");
            }
            
        }
        public static void Puntajes(double puntaje, string nomJugador)
        {
            double puntuacionmasalta = 100;
           
            if (puntaje > puntuacionmasalta)
            {
                puntuacionmasalta = puntaje;
                Console.WriteLine("la puntuacion mas alta fue {0}, y fue lograda por {1}", puntuacionmasalta, nomJugador);
            }else
            {
                Console.WriteLine("Tu puntaje fue {0}, gracias {1} por jugar", puntaje, nomJugador);
            }



        }
        //declaracion if mejorada,con operadores terniarios
        public static void DeclaracionIfMejorada()
        {
            //que estado va a tener el agua segun la temperatura
            int temperatura = -5;
            string estadoagua;
            if (temperatura < 0)
            {
                estadoagua = "solido";
             
            }else
            {
                estadoagua = "Liquido";
               
            }
            /*
             Los operadores ternarios son una forma reducida de hacer un if-else
            la sintaxis es :  lo que vamos a imprimir = condicion ? respuesta en caso de ser positivo: respuesta en caso de ser negativa;
             */
            temperatura += 25;
            estadoagua = temperatura<0?"solido":"liquido";
            Console.WriteLine("El estado del agua es {0}", estadoagua);
            // operador ternario con tres opciones
            // la sintaxis es :  lo que vamos a imprimir = condicion ? respuesta en caso de ser positivo: condicion ? respuesta en caso de ser positiva  : respuesta en caso de ser negativa;
            temperatura += 105;
            estadoagua = temperatura > 100 ? "gaseoso" : temperatura < 0 ? "solido" : "liquido";
            Console.WriteLine("El estado del agua es {0}",estadoagua);

        }
        // D   E   S   A   F   I   O D   E   S   A   F   I   O D   E   S   A   F   I   O D   E   S   A   F   I   O D   E   S   A   F   I   O
        public static void OperacionesTernariasDesafio()
        {
            /*
            Vas a crear una pequeña aplicación que tome un valor que represente la temperatura ingresado por el usuario, y que el verifique si ese valor es un integer o no.
            Si el valor ingresado no es un integer, debe imprimir en la consola "Esa no es una temperatura válida".

            En caso de que el valor ingresado sí sea un integer válido, entonces debe hacer lo siguiente:

            Si el valor de la temperatura ingresada es <=15 debe escribir "Hace mucho frio" en la consola.

            Si el valor de la temperatura ingresada es entre >= 16 y <=28 debe escribir "Hace un clima agradable" en la consola.

            Si el valor de la temperatura ingresada es > 28 debe escribir "Hace mucho calor" en la consola.
             */

            Console.WriteLine("Ingresa la temperatura actual");
            string temperatura = Console.ReadLine();
            int valortemporaltem;
            if (int.TryParse(temperatura,out valortemporaltem))
            {
                temperatura = valortemporaltem <= 15 ? "Hace mucho frio" : valortemporaltem > 28 ? "Hace mucho calor" : "El clima es agradable";
                Console.WriteLine("La temperatura es que {0}", temperatura);
            }
            else
            {
                Console.WriteLine("Esa no es una temperatura valida");
            }
        }
    }
}
