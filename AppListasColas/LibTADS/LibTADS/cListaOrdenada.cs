using System;

namespace LibTADS
{
    public class CListaOrdenada : CLista
    {
        /* Constructores */
        public CListaOrdenada() : base() { }

        public CListaOrdenada(object pElemento, CLista pSubLista) : base(pElemento, pSubLista) { }

        
        public override void Insertar(object pElemento, int pos)
        {
            Console.WriteLine("Método no disponible");
        }

        //método sobrescrito para Agregar, manteniendo la lista ordenada
        public override void Agregar(Object pElemento)
        {
            //si la lista está vacía o el pElemento es menor que el elemento actual, insertar al inicio
            if (EstaVacia() || pElemento.ToString().CompareTo(Elemento.ToString()) <= 0)
            {
                SubLista = new CListaOrdenada(Elemento, SubLista);
                Elemento = pElemento;
            }
            else //insertar en la sublista
            {
                (SubLista as CListaOrdenada).Agregar(pElemento);
            }
        }

        //método sobrescrito para Ubicacion, manteniendo la lista ordenada
        public override int Ubicacion(Object pElemento)
        {
            if (EstaVacia() || pElemento.ToString().CompareTo(Elemento.ToString()) < 0)
                return 0;
            else
            {
                if (Elemento.Equals(pElemento))
                    return 1;
                else
                {
                    //buscar en la sublista
                    int k = SubLista.Ubicacion(pElemento);
                    return (k > 0 ? k + 1 : 0);
                }
            }
        }
    }
}
