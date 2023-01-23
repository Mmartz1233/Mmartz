using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Interfaz
{
    /// <summary>
    /// Una interfaz se utiliza cuando varias clases implementan el mismo metodo, son parecidas a las clases
    ///pero no contienen codigo, contiene las definiciones de un grupo de metodos.
    ///Las interfaces establecen el "Que" y las clases que heredan de la interfaz "El contenido"
    /// </summary>
    public interface Inotificacion
    {
       void MostrarNotificacion();//las clases que heredan de esta interfaz tengan este metodo
       string Verfecha();

    }
    /// <summary>
    /// Implementacion de una interfaz en una clase
    /// </summary>
    public class Notificacion :Inotificacion
    {
        private string enviadopor;
        private string mensaje;
        private string fecha;
        /// <summary>
        /// constructor por defecto
        /// </summary>
        public Notificacion()
        {
            enviadopor = "May";
            mensaje = "Hola";
            fecha = "23-01-2023";
        }
        /// <summary>
        /// Constructor parametrizado
        /// </summary>
        /// <param name="enviadopor"></param>
        /// <param name="mensaje"></param>
        /// <param name="fecha"></param>
        public Notificacion(string enviadopor, string mensaje, string fecha)
        {
            this.enviadopor = enviadopor;
            this.mensaje = mensaje;
            this.fecha = fecha;
        }

        public void MostrarNotificacion()
        {
            Console.WriteLine("El mensaje es {0} fue enviado por {1} el dia {2}", mensaje, enviadopor, fecha);
        }

        public string Verfecha()
        {
            return fecha;
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            Notificacion notificacion = new Notificacion("Mmartz", "Holii", "23-02-2023");
            Notificacion notificacion2 = new Notificacion("Julio", "Holi amor", "23-02-2023");
            notificacion.MostrarNotificacion();
            notificacion2.MostrarNotificacion();
            Console.Read();
        }
    }

}