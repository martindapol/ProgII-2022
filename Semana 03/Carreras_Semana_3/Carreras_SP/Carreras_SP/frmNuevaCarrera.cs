using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Carreras_SP
{
    public partial class frmNuevaCarrera : Form
    {

        Carrera carrera = new Carrera();
        AccesoBD accesoBD = new AccesoBD();
        public frmNuevaCarrera()
        {
            InitializeComponent();
            
        }

        private void frmNuevaCarrera_Load(object sender, EventArgs e)
        {
            cboMateria.DataSource = accesoBD.Consultar_SP("SP_consultar_asignaturas");
            cboMateria.ValueMember = "id_asignatura";
            cboMateria.DisplayMember = "nombre";
        }

        private void btnAgregarDetalle_Click(object sender, EventArgs e)
        {
            if (txtNombreCarrera.Text == "")
            {
                MessageBox.Show("Ingrese el nombre de la carrera", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (cboMateria.SelectedItem.Equals(String.Empty))
            {
                MessageBox.Show("seleccione una materia", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (txtAnioCursado.Text == "")
            {
                MessageBox.Show("Debe ingresar un año de cursado", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (!rbnPrimerCuatrimestre.Checked && !rbnSegundoCuatrimestre.Checked)
            {
                MessageBox.Show("Debe seleccionar un cuatrimestre", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            foreach (DetalleCarrera dc in carrera.DetallesCarrera)
            {
                if (dc.Materia.Nombre == cboMateria.Text)
                {
                    MessageBox.Show("Solo puede agregar una vez cada materia", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }
            Asignatura asignatura = new Asignatura();
            asignatura.Codigo = Convert.ToInt32(cboMateria.SelectedValue);
            asignatura.Nombre = cboMateria.Text;
            int anioCursado = int.Parse(txtAnioCursado.Text);
            int cuatrimestre = 0;
            if (rbnPrimerCuatrimestre.Checked) cuatrimestre = 1;
            if (rbnSegundoCuatrimestre.Checked) cuatrimestre = 2;

            DetalleCarrera detCarrera = new DetalleCarrera(anioCursado, cuatrimestre, asignatura);
            carrera.AgregarDetalle(detCarrera);
            dgvDetalles.Rows.Add(new Object[] { asignatura.Codigo, asignatura.Nombre, anioCursado, cuatrimestre });
        }

        private void dgvDetalles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDetalles.CurrentCell.ColumnIndex == 4)
            {
                carrera.EliminarDetalle(dgvDetalles.CurrentCell.RowIndex);
                dgvDetalles.Rows.Remove(dgvDetalles.CurrentRow);
            }
        }

        private void txtNombreCarrera_TextChanged(object sender, EventArgs e)
        {
            carrera.Nombre_Titulo = txtNombreCarrera.Text;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtNombreCarrera.Text == "")
            {
                MessageBox.Show("Ingrese el nombre de la carrera",
                "Atención", MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
                return;
            }

            accesoBD.AltaCarrera(carrera);

            MessageBox.Show("La carrera ha sido agregada", "Información",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
