using RecetasLib.entidades;
using RecetasSLN.servicios;
using RecetasSLN.servicios.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecetasSLN
{
    public partial class FrmAltaReceta : Form
    {
        private IServicio oServicio;
        private FabricaServicio oFabrica;
        private Receta receta;
        public FrmAltaReceta()
        {
            InitializeComponent();
            //oServicio = new Servicio();
            oFabrica = new FabricaServicioImp();
            oServicio = oFabrica.CrearServicio();
            receta = new Receta();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                MessageBox.Show("Debe ingresar un nombre válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNombre.Focus();
                return;
            }
            else if (cboTipo.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un tipo de receta válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else if (dgvDetalles.Rows.Count < 3)
            {
                MessageBox.Show("Debe insertar al menos tres ingredientes...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            receta.Cheff = txtCheff.Text;
            receta.Nombre = txtNombre.Text;
            //CUIDADO: Este combo es fijo, no se carga con elementos
            //de la base de datos, entonces podes tomar SelectedIndex + 1 como Id

            receta.TipoReceta = cboTipo.SelectedIndex + 1; 

            if (oServicio.GuardarReceta(receta)){
                MessageBox.Show("Receta insertada con éxito", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();
            }
        }

        private void LimpiarCampos()
        {
            txtCheff.Text = String.Empty;
            txtNombre.Text = String.Empty;
            cboTipo.SelectedIndex = -1;
            cboProducto.SelectedIndex = -1;
            nudCantidad.Value = 1;
            dgvDetalles.Rows.Clear();
            lblNro.Text = "Receta #:" + oServicio.ProximaReceta().ToString();
            lblTotalIngredientes.Text = "Total de ingredientes:";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Está seguro que desea cancelar?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Dispose();
            }
            else
            {
                return;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (cboProducto.SelectedIndex != -1)
            {
                //cotrolar que no este ya cargado en la grilla
                if (!existe(cboProducto.Text))
                {
                    DetalleReceta det = new DetalleReceta();
                    det.Cantidad = (int)nudCantidad.Value;
                    det.Ingrediente = (Ingrediente)cboProducto.SelectedItem;
                    receta.AgregarDetalle(det);
                    dgvDetalles.Rows.Add(new object[] { det.Ingrediente.IdIngrediente, det.Ingrediente.Nombre, det.Cantidad });
                    lblTotalIngredientes.Text = "Total de ingredientes: " + dgvDetalles.Rows.Count.ToString();
                }
            }
        }

        private bool existe(string selectedItem)
        {
            bool aux = false;
            foreach (DataGridViewRow item in dgvDetalles.Rows)
            {
                if (item.Cells["ingrediente"].Value.ToString().Equals(selectedItem))
                {
                    aux = true;
                    break;
                }

            }
            return aux;
        }

        private void FrmAltaReceta_Load(object sender, EventArgs e)
        {
            lblNro.Text += oServicio.ProximaReceta().ToString();
            CargarIngredientes();
        }

        private void CargarIngredientes()
        {
            cboProducto.DataSource = oServicio.ObtenerIngredientes();
            cboProducto.DisplayMember = "Nombre";
            cboProducto.ValueMember = "IdIngrediente";//Nombre de la Property del objeto
        }

        private void nudCantidad_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
