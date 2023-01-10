using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using static Objetos.Vehiculo;

namespace Objetos
{
    //una clase tiene metodos, propiedades, se puede hacer herencia y puede utilizarse como tipo de datos

    public class Program
    {
        static void Main(string[] args)
        {
         

            //Ejemplo de invocacion utilizando un constructor.
            Humano juan = new Humano("laura", "perez", "cafes", 21);//para leer el nombre y apellido NO es necesario declarar la variable "Public" en su clase.
           // juan.Presentarme();// llamo a un metodo de la clase, el cual leera el texto completo con el nombre asignado en el main

            //Ejemplo de invocaion sin utilizar un constructor
            Animal animal = new Animal();
            animal.razavar = "PitBul";//para leer el nombre y apellido SI es necesario declarar la variable "Public" en su clase.
            animal.nombreVar = "Perro";
           // animal.DatosAnimial();

            //Invocamos un vehiculo
            Vehiculo vehiculo = new Vehiculo();//creando una instancia sin utilizar constructor
            Vehiculo vehiculo1 = new Vehiculo("vento", 2022);//Creando una instancia utilizando un constructor
            
            vehiculo.DatosVehiculo();
            vehiculo1.DatosVehiculo();


            Caja caja = new Caja(4,4,2);
            Caja caja1=new Caja(4,5);
            Console.WriteLine("Superficie frontal desde Main {0}",caja1.SuperficieFrontal);
           Miembros nuevoMiembro = new Miembros();
            nuevoMiembro.Amigo(true);// se accedio a un metodo privado atravez de uno publico
                                     // El objeto "nuevoMiembro" sera destruido al llamar al finalizador
          
            
            caja.MuestraInfo();
          
           Console.Read();
        }
    }
    /// <summary>
    /// Esta es una clase de un humano que nace sin nombre ni apellido
    /// si se utiliza un constructor, para posteriormente asignar los datos
    /// </summary>
    public class Humano
    {
        string primerNombre;
        string apellido;
        string colordeojos;
        int edad;
        public Humano(string primernombre, string apellido, string colordeojos, int edad)
        {
            primerNombre = primernombre;
            this.apellido = apellido;
            this.colordeojos = colordeojos;
            this.edad = edad;
        }
        public  void Presentarme()
        {
            Console.WriteLine("Hola soy {0} {1} mis ojos son de color {2} y tengo {3} años", primerNombre , apellido, colordeojos, edad);
        }

    }
  /// <summary>
  /// Esta es una clase que nace sin nombre ni raza definida, no se utiliza un constructor.
  /// </summary>
    public class Animal
    {
        public string nombreVar;
        public string razavar;
        public void DatosAnimial()
        {
            Console.WriteLine("Hola soy {0} de raza {1}", nombreVar, razavar);
        }
    }
    /// <summary>
    /// En esta clase se crearan multiples constructores, uno de ellos sera parametrizado y el otro no
    /// </summary>
    public class Vehiculo
    {
        string marca;
        int anio;
        /// <summary>
        /// creamos un constructor por defecto
        /// </summary>
        public Vehiculo() {
            Console.WriteLine("Contructor por defecto");
        }
        /// <summary>
        /// creamos un constructor parametrizado
        /// </summary>
        /// <param name="marca"></param>
        /// <param name="anio"></param>
        public Vehiculo (string marca, int anio)
        {
            this.marca=marca;
            this.anio= anio;
        }
        public Vehiculo( int anio)
        {
           
            this.anio = anio;
        }
        public void DatosVehiculo()
        {
         switch (anio == 0)
            {
                case true:
                    Console.WriteLine("---");
                    break;
                case false:
                    Console.WriteLine("Marca {0} y anio {1}", marca, anio);
                   break;
                
            }
           
        }
        /// <summary>
        /// propiedades y encampsulamiento
        /// </summary>
        public class Caja
        {

            public int largo, alto, ancho, volumen;
            public int Largo
            {
                get { return largo; }

                set { largo = value; }
            }
          

            public int Ancho
            {
                get { return ancho; }
                set { ancho = value; }
            }

            public int Alto
            {
                get { return alto; }
                set {
                    if (value < 0)
                    {
                        //value = -value;
                        throw new Exception("El valor tiene que ser positivo");
                    } else {
                        alto = value;
                    }
                }
            }

            public int Volumen
            {
                
                get { return largo* alto * ancho; }
                set { volumen = value; }

            }
            /// <summary>
            /// Crea una nueva propiedad de solo lectura llamada superficie frontal, que calcule solo las variables de alto y largo
            /// </summary>
            
            public int SuperficieFrontal
            {
                get { return alto*largo; }
                
            }
            public Caja(int alto, int largo)
            {
                this.alto = alto;
                this.largo = largo;
                Console.WriteLine("La superficie frontal es de {0},", SuperficieFrontal);

            }


            public Caja(int largo, int alto, int ancho){
                this.largo = largo;
                this.ancho = ancho;
                this.alto=alto;
                Console.WriteLine("El volumen es: {0}", Volumen);
                }


            public void MuestraInfo()
            {
                Console.WriteLine("El largo es {0}, la altura es {1}, la anchura es {2}, el volumen es {3}", Largo, Alto, Ancho, Volumen);
            }
        }

    }
    /// <summary>
    /// En esta clase se crearan los miembros necesarios para la programacion orientado a objetos 
    /// </summary>
    public class Miembros
    {
        //Creamos miembros como campos provados, como las variables que son privadas
        private string nombrePersona;
        private string tituloTrabajo;
        private int salario;

        //creamos miembros campo publico, como las variables que son publicas que se pueden acceder desde otra clase
        public int edad;

        //Miembros propiedades
        public string TituloTrabajo
        {
            get { return tituloTrabajo; }
            set { tituloTrabajo = value; }//el que se le asigna desde afuera
        }
        //miembro metodo privado
        private void CompartirInfoPrivada()
        {
            Console.WriteLine("Hola mi salario es {0}", salario);//algo privado que no quiero conpartir con nadie
        }
        /// <summary>
        /// Miembros metodos publicos, en este ejemplo se accede a un metodo privado a travez de uno publico cuando la condicion sea TRUE 
        /// </summary>
        /// <param name="esAmigo"></param>
        public void Amigo(bool esAmigo)
        {
            if (esAmigo)
            {
                CompartirInfoPrivada();
            }
            else
            {
                Console.WriteLine("Hola mi nombre es {0}, y mi edad es {1}", nombrePersona, edad);
            }
        }
        /// <summary>
        /// Miembros constructor, nos permite establecer formas en las que se construiran nuevas instancias de nuestra clase miembros
        /// En este constructor asignamos los valores de las varibles que se utilizaran en nuestra clase
        /// </summary>
        public Miembros(){
            edad = 30;
            nombrePersona = "Mayra";
            salario = 1000;
            tituloTrabajo = "Desarrollador";
            Console.WriteLine("Objeto creado");
        }
        /// <summary>
        /// Desatructor o finalizador:Lo que realiza es eliminar el objeto que se ha creado
        /// Solo se pueden utilizar dentro de la clase que los creo. 
        /// No se puede acceder desde Main.
        /// Cada clase solo puede tener un finalizador.
        /// No puede heredarse.
        /// No debe haber finalizadores vacios
        /// </summary>
        ~Miembros()
        {
            //Limpia declaraciones 
            Console.WriteLine("Destruccion de objeto");
            Debug.Write("Destruccion del objeto");// el mensaje se muestra en el depurador
        }


    }
}
