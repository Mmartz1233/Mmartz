using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    public class Caja
    {
        /// <summary>
        /// Ejemplo de encapsulamiento
        /// </summary>
        private int largo;
        private int ancho;
        private int alto;
        private int volumen;
        private int superficiefrontal;
        /// <summary>
        /// Ejemplo de propiedades
        /// </summary>
        public int Largo {//Propiedad en donde asignamos valores 
            get { return largo; } //es lo que va a devolver y generalmente es con un return
            set { largo = value; } } //asignamos valor a las variables
        public int Ancho {

            get { return ancho; }//permite ver lo que se imprime, devuelve un valor
            set//permite asignar un valor desde program
            {
                if (value < 0) value = -value;//Todo valor negativo lo multiplicamos por otro negativo 
                ancho = value;
            }
        }

        public int Alto {
            get { return alto; }
            set {
                if (value < 0) throw new Exception("Necesitas ingresar un valor menor a cero");//Creamos una excepcion 
                alto = value;
            }
        }
        public int Volumen {
            get { return Largo * Ancho * Alto; }
            set
            {
                volumen = value;
            }
        }
        public void Mostrarinfo()
        {
            Console.WriteLine("el largo {0}, ancho{1}, alto {2} y volumen es: {3}", Largo, Ancho, Alto, Volumen);//Mandamos a llamar a las propiedades no a las variables
        }
        public Caja(){}
        public Caja(int largo, int ancho, int alto)
        {
            this.largo = largo;
            this.ancho = ancho;
            this.alto = alto;
        }
        /*
         crea una propiedad de solo lectura llamada superficie frontal
         se calcula con las variables alto y largo
         */
        public int Superficiefrontal {//permite calcular un valor pero no asignarle uno en el program
            get { return alto*largo; }
           
        }


    }
}
