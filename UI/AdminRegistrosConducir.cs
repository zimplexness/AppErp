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
    public partial class AdminRegistrosConducir : MetroFramework.Forms.MetroForm
    {
        MantenimientoVehiculoController MantenimientoVehiculoController;
        IEnumerable<RegistrosConducir> ListaregistrosConducir;
        
        public AdminRegistrosConducir()
        {
            InitializeComponent();
            MantenimientoVehiculoController = new MantenimientoVehiculoController();
            ListaregistrosConducir = new List<RegistrosConducir>();
        }

        private void AdminRegistrosConducir_Load(object sender, EventArgs e)
        {
            bindingSourceRegistrosConducir.DataSource = MantenimientoVehiculoController.GetAllRegistros();
        }

        private void bindingSourceRegistrosConducir_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void metroGridRegistros_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int ID = (int)metroGridRegistros.CurrentRow.Cells["iDRegistroConducirDataGridViewTextBoxColumn"].Value;
            RegistroConducirForm registrosConducir= new RegistroConducirForm();
            registrosConducir.FormClosing += AdminRegistrosConducir_FormClosing;
            registrosConducir.RegistroID = ID;
            registrosConducir.Show();
        }

        private void AdminRegistrosConducir_FormClosing(object sender, FormClosingEventArgs e)
        {
            bindingSourceRegistrosConducir.DataSource = MantenimientoVehiculoController.GetAllRegistros();
            bindingSourceRegistrosConducir.ResetBindings(true);

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
          
           
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

           
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           
        }

        private void metroTextBoxFiltro_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(metroTextBoxFiltro.Text)!=true)
            {
                bindingSourceRegistrosConducir.DataSource = MantenimientoVehiculoController.FilterRegistrosConducirxDni(metroTextBoxFiltro.Text);
            }
            else
            {
                bindingSourceRegistrosConducir.DataSource = MantenimientoVehiculoController.GetAllRegistros();
            }
           
            
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
           
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
           
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
           
        }

        private void metroTile4_Click(object sender, EventArgs e)
        {
            RegistroConducirForm registrosConducir = new RegistroConducirForm();
            registrosConducir.FormClosing += AdminRegistrosConducir_FormClosing;

            registrosConducir.Show();
        }

        private void metroTile6_Click(object sender, EventArgs e)
        {
            int ID = (int)metroGridRegistros.CurrentRow.Cells["iDRegistroConducirDataGridViewTextBoxColumn"].Value;
            RegistroConducirForm registrosConducir = new RegistroConducirForm();
            registrosConducir.FormClosing += AdminRegistrosConducir_FormClosing;
            registrosConducir.RegistroID = ID;
            registrosConducir.Show();
        }

        private void metroTile5_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MetroFramework.MetroMessageBox.Show(this, "Estas seguro que quieres eliminar el Proveedor seleccionado?", "Sistema de Gestion", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation & MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    MantenimientoVehiculoController.DeleteRegistroConducir((int)metroGridRegistros.CurrentRow.Cells["iDRegistroConducirDataGridViewTextBoxColumn"].Value);
                    MetroFramework.MetroMessageBox.Show(this, "Proveedor elimminado con exito", "Sistema de Gestiòn", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else if (dialogResult == DialogResult.No)
                {

                }

            }
            catch (Exception EX)
            {

                throw new Exception(EX.Message);
            }
        }
    }
}
