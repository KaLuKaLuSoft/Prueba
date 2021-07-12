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
using Capa_Logica;

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
            if (dataGridView1.SelectedRows.Count > 0)
            {
                txt_Nombre.Text = dataGridView1.CurrentRow.Cells["Nombre"].Value.ToString();
                //CmbMarca.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                //txtDescripcion.Text = dataGridView1.CurrentRow.Cells["DESCRIPCION"].Value.ToString();
                //txtPrecio.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                //idprod = dataGridView1.CurrentRow.Cells["ID"].Value.ToString();
            }
            else
            {
                MessageBox.Show("debe seleccionar una fila");
            }
        }
    }
}
