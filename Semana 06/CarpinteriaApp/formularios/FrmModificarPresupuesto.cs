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
    public partial class FrmModificarPresupuesto : Form
    {
        private Presupuesto oPresupuesto;
        private IServicio servicio;
    
        public FrmModificarPresupuesto(int presupuestoNro, FabricaServicio fabrica)
        {
            InitializeComponent();
            oPresupuesto = new Presupuesto();
            oPresupuesto.PresupuestoNro = presupuestoNro;
            servicio = fabrica.CrearServicio();
            CargarProductos();
        }

        private void CargarProductos()
        {
            List<Producto> lst = servicio.ObtenerProductos();
            if (lst.Count > 0)
            {
                cboProductos.DataSource = lst;
                cboProductos.DisplayMember = "Nombre";
                cboProductos.ValueMember = "ProductoNro";
            }
        }

        private void FrmModificarPresupuesto_Load(object sender, EventArgs e)
        {
            //En el título de la ventana agregamos el número de presupuesto
            this.Text = this.Text + oPresupuesto.PresupuestoNro.ToString();
            string sp = "SP_CONSULTAR_DETALLES_PRESUPUESTO";
            List<Parametro> lst = new List<Parametro>();
            lst.Add(new Parametro("@presupuesto_nro", oPresupuesto.PresupuestoNro));

            DataTable dt = HelperDB.ObtenerInstancia().ConsultaSQL(sp, lst);
            bool primero = true;

            //Mappeamos los datos del presupuesto obtenidos desde el SP
            //con un objeto Presupuesto y actualizamos la pantalla:
            foreach (DataRow fila in dt.Rows)
            {
                //Solo para la primer fila recuperamos los datos del maestro:
                if (primero)
                {
                    oPresupuesto.Cliente = fila["cliente"].ToString();
                    oPresupuesto.Fecha = DateTime.Parse(fila["fecha"].ToString());
                    oPresupuesto.Descuento = Double.Parse(fila["descuento"].ToString());
                    txtCliente.Text = oPresupuesto.Cliente;
                    txtFecha.Text = oPresupuesto.Fecha.ToString("dd/MM/yyyy");
                    txtDto.Text = oPresupuesto.Descuento.ToString();
                    primero = false;
                }
                int productoNro = int.Parse(fila["id_producto"].ToString());
                string nombre = fila["n_producto"].ToString();
                Double precio = Double.Parse(fila["precio"].ToString());

                Producto oProducto = new Producto(productoNro, nombre, precio);
                int cantidad = int.Parse(fila["cantidad"].ToString());
                DetallePresupuesto detalle = new DetallePresupuesto(oProducto, cantidad);
                oPresupuesto.AgregarDetalle(detalle);

                dgvDetalles.Rows.Add(new object[] {
                    oProducto.ProductoNro,
                    oProducto.Nombre,
                    oProducto.Precio,
                    detalle.Cantidad
                });
            }

            txtTotal.Text = oPresupuesto.CalcularTotal().ToString();
            txtFinal.Text = oPresupuesto.CalcularTotalConDescuento().ToString();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (cboProductos.Text.Equals(String.Empty))
            {
                MessageBox.Show("Debe seleccionar un PRODUCTO!", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (txtCantidad.Text == "" || !int.TryParse(txtCantidad.Text, out _))
            {
                MessageBox.Show("Debe ingresar una cantidad válida!", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }


            foreach (DataGridViewRow row in dgvDetalles.Rows)
            {
                if (row.Cells["colProd"].Value.ToString().Equals(cboProductos.Text))
                {
                    MessageBox.Show("PRODUCTO: " + cboProductos.Text + " ya se encuentra como detalle!", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;

                }
            }

            Producto p = (Producto)cboProductos.SelectedItem;
            int cantidad = Convert.ToInt32(txtCantidad.Text);

            DetallePresupuesto detalle = new DetallePresupuesto(p, cantidad);
            oPresupuesto.AgregarDetalle(detalle);
            dgvDetalles.Rows.Add(new object[] {p.ProductoNro, p.Nombre, p.Precio, txtCantidad.Text });

            CalcularTotal();
        }
        private void CalcularTotal()
        {
            double total = oPresupuesto.CalcularTotal();
            txtTotal.Text = total.ToString();

            if (txtDto.Text != "")
            {
                double dto = (total * Convert.ToDouble(txtDto.Text)) / 100;
                txtFinal.Text = (total - dto).ToString();
            }
        }

        private void dgvDetalles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDetalles.CurrentCell.ColumnIndex == 4)
            {
                oPresupuesto.QuitarDetalle(dgvDetalles.CurrentRow.Index);
                //click button:
                dgvDetalles.Rows.Remove(dgvDetalles.CurrentRow);
                //presupuesto.quitarDetalle();
                CalcularTotal();

            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtCliente.Text == "")
            {
                MessageBox.Show("Debe ingresar un cliente!", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (dgvDetalles.Rows.Count == 0)
            {
                MessageBox.Show("Debe ingresar al menos detalle!", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            GuardarPresupuesto();
        }
        private void GuardarPresupuesto()
        {
            oPresupuesto.Descuento = Double.Parse(txtDto.Text);
            oPresupuesto.Cliente = txtCliente.Text;
            
            if (servicio.ActualizarPresupuesto(oPresupuesto))
            {
                MessageBox.Show("Presupuesto modificado", "Informe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
            }
            else
            {
                MessageBox.Show("ERROR. No se pudo modificar el presupuesto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
