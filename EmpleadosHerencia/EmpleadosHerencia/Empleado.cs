using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EmpleadosHerencia
{
     public class Empleado
    {
        
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public double Salaio { get; set; }
        public  virtual void  Trabajar()
        {
            Console.WriteLine("Estoy trabajando");
        }
        public void Descansar()
        {
            Console.WriteLine("Estoy descansando");
        }
        public Empleado()
        {
            Nombre = "Mayra";
            Apellidos = "Martz";
            Salaio = 10000.2;
        }
        public Empleado(string nombre, string apellido, double salario)
        {
            this.Nombre = nombre;
            this.Apellidos = apellido;
            this.Salaio = salario;
        }
        public override string ToString()
        {
            return String.Format("Empleado: Nombre: {0} Apellido {1}, Salario{2}", this.Nombre, this.Apellidos, this.Salaio);

        }
    }
}
