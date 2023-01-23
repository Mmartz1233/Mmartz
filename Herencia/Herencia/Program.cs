using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Publicacion post1 = new Publicacion("Titanic", "Mayra", true);
            Console.WriteLine(post1.ToString());
            PublicacionImagen post2 = new PublicacionImagen("https://imagenes/perrito.com", "Perrito", "JulioLove", true);
            Console.WriteLine(post2.ToString());
            PublicacionVideo post3 = new PublicacionVideo("https://mivideo.com", "MmartzPeli", "JulMay", true, 10);//la duracion es el numero de veces en que se va a reproducir
            Console.WriteLine(post3.ToString());
            post3.Play();
            Console.WriteLine("Presione cualquier tecla para detener");
            Console.ReadKey();
            post3.Stop();
            Console.Read();
        }
    }
}
