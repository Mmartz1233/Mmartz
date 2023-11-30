using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    public  class Audi: Auto
    {
        string marca = "Audi";
        public string Modelo { get; set; }
        public Audi(string modelo, string hp, string color) : base(hp, color)
        {
            this.Modelo = modelo;
        }
        /// <summary>
        /// Sobreescribimos el metodo reparar de la clase auto
        /// </summary>
        public override void Reparar()
        {
            Console.WriteLine("{0} reparado", marca);
        }
        /// <summary>
        /// Este es un metodo nuevo del de la clase padre, es decir agregamos prioridad a esta clase sobre la otra
        /// </summary>
        public new void MostrarDetalles()
        {
            Console.WriteLine("El auto es de la marca {0}, modelo {1}, color {2}, hp {3}", marca, Modelo, Color, HP);
        }

    }
}
