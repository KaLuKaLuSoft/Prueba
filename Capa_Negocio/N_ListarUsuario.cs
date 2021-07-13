using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Datos;
using Capa_Logica;

namespace Capa_Negocio
{
    public class N_ListarUsuario
    {
        public DataTable ListarProductos()
        {
            SqlConnection cn = Conexion.ObtenerConexion();
            SqlCommand cmd = new SqlCommand("sp_ListarUsuario", cn);
            SqlDataReader LeerFilas;
            DataTable Tabla = new DataTable();
            cmd.CommandType = CommandType.StoredProcedure;
            LeerFilas = cmd.ExecuteReader();
            Tabla.Load(LeerFilas);
            LeerFilas.Close();
            cn.Close();
            return Tabla;
        }
    }
}
