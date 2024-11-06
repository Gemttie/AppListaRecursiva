using System;
using System.Collections.Generic;

namespace RegistroDeLibros
{
    class cRegistroLibros
    {
        private List<cLibro> libros = new List<cLibro>();

        public void AgregarLibro()
        {
            Console.WriteLine("\nAgregar un nuevo libro:");
            Console.Write("Título: ");
            string titulo = Console.ReadLine();
            Console.Write("Autor: ");
            string autor = Console.ReadLine();

            Console.WriteLine("Estado:");
            Console.WriteLine("1. Leído");
            Console.WriteLine("2. Leyendo");
            Console.WriteLine("3. Quiero Leer");
            Console.Write("Seleccione el estado: ");
            string estadoInput = Console.ReadLine();

            cEstadoLibro estado = estadoInput switch
            {
                "1" => cEstadoLibro.Leido,
                "2" => cEstadoLibro.Leyendo,
                "3" => cEstadoLibro.QuieroLeer,
                _ => cEstadoLibro.QuieroLeer
            };

            libros.Add(new cLibro(titulo, autor, estado));
            Console.WriteLine("Libro agregado exitosamente.");
            Console.WriteLine("Presione cualquier tecla para continuar...");
            Console.ReadKey();
        }

        public void MostrarLibros()
        {
            Console.WriteLine("\nLista de Libros:");
            foreach (var libro in libros)
            {
                Console.WriteLine(libro);
            }
            Console.WriteLine("Presione cualquier tecla para continuar...");
            Console.ReadKey();
        }

        public void ActualizarEstadoLibro()
        {
            Console.WriteLine("\nActualizar el estado de un libro:");
            Console.Write("Ingrese el título del libro: ");
            string titulo = Console.ReadLine();

            var libro = libros.Find(l => l.Titulo.Equals(titulo, StringComparison.OrdinalIgnoreCase));
            if (libro != null)
            {
                Console.WriteLine("Estado actual: " + libro.Estado);
                Console.WriteLine("Nuevo estado:");
                Console.WriteLine("1. Leído");
                Console.WriteLine("2. Leyendo");
                Console.WriteLine("3. Quiero Leer");
                Console.Write("Seleccione el nuevo estado: ");
                string estadoInput = Console.ReadLine();

                libro.Estado = estadoInput switch
                {
                    "1" => cEstadoLibro.Leido,
                    "2" => cEstadoLibro.Leyendo,
                    "3" => cEstadoLibro.QuieroLeer,
                    _ => libro.Estado
                };

                Console.WriteLine("Estado actualizado.");
            }
            else
            {
                Console.WriteLine("El libro no se encuentra en la lista.");
            }
            Console.WriteLine("Presione cualquier tecla para continuar...");
            Console.ReadKey();
        }

        public void EliminarLibro()
        {
            Console.WriteLine("\nEliminar un libro:");
            Console.Write("Ingrese el título del libro: ");
            string titulo = Console.ReadLine();

            var libro = libros.Find(l => l.Titulo.Equals(titulo, StringComparison.OrdinalIgnoreCase));
            if (libro != null)
            {
                libros.Remove(libro);
                Console.WriteLine("Libro eliminado.");
            }
            else
            {
                Console.WriteLine("El libro no se encuentra en la lista.");
            }
            Console.WriteLine("Presione cualquier tecla para continuar...");
            Console.ReadKey();
        }
    }
}
