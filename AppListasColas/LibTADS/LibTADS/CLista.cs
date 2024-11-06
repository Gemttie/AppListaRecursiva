using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace LibTADS
{
    public class CLista : ILista
    {
        #region Atributos
        protected object aElemento;
        protected CLista aSubLista;
        #endregion

        #region Constructores
        public CLista()
        {
            aElemento = null;
            aSubLista = null;
        }

        public CLista(object pElemento, CLista pSubLista)
        {
            aElemento = pElemento;
            aSubLista = pSubLista;
        }
        #endregion

        #region Propiedades
        public object Elemento
        {
            get { return aElemento; }
            set { aElemento = value; }
        }

        public CLista SubLista
        {
            get { return aSubLista; }
            set { aSubLista = value; }
        }
        #endregion

        #region Métodos base
        public bool EstaVacia()
        {
            return (aElemento == null && aSubLista == null);
        }

        protected void insertar(object pElemento, int posicion)
        {
            if (posicion == 1)
            {
                aSubLista = new CLista(aElemento, aSubLista);
                aElemento = pElemento;
            }
            else
            {
                if (aSubLista == null)
                    aSubLista = new CLista();

                aSubLista.insertar(pElemento, posicion - 1);
            }
        }

        public virtual void Insertar(object pElemento, int posicion)
        {
            if (1 <= posicion && posicion <= Longitud() + 1)
                insertar(pElemento, posicion);
            else
                Console.WriteLine("ERROR: Posición incorrecta");
        }

        public virtual void Agregar(object pElemento)
        {
            insertar(pElemento, Longitud() + 1);
        }

        public virtual int Ubicacion(object pElemento)
        {
            if (EstaVacia())
                return 0;
            else if (aElemento.Equals(pElemento))
                return 1;
            else
            {
                int k = aSubLista?.Ubicacion(pElemento) ?? 0;
                return (k > 0) ? 1 + k : 0;
            }
        }

        protected object iesimo(int posicion)
        {
            if (posicion == 1)
                return aElemento;
            else
                return aSubLista.iesimo(posicion - 1);
        }

        public virtual object Iesimo(int posicion)
        {
            if (1 <= posicion && posicion <= Longitud())
                return iesimo(posicion);
            else
            {
                Console.WriteLine("ERROR: Posición incorrecta");
                return null;
            }
        }

        protected void eliminar(int posicion)
        {
            if (posicion == 1)
            {
                aElemento = aSubLista.Elemento;
                aSubLista = aSubLista.SubLista;
            }
            else
            {
                aSubLista.eliminar(posicion - 1);
            }
        }

        public virtual void Eliminar(int posicion)
        {
            if (1 <= posicion && posicion <= Longitud())
                eliminar(posicion);
            else
                Console.WriteLine("ERROR: Posición incorrecta");
        }

        public void Eliminar(object pElemento)
        {
            int pos = Ubicacion(pElemento);
            if (pos != 0)
                eliminar(pos);
            else
                Console.WriteLine("ERROR: El elemento no existe");
        }

        public int Longitud()
        {
            if (EstaVacia())
                return 0;
            else
                return 1 + (aSubLista?.Longitud() ?? 0);
        }

        public void Mostrar()
        {
            if (!EstaVacia())
            {
                Console.WriteLine(aElemento);
                aSubLista?.Mostrar();
            }
        }
        #endregion
    }
}
