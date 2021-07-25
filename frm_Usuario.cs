using System;
using System.Data;
using System.Windows.Forms;
using Capa_Negocio;
using Capa_Datos;
using Capa_Logica;

namespace Ventas
{
    public partial class frm_Usuario : Form
    {
        public frm_Usuario()
        {
            InitializeComponent();
        }
        private int id;
        private DataTable tabla;
        N_InsertarUsuario objI = new N_InsertarUsuario();
        N_ActualizarUsuario objA = new N_ActualizarUsuario();
        N_EliminarUsuario objE = new N_EliminarUsuario();
        Conexion cn = new Conexion();
        L_Usuario objL = new L_Usuario();
        private void frm_Usuario_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dB_PruebaDataSet.sp_ListarUsuario' Puede moverla o quitarla según sea necesario.
            sp_ListarUsuarioTableAdapter.Fill(dB_PruebaDataSet.sp_ListarUsuario);
            ListarUsuarios();
        }
        #region Guardar,Actualizar
        private void btn_Guardar_Click_1(object sender, EventArgs e)
        {
            objL.id = id;
            objL.nombre = txt_Nombre.Text;
            objL.apellidopaterno = txt_ApellidoPaterno.Text;
            objL.apellidomaterno = txt_ApellidoMaterno.Text;
            objL.correo = txt_Correo.Text;
            objL.telefono = Convert.ToInt32(txt_Telefono.Text);
            objL.celular = Convert.ToInt32(txt_Celular.Text);
            objL.comentarios = txt_Comentarios.Text;
            if (btn_Guardar.Text == "Ingresar")
            {
                if (objI.InsertarUsuarios(objL) == true)
                {
                    MessageBox.Show("Guardado Correctamente");
                    VaciarTextBoxes();
                    ListarUsuarios();
                }
                else
                {
                    MessageBox.Show("Se produjo un error: No guardado");
                    VaciarTextBoxes();
                    ListarUsuarios();
                }
            }
            else if (btn_Guardar.Text == "Actualizar")
            {
                if (objA.ActualizarUsuario(objL) == true)
                {
                    MessageBox.Show("Actualizado Correctamente");
                    VaciarTextBoxes();
                    ListarUsuarios();
                    btn_Guardar.Text = "Ingresar";
                }
                else
                {
                    MessageBox.Show("Se produjo un error: No actualizado");
                    VaciarTextBoxes();
                    ListarUsuarios();
                    btn_Guardar.Text = "Ingresar";
                }
            }     
        }
        #endregion
        #region Eliminar
        private void btn_Eliminar_Click_1(object sender, EventArgs e)
        {
            objL.id = id;
            if (objE.EliminarUsuario(objL) == true)
            {
                DialogResult result = MessageBox.Show("Seguro que dese eliminar " + txt_Nombre.Text+ "?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    VaciarTextBoxes();
                    ListarUsuarios();
                }
                else if (result == DialogResult.No)
                {
                    MessageBox.Show("No se eliminó");
                    VaciarTextBoxes();
                    ListarUsuarios();
                }
            }
            else
            {
                MessageBox.Show("Se produjo un error: No eliminado");
            }
        } 
        #endregion
        #region Actualizar
        private void btn_Actualizar_Click(object sender, EventArgs e)
        {
        }
        private void VaciarTextBoxes()
        {
            txt_ApellidoPaterno.Text = "";
            txt_Nombre.Text = "";
            txt_ApellidoMaterno.Text = "";
            txt_Telefono.Text = "";
            txt_Celular.Text = "";
            txt_Correo.Text = "";
            txt_Comentarios.Text = "";
        }
        #endregion
        #region Listar Usuarios
        private void ListarUsuarios()
        {
            N_ListarUsuario listar = new N_ListarUsuario();
            tabla = listar.ListarUsuarios();
            dataGridView1.DataSource = tabla;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[4].Visible = false;
        }
        #endregion
        #region Filtrar Datos
        private void txt_filtrar_TextChanged(object sender, EventArgs e)
        {
            if(cb_ListarUsuario.Text == "Nombre Completo")
            {
                var aux = new N_ListarUsuario();
                aux.FiltrarNombre(dataGridView1, txt_filtrar.Text.Trim());
            }
            else if(cb_ListarUsuario.Text == "Teléfono")
            {
                var aux = new N_ListarUsuario();
                aux.filtrarTelefono(dataGridView1, txt_filtrar.Text.Trim());
            }
            else if(cb_ListarUsuario.Text == "Celular")
            {
                var aux = new N_ListarUsuario();
                aux.filtrarCelular(dataGridView1, txt_filtrar.Text.Trim());
            }
            else if(cb_ListarUsuario.Text == "Correo")
            {
                var aux = new N_ListarUsuario();
                aux.filtrarCorreo(dataGridView1, txt_filtrar.Text.Trim());
            }
        } 
        #endregion
        #region DataGridView
        private void dataGridView1_CellContentDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            tabControl1.SelectedTab = tabPage1;
            btn_Guardar.Text = "Actualizar";
            txt_Nombre.Text = tabla.Rows[e.RowIndex].Field<string>(2);
            txt_ApellidoPaterno.Text = tabla.Rows[e.RowIndex].Field<string>(3);
            txt_ApellidoMaterno.Text = tabla.Rows[e.RowIndex].Field<string>(4);
            txt_Telefono.Text = tabla.Rows[e.RowIndex].Field<int>(5).ToString();
            txt_Celular.Text = tabla.Rows[e.RowIndex].Field<int>(6).ToString();
            txt_Correo.Text = tabla.Rows[e.RowIndex].Field<string>(7);
            txt_Comentarios.Text = tabla.Rows[e.RowIndex].Field<string>(8);
            txt_Id.Text = tabla.Rows[e.RowIndex].Field<int>(0).ToString();
            id = tabla.Rows[e.RowIndex].Field<int>(0);
            ListarUsuarios();
        } 
        #endregion
        #region Bloquear frm_Usuario
        //Bloquear el frm_Usuario para que solo se muestre una sola vez
        private static frm_Usuario frm_Instancia = null;
        public static frm_Usuario Instancia()
        {
            if (((frm_Instancia == null) || (frm_Instancia.IsDisposed == true)))
            {
                frm_Instancia = new frm_Usuario();
            }
            frm_Instancia.BringToFront();
            return frm_Instancia;
        }
        #endregion    
    }
}