using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
     class Publicacion
    {
        //Static: para que pueda ser modificlable
        private static int publicacionId;
        //Protected: solo puede verse en esta clase 
        protected int Id { get; set; }
        protected string Titulo { get; set; }
        protected string Autor { get; set; }
        protected bool EsPublico { get; set; }

        public Publicacion()
        {
            Id = CrearId();
            Titulo = "Mi primera publicacion";
            Autor = "Mayra Martz";
            EsPublico = true;
        }
        public Publicacion(string titulo, string autor, bool espublico)
        {
            Id = CrearId();
            this.Titulo = titulo;
            this.Autor = autor;
            this.EsPublico = espublico;
        }
        //Crear el metodo para hacer el id incrementable
        protected int CrearId()
        {
            return ++publicacionId;
        }
        //Metodo para editar una publicacion
        public void Editar(string titulo, bool espublico)
        {
            this.Titulo=titulo;
            this.EsPublico = true;
        }
        public override string ToString()
        {
            return String.Format("{0} - {1} -- Creado por {2}", this.Id, this.Titulo, this.Autor);

        }

    }
}
