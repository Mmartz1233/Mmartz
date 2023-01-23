using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Herencia
{
     class PublicacionVideo:Publicacion
    {
        protected bool reproducir = false;
        protected int duracionactual = 0;
        Timer Reloj;
        public double Duracion { get; set; }
        public string UrlVideo { get; set; }

        public PublicacionVideo()
        {

        }
        public PublicacionVideo(string url, string tituto, string autor, bool espublico, double duracion)
        {
            this.Id = CrearId();
            this.Titulo = tituto;
            this.Autor = autor;
            this.EsPublico = espublico;
            this.UrlVideo = url;
            this.Duracion = duracion;
        }
        public override string ToString()
        {
            return String.Format("{0} - {1} -- Creado por {2} y lo puedes encontrar en : {3}, tiene una duracion de {4}", this.Id, this.Titulo, this.Autor, this.UrlVideo, this.Duracion);

        }
        public void Play()
        {
            if (!reproducir)
            {
                reproducir = true;
                Console.WriteLine("Reproduciendo");
                Reloj = new Timer(Reproduccion, null, 0, 1000);
            }
            
        }
        public void Stop()
        {
           if (reproducir)
            {
                reproducir = false;
                Console.WriteLine("Detenido en {0}", duracionactual);
                duracionactual = 0;
                Reloj.Dispose();//libera todos los recursos
            }
        }
        private void Reproduccion(object o)
        {
            if (duracionactual < Duracion)
            {
                duracionactual++;
                Console.WriteLine("Video en {0}", duracionactual);
                GC.Collect();//LIMpia el desorden de los timer
            }
            else
            {
                Stop();
            }
        }
    }
}
