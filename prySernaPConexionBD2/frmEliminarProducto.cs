using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.CompilerServices.RuntimeHelpers;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace prySernaPConexionBD2
{
    public partial class frmEliminarProducto : Form
    {
        public frmEliminarProducto()
        {
            InitializeComponent();
        }

        private void frmEliminarProducto_Load(object sender, EventArgs e)
        {
            clsConexión BD = new clsConexión();
            BD.CargarProductos(dgvProductosE);
            btnEliminar.Enabled = false;
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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
             try
             {
                int codigo = (int)numCodigo.Value;

                clsConexión BD = new clsConexión();
                BD.Eliminar(codigo);
                BD.CargarProductos(dgvProductosE);
             } 
            catch (Exception ex)
             {
                MessageBox.Show($"No se elimino el producto");
            }
            numCodigo.Value = 0;



        }

        private void numCodigo_ValueChanged(object sender, EventArgs e)
        {
            ValidarDatos();
        }

       

       
    }
}
