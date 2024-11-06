using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibTADS
{
    public class CNodoLista
    {
        #region Atributos
        private object aElemento;
        private CNodoLista aSgte;
        #endregion

        #region Constructores
        public CNodoLista()
        {
            aElemento = null;
            aSgte = null;
        }

        public CNodoLista(object pElemento)
        {
            aElemento = pElemento;
            aSgte = null;
        }

        public CNodoLista(object pElemento, CNodoLista pNodo)
        {
            aElemento = pElemento;
            aSgte = pNodo;
        }
        #endregion

        #region Propiedades
        public object Elemento
        {
            set { aElemento = value; }
            get { return aElemento; }
        }

        public CNodoLista Sgte
        {
            set { aSgte = value; }
            get { return aSgte; }
        }
        #endregion
    }
}
