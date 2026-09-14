using System;
using System.Colecctions.generic;
using System.Runtime.CompilerServices;

namespace Colecciones
{
    internal class test
    {
        static void Main(string[] args)
        {
            Biblioteca biblioteca = new Biblioteca();
            cargarLibros(10);
            cargarLibros(2);
            biblioteca.listarLibros();
            biblioteca.eliminarLibros("Libro5");
            biblioteca.listarLibros();
            void cargarLibros(int cantidad){
                bool pude;
                for (int i = 1; i <= cantidad; i++)
                {
                    pude = biblioteca.agregarLibro("Libro" + i, "Autor" + i, "Editorial" + i);
                    if (pude)
                        console.WriteLine("libro" + i + "Agregado correctamente");
                    else
                        console.WriteLine("libro" + i + "Ya existe en biblioteca");
                }

            }
        }
    }
}