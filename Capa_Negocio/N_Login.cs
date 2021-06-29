using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Capa_Logica;
using Capa_Datos;

namespace Capa_Negocio
{
    public class N_Login
    {
        //public DataTable logueo(L_Login obje)
        //{
        //    return n_Login(obje);
        //}
        public DataTable n_Login(L_Login obj)
        {
            SqlConnection cn = Conexion.ObtenerConexion();
            SqlCommand cmd = new SqlCommand("sp_Login", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@logueo", obj.logueo);
            cmd.Parameters.AddWithValue("@contrasena", obj.contrasena);
            cmd.Parameters.AddWithValue("@idRol", obj.idLRoles);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dtable1 = new DataTable();
            da.Fill(dtable1);
            return dtable1;
        }
        public static List<L_Login> ObtenerRoles()
        {
            List<L_Login> _lista = new List<L_Login>();
            SqlConnection cn = Conexion.ObtenerConexion();
            SqlCommand _comando = new SqlCommand("select id, rol from tb_roles", cn);
            SqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                L_Login pRoles = new L_Login();

                pRoles.id = _reader.GetInt32(0);
                pRoles.rol = _reader.GetString(1);

                _lista.Add(pRoles);
            }
            return _lista;
        }
    }
}
