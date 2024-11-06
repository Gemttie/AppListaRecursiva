using System;
using LibTADS;

namespace AppTADS
{
    class Program
    {
        static void Main(string[] args)
        {
            
            CListaOrdenada listaFrutasOrdenada = new CListaOrdenada();

            
            listaFrutasOrdenada.Agregar("Manzana");
            listaFrutasOrdenada.Agregar("Banana");
            listaFrutasOrdenada.Agregar("Naranja");
            listaFrutasOrdenada.Agregar("Fresa");
            listaFrutasOrdenada.Agregar("Kiwi");
            listaFrutasOrdenada.Agregar("Mango");
            listaFrutasOrdenada.Agregar("Piña");
            listaFrutasOrdenada.Agregar("Uva");

            
            listaFrutasOrdenada.Mostrar();

            Console.WriteLine("Posición de Piña: " + listaFrutasOrdenada.Ubicacion("Piña"));

            Console.ReadLine(); 
        }
    }
}
