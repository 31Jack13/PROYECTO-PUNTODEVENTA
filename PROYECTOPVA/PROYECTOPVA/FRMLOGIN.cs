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
    public partial class FRMLOGIN : Form
    {
        public FRMLOGIN()
        {
            InitializeComponent();
        }

        public static String Codigo = "";
        private void btnEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                string CMD = string.Format("SELECT * FROM Users WHERE username= '{0}' AND password = '{1}' ", txtUserLog.Text.Trim(), txtPassLog.Text.Trim());
                DataSet ds = Utilidades.Ejecutar(CMD);

                Codigo = ds.Tables[0].Rows[0]["id_user"].ToString().Trim();

                string cuenta = ds.Tables[0].Rows[0]["username"].ToString().Trim();
                string contra = ds.Tables[0].Rows[0]["password"].ToString().Trim();

                if (cuenta == txtUserLog.Text.Trim() && contra == txtPassLog.Text.Trim())
                {
                    if (Convert.ToBoolean(ds.Tables[0].Rows[0]["status_adm"]) == true)
                    {
                        FRMADMIN VenAD = new FRMADMIN();
                        this.Hide();
                        VenAD.Show();
                    }
                    else
                    {
                        FRMUSER VenUs = new FRMUSER();
                        this.Hide();
                        VenUs.Show();
                    }
                }

            }
            catch (Exception error)
            {
                MessageBox.Show("ERROR , Usuario o contrasena incorrecta");
            }
        }

        private void txtUserLog_Click(object sender, EventArgs e)
        {
            txtUserLog.Clear();
            pictureBox2.Image = Properties.Resources.log;
            panel1.BackColor = Color.WhiteSmoke;
            txtUserLog.ForeColor = Color.WhiteSmoke;

            pictureBox3.Image = Properties.Resources.contrasena;
            panel2.BackColor = Color.DeepSkyBlue;
            txtPassLog.ForeColor = Color.DeepSkyBlue;
        }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                if (txtPassLog.PasswordChar == '*')
                {
                    txtPassLog.PasswordChar = '\0';
                    pictureBox4.Image = Properties.Resources.mostrar;
                }
            }
            else
            {
                pictureBox4.Image = Properties.Resources.mostrar_contrasena;
                txtPassLog.PasswordChar = '*';
            }
        }

        private void txtPassLog_Click(object sender, EventArgs e)
        {
            txtPassLog.Clear();
            txtPassLog.PasswordChar = '*';
            pictureBox3.Image = Properties.Resources.pass;
            panel2.BackColor = Color.WhiteSmoke;
            txtPassLog.ForeColor = Color.WhiteSmoke;

            pictureBox2.Image = Properties.Resources.iniciar_sesion;
            panel1.BackColor = Color.DeepSkyBlue;
            txtUserLog.ForeColor = Color.DeepSkyBlue;
        }
    }
}
