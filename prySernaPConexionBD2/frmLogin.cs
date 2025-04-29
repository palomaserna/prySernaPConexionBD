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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            //int IntentosFallidos = 0;
        }
        int IntentosFallidos = 0;

        private void frmLogin_Load(object sender, EventArgs e)
        {
           clsConexión conexion=new clsConexión();
            txtContraseña.PasswordChar = '*';
            this.KeyPreview = true;
            this.KeyDown += TeclaESC;
            btnEntrar.Enabled = false;
        }

      

        private void btnEntrar_Click_1(object sender, EventArgs e)
        {
            

            clsInicioSesión Inicio = new clsInicioSesión();
            clsConexión conexión = new clsConexión();

            Inicio.Usuario = txtUsuario.Text;
            Inicio.Contraseña = txtContraseña.Text;
            bool InicioExitoso = conexión.Iniciar(Inicio);
            
            if (InicioExitoso)
            {
                frmIncio inicio = new frmIncio();
                inicio.Show();
                this.Hide();
            }
            else
            {
               
                IntentosFallidos++;

                MessageBox.Show($"Usuario o Contraseña incorrecto . Intento{IntentosFallidos} de 3");
            }
            if (IntentosFallidos >= 3)
            {
                MessageBox.Show("Demasiados intentos fallidos");
                Application.Exit();
            }

        }

        private void TeclaESC(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close(); // Cierra el formulario al presionar ESC
            }
        }
        public void ValidarDatos()
        {
            if(txtUsuario.Text != "" && txtContraseña.Text != "")
            {
                btnEntrar.Enabled = true;
            }
            else
            {
                btnEntrar.Enabled = false;
            }
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            ValidarDatos();
        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {
            ValidarDatos();
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {

        }
    }
}
