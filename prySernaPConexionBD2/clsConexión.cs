using System;
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



        public void Agregar(clsProducto Producto)
        {
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                conexion.Open();
                string query = "INSERT INTO Productos(Codigo, Nombre, Descripcion, Precio, Stock, CategoriaId)" +
                    "VALUES (@Codigo, @Nombre, @Descripcion, @Precio, @Stock, @CategoriaId)";

                SqlCommand comando = new SqlCommand(query, conexion);
                comando.Parameters.AddWithValue("@Codigo", Producto.Codigo);
                comando.Parameters.AddWithValue("@Nombre", Producto.Nombre);
                comando.Parameters.AddWithValue("@Descripcion", Producto.Descripcion);
                comando.Parameters.AddWithValue("@Precio", Producto.Precio);
                comando.Parameters.AddWithValue("@Stock", Producto.Stock);
                comando.Parameters.AddWithValue("@CategoriaId", Producto.CategoriaId);
                comando.ExecuteNonQuery();
            }
        }


       


        // READ - Obtener todos los productos
        /* public List<clsProducto> ObtenerTodos()
         {
             List<clsProducto> lista = new List<clsProducto>();
             using (SqlConnection conn = new SqlConnection(cadenaConexion))
             {
                 string query = "SELECT * FROM Productos";
                 SqlCommand cmd = new SqlCommand(query, conn);
                 conn.Open();
                 SqlDataReader reader = cmd.ExecuteReader();
                 while (reader.Read())
                 {
                     clsProducto producto = new clsProducto
                     {
                         Codigo = Convert.ToInt32(reader["Codigo"]),
                         Nombre = reader["Nombre"].ToString(),
                         Descripcion = reader["Descripcion"].ToString(),
                         Precio = reader["Precio"].ToString(),
                         Stock = Convert.ToInt32(reader["Stock"]),
                         Categoria = reader["Categoria"].ToString(),
                     };
                     lista.Add(producto);
                 }
             }
             return lista;
        */ //}
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

