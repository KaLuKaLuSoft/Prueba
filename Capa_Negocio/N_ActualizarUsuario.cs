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
      public bool ActualizarUsuario(L_Usuario objl)
        {
            SqlConnection cn = Conexion.ObtenerConexion();
            SqlCommand cmd = new SqlCommand("sp_ActualizarUsuario", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", objl.id);
            cmd.Parameters.AddWithValue("@nombre", objl.nombre);
            cmd.Parameters.AddWithValue("@apellidopaterno", objl.apellidopaterno);
            cmd.Parameters.AddWithValue("@apellidomaterno", objl.apellidomaterno);
            cmd.Parameters.AddWithValue("@telefono", objl.telefono);
            cmd.Parameters.AddWithValue("@celular", objl.celular);
            cmd.Parameters.AddWithValue("@correo", objl.correo);
            cmd.Parameters.AddWithValue("@comentarios", objl.comentarios);
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
