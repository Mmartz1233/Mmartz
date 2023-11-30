using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    public class Auto
    {
        public string HP { get; set; }
        public string  Color { get; set; }
        public Auto(string hp, string color)
        {
            this.HP = hp;
            this.Color = color;
        }
        public void MostrarDetalles()
        {
            Console.WriteLine("Las propieades son: color  {0} y HP {1}", Color, HP);
        }
        /// <summary>
        /// Los metodos virtuales solo pueden ser invocados desde las clases derivadas en tanto esten sobre escritos
        /// </summary>
        public virtual void Reparar() 
        {
            Console.WriteLine("Auto reparado");
        }
    }
}
