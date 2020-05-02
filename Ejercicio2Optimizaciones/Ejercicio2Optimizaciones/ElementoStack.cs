using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2Optimizaciones
{
  public  class ElementoStack
    {
        public ElementoStack objetoAnterior;
        public int Value { get; set; }
        public ElementoStack ObjetoAnterior
        {
            get
            {
                return objetoAnterior;
            }
            set
            {
                objetoAnterior = value;
            }
        }
        public ElementoStack(int pValue)
        {
            Value = pValue;
            objetoAnterior = null;
        }
    }
}
