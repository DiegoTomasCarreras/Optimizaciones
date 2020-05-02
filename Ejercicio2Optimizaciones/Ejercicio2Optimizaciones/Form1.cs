using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio2Optimizaciones
{
    public partial class Form1 : Form
    {
        lista lista1 = new lista();
        Stack stack1 = new Stack();
        Queue queue1 = new Queue();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void AgregarLista_Click(object sender, EventArgs e)
        {
            lista1.addElement(int.Parse(textBoxValorLista.Text));
        }

        private void buttonMostrarLista_Click(object sender, EventArgs e)
        {
            labelLista.Text = lista1.printList();
        }

        private void buttonBuscadorLista_Click(object sender, EventArgs e)
        {
           var x =  lista1.search(int.Parse(textBoxBuscador.Text));
            labelBuscarLista.Text = x.ToString();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
             stack1.Push(int.Parse(textBoxValorPila.Text));
        }

        private void buttonMostrarPila_Click(object sender, EventArgs e)
        {
            labelMostrarPila.Text= stack1.MostrarPila();
        }

        private void buttonPop_Click(object sender, EventArgs e)
        {
            labelPop.Text= stack1.Pop();
        }

        private void buttonDequeue_Click(object sender, EventArgs e)
        {
            labelDequeue.Text = queue1.DeQueue();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            queue1.AddQueue(int.Parse(textBoxValorFila.Text));
        }
    }
}
