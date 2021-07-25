using Capa_Datos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Logica;

namespace Capa_Negocio
{
    public class N_EliminarUsuario
    {
        public bool EliminarUsuario(L_Usuario objl)
        {
            SqlConnection cn = Conexion.ObtenerConexion();
            SqlCommand cmd = new SqlCommand("sp_EliminarUsuario", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", objl.id);
            if (cmd.ExecuteNonQuery() == 1)
            {
                cn.Close();
                return true;
            }
            else
            {
                cn.Close();
                return false;
            }
        }
    }
}
