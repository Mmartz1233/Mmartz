using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    public class Program
    {
        static void Main(string[] args)
        {
           
            //imprimir metodos
            var autos = new List<Auto>
            {
                new Audi("WX003", "500", "Azul"),
                new BMW("XY20", "300", "Verde")
            };

            foreach (var auto1 in autos)
            {
                auto1.Reparar();
            }
            //Declaramos un nuevo objeto utilizando polimorfismo, es decir una subclase de la clase padre
            Auto bmw = new BMW("XW02", "1200", "Verde");
            Auto audi = new Audi("A2", "2300", "Azul");//muestra los detalles de la clase auto
            BMW bmw1 = new BMW("XW02", "1200", "Verde");//muestra los detalles de la clase bmw
            bmw1.MostrarDetalles();


            Auto autobmw = (Auto)bmw;
            autobmw.MostrarDetalles();
            Console.Read();
        }
    }
}
