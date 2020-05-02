using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2Optimizaciones
{
   public class lista
    {

        public ElementoLista inicializador = null;
        public ElementoLista elemento=null;
        private int indice= 0;
        public lista()
        {
            inicializador = new ElementoLista(0,-1);
        }

        public void addElement(int value)
        {
            elemento = inicializador;
            while (elemento.SiguienteObjeto!=null)
            {
                elemento = elemento.SiguienteObjeto;
            }
            ElementoLista elementoNuevo = new ElementoLista(value,indice);
            indice++;
            elemento.SiguienteObjeto = elementoNuevo;
        }
        public string printList()
        {
            elemento = inicializador;
            string value = "";
            while(elemento.SiguienteObjeto!=null)
            {
                elemento = elemento.SiguienteObjeto;
                value += int.Parse(elemento.Valor.ToString());
                value += " ";
            }

            return value;
        }
        public object search(int pIndice)
        {
            elemento = inicializador;
            while (elemento.Indice!=pIndice)
            {
                elemento = elemento.SiguienteObjeto;
                if(elemento.SiguienteObjeto==null)
                {
                    return "Not found";
                }
            }
            return elemento.Valor;
        }
    }
}
