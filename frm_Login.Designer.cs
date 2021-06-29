
namespace Ventas
{
    partial class frm_Login
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_Usuario = new System.Windows.Forms.TextBox();
            this.txt_Pass = new System.Windows.Forms.TextBox();
            this.cbo_Rol = new System.Windows.Forms.ComboBox();
            this.btn_Ingresar = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.lbl_Usuario = new System.Windows.Forms.Label();
            this.lbl_Pass = new System.Windows.Forms.Label();
            this.lbl_Rol = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_Usuario
            // 
            this.txt_Usuario.Location = new System.Drawing.Point(118, 25);
            this.txt_Usuario.Name = "txt_Usuario";
            this.txt_Usuario.Size = new System.Drawing.Size(166, 22);
            this.txt_Usuario.TabIndex = 0;
            // 
            // txt_Pass
            // 
            this.txt_Pass.Location = new System.Drawing.Point(118, 66);
            this.txt_Pass.Name = "txt_Pass";
            this.txt_Pass.Size = new System.Drawing.Size(166, 22);
            this.txt_Pass.TabIndex = 1;
            // 
            // cbo_Rol
            // 
            this.cbo_Rol.FormattingEnabled = true;
            this.cbo_Rol.Location = new System.Drawing.Point(118, 111);
            this.cbo_Rol.Name = "cbo_Rol";
            this.cbo_Rol.Size = new System.Drawing.Size(166, 24);
            this.cbo_Rol.TabIndex = 2;
            // 
            // btn_Ingresar
            // 
            this.btn_Ingresar.Location = new System.Drawing.Point(35, 162);
            this.btn_Ingresar.Name = "btn_Ingresar";
            this.btn_Ingresar.Size = new System.Drawing.Size(83, 39);
            this.btn_Ingresar.TabIndex = 3;
            this.btn_Ingresar.Text = "Ingresar";
            this.btn_Ingresar.UseVisualStyleBackColor = true;
            this.btn_Ingresar.Click += new System.EventHandler(this.btn_Ingresar_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Location = new System.Drawing.Point(161, 162);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(83, 39);
            this.btn_Cancelar.TabIndex = 4;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            // 
            // lbl_Usuario
            // 
            this.lbl_Usuario.AutoSize = true;
            this.lbl_Usuario.Location = new System.Drawing.Point(12, 30);
            this.lbl_Usuario.Name = "lbl_Usuario";
            this.lbl_Usuario.Size = new System.Drawing.Size(65, 17);
            this.lbl_Usuario.TabIndex = 5;
            this.lbl_Usuario.Text = "Usuario :";
            // 
            // lbl_Pass
            // 
            this.lbl_Pass.AutoSize = true;
            this.lbl_Pass.Location = new System.Drawing.Point(12, 71);
            this.lbl_Pass.Name = "lbl_Pass";
            this.lbl_Pass.Size = new System.Drawing.Size(89, 17);
            this.lbl_Pass.TabIndex = 6;
            this.lbl_Pass.Text = "Contraseña :";
            // 
            // lbl_Rol
            // 
            this.lbl_Rol.AutoSize = true;
            this.lbl_Rol.Location = new System.Drawing.Point(12, 118);
            this.lbl_Rol.Name = "lbl_Rol";
            this.lbl_Rol.Size = new System.Drawing.Size(44, 17);
            this.lbl_Rol.TabIndex = 7;
            this.lbl_Rol.Text = "Tipo :";
            // 
            // frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 222);
            this.Controls.Add(this.lbl_Rol);
            this.Controls.Add(this.lbl_Pass);
            this.Controls.Add(this.lbl_Usuario);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Ingresar);
            this.Controls.Add(this.cbo_Rol);
            this.Controls.Add(this.txt_Pass);
            this.Controls.Add(this.txt_Usuario);
            this.Name = "frm_Login";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frm_Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Usuario;
        private System.Windows.Forms.TextBox txt_Pass;
        private System.Windows.Forms.ComboBox cbo_Rol;
        private System.Windows.Forms.Button btn_Ingresar;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Label lbl_Usuario;
        private System.Windows.Forms.Label lbl_Pass;
        private System.Windows.Forms.Label lbl_Rol;
    }
}

