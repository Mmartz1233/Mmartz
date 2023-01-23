using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
     class PublicacionImagen:Publicacion
    {
        public string Url { get; set; }
        public PublicacionImagen()
        {

        }
        public PublicacionImagen(string url, string tituto, string autor, bool espublico)
        {
            this.Id = CrearId();
            this.Titulo = tituto;
            this.Autor = autor;
            this.EsPublico = espublico;
            this.Url = url;
        }
        public override string ToString()
        {
            return String.Format("{0} - {1} -- Creado por {2} y lo puedes encontrar en : {3}", this.Id, this.Titulo, this.Autor, this.Url);

        }
    }
}
