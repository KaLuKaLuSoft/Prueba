﻿using System;
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
        private DataTable tabla;
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
            objL.comentarios = txt_comentario.Text;
            objI.InsertarUsuarios(objL);
            MessageBox.Show("Ingresado Correctamente");
        }
        private void btn_Actualizar_Click(object sender, EventArgs e)
        {
            objL.nombre = textBox2.Text;
            objL.apellidopaterno = textBox1.Text;
            objL.apellidomaterno = textBox7.Text;
            objL.correo = textBox6.Text;
            objL.telefono = Convert.ToInt32(textBox5.Text);
            objL.celular = Convert.ToInt32(textBox4.Text);
            objL.comentarios = textBox3.Text;
            //objL.id = Convert.ToInt32(textBox15.Text);
            objA.ActualizarUsuario(objL);
            MessageBox.Show("Actualizado Correctamente");       
        }
        private void ListarUsuarios()
        {
            N_ListarUsuario listar = new N_ListarUsuario();
            tabla = listar.ListarProductos();
            dataGridView1.DataSource = tabla;
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[3].Visible = false;
        }
        private void frm_Usuario_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dB_PruebaDataSet.sp_ListarUsuario' Puede moverla o quitarla según sea necesario.
            sp_ListarUsuarioTableAdapter.Fill(dB_PruebaDataSet.sp_ListarUsuario);
            ListarUsuarios();
        }
        private void txt_filtrar_TextChanged(object sender, EventArgs e)
        {
        }
        private void dataGridView1_CellContentDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            tabControl1.SelectedTab = tabPage2;
            textBox2.Text = tabla.Rows[e.RowIndex].Field<string>(1);
            textBox1.Text = tabla.Rows[e.RowIndex].Field<string>(2);
            textBox7.Text = tabla.Rows[e.RowIndex].Field<string>(3);
            textBox5.Text = tabla.Rows[e.RowIndex].Field<int>(4).ToString();
            textBox4.Text = tabla.Rows[e.RowIndex].Field<int>(5).ToString();
            textBox6.Text = tabla.Rows[e.RowIndex].Field<string>(6);
            textBox3.Text = tabla.Rows[e.RowIndex].Field<string>(7);
            textBox15.Text = tabla.Rows[e.RowIndex].Field<int>(8).ToString();
        }
    }
}