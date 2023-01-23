using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EmpleadosHerencia
{
     public class Pasante:Empleado
    {
        protected bool Reproducir = false;
        protected int Duracionactual = 0;
        Timer Reloj;
        public int HorasdeTrabajo { get; set; }
        public int HorasdeEscuela { get; set; }
        public void Aprender()
        {

            Console.WriteLine("Estoy aprendiendo {0} cantidad de horas", HorasdeEscuela);
        }
        public override void Trabajar()
        {
            Console.WriteLine("Estoy trabajando {0} horas ", HorasdeTrabajo);
        }
        public Pasante()
        {

        }
        public Pasante(string nombre, string apellido, int horasdeTrabajo, int horasdeEscuela, double salario):base(nombre, apellido,salario)
        {
            //this.Nombre = nombre;
            //this.Apellidos = apellido;
            this.HorasdeTrabajo = horasdeTrabajo;
            this.HorasdeEscuela = horasdeEscuela;

        }
        public override string ToString()
        {
            return String.Format("Pasante: Nombre: {0} Apellido {1}, Horas de trabajo {2}, Horas en la escuela {3}", this.Nombre, this.Apellidos, this.HorasdeTrabajo, this.HorasdeEscuela);

        }
      
    }
}
