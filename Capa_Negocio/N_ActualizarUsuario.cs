using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Datos;
using Capa_Logica;
using System.Data;

namespace Capa_Negocio
{
    public class N_ActualizarUsuario
    {
        public void ActualizarUsuario(L_Usuario objl)
        {
            SqlConnection cn = Conexion.ObtenerConexion();
            SqlCommand cmd = new SqlCommand("sp_ActualizarUsuario", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();
            cn.Close();
        }
    }
}
