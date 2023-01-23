using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpleadosHerencia
{
     public class Jefe:Empleado
    {
        public string AutodeEmpresa { get; set; }
        public void Dirigir()
        {
            Console.WriteLine("Soy el jefe");
        }
        public Jefe()
        {

        }
        public Jefe(string nombre, string apellido, string marca, double salario)
        {
            this.Nombre = nombre;
            this.Apellidos = apellido;
            this.AutodeEmpresa = marca;
            this.Salaio=salario;
        }
        public override string ToString()
        {
            return String.Format("Jefe: Nombre: {0} Apellido {1}, Auto de la empresa {2}, Salario{3}", this.Nombre, this.Apellidos, this.AutodeEmpresa, this.Salaio);

        }
    }
}
