using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prySernaPConexionBD2
{
    public class clsContactos
    {
        public int Codigo {  get; set; }
        public string Nombre { get; set; }
        public string Apellido {  get; set; }
        public long Telefono { get; set; }
        public string Correo {  get; set; }
        public int CategoriaId { get; set; }
    }
}
