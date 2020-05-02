using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2Optimizaciones
{
    class ElementoQueue
    {
        private ElementoQueue siguienteObjeto;
        public int Indice { get; set; }
        public int Valor { get; set; }
        public ElementoQueue SiguienteObjeto
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


        public ElementoQueue(int pValue)
        {
            Valor = pValue;
            siguienteObjeto = null;
        }
    }
}

