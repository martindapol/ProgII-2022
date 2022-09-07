using Carreras__SP.Datos;
using Carreras__SP.Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Carreras__SP.Presentacion
{
    public partial class frmNuevaCarrera : Form
    {

        Carrera carrera;
        Helper helper = new Helper();

        public frmNuevaCarrera()
        {
            InitializeComponent();
            carrera = new Carrera();
        }

        private void frmNuevaCarrera_Load(object sender, EventArgs e)
        {
            cboMaterias.DataSource = helper.Consultar_SP("sp_consultar_asignaturas");
            cboMaterias.ValueMember = "id_asignatura";
            cboMaterias.DisplayMember = "nombre";
        }

        private void btnAgregarDetalle_Click(object sender, EventArgs e)
        {
            if (txtNombreCarrera.Text.Equals(String.Empty))
            {
                MessageBox.Show("Ingrese el nombre de la carrera", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (cboMaterias.Text.Equals(String.Empty))
            {
                MessageBox.Show("Seleccione una materia", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (txtAnioCursado.Text == "")
            {
                MessageBox.Show("Ingrese el año de cursado", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (rbnPrimerCuatrimestre.Checked == false && rbnSegundoCuatrimestre.Checked == false)
            {
                MessageBox.Show("Seleccione un cuatrimestre", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            foreach (DetalleCarrera dc in carrera.DetallesCarrera)
            {
                if (dc.Asignatura.Nombre == cboMaterias.Text)
                {
                    MessageBox.Show("La carrera que intenta agregar ya existe", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }

            Asignatura asignatura = new Asignatura();
            asignatura.Codigo = Convert.ToInt32(cboMaterias.SelectedValue);
            asignatura.Nombre = cboMaterias.Text;

            int anioCursado = int.Parse(txtAnioCursado.Text);
            int cuatrimestre = 0;

            if (rbnPrimerCuatrimestre.Checked) cuatrimestre = 1;
            if (rbnSegundoCuatrimestre.Checked) cuatrimestre = 2;

            DetalleCarrera detalle = new DetalleCarrera(anioCursado, cuatrimestre, asignatura);

            carrera.AgregarDetalle(detalle);

            dgvDetalles.Rows.Add(asignatura.Codigo, asignatura.Nombre, anioCursado, cuatrimestre);
        }

        private void dgvDetalles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDetalles.CurrentCell.ColumnIndex == 4)
            {
                carrera.EliminarDetalle(dgvDetalles.CurrentRow.Index);
                dgvDetalles.Rows.Remove(dgvDetalles.CurrentRow);
            }
        }

        private void txtNombreCarrera_TextChanged(object sender, EventArgs e)
        {
            carrera.Nombre_Titulo = txtNombreCarrera.Text;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            
            if (txtNombreCarrera.Text.Equals(String.Empty))
            {
                MessageBox.Show("Inserte el nombre de la carrera", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                helper.AltaCarrera(carrera);
                MessageBox.Show("Se agregó con exito la carrera", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
   
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
