using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Negocio;
using Capa_Datos;
using Capa_Logica;
using System.Data.SqlClient;

namespace Ventas
{
    public partial class frm_Usuario : Form
    {
        public frm_Usuario()
        {
            InitializeComponent();
        }
        N_InsertarUsuario objI = new N_InsertarUsuario();
        N_ActualizarUsuario objA = new N_ActualizarUsuario();
        Conexion cn = new Conexion();
        
        L_Usuario objL = new L_Usuario();
        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            objL.nombre = txt_Nombre.Text;
            objL.apellidopaterno = txt_ApellidoPaterno.Text;
            objL.apellidomaterno = txt_ApellidoMaterno.Text;
            objL.correo = txt_Correo.Text;
            objL.telefono = Convert.ToInt32(txt_Telefono.Text);
            objL.celular = Convert.ToInt32(txt_Celular.Text);
            objL.comentario = txt_Comentario.Text;
            objI.InsertarUsuarios(objL);
            MessageBox.Show("Ingresado Correctamente");
        }
        private void btn_Actualizar_Click(object sender, EventArgs e)
        {
            objL.nombre = txt_Nombre.Text;
            objL.apellidopaterno = txt_ApellidoPaterno.Text;
            objL.apellidomaterno = txt_ApellidoMaterno.Text;
            objL.correo = txt_Correo.Text;
            objL.telefono = Convert.ToInt32(txt_Telefono.Text);
            objL.celular = Convert.ToInt32(txt_Celular.Text);
            objL.comentario = txt_Comentario.Text;
            objA.ActualizarUsuario(objL);
            MessageBox.Show("Actualizado Correctamente");
            
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (dataGridView1.SelectedRows.Count > 0)
            //{
            //    txt_Nombre.Text = dataGridView1.CurrentRow.Cells["Nombre Completo"].Value.ToString();
            //    //CmbMarca.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            //    //txtDescripcion.Text = dataGridView1.CurrentRow.Cells["DESCRIPCION"].Value.ToString();
            //    //txtPrecio.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            //    //idprod = dataGridView1.CurrentRow.Cells["ID"].Value.ToString();
            //}
            //else
            //{
            //    MessageBox.Show("Debe seleccionar una fila");
            //}
        }
        private void ListarUsuarios()
        {
            N_ListarUsuario listar = new N_ListarUsuario();
            dataGridView1.DataSource = listar.ListarProductos();
        }
        private void frm_Usuario_Load(object sender, EventArgs e)
        {
            ListarUsuarios();
        }
        private void txt_filtrar_TextChanged(object sender, EventArgs e)
        {
            //if(cb_ListarUsuario.Text == "Nombre")
            //{
            //    SqlDataAdapter sda = new SqlDataAdapter("select nombre + ' ' + apellidopaterno + ' ' + apellidomaterno AS [Nombre] from tb_usuario WHERE Nombre LIKE '" + txt_filtrar.Text + "%'", cn.ToString());
            //    DataTable data = new DataTable();
            //    sda.Fill(data);
            //    dataGridView1.DataSource = data;
            //}
        }
    }
}
