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
    public partial class FrmConsultarPresupuestos : Form
    {   
        private IServicio servicio;
        private FabricaServicio fabrica;

        public FrmConsultarPresupuestos(FabricaServicio fabrica)
        {
            InitializeComponent();
            this.fabrica = fabrica;
            servicio = fabrica.CrearServicio();
        }

        private void Frm_Consultar_Presupuestos_Load(object sender, EventArgs e)
        {
            dtpDesde.Value = DateTime.Now;
            dtpHasta.Value = DateTime.Now.AddDays(7);
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            
            dgvPresupuestos.Rows.Clear();
            List <Presupuesto> lst = servicio.ObtenerPresupuestos(dtpDesde.Value, dtpHasta.Value, txtCliente.Text);
            foreach (Presupuesto presupuesto in lst)
            {
                dgvPresupuestos.Rows.Add(new object[] {
                    presupuesto.PresupuestoNro,
                    presupuesto.Fecha.ToString("dd/MM/yyyy"),
                    presupuesto.Cliente,
                    });
            }
        }

        private void dgvPresupuestos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvPresupuestos.CurrentCell.ColumnIndex == 4)
            {
                int nro = int.Parse(dgvPresupuestos.CurrentRow.Cells["colNro"].Value.ToString());
                new FrmDetallesPresupuesto(nro, fabrica).ShowDialog();
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro que desea quitar el presupuesto seleccionado?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (dgvPresupuestos.CurrentRow != null)
                {
                    int nro = int.Parse(dgvPresupuestos.CurrentRow.Cells["colNro"].Value.ToString());
                    if (servicio.BorrarPresupuesto(nro))
                    {
                        MessageBox.Show("El presupuesto se quitó exitosamente!", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.btnConsultar_Click(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("El presupuesto NO se quitó exitosamente!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Seguro que desea salir?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void dgvPresupuestos_Click(object sender, EventArgs e)
        {
            DataGridViewRow actual = dgvPresupuestos.CurrentRow;
            if (actual != null)
            {
                btnBorrar.Enabled = BtnEditar.Enabled = true;

            }
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            int nro = int.Parse(dgvPresupuestos.CurrentRow.Cells["colNro"].Value.ToString());
            new FrmModificarPresupuesto(nro, fabrica).ShowDialog();
            this.btnConsultar_Click(null, null);
        }
    }
}
