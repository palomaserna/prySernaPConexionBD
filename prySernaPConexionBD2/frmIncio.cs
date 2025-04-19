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
    public partial class frmIncio : Form
    {
        public frmIncio()
        {
            InitializeComponent();
        }

        private void frmIncio_Load(object sender, EventArgs e)
        {
            clsConexión BD=new clsConexión();
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

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAgregarProducto v=new frmAgregarProducto();
            v.ShowDialog();
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEliminarProducto v=new frmEliminarProducto();
            v.ShowDialog();
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmModificarProducto v=new frmModificarProducto();
            v.ShowDialog();
        }
    }
}
