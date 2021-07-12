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
        int veces = 0;
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
                string Rol = ((L_Login)cbo_Rol.SelectedItem).rol;
                if (dt.Rows.Count > 0)
                {
                    objl.logueo = dt.Rows[0][0].ToString();
                    objl.contrasena = dt.Rows[0][1].ToString();
                
                    if (Rol == dt.Rows[0][2].ToString())
                    {
                        this.Hide();
                        frm_Principal pri = new frm_Principal();
                        pri.Show();
                        pri.lbl_NombreLogin.Text = "Bienvenido " + objl.logueo + " / " + Rol;
                    }
                    else
                    {
                        MessageBox.Show("Elija su rol");
                        veces += 1;
                    }
                }
                else
                {
                    //al intenter incorrectamente va sumante la variables veces
                    MessageBox.Show("Usuario o Contraseña incorrecto");
                    veces += 1;
                }
                //si veces es igual a 3 bloqueo el boton de ingresar
                if (veces == 3)
                {
                    MessageBox.Show("Usuario Bloqueado / Vuelva a intentar en 10 segundos");
                    veces = 0;
                    btn_Ingresar.Enabled = false; ;
                    timer_bloqueo.Start();
                    //MessageBox.Show("Usuario o Contraseña incorrecto");
                }
            }
        }
        private void timer_bloqueo_Tick_1(object sender, System.EventArgs e)
        {
            btn_Ingresar.Enabled = true;
            timer_bloqueo.Stop();
        }

        private void btn_Ingresar_Enter(object sender, System.EventArgs e)
        {

        }
    }
}
