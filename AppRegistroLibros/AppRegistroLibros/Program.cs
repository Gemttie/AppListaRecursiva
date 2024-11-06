using System;

namespace RegistroDeLibros
{
    class Programa
    {
        static void Main(string[] args)
        {
            cRegistroLibros registroLibros = new cRegistroLibros();
            bool salir = false;

            while (!salir)
            {
                Console.Clear();
                Console.WriteLine("Registro de Libros");
                Console.WriteLine("1. Agregar un libro");
                Console.WriteLine("2. Ver lista de libros");
                Console.WriteLine("3. Actualizar el estado de un libro");
                Console.WriteLine("4. Eliminar un libro");
                Console.WriteLine("5. Salir");
                Console.Write("Seleccione una opción: ");

                switch (Console.ReadLine())
                {
                    case "1":
                        registroLibros.AgregarLibro();
                        break;
                    case "2":
                        registroLibros.MostrarLibros();
                        break;
                    case "3":
                        registroLibros.ActualizarEstadoLibro();
                        break;
                    case "4":
                        registroLibros.EliminarLibro();
                        break;
                    case "5":
                        salir = true;
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Intente de nuevo.");
                        break;
                }
            }
        }
    }
}
