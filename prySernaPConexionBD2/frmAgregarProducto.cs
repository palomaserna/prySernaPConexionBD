using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prySernaPConexionBD2
{
    public partial class frmAgregarProducto : Form
    {
        public frmAgregarProducto()
        {
            InitializeComponent();
        }
       

        private void frmAgregarProducto_Load(object sender, EventArgs e)
        {
            btnAgregar.Enabled = false;
            clsConexión BD = new clsConexión();
            BD.CargarProductos(dgvProductos);


            using (SqlConnection conexion = new SqlConnection(BD.cadenaConexion))
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("SELECT Id, Nombre FROM Categorias", conexion);
                SqlDataAdapter adaptador = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adaptador.Fill(dt);
                cmbCategorias.DataSource = dt;
                cmbCategorias.DisplayMember = "Nombre";
                cmbCategorias.ValueMember = "Id";


            }
        }
        

        private void ValidarDatos()
        {
            if (numCodigo.Value > 0 && txtNombre.Text != "" && txtDescripcion.Text != ""&& numPrecio.Value > 0 && numStock.Value > 0)
            {
                btnAgregar.Enabled = true;
            }
            else
            {
                btnAgregar.Enabled = false;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                clsProducto producto = new clsProducto();
                clsConexión BD = new clsConexión();
              //  producto.Codigo = Convert.ToInt32(numCodigo.Value);
                producto.Nombre = txtNombre.Text;
                producto.Descripcion = txtDescripcion.Text;
                producto.Precio = Convert.ToInt32(numPrecio.Value);
                producto.Stock = Convert.ToInt32(numStock.Value);
                producto.CategoriaId = Convert.ToInt32(cmbCategorias.SelectedValue);

                BD.Agregar(producto);
                BD.CargarProductos(dgvProductos);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"No se agrego el producto" + ex.Message);
            }
            numCodigo.Value = 0;
            txtNombre.Clear();
            txtDescripcion.Clear();
            numPrecio.Value = 0;
            numStock.Value = 0;
            cmbCategorias.SelectedIndex = -1;
        }

        private void cmbCategorias_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCategorias.SelectedIndex != -1)
            {
                btnAgregar.Enabled = true;
            }
            else
            {
                btnAgregar.Enabled = false;
            }
        }

        private void numCodigo_ValueChanged(object sender, EventArgs e)
        {
            ValidarDatos();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            ValidarDatos();
        }

        private void txtDescripcion_TextChanged(object sender, EventArgs e)
        {
            ValidarDatos();
        }

        private void numPrecio_ValueChanged(object sender, EventArgs e)
        {
            ValidarDatos();
        }

        private void numStock_ValueChanged(object sender, EventArgs e)
        {
            ValidarDatos();
        }

        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
