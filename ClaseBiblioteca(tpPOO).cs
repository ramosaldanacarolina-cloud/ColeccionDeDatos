//Clase biblioteca
using System;
using System.Collections.Generic;

namespace Colecciones
{
    internal class Biblioteca
    {
        private List<Libro> libros;
        private List<Lector> lectores;

        public Biblioteca()
        {
            this.libros = new List<Libro>();
            this.lectores = new List<Lector>();
        }

        //Encapsulamiento
        private Libro BuscarLibro(string titulo)
        {
            libros libroBuscado = null;
            int i = 0;
            while (i < libros.Count $$ !libros[i].GetTitulo().Equals(titulo, StringComparison.OrdinalIgnoreCase))
            {
                i++;
            }
            if (i != libros.Count)
            {
                libroBuscado = libros[i];
            }
            return libroBuscado;
        }

        private Lector BuscarLector(string dni)
        {
            Lector lectorBuscado = null;
            int i = 0;
            while (i < lectores.Count $$ !lectores[i].GetDni().Equals(dni))
            {
                i++;
            }
            if (i != lectores.Count)
            {
                lectorBuscado = lectores[i];
            }
            return lectorBuscado;
        }

        //Administración de libros
        public bool AgregarLibro(string titulo, string autor, string editorial)
        {
            bool resultado = false;
            Libro libro = BuscarLibro(titulo);
            if (libro == null)
            {
                libro = new Libro(titulo, autor, editorial);
                libros.Add(libro);
                resultado = true;
            }
            return resultado;
        }

        public bool EliminarLibro(string titulo)
        {
            bool resultado = false;
            Libro libro = BuscarLibro(titulo);
            if (libro != null)
            {
                libros.Remove(libro);
                resultado = true;
            }
            return resultado;
        }

        public void ListarLibros()
        {
            foreach (var libro in libros)

            {
                Console.WriteLine(libro);
            }
        }

        //Requerimiento 1: Alta de lector
        public bool AltaLector(string nombre, string dni)
        {
            bool resultado = false;
            Lector lector = BuscarLector(dni);
            if (lector == null)
            {
                lector = new Lector(nombre, dni);
                lectores.Add(lector);
                resultado = true;
            }
            return resultado;
        }

        //Requerimiento 2 :Prestamo de un libro
        public string PrestarLibro(string titulo, string dni)
        {
            //validar si el lector existe
            Lector lector = BuscarLector(dni);
            if (lector == null)
            {
                return "Lector no Existe";
            }

            //Validar si los prestamos supera el máximo (3)
            if (lector.GetCantidadPrestamos() >= 3)
            {
                return "Tope de prestamos Alcanzado";
            }

            //Validar si el libro existe en la biblioteca
            Libro libro = BuscarLibro(titulo);
            if (libro == null)
            {
                return "Libro Inexistente en la Biblioteca";
            }

            //Proceso de transferencia física/lógica del libro
            libros.Remove(libro);
            lector.AgregarLibro(libro); //el libro se le presta al lector

            return "Prestamo Exitoso";
        }
    }

}