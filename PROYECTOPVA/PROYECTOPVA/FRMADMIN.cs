using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MiLibreria;

namespace PROYECTOPVA
{
    public partial class FRMADMIN : FRMPadre
    {
        public FRMADMIN()
        {
            InitializeComponent();
        }

        private void FRMADMIN_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void FRMADMIN_Load(object sender, EventArgs e)
        {
            string cmd = "SELECT * FROM Users WHERE id_user=" + FRMLOGIN.Codigo;

            DataSet ds = Utilidades.Ejecutar(cmd);

            txtID.Text = ds.Tables[0].Rows[0]["id_user"].ToString();
            txtNombre.Text = ds.Tables[0].Rows[0]["status_adm"].ToString();
            txtUsuario.Text = ds.Tables[0].Rows[0]["username"].ToString();

            string url = ds.Tables[0].Rows[0]["foto"].ToString();

            ptrFoto.Image = Image.FromFile(url);
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            MDIMenuPrincipal MP = new MDIMenuPrincipal();
            this.Hide();
            MP.Show();
        }
    }
}
