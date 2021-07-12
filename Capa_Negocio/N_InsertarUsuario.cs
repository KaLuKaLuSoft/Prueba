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
        Conexion objd = new Conexion();
        public void InsertarUsuarios(L_Usuario obj)
        {
            SqlConnection cn = Conexion.ObtenerConexion();
            SqlCommand cmd = new SqlCommand("sp_InsertarUsuario", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@nombre", obj.nombre);
            cmd.Parameters.AddWithValue("@apellidopaterno", obj.apellidopaterno);
            cmd.Parameters.AddWithValue("@apellidomaterno", obj.apellidomaterno);
            cmd.Parameters.AddWithValue("@correo", obj.correo);
            cmd.Parameters.AddWithValue("@telefono", obj.telefono);
            cmd.Parameters.AddWithValue("@celular", obj.celular);
            cmd.Parameters.AddWithValue("@comentario", obj.comentario);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            cn.Close();
        }
    }
}
