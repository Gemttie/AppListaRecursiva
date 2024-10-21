using System;

namespace BibliotecasTDA
{
    public class cListaRecursiva
    {
        private object aElem;
        private cListaRecursiva aSubLista;

        public cListaRecursiva()
        {
            aElem = null;
            aSubLista = null;
        }
        public cListaRecursiva(object pElem, cListaRecursiva pSubLista)
        {
            aElem = pElem;
            aSubLista = pSubLista;
        }
        public object Elem
        {
            get { return aElem; }
            set { aElem = value; }
        }
        public cListaRecursiva SubLista
        {
            get { return aSubLista; }
            set { aSubLista = value; }
        }
        public bool EsVacia()
        {
            return ((aElem == null) && (aSubLista == null));
        }
        public int Longitud()
        {
            int longitud = 0;
            if (EsVacia())
            {
                longitud = 0;
            }
            else
            {
                longitud = 1 + aSubLista.Longitud();
            }
            return longitud;
        }
        public virtual void Procesar(Action<object> modulo = null)
        {
            if (!EsVacia())
            {
                if (modulo == null)
                    Console.WriteLine(aElem);
                else
                    modulo(aElem);
                aSubLista.Procesar(modulo);
            }
        }

        public virtual void Agregar(Object pElemento)
        {
            if (EsVacia())
            {
                aSubLista = new cListaRecursiva(aElem, aSubLista);
                aElem = pElemento;
            }
            else
            {
                aSubLista.Agregar(pElemento);
            }
        }
        public void EliminarElemento(int n)
        {
            if (n == 0)
            {
                aElem = aSubLista.Elem;
                aSubLista = aSubLista.SubLista;
            }
            else
            {
                aSubLista.EliminarElemento(n - 1);
            }
        }
        public void Eliminar(int n)
        {
            if ((n >= 0) && (n < Longitud()))
            {
                EliminarElemento(n);
            }
        }

        public void Insertar(int n, object ElemInsert)
        {
            if ((n >= 0) && (n < Longitud()))
            {
                InsertarElemento(n, ElemInsert);
            }
        }
        public void InsertarElemento(int n, object ElemInsert)
        {
            if (n == 0)
            {
                aSubLista = new cListaRecursiva(aElem, aSubLista);
                aElem = ElemInsert;
            }
            else
            {
                aSubLista.InsertarElemento(n - 1, ElemInsert);
            }
        }
        public object Iesimo(int n)
        {
            if (n < 0 || n >= Longitud())
            {
                // La posición especificada está fuera de los límites de la lista
                return null;
            }

            if (n == 0)
            {
                return Elem;
            }

            return aSubLista.Iesimo(n - 1);
        }

        public bool ExisteElemento(object elemento)
        {
            if (EsVacia())
            {
                return false; // La lista está vacía, el elemento no puede existir
            }

            if (Elem.Equals(elemento))
            {
                return true; // El elemento está en la posición actual
            }

            return aSubLista.ExisteElemento(elemento);
        }

        public void Buscar()
        {

        }

        //
        public object EncontrarMinimo()
        {
            if (EsVacia())
            {
                throw new InvalidOperationException("La lista está vacía.");
            }
            return EncontrarMinimoRecursivo(aElem, aSubLista);
        }

        private object EncontrarMinimoRecursivo(object minimoActual, cListaRecursiva subLista)
        {
            if (subLista.EsVacia())
            {
                return minimoActual;
            }

            if (((IComparable)subLista.Elem).CompareTo(minimoActual) < 0)
            {
                minimoActual = subLista.Elem;
            }

            return EncontrarMinimoRecursivo(minimoActual, subLista.SubLista);
        }
        //
    }
}
