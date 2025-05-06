using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prySernaPConexionBD2
{
    public partial class frmEliminarContacto : Form
    {
        public frmEliminarContacto()
        {
            InitializeComponent();
        }

        private void frmEliminarContacto_Load(object sender, EventArgs e)
        {
            clsConexión BD = new clsConexión();
            BD.CargarContactos(dgvContactos);
           // btnEliminar.Enabled = false;
            this.KeyPreview = true;
            this.KeyDown += TeclaESC;

        }
        private void TeclaESC(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close(); // Cierra el formulario al presionar ESC
            }
        }


        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                int codigo = (int)numCodigo.Value;

                clsConexión BD = new clsConexión();
                BD.EliminarContactos(codigo);
                BD.CargarContactos(dgvContactos);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"No se elimino el producto");
            }
            numCodigo.Value = 0;
        }
        private void ValidarDatos()
        {
            if (numCodigo.Value > 0)
            {
                btnEliminar.Enabled = true;
            }
            else
            {
                btnEliminar.Enabled = false;
            }
        }

        private void numCodigo_ValueChanged(object sender, EventArgs e)
        {
            ValidarDatos();
        }
    }
}
