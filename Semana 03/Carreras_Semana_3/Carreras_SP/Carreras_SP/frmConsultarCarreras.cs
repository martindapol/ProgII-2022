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
    public partial class frmConsultarCarreras : Form
    {
        public frmConsultarCarreras()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != -1)
            {   
                int id_carrera = (int)comboBox1.SelectedValue;
                if (MessageBox.Show("Seguro que desea eliminar la carrera " +  comboBox1.Text + "?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {


                    new AccesoBD().EliminarCarrera(id_carrera);
                }
            }

        }
    }
}
