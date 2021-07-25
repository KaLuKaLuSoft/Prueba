
namespace Ventas
{
    partial class frm_Usuario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_Id = new System.Windows.Forms.TextBox();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_Correo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_Telefono = new System.Windows.Forms.Label();
            this.lbl_AMaterno = new System.Windows.Forms.Label();
            this.lbl_APaterno = new System.Windows.Forms.Label();
            this.lbl_Nombre = new System.Windows.Forms.Label();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.txt_ApellidoPaterno = new System.Windows.Forms.TextBox();
            this.txt_Comentarios = new System.Windows.Forms.TextBox();
            this.txt_Celular = new System.Windows.Forms.TextBox();
            this.txt_Telefono = new System.Windows.Forms.TextBox();
            this.txt_Correo = new System.Windows.Forms.TextBox();
            this.txt_ApellidoMaterno = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre_CompletoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoPaternoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoMaternoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.celularDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comentariosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spListarUsuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_PruebaDataSet = new Ventas.DB_PruebaDataSet();
            this.txt_filtrar = new System.Windows.Forms.TextBox();
            this.cb_ListarUsuario = new System.Windows.Forms.ComboBox();
            this.sp_ListarUsuarioTableAdapter = new Ventas.DB_PruebaDataSetTableAdapters.sp_ListarUsuarioTableAdapter();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spListarUsuarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_PruebaDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.ItemSize = new System.Drawing.Size(120, 50);
            this.tabControl1.Location = new System.Drawing.Point(-7, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1695, 601);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 54);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(5);
            this.tabPage1.Size = new System.Drawing.Size(1687, 543);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Insertar";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txt_Id);
            this.groupBox1.Controls.Add(this.btn_Eliminar);
            this.groupBox1.Controls.Add(this.btn_Guardar);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lbl_Correo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lbl_Telefono);
            this.groupBox1.Controls.Add(this.lbl_AMaterno);
            this.groupBox1.Controls.Add(this.lbl_APaterno);
            this.groupBox1.Controls.Add(this.lbl_Nombre);
            this.groupBox1.Controls.Add(this.txt_Nombre);
            this.groupBox1.Controls.Add(this.txt_ApellidoPaterno);
            this.groupBox1.Controls.Add(this.txt_Comentarios);
            this.groupBox1.Controls.Add(this.txt_Celular);
            this.groupBox1.Controls.Add(this.txt_Telefono);
            this.groupBox1.Controls.Add(this.txt_Correo);
            this.groupBox1.Controls.Add(this.txt_ApellidoMaterno);
            this.groupBox1.Location = new System.Drawing.Point(217, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1149, 488);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Usuario";
            // 
            // txt_Id
            // 
            this.txt_Id.Location = new System.Drawing.Point(476, 447);
            this.txt_Id.Name = "txt_Id";
            this.txt_Id.Size = new System.Drawing.Size(100, 34);
            this.txt_Id.TabIndex = 33;
            this.txt_Id.Visible = false;
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.Location = new System.Drawing.Point(652, 314);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(145, 51);
            this.btn_Eliminar.TabIndex = 32;
            this.btn_Eliminar.Text = "Eliminar";
            this.btn_Eliminar.UseVisualStyleBackColor = true;
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click_1);
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.Location = new System.Drawing.Point(450, 314);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(145, 51);
            this.btn_Guardar.TabIndex = 31;
            this.btn_Guardar.Text = "Ingresar";
            this.btn_Guardar.UseVisualStyleBackColor = true;
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 29);
            this.label2.TabIndex = 30;
            this.label2.Text = "Comentarios:";
            // 
            // lbl_Correo
            // 
            this.lbl_Correo.AutoSize = true;
            this.lbl_Correo.Location = new System.Drawing.Point(703, 137);
            this.lbl_Correo.Name = "lbl_Correo";
            this.lbl_Correo.Size = new System.Drawing.Size(94, 29);
            this.lbl_Correo.TabIndex = 29;
            this.lbl_Correo.Text = "Correo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(349, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 29);
            this.label1.TabIndex = 28;
            this.label1.Text = "Celular:";
            // 
            // lbl_Telefono
            // 
            this.lbl_Telefono.AutoSize = true;
            this.lbl_Telefono.Location = new System.Drawing.Point(15, 138);
            this.lbl_Telefono.Name = "lbl_Telefono";
            this.lbl_Telefono.Size = new System.Drawing.Size(116, 29);
            this.lbl_Telefono.TabIndex = 27;
            this.lbl_Telefono.Text = "Telefono:";
            // 
            // lbl_AMaterno
            // 
            this.lbl_AMaterno.AutoSize = true;
            this.lbl_AMaterno.Location = new System.Drawing.Point(683, 64);
            this.lbl_AMaterno.Name = "lbl_AMaterno";
            this.lbl_AMaterno.Size = new System.Drawing.Size(140, 29);
            this.lbl_AMaterno.TabIndex = 26;
            this.lbl_AMaterno.Text = "Apellido M.:";
            // 
            // lbl_APaterno
            // 
            this.lbl_APaterno.AutoSize = true;
            this.lbl_APaterno.Location = new System.Drawing.Point(335, 64);
            this.lbl_APaterno.Name = "lbl_APaterno";
            this.lbl_APaterno.Size = new System.Drawing.Size(136, 29);
            this.lbl_APaterno.TabIndex = 25;
            this.lbl_APaterno.Text = "Apellido P.:";
            // 
            // lbl_Nombre
            // 
            this.lbl_Nombre.AutoSize = true;
            this.lbl_Nombre.Location = new System.Drawing.Point(15, 64);
            this.lbl_Nombre.Name = "lbl_Nombre";
            this.lbl_Nombre.Size = new System.Drawing.Size(107, 29);
            this.lbl_Nombre.TabIndex = 24;
            this.lbl_Nombre.Text = "Nombre:";
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Location = new System.Drawing.Point(136, 59);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(193, 34);
            this.txt_Nombre.TabIndex = 18;
            // 
            // txt_ApellidoPaterno
            // 
            this.txt_ApellidoPaterno.Location = new System.Drawing.Point(476, 59);
            this.txt_ApellidoPaterno.Name = "txt_ApellidoPaterno";
            this.txt_ApellidoPaterno.Size = new System.Drawing.Size(193, 34);
            this.txt_ApellidoPaterno.TabIndex = 17;
            // 
            // txt_Comentarios
            // 
            this.txt_Comentarios.Location = new System.Drawing.Point(177, 201);
            this.txt_Comentarios.Multiline = true;
            this.txt_Comentarios.Name = "txt_Comentarios";
            this.txt_Comentarios.Size = new System.Drawing.Size(953, 98);
            this.txt_Comentarios.TabIndex = 23;
            // 
            // txt_Celular
            // 
            this.txt_Celular.Location = new System.Drawing.Point(476, 133);
            this.txt_Celular.Name = "txt_Celular";
            this.txt_Celular.Size = new System.Drawing.Size(193, 34);
            this.txt_Celular.TabIndex = 21;
            // 
            // txt_Telefono
            // 
            this.txt_Telefono.Location = new System.Drawing.Point(136, 134);
            this.txt_Telefono.Name = "txt_Telefono";
            this.txt_Telefono.Size = new System.Drawing.Size(193, 34);
            this.txt_Telefono.TabIndex = 20;
            // 
            // txt_Correo
            // 
            this.txt_Correo.Location = new System.Drawing.Point(830, 135);
            this.txt_Correo.Name = "txt_Correo";
            this.txt_Correo.Size = new System.Drawing.Size(300, 34);
            this.txt_Correo.TabIndex = 22;
            // 
            // txt_ApellidoMaterno
            // 
            this.txt_ApellidoMaterno.Location = new System.Drawing.Point(830, 59);
            this.txt_ApellidoMaterno.Name = "txt_ApellidoMaterno";
            this.txt_ApellidoMaterno.Size = new System.Drawing.Size(193, 34);
            this.txt_ApellidoMaterno.TabIndex = 19;
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.White;
            this.tabPage4.Controls.Add(this.dataGridView1);
            this.tabPage4.Controls.Add(this.txt_filtrar);
            this.tabPage4.Controls.Add(this.cb_ListarUsuario);
            this.tabPage4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage4.Location = new System.Drawing.Point(4, 54);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1687, 543);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Buscar";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeight = 29;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.Nombre_CompletoDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.apellidoPaternoDataGridViewTextBoxColumn,
            this.apellidoMaternoDataGridViewTextBoxColumn,
            this.telefonoDataGridViewTextBoxColumn,
            this.celularDataGridViewTextBoxColumn,
            this.correoDataGridViewTextBoxColumn,
            this.comentariosDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.spListarUsuarioBindingSource;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.Location = new System.Drawing.Point(3, 66);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1682, 481);
            this.dataGridView1.TabIndex = 34;
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick_1);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // Nombre_CompletoDataGridViewTextBoxColumn
            // 
            this.Nombre_CompletoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Nombre_CompletoDataGridViewTextBoxColumn.DataPropertyName = "Nombre_Completo";
            this.Nombre_CompletoDataGridViewTextBoxColumn.HeaderText = "Nombre Completo";
            this.Nombre_CompletoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.Nombre_CompletoDataGridViewTextBoxColumn.Name = "Nombre_CompletoDataGridViewTextBoxColumn";
            this.Nombre_CompletoDataGridViewTextBoxColumn.ReadOnly = true;
            this.Nombre_CompletoDataGridViewTextBoxColumn.Width = 241;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreDataGridViewTextBoxColumn.Visible = false;
            // 
            // apellidoPaternoDataGridViewTextBoxColumn
            // 
            this.apellidoPaternoDataGridViewTextBoxColumn.DataPropertyName = "Apellido Paterno";
            this.apellidoPaternoDataGridViewTextBoxColumn.HeaderText = "Apellido Paterno";
            this.apellidoPaternoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.apellidoPaternoDataGridViewTextBoxColumn.Name = "apellidoPaternoDataGridViewTextBoxColumn";
            this.apellidoPaternoDataGridViewTextBoxColumn.ReadOnly = true;
            this.apellidoPaternoDataGridViewTextBoxColumn.Visible = false;
            // 
            // apellidoMaternoDataGridViewTextBoxColumn
            // 
            this.apellidoMaternoDataGridViewTextBoxColumn.DataPropertyName = "Apellido Materno";
            this.apellidoMaternoDataGridViewTextBoxColumn.HeaderText = "Apellido Materno";
            this.apellidoMaternoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.apellidoMaternoDataGridViewTextBoxColumn.Name = "apellidoMaternoDataGridViewTextBoxColumn";
            this.apellidoMaternoDataGridViewTextBoxColumn.ReadOnly = true;
            this.apellidoMaternoDataGridViewTextBoxColumn.Visible = false;
            // 
            // telefonoDataGridViewTextBoxColumn
            // 
            this.telefonoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.telefonoDataGridViewTextBoxColumn.DataPropertyName = "Telefono";
            this.telefonoDataGridViewTextBoxColumn.HeaderText = "Telefono";
            this.telefonoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.telefonoDataGridViewTextBoxColumn.Name = "telefonoDataGridViewTextBoxColumn";
            this.telefonoDataGridViewTextBoxColumn.ReadOnly = true;
            this.telefonoDataGridViewTextBoxColumn.Width = 139;
            // 
            // celularDataGridViewTextBoxColumn
            // 
            this.celularDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.celularDataGridViewTextBoxColumn.DataPropertyName = "Celular";
            this.celularDataGridViewTextBoxColumn.HeaderText = "Celular";
            this.celularDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.celularDataGridViewTextBoxColumn.Name = "celularDataGridViewTextBoxColumn";
            this.celularDataGridViewTextBoxColumn.ReadOnly = true;
            this.celularDataGridViewTextBoxColumn.Width = 119;
            // 
            // correoDataGridViewTextBoxColumn
            // 
            this.correoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.correoDataGridViewTextBoxColumn.DataPropertyName = "Correo";
            this.correoDataGridViewTextBoxColumn.HeaderText = "Correo";
            this.correoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.correoDataGridViewTextBoxColumn.Name = "correoDataGridViewTextBoxColumn";
            this.correoDataGridViewTextBoxColumn.ReadOnly = true;
            this.correoDataGridViewTextBoxColumn.Width = 117;
            // 
            // comentariosDataGridViewTextBoxColumn
            // 
            this.comentariosDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.comentariosDataGridViewTextBoxColumn.DataPropertyName = "Comentarios";
            this.comentariosDataGridViewTextBoxColumn.HeaderText = "Comentarios";
            this.comentariosDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.comentariosDataGridViewTextBoxColumn.Name = "comentariosDataGridViewTextBoxColumn";
            this.comentariosDataGridViewTextBoxColumn.ReadOnly = true;
            this.comentariosDataGridViewTextBoxColumn.Width = 179;
            // 
            // spListarUsuarioBindingSource
            // 
            this.spListarUsuarioBindingSource.DataMember = "sp_ListarUsuario";
            this.spListarUsuarioBindingSource.DataSource = this.dB_PruebaDataSet;
            // 
            // dB_PruebaDataSet
            // 
            this.dB_PruebaDataSet.DataSetName = "DB_PruebaDataSet";
            this.dB_PruebaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txt_filtrar
            // 
            this.txt_filtrar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_filtrar.Location = new System.Drawing.Point(221, 13);
            this.txt_filtrar.Multiline = true;
            this.txt_filtrar.Name = "txt_filtrar";
            this.txt_filtrar.Size = new System.Drawing.Size(1452, 37);
            this.txt_filtrar.TabIndex = 33;
            this.txt_filtrar.TextChanged += new System.EventHandler(this.txt_filtrar_TextChanged);
            // 
            // cb_ListarUsuario
            // 
            this.cb_ListarUsuario.FormattingEnabled = true;
            this.cb_ListarUsuario.Items.AddRange(new object[] {
            "Nombre Completo",
            "Teléfono",
            "Celular",
            "Correo"});
            this.cb_ListarUsuario.Location = new System.Drawing.Point(26, 13);
            this.cb_ListarUsuario.Name = "cb_ListarUsuario";
            this.cb_ListarUsuario.Size = new System.Drawing.Size(162, 37);
            this.cb_ListarUsuario.TabIndex = 32;
            this.cb_ListarUsuario.Text = "Seleccione";
            // 
            // sp_ListarUsuarioTableAdapter
            // 
            this.sp_ListarUsuarioTableAdapter.ClearBeforeFill = true;
            // 
            // frm_Usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1682, 600);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.Name = "frm_Usuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frm_Usuario";
            this.Load += new System.EventHandler(this.frm_Usuario_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spListarUsuarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_PruebaDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TextBox txt_filtrar;
        private System.Windows.Forms.ComboBox cb_ListarUsuario;
        private DB_PruebaDataSet dB_PruebaDataSet;
        private System.Windows.Forms.BindingSource spListarUsuarioBindingSource;
        private DB_PruebaDataSetTableAdapters.sp_ListarUsuarioTableAdapter sp_ListarUsuarioTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreCompletoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_CompletoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoPaternoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoMaternoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn celularDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn correoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn comentariosDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_Id;
        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.Button btn_Guardar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_Correo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_Telefono;
        private System.Windows.Forms.Label lbl_AMaterno;
        private System.Windows.Forms.Label lbl_APaterno;
        private System.Windows.Forms.Label lbl_Nombre;
        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.TextBox txt_ApellidoPaterno;
        private System.Windows.Forms.TextBox txt_Comentarios;
        private System.Windows.Forms.TextBox txt_Celular;
        private System.Windows.Forms.TextBox txt_Telefono;
        private System.Windows.Forms.TextBox txt_Correo;
        private System.Windows.Forms.TextBox txt_ApellidoMaterno;
    }
}