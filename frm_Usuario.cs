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
        Conexion cn = new Conexion();
        L_Usuario objL = new L_Usuario();
        private void frm_Usuario_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dB_PruebaDataSet.sp_ListarUsuario' Puede moverla o quitarla según sea necesario.
            sp_ListarUsuarioTableAdapter.Fill(dB_PruebaDataSet.sp_ListarUsuario);
            ListarUsuarios();
        }
        #region Guardar o Insertar
        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            guardar();
        }
        
        void guardar()
        {
            objL.nombre = txt_Nombre.Text;
            objL.apellidopaterno = txt_ApellidoPaterno.Text;
            objL.apellidomaterno = txt_ApellidoMaterno.Text;
            objL.correo = txt_Correo.Text;
            objL.telefono = Convert.ToInt32(txt_Telefono.Text);
            objL.celular = Convert.ToInt32(txt_Celular.Text);
            objL.comentarios = txt_comentario.Text;
            objI.InsertarUsuarios(objL);
            MessageBox.Show("Ingresado Correctamente");
        }
        #endregion
        #region Actualizar
        private void btn_Actualizar_Click(object sender, EventArgs e)
        {
            Actualizar();
        }
        void Actualizar()
        {
            objL.id = id;
            objL.nombre = textBox2.Text;
            objL.apellidopaterno = textBox1.Text;
            objL.apellidomaterno = textBox7.Text;
            objL.correo = textBox6.Text;
            objL.telefono = Convert.ToInt32(textBox5.Text);
            objL.celular = Convert.ToInt32(textBox4.Text);
            objL.comentarios = textBox3.Text;
            objA.ActualizarUsuario(objL);
            MessageBox.Show("Actualizado Correctamente");
            VaciarTextBoxes();
            ListarUsuarios();
        }
        private void VaciarTextBoxes()
        {
            textBox2.Text = "";
            textBox1.Text = "";
            textBox7.Text = "";
            textBox5.Text = "";
            textBox4.Text = "";
            textBox6.Text = "";
            textBox3.Text = "";
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
                //aux.filtrarCelular(dataGridView1, txt_filtrar.Text.Trim());
            }
        } 
        #endregion
        #region DataGridView
        private void dataGridView1_CellContentDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            tabControl1.SelectedTab = tabPage2;
            textBox2.Text = tabla.Rows[e.RowIndex].Field<string>(2);
            textBox1.Text = tabla.Rows[e.RowIndex].Field<string>(3);
            textBox7.Text = tabla.Rows[e.RowIndex].Field<string>(4);
            textBox5.Text = tabla.Rows[e.RowIndex].Field<int>(5).ToString();
            textBox4.Text = tabla.Rows[e.RowIndex].Field<int>(6).ToString();
            textBox6.Text = tabla.Rows[e.RowIndex].Field<string>(7);
            textBox3.Text = tabla.Rows[e.RowIndex].Field<string>(8);
            //textBox15.Text = tabla.Rows[e.RowIndex].Field<int>(0).ToString();
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