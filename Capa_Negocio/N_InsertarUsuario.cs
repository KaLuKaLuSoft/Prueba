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
    public class N_InsertarUsuario
    {
        public void InsertarUsuarios(L_Usuario objl)
        {
            SqlConnection cn = Conexion.ObtenerConexion();
            SqlCommand cmd = new SqlCommand("sp_InsertarUsuario", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@nombre", objl.nombre);
            cmd.Parameters.AddWithValue("@apellidopaterno", objl.apellidopaterno);
            cmd.Parameters.AddWithValue("@apellidomaterno", objl.apellidomaterno);
            cmd.Parameters.AddWithValue("@correo", objl.correo);
            cmd.Parameters.AddWithValue("@telefono", objl.telefono);
            cmd.Parameters.AddWithValue("@celular", objl.celular);
            cmd.Parameters.AddWithValue("@comentario", objl.comentario);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            cn.Close();
        }
    }
}
