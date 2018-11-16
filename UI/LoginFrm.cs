using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLayer;
using Controllers;
using Entidades;

namespace ErpGestion
{
    public partial class LoginFrm : MetroFramework.Forms.MetroForm
    {
        public Thread NuevoHilo { get; private set; }
       
        private ApplicationUsers ApplicationUsers;
        public NetUser user;
        public LoginFrm()
        {
            InitializeComponent();
            ApplicationUsers=new ApplicationUsers();
            user = new NetUser();
        }
        private void RunPrincipal()
        {
            
        }

        private void LOGINFORM_Load(object sender, EventArgs e)
        {
           
            
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(metroTextBoxContraseña.Text) == true)
            {
                MessageBox.Show("Por Favor Inserte la Contraseña", "Sistema de Gestion Compras", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
               


                if (ApplicationUsers.Autenticar(metroTextBoxUserName.Text,metroTextBoxContraseña.Text)==true)
                {
                   this.DialogResult = DialogResult.OK;
                    this.user.UserName = ApplicationUsers.GetUser(metroTextBoxUserName.Text).UserName;
                    
                   
                }
                else
                {
                    MessageBox.Show("Usuario o Contraseña incorrecta", "Sistema de Gestion Compras", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Refresh();
                }

            }
        }

        private void metroTextBoxContraseña_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                if (string.IsNullOrEmpty(metroTextBoxContraseña.Text) == true)
                {
                    MessageBox.Show("Por Favor Inserte la Contraseña", "Sistema de Gestion Compras", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {



                    if (ApplicationUsers.Autenticar(metroTextBoxUserName.Text, metroTextBoxContraseña.Text) == true)
                    {
                        this.DialogResult = DialogResult.OK;
                        this.user.UserName = ApplicationUsers.GetUser(metroTextBoxUserName.Text).UserName;
                    }
                    else
                    {
                        MessageBox.Show("Usuario o Contraseña incorrecta", "Sistema de Gestion Compras", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.Refresh();
                    }

                }

            }

            

        }

        private void metroTextBoxContraseña_Click(object sender, EventArgs e)
        {
            metroTextBoxContraseña.Text = "";
            metroTextBoxContraseña.UseSystemPasswordChar = true;
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void metroTextBoxContraseña_Enter(object sender, EventArgs e)
        {
            metroTextBoxContraseña.Text = "";
            metroTextBoxContraseña.UseSystemPasswordChar = true;
        }
    }
}
