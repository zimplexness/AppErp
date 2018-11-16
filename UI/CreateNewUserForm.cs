using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controllers;
using Entidades;

namespace ErpGestion
{
    public partial class CreateNewUserForm : MetroFramework.Forms.MetroForm
    {
        public ApplicationUsers Users;
        public List< NetUser> users;
        public CreateNewUserForm()
        {
            InitializeComponent();
            Users = new ApplicationUsers();
            users = Users.GetUsers();
          
        }

        private void CreateNewUserForm_Load(object sender, EventArgs e)
        {
            users = Users.GetUsers();
           

            metroGridUsers.AutoGenerateColumns = false;
            metroGridUsers.DataSource = users;
            metroGridUsers.AutoSize = false;

            foreach (var item in users)
            {
                username.DataPropertyName = "UserName";
                Password.DataPropertyName = "PasswordHash";
             
               

            }
        }

        private void metroButtonGa_Click(object sender, EventArgs e)
        {
            try
            {
                if (metroTextBoxPassword.Text!=metroTextBoxPassConfirm.Text)
                {
                    MessageBox.Show("Las contraseñas no coinciden", "Sistema de Gestion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    //var user = Users.StoreUser(metroTextBoxUserName.Text, metroTextBoxPassword.Text);
                    if (Users.StoreUser(metroTextBoxUserName.Text, metroTextBoxPassword.Text) != null)
                    {
                        MessageBox.Show("Usuario agregado con exito", "Sistema de Gestion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("El usuario no se pudo agregar", "Sistema de Gestion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        private void metroGridUsers_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex==2)
            {
                if (e != null)
                {
                    e.Value = new string('*', e.Value.ToString().Length);
                }
                else e.Value = "NULL";
            }
        }
    }
}
