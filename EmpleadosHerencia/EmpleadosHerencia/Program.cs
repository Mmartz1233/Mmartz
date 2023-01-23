using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpleadosHerencia
{
    public class Program
    {
        static void Main(string[] args)
        {
            Jefe jefe = new Jefe("Mayra", "Martinez", "Audi", 1500);
            Console.WriteLine(jefe.ToString());
            jefe.Dirigir();
            Pasante pasante = new Pasante("Pasante", "Castillo", 10, 5, 2500);
            Console.WriteLine(pasante.ToString());
            pasante.Trabajar();
            pasante.Descansar();
            pasante.Aprender();
            Empleado empleado = new Empleado("Empleado", "Flores", 1600);
            empleado.Trabajar();
            Console.WriteLine(empleado.ToString());
            Console.Read();
        }
    }
}
