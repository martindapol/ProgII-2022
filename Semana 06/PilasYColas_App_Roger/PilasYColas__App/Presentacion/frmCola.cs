using PilasYColas__App.Clases;
using PilasYColas__App.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PilasYColas__App.Presentacion
{
    public partial class frmCola : Form
    {
        private IColeccion coleccion;
        public frmCola()
        {
            InitializeComponent();
            coleccion = new Cola(20);
        }

        private void btnAgregarElementoCola_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtElementoCola.Text))
            {
                object elemento = txtElementoCola.Text;
                if (coleccion.agregar(elemento))
                {
                    lstElementosCola.Items.Add(elemento);
                    MessageBox.Show("Se añadió el elemento a la Cola", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("La cola esta llena, no se puede añadir mas elementos", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                txtElementoCola.Text = "";
                txtElementoCola.Focus();
            }
        }

        private void btnPrimerElementoCola_Click(object sender, EventArgs e)
        {
            if (!coleccion.listaVacia())
            MessageBox.Show("El primer elemento de la cola es: " + coleccion.primerElemento(), "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnEstaVaciaCola_Click(object sender, EventArgs e)
        {
            object elementos = coleccion.cantidadElementos();
            string mensaje = coleccion.listaVacia() ? "La cola esta vacía" : "La cola contiene " + elementos + " elementos";
            MessageBox.Show(mensaje, "Elemento", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnExtraerElementoCola_Click(object sender, EventArgs e)
        {
            object elemento = coleccion.extraer();
            lstElementosCola.Items.Remove(elemento);
            txtElementoCola.Focus();
        }

        private void btnProximoEnSalirCola_Click(object sender, EventArgs e)
        {
            object elemento = coleccion.proximoEnSalir();
            if(elemento != null)
                MessageBox.Show("El próximo elemento de la cola en salir es: " + elemento, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Cola vacía!" + elemento, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSalirCola_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
