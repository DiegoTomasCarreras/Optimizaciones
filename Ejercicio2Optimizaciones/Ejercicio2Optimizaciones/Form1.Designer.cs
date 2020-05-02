namespace Ejercicio2Optimizaciones
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.AgregarLista = new System.Windows.Forms.Button();
            this.textBoxValorLista = new System.Windows.Forms.TextBox();
            this.textBoxValorPila = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxValorFila = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonMostrarLista = new System.Windows.Forms.Button();
            this.labelLista = new System.Windows.Forms.Label();
            this.textBoxBuscador = new System.Windows.Forms.TextBox();
            this.buttonBuscadorLista = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelBuscarLista = new System.Windows.Forms.Label();
            this.buttonMostrarPila = new System.Windows.Forms.Button();
            this.labelMostrarPila = new System.Windows.Forms.Label();
            this.buttonPop = new System.Windows.Forms.Button();
            this.labelPop = new System.Windows.Forms.Label();
            this.labelDequeue = new System.Windows.Forms.Label();
            this.buttonDequeue = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AgregarLista
            // 
            this.AgregarLista.Location = new System.Drawing.Point(128, 66);
            this.AgregarLista.Name = "AgregarLista";
            this.AgregarLista.Size = new System.Drawing.Size(91, 23);
            this.AgregarLista.TabIndex = 0;
            this.AgregarLista.Text = "AgregarALista";
            this.AgregarLista.UseVisualStyleBackColor = true;
            this.AgregarLista.Click += new System.EventHandler(this.AgregarLista_Click);
            // 
            // textBoxValorLista
            // 
            this.textBoxValorLista.Location = new System.Drawing.Point(12, 69);
            this.textBoxValorLista.Name = "textBoxValorLista";
            this.textBoxValorLista.Size = new System.Drawing.Size(100, 20);
            this.textBoxValorLista.TabIndex = 1;
            // 
            // textBoxValorPila
            // 
            this.textBoxValorPila.Location = new System.Drawing.Point(12, 124);
            this.textBoxValorPila.Name = "textBoxValorPila";
            this.textBoxValorPila.Size = new System.Drawing.Size(100, 20);
            this.textBoxValorPila.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(128, 121);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "AgregarAPila";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxValorFila
            // 
            this.textBoxValorFila.Location = new System.Drawing.Point(12, 174);
            this.textBoxValorFila.Name = "textBoxValorFila";
            this.textBoxValorFila.Size = new System.Drawing.Size(100, 20);
            this.textBoxValorFila.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(128, 171);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "AgregarAFila";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonMostrarLista
            // 
            this.buttonMostrarLista.Location = new System.Drawing.Point(275, 66);
            this.buttonMostrarLista.Name = "buttonMostrarLista";
            this.buttonMostrarLista.Size = new System.Drawing.Size(75, 23);
            this.buttonMostrarLista.TabIndex = 6;
            this.buttonMostrarLista.Text = "MostrarLista";
            this.buttonMostrarLista.UseVisualStyleBackColor = true;
            this.buttonMostrarLista.Click += new System.EventHandler(this.buttonMostrarLista_Click);
            // 
            // labelLista
            // 
            this.labelLista.AutoSize = true;
            this.labelLista.Location = new System.Drawing.Point(405, 69);
            this.labelLista.Name = "labelLista";
            this.labelLista.Size = new System.Drawing.Size(35, 13);
            this.labelLista.TabIndex = 7;
            this.labelLista.Text = "label1";
            // 
            // textBoxBuscador
            // 
            this.textBoxBuscador.Location = new System.Drawing.Point(12, 296);
            this.textBoxBuscador.Name = "textBoxBuscador";
            this.textBoxBuscador.Size = new System.Drawing.Size(100, 20);
            this.textBoxBuscador.TabIndex = 8;
            // 
            // buttonBuscadorLista
            // 
            this.buttonBuscadorLista.Location = new System.Drawing.Point(275, 12);
            this.buttonBuscadorLista.Name = "buttonBuscadorLista";
            this.buttonBuscadorLista.Size = new System.Drawing.Size(75, 23);
            this.buttonBuscadorLista.TabIndex = 9;
            this.buttonBuscadorLista.Text = "BuscarLista";
            this.buttonBuscadorLista.UseVisualStyleBackColor = true;
            this.buttonBuscadorLista.Click += new System.EventHandler(this.buttonBuscadorLista_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 277);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Buscador";
            // 
            // labelBuscarLista
            // 
            this.labelBuscarLista.AutoSize = true;
            this.labelBuscarLista.Location = new System.Drawing.Point(405, 12);
            this.labelBuscarLista.Name = "labelBuscarLista";
            this.labelBuscarLista.Size = new System.Drawing.Size(35, 13);
            this.labelBuscarLista.TabIndex = 11;
            this.labelBuscarLista.Text = "label1";
            // 
            // buttonMostrarPila
            // 
            this.buttonMostrarPila.Location = new System.Drawing.Point(275, 121);
            this.buttonMostrarPila.Name = "buttonMostrarPila";
            this.buttonMostrarPila.Size = new System.Drawing.Size(75, 23);
            this.buttonMostrarPila.TabIndex = 12;
            this.buttonMostrarPila.Text = "MostrarPila";
            this.buttonMostrarPila.UseVisualStyleBackColor = true;
            this.buttonMostrarPila.Click += new System.EventHandler(this.buttonMostrarPila_Click);
            // 
            // labelMostrarPila
            // 
            this.labelMostrarPila.AutoSize = true;
            this.labelMostrarPila.Location = new System.Drawing.Point(405, 124);
            this.labelMostrarPila.Name = "labelMostrarPila";
            this.labelMostrarPila.Size = new System.Drawing.Size(35, 13);
            this.labelMostrarPila.TabIndex = 13;
            this.labelMostrarPila.Text = "label1";
            // 
            // buttonPop
            // 
            this.buttonPop.Location = new System.Drawing.Point(275, 172);
            this.buttonPop.Name = "buttonPop";
            this.buttonPop.Size = new System.Drawing.Size(75, 23);
            this.buttonPop.TabIndex = 15;
            this.buttonPop.Text = "Pop";
            this.buttonPop.UseVisualStyleBackColor = true;
            this.buttonPop.Click += new System.EventHandler(this.buttonPop_Click);
            // 
            // labelPop
            // 
            this.labelPop.AutoSize = true;
            this.labelPop.Location = new System.Drawing.Point(405, 182);
            this.labelPop.Name = "labelPop";
            this.labelPop.Size = new System.Drawing.Size(35, 13);
            this.labelPop.TabIndex = 16;
            this.labelPop.Text = "label1";
            // 
            // labelDequeue
            // 
            this.labelDequeue.AutoSize = true;
            this.labelDequeue.Location = new System.Drawing.Point(405, 242);
            this.labelDequeue.Name = "labelDequeue";
            this.labelDequeue.Size = new System.Drawing.Size(35, 13);
            this.labelDequeue.TabIndex = 18;
            this.labelDequeue.Text = "label1";
            // 
            // buttonDequeue
            // 
            this.buttonDequeue.Location = new System.Drawing.Point(275, 232);
            this.buttonDequeue.Name = "buttonDequeue";
            this.buttonDequeue.Size = new System.Drawing.Size(75, 23);
            this.buttonDequeue.TabIndex = 17;
            this.buttonDequeue.Text = "Dequeue";
            this.buttonDequeue.UseVisualStyleBackColor = true;
            this.buttonDequeue.Click += new System.EventHandler(this.buttonDequeue_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 434);
            this.Controls.Add(this.labelDequeue);
            this.Controls.Add(this.buttonDequeue);
            this.Controls.Add(this.labelPop);
            this.Controls.Add(this.buttonPop);
            this.Controls.Add(this.labelMostrarPila);
            this.Controls.Add(this.buttonMostrarPila);
            this.Controls.Add(this.labelBuscarLista);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonBuscadorLista);
            this.Controls.Add(this.textBoxBuscador);
            this.Controls.Add(this.labelLista);
            this.Controls.Add(this.buttonMostrarLista);
            this.Controls.Add(this.textBoxValorFila);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBoxValorPila);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxValorLista);
            this.Controls.Add(this.AgregarLista);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AgregarLista;
        private System.Windows.Forms.TextBox textBoxValorLista;
        private System.Windows.Forms.TextBox textBoxValorPila;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxValorFila;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonMostrarLista;
        private System.Windows.Forms.Label labelLista;
        private System.Windows.Forms.TextBox textBoxBuscador;
        private System.Windows.Forms.Button buttonBuscadorLista;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelBuscarLista;
        private System.Windows.Forms.Button buttonMostrarPila;
        private System.Windows.Forms.Label labelMostrarPila;
        private System.Windows.Forms.Button buttonPop;
        private System.Windows.Forms.Label labelPop;
        private System.Windows.Forms.Label labelDequeue;
        private System.Windows.Forms.Button buttonDequeue;
    }
}

