using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    public class Miembros
    {
        private string nombre;
        private int edad;
        private int salario;
        private string especialidad;

        public string Nombre { get; set; }
        public int Edad { get; set; }
        public int Salario { get; set; }
        public string Especialidad { get; set; }

        private void Monstrarinfo()
        {
            Console.WriteLine("Hola tengo {0} años y mi nombre es {1}", edad, nombre);
        }
        public void Amigo(bool esamigo)
        {
            if (esamigo)
            {
                Console.WriteLine("Si es amigo");
                Monstrarinfo();
            }
            else
            {
                Console.WriteLine("No es amigo");
            }
        }
        public Miembros() {
            edad = 22;
            nombre = "Mayrax";
        
        }
        /// <summary>
        /// Ejemplo de la creacion de un destructor
        /// Su funcion es eliminar el objeto que se ha creado.
        /// Limpia declaraciones 
        /// </summary>
        ~Miembros()
        {
            //Console.WriteLine("Elimina las lineas creadas");
            Debug.Write("Elimina las lineas creada");// esta linea sera mostrada en el debug

        }
    }
}
