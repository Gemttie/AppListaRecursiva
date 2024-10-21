using System;
using BibliotecasTDA;

namespace AplicacionListaRecursiva
{
    class Program
    {
        static void Main(string[] args)
        {
            cListaRecursiva listaTareas = new cListaRecursiva();
            int opcion = -1;

            while (opcion != 0)
            {
                Console.Clear();
                MostrarMenu();

                Console.Write("Ingrese una opción: ");
                opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        AgregarTarea(listaTareas);
                        break;
                    case 2:
                        EliminarTarea(listaTareas);
                        break;
                    case 3:
                        InsertarTarea(listaTareas);
                        break;
                    case 4:
                        ListarTareas(listaTareas);
                        break;
                    case 5:
                        VerTareaEspecifica(listaTareas);
                        break;
                    case 6:
                        BuscarTarea(listaTareas);
                        break;
                    
                    case 7:
                        EncontrarMinimoTarea(listaTareas);
                        break;
                    
                    case 0:
                        Console.WriteLine("Saliendo de la aplicación...");
                        break;
                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }

                if (opcion != 0)
                {
                    Console.WriteLine("\nPresione cualquier tecla para continuar...");
                    Console.ReadKey();
                }
            }
        }

        //mostrar menu dentro de un cuadro
        static void MostrarMenu()
        {
            Console.WriteLine("╔═══════════════════════════════════════╗");
            Console.WriteLine("║        GESTIÓN DE LISTA DE TAREAS      ║");
            Console.WriteLine("╠═══════════════════════════════════════╣");
            Console.WriteLine("║  1. Agregar tarea                     ║");
            Console.WriteLine("║  2. Eliminar tarea                    ║");
            Console.WriteLine("║  3. Insertar tarea en una posición    ║");
            Console.WriteLine("║  4. Listar todas las tareas           ║");
            Console.WriteLine("║  5. Ver una tarea específica          ║");
            Console.WriteLine("║  6. Buscar tarea                      ║");
            Console.WriteLine("║  7. Encontrar el valor mínimo         ║"); 
            Console.WriteLine("║  0. Salir                             ║");
            Console.WriteLine("╚═══════════════════════════════════════╝");
        }

        static void AgregarTarea(cListaRecursiva lista)
        {
            Console.Write("Ingrese la descripción de la tarea: ");
            string descripcion = Console.ReadLine();
            lista.Agregar(descripcion);
            Console.WriteLine("Tarea agregada correctamente.");
        }

        static void EliminarTarea(cListaRecursiva lista)
        {
            ListarTareas(lista);
            Console.Write("\nIngrese la posición de la tarea a eliminar: ");
            int posicion = Convert.ToInt32(Console.ReadLine());

            if (posicion >= 0 && posicion < lista.Longitud())
            {
                lista.Eliminar(posicion);
                Console.WriteLine("Tarea eliminada correctamente.");
            }
            else
            {
                Console.WriteLine("Posición inválida.");
            }
        }

        static void InsertarTarea(cListaRecursiva lista)
        {
            ListarTareas(lista);
            Console.Write("\nIngrese la posición donde desea insertar la nueva tarea: ");
            int posicion = Convert.ToInt32(Console.ReadLine());
            if (posicion >= 0 && posicion <= lista.Longitud())
            {
                Console.Write("Ingrese la descripción de la tarea: ");
                string descripcion = Console.ReadLine();
                lista.Insertar(posicion, descripcion);
                Console.WriteLine("Tarea insertada correctamente.");
            }
            else
            {
                Console.WriteLine("Posición inválida.");
            }
        }

        static void ListarTareas(cListaRecursiva lista)
        {
            if (lista.EsVacia())
            {
                Console.WriteLine("No hay tareas en la lista.");
            }
            else
            {
                Console.WriteLine("===== LISTA DE TAREAS =====");
                lista.Procesar(tarea => Console.WriteLine("- " + tarea));
            }
        }

        static void VerTareaEspecifica(cListaRecursiva lista)
        {
            Console.Write("\nIngrese la posición de la tarea que desea ver: ");
            int posicion = Convert.ToInt32(Console.ReadLine());

            object tarea = lista.Iesimo(posicion);
            if (tarea != null)
            {
                Console.WriteLine("Tarea en la posición " + posicion + ": " + tarea);
            }
            else
            {
                Console.WriteLine("Posición inválida.");
            }
        }

        static void BuscarTarea(cListaRecursiva lista)
        {
            Console.Write("Ingrese la descripción de la tarea a buscar: ");
            string descripcion = Console.ReadLine();
            bool existe = lista.ExisteElemento(descripcion);
            if (existe)
            {
                Console.WriteLine("La tarea '" + descripcion + "' existe en la lista.");
            }
            else
            {
                Console.WriteLine("La tarea '" + descripcion + "' no fue encontrada.");
            }
        }

        
        static void EncontrarMinimoTarea(cListaRecursiva lista)
        {
            if (lista.EsVacia())
            {
                Console.WriteLine("La lista está vacía.");
            }
            else
            {
                object minimo = lista.EncontrarMinimo();
                Console.WriteLine("El valor mínimo en la lista es: " + minimo);
            }
        }
        
    }
}
