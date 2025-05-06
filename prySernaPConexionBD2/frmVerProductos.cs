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
    public partial class frmVerProductos : Form
    {
        public frmVerProductos()
        {
            InitializeComponent();
        }

        private void frmVerProductos_Load(object sender, EventArgs e)
        {
            clsConexión BD = new clsConexión();
            BD.CargarProductos(dgvProductos);
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
    }
}
