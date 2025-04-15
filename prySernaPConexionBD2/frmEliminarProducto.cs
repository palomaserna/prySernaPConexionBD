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
    public partial class frmEliminarProducto : Form
    {
        public frmEliminarProducto()
        {
            InitializeComponent();
        }

        private void frmEliminarProducto_Load(object sender, EventArgs e)
        {
            clsConexión BD = new clsConexión();
            BD.CargarProductos(dgvProductos);
            btnEliminar.Enabled = false;
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
