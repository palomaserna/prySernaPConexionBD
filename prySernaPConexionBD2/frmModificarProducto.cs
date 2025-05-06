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
    public partial class frmModificarProducto : Form
    {
        public frmModificarProducto()
        {
            InitializeComponent();
        }

        private void frmModificarProducto_Load(object sender, EventArgs e)
        {
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

                this.KeyPreview = true;
                this.KeyDown += TeclaESC;
            }
            btnModificar.Enabled = false;
            numPrecio.Maximum = 100000000; 
           // numPrecio.Minimum = 1;         


        }
        private void TeclaESC(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close(); // Cierra el formulario al presionar ESC
            }
        }

        private void ValidarDatos()
        {
            if (numCodigo.Value > 0 && txtNombre.Text != "" && txtDescripcion.Text != "" && numPrecio.Value > 0 && numStock.Value > 0)
            {
                btnModificar.Enabled = true;
            }
            else
            {
                btnModificar.Enabled = false;
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                clsConexión BD = new clsConexión();
                clsProducto producto = new clsProducto();
                {
                    producto.Codigo = Convert.ToInt32(numCodigo.Value);
                    producto.Nombre = txtNombre.Text;
                    producto.Descripcion = txtDescripcion.Text;
                    producto.Precio = Convert.ToInt32(numPrecio.Value);
                    producto.Stock = Convert.ToInt32(numStock.Value);
                    producto.CategoriaId = Convert.ToInt32(cmbCategorias.SelectedValue);
                    BD.Modificar(producto);
                    BD.CargarProductos(dgvProductos);
                };
            } catch (Exception ex)
            {
                MessageBox.Show($"No se modifico el producto");
            }
            numCodigo.Value = 0;
            txtNombre.Text = "";
            txtDescripcion.Text = "";
            numPrecio.Value = 0;
            numStock.Value = 0;
            cmbCategorias.SelectedIndex = -1;



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

        private void cmbCategorias_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCategorias.SelectedIndex != -1)
            {
                btnModificar.Enabled = true;
            }
            else
            {
                btnModificar.Enabled = false;
            }
        }
        private void dgvProductos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                
                DataGridViewRow fila = dgvProductos.Rows[e.RowIndex];
                numCodigo.Value = Convert.ToInt32(fila.Cells["Codigo"].Value);
                txtNombre.Text = fila.Cells["Nombre"].Value.ToString();
                txtDescripcion.Text = fila.Cells["Descripcion"].Value.ToString();
                numPrecio.Value = Convert.ToDecimal(fila.Cells["Precio"].Value);
                numStock.Value = Convert.ToInt32(fila.Cells["Stock"].Value);
                cmbCategorias.SelectedValue = Convert.ToInt32(fila.Cells["CategoriaId"].Value);

                //cmbCategorias.SelectedItem = fila.Cells["CategoriaId"].Value.ToString();
            }
        }

        
    }
}
