using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2Optimizaciones
{
   public class ElementoLista
    {
        private ElementoLista siguienteObjeto;
        public int Indice { get; set; }
        public int Valor { get; set; }
        public ElementoLista SiguienteObjeto
        {
            get
            {
                return siguienteObjeto;
            }
            set
            {
                siguienteObjeto = value;
            }
        }
      

        public ElementoLista(int pValue, int pIndice)
        {
            Valor = pValue;
            siguienteObjeto = null;
            Indice = pIndice;
        }
    }
}
