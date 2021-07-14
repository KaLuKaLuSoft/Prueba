using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Datos;
using Capa_Logica;

namespace Capa_Negocio
{
    public class N_ListarUsuario
    {
        public DataTable ListarUsuarios()
        {
            SqlConnection cn = Conexion.ObtenerConexion();
            try
            {
                SqlCommand cmd = new SqlCommand("sp_ListarUsuario", cn);
                SqlDataReader LeerFilas;
                DataTable Tabla = new DataTable();
                cmd.CommandType = CommandType.StoredProcedure;
                LeerFilas = cmd.ExecuteReader();
                Tabla.Load(LeerFilas);
                LeerFilas.Close();
                return Tabla;
            }
            catch(Exception)
            {
                throw;
            }
            finally
            {
                cn.Close();
            }
        }
        public void filtrar(DataGridView data,string nombre)
        {
            SqlConnection cn = Conexion.ObtenerConexion();
            try
            {
                SqlCommand cmd = new SqlCommand("sp_filtrarNombre", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@filtro", SqlDbType.VarChar, 200).Value = nombre;
                cmd.ExecuteNonQuery();
                DataTable Tabla = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(Tabla);
                data.DataSource = Tabla;
                cn.Close();
            }
            catch(Exception)
            {
                throw;
            }
            finally
            {
                cn.Close();
            }
        }
    }
}
