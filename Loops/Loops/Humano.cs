using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    public class Humano
    {
        //miembro de la variable
        public string prmiernombre;
        public string apellido;
        private int edad;
        private string colorojos;
        private string nivelestudios;
        private double salario;

        public void Presentarme()
        {
            switch (edad)
            {
                case 0:
                    if (salario > 0) { 
                    Console.WriteLine("Hola soy {0} y mi salario es {1}", prmiernombre, salario);
                    }else if (nivelestudios != null)
                    {
                        Console.WriteLine("Hola soy {0} y mi nivel de estudios es {1}", prmiernombre, nivelestudios);
                    }
                    break;
                case 1:
                    Console.WriteLine("Hola soy {0} y mi apellido es {1} tengo ojos color {2} y {3} año de edad", prmiernombre, apellido, colorojos, edad);
                    break;
              default:
                    if (edad > 1) 
                        Console.WriteLine("Hola soy {0} y mi apellido es {1} tengo ojos color {2} y {3} año de edad", prmiernombre, apellido, colorojos, edad);
                     break;
            }
    }

       /// <summary>
       /// Creando constructor por defecto
       /// </summary>

        public Humano() { }
        ///<summary>
        ///Creando un constructor parametrizado
        ///Es un constructor al que le cargamos las variables especificas para ese  
        ///Nota: Para el uso de constructores las varibles son privadas
        /// </summary>
        public Humano(string nombre, string apellido, int edad, string colorojos) {
        prmiernombre = nombre;//asignamos el valor nombre de nuestro constructor a la variable de la clase
        this.apellido = apellido;//realizamos la misma operacion pero en esta ocasion utilizamos "this"
        this.edad = edad;
        this.colorojos = colorojos;
        }

        public Humano(string prmiernombre, double salario)
        {
            this.prmiernombre = prmiernombre;
            this.salario = salario;
        }
        public Humano(string prmiernombre, string nivelestudios)
        {
            this.prmiernombre = prmiernombre;
            this.nivelestudios = nivelestudios;
        }

    }
}
