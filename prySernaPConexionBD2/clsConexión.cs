using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prySernaPConexionBD2
{
    public class clsConexión
    {
        //cadena de conexion
        public string cadenaConexion;

        

        public clsConexión()
        {
            cadenaConexion = "Server=localhost;Database=Comercio;Trusted_Connection=True;";
        }

        public bool Iniciar(clsInicioSesión Iniciar)
        {

            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    conexion.Open();
                    string query = " SELECT COUNT (*) FROM Usuarios WHERE Usuario = @Usuario AND Contraseña = @Contraseña";

                    SqlCommand comando = new SqlCommand(query, conexion);
                    comando.Parameters.AddWithValue("@Usuario", Iniciar.Usuario);
                    comando.Parameters.AddWithValue("@Contraseña", Iniciar.Contraseña);

                    int resultado=(int)comando.ExecuteScalar();
                    return resultado > 0;
                }
                
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public void AgregarUsuario(clsInicioSesión Usuario)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    conexion.Open();
                    string query = "INSERT INTO Usuarios (Nombre, Contraseña)" + "VALUES(@Usuario, @Contraseña)";
                    SqlCommand comando = new SqlCommand(query, conexion);
                    comando.Parameters.AddWithValue("@Usuario", Usuario.Usuario);
                    comando.Parameters.AddWithValue("@Contraseña", Usuario.Contraseña);
                    comando.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al crear el usuario: " + ex.Message);
            }
        }
        public void Agregar(clsProducto Producto)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    conexion.Open();
                    string query = "INSERT INTO Productos (Nombre, Descripcion, Precio, Stock, CategoriaId) " +
                                   "VALUES (@Nombre, @Descripcion, @Precio, @Stock, @CategoriaId)";

                    SqlCommand comando = new SqlCommand(query, conexion);
                    comando.Parameters.AddWithValue("@Nombre", Producto.Nombre);
                    comando.Parameters.AddWithValue("@Descripcion", Producto.Descripcion);
                    comando.Parameters.AddWithValue("@Precio", Producto.Precio);
                    comando.Parameters.AddWithValue("@Stock", Producto.Stock);
                    comando.Parameters.AddWithValue("@CategoriaId", Producto.CategoriaId);

                    comando.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar producto: " + ex.Message);
            }
        }






        public void CargarProductos(DataGridView dgv)
        {
                try
                {
                  string query = "SELECT Codigo, Nombre, Descripcion, Precio, Stock, CategoriaId FROM Productos";
                  
                 using (SqlConnection conn = new SqlConnection(cadenaConexion))
                  using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                  {
                    DataTable tabla = new DataTable();
                    adapter.Fill(tabla);
                    dgv.DataSource = tabla;
                  }    
                
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar los datos: " + ex.Message);
                }
            
        }
       



        /*  public DataTable Obtener(DataGridView dgvProductos)
          {
              DataTable tabla = new DataTable();
              string query = "SELECT Codigo, Nombre, Descripcion, Precio, Stock, Categoria FROM Productos";

              using (SqlConnection conn = new SqlConnection(cadenaConexion))
              {
                  conn.Open();
                  using (SqlCommand cmd = new SqlCommand(query, conn))
                  {
                      SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                      adapter.Fill(tabla);
                      dgvProductos.DataSource = tabla;
                  }
              }

              return tabla;
          *///}

        public void Modificar(clsProducto producto)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(cadenaConexion))
                {
                    string query = "UPDATE Productos SET Nombre=@Nombre, Descripcion=@Descripcion, Precio=@Precio, " +
                                   "Stock=@Stock, CategoriaId=@CategoriaId WHERE Codigo=@Codigo";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Codigo", producto.Codigo);
                    cmd.Parameters.AddWithValue("@Nombre", producto.Nombre);
                    cmd.Parameters.AddWithValue("@Descripcion", producto.Descripcion);
                    cmd.Parameters.AddWithValue("@Precio", producto.Precio);
                    cmd.Parameters.AddWithValue("@Stock", producto.Stock);
                    cmd.Parameters.AddWithValue("@CategoriaId", producto.CategoriaId);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception error)
            {
                MessageBox.Show($"No se pudo modificar el producto: {error.Message}");
            }
        }


        public void Eliminar(int codigo)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(cadenaConexion))
                {
                    string query = "DELETE FROM Productos WHERE Codigo = @Codigo";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Codigo", codigo);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception error)
            {
                MessageBox.Show($"No se pudo eliminar el producto: {error.Message}");
            }
        }

       

    }
}

