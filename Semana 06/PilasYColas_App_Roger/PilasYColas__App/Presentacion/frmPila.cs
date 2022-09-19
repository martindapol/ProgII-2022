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

    // LIFO - last in, first out
{
    public partial class frmPila : Form
    {
        private IColeccion coleccion;
        public frmPila()
        {
            InitializeComponent();
            coleccion = new Pila(20);
        }

        private void btnAgregarElementoPila_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtElementoPila.Text))
            {
                object elemento = txtElementoPila.Text;
                if (coleccion.agregar(elemento))
                {
                    lstElementosPila.Items.Add(elemento);
                    MessageBox.Show("Se añadió el elemento a la pila", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("La pila esta llena, no se puede añadir mas elementos", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                txtElementoPila.Text = "";
                txtElementoPila.Focus();
            }
        }

        private void btnPrimerElemento_Click(object sender, EventArgs e)
        {
            if (!coleccion.listaVacia())
                MessageBox.Show("El primer elemento de la pila es: " + coleccion.primerElemento(), "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnEstaVaciaPila_Click(object sender, EventArgs e)
        {
            object elementos = coleccion.cantidadElementos();
            string mensaje = coleccion.listaVacia() ? "La pila esta vacía" : "La pila contiene " + elementos + " elementos";
            MessageBox.Show(mensaje, "Elemento", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnExtraerElementoPila_Click(object sender, EventArgs e)
        {
            object elemento = coleccion.extraer();
            lstElementosPila.Items.Remove(elemento);
        }

        private void btnProximoEnSalir_Click(object sender, EventArgs e)
        {
            object elemento = coleccion.proximoEnSalir();
            if(elemento != null)
                MessageBox.Show("El próximo elemento de la pila en salir es: " + elemento, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Pila vacía!" + elemento, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
