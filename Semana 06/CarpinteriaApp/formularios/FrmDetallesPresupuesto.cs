using CarpinteriaApp.datos;
using CarpinteriaApp.dominio;
using CarpinteriaApp.Servicios;
using CarpinteriaApp.Servicios.Interfaz;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarpinteriaApp.formularios
{
    public partial class FrmDetallesPresupuesto : Form
    {
        private int presupuestoNro;
        private IServicio servicio;
        public FrmDetallesPresupuesto(int presupuestoNro, FabricaServicio fabrica)
        {
            InitializeComponent();
            this.presupuestoNro = presupuestoNro;
            servicio = fabrica.CrearServicio();
        }

        private void FrmDetallesPresupuesto_Load(object sender, EventArgs e)
        {
            //En el título de la ventana agregamos el número de presupuesto
            this.Text = this.Text + presupuestoNro.ToString();
            Presupuesto presupuesto = servicio.ObtenerPresupuestoPorNro(presupuestoNro);    
            
            txtCliente.Text = presupuesto.Cliente;
            txtDto.Text = presupuesto.Descuento.ToString();
            txtFecha.Text = presupuesto.Fecha.ToString("dd/MM/yyyy");
            txtTotal.Text = presupuesto.CalcularTotal().ToString();
        
            foreach(DetallePresupuesto detalle in presupuesto.Detalles)
            {
                dgvDetalles.Rows.Add(new object[] {detalle.Producto.Nombre, detalle.Producto.Precio, detalle.Cantidad });
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}