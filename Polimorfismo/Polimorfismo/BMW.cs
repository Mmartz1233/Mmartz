using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    public  class BMW: Auto
    {
        string marca = "BMW";
        public string Modelo { get; set; }
        public BMW(string modelo, string hp, string color) : base(hp, color)
        {
            this.Modelo = modelo;
        }
        public override void Reparar()
        {
            Console.WriteLine("{0} reparado", marca);
        }
        public new void MostrarDetalles()
        {
            Console.WriteLine("El auto es de la marca {0}, modelo {1}, color {2}, hp {3}", marca, Modelo, Color,HP );
        }

        
        
    }
}
