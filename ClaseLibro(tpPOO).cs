//Clase libro
using System;

namespace Colecciones
{
    internal class Libro
    {
        private string titulo;
        private string autor;
        private string editorial;

        public Libro(string titulo, string autor, string editorial)
        {
            this.titulo = titulo;
            this.autor = autor;
            this.editorial = editorial;
        }

        public string GetTitulo()
        {
            return titulo;
        }

        public override string ToString()
        {
            return $"Título:{titulo} | Autor:{autor} | Editorial:{editorial}";
        }
    }
}

