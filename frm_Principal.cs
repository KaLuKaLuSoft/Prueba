using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ventas
{
    public partial class frm_Principal : Form
    {
        public frm_Principal()
        {
            InitializeComponent();
        }
        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Usuario abrir = new frm_Usuario();
            //Llamando a la Instancia
            abrir = frm_Usuario.Instancia();
            abrir.MdiParent = this;
            abrir.Show();
        }

    }
}
