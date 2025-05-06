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
    public partial class frmAgregarContacto : Form
    {
        public frmAgregarContacto()
        {
            InitializeComponent();
        }


        private void frmAgregarContacto_Load(object sender, EventArgs e)
        {
            btnAgregar.Enabled = false;
            clsConexión BD = new clsConexión();
            BD.CargarContactos(dgvContactos);
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

        }
        private void TeclaESC(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close(); // Cierra el formulario al presionar ESC
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                clsContactos contacto = new clsContactos();
                clsConexión conexion = new clsConexión();
                contacto.Nombre = txtNombre.Text;
                contacto.Apellido = txtApellido.Text;
                contacto.Telefono = long.Parse(txtTeléfono.Text);
                contacto.Correo = txtCorreo.Text;
                contacto.CategoriaId = Convert.ToInt32(cmbCategorias.SelectedValue);
                conexion.AgregarContactos(contacto);
                conexion.CargarContactos(dgvContactos);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"No se agrego el contacto" + ex.Message);
            }
            txtNombre.Clear();
            txtApellido.Clear();
            txtTeléfono.Clear();
            txtCorreo.Clear();
            cmbCategorias.SelectedIndex = -1;
        }

        private void ValidarDatos()
        {
            if (numCodigo.Value > 0 && txtNombre.Text != "" && txtApellido.Text != "" && txtTeléfono.Text!="" && txtCorreo.Text!="")
            {
                btnAgregar.Enabled = true;
            }
            else
            {
                btnAgregar.Enabled = false;
            }
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

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {
            ValidarDatos();
        }

        private void txtTeléfono_TextChanged(object sender, EventArgs e)
        {
            ValidarDatos();
        }

        private void txtCorreo_TextChanged(object sender, EventArgs e)
        {
            ValidarDatos();
        }
    }

    
}
