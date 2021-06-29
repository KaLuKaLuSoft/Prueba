using System.Windows.Forms;
using Capa_Negocio;
using System.Data;
using Capa_Logica;

namespace Ventas
{
    public partial class frm_Login : Form
    {
        L_Login objl = new L_Login();
        N_Login objn = new N_Login();
        public frm_Login()
        {
            InitializeComponent();
        }
        private void frm_Login_Load(object sender, System.EventArgs e)
        {
            cbo_Rol.DataSource = N_Login.ObtenerRoles();
            cbo_Rol.DisplayMember = "rol";
            cbo_Rol.ValueMember = "id";
        }
        private void btn_Ingresar_Click(object sender, System.EventArgs e)
        {
            DataTable dt = new DataTable();
            objl.logueo = txt_Usuario.Text;
            objl.contrasena = txt_Pass.Text;
            dt = objn.n_Login(objl);
            if (string.IsNullOrEmpty(txt_Usuario.Text) || string.IsNullOrEmpty(txt_Pass.Text))
            {
                MessageBox.Show("Debe Completar los campos necesarios");
            }
            else
            {
                if(cbo_Rol.SelectedItem != null)
                {
                    MessageBox.Show(cbo_Rol.SelectedItem.ToString());
                    //cbo_Rol.SelectedItem.ToString();
                    if (dt.Rows.Count > 0)
                    {
                        
                        objl.logueo = dt.Rows[0][1].ToString();
                        objl.contrasena = dt.Rows[0][2].ToString();
                        objl.idLRoles = int.Parse(dt.Rows[0][3].ToString());
                        this.Hide();
                        frm_Principal pri = new frm_Principal();
                        pri.Show();
                        pri.lbl_NombreLogin.Text = "Bienvenido "  + objl.logueo;
                    }
                    else
                    {
                        MessageBox.Show("Usuario Incorrecto");
                    }
                }
                else
                {
                    MessageBox.Show("Seleccione un Rol");
                }
            }
        }
    }
}
