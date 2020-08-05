﻿using System;
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

                if (cuenta == txtUserLog.Text.Trim())
                {
                    if (Convert.ToBoolean(ds.Tables[0].Rows[0]["status_adm"]) == true)
                    {
                        FRMADMIN VenMe = new FRMADMIN();
                        this.Hide();
                        VenMe.Show();
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
    }
}