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

namespace ErpGestion
{
    public partial class AdminMantenimientoVehiculoForm : MetroFramework.Forms.MetroForm
    {
        private readonly MantenimientoVehiculoController mantenimientoVehiculo;
        public AdminMantenimientoVehiculoForm()
        {
            InitializeComponent();
            mantenimientoVehiculo = new MantenimientoVehiculoController();
        }

        private void AdminMantenimientoVehiculoForm_Load(object sender, EventArgs e)
        {
            
           bindingSourceMantenimientos.DataSource = mantenimientoVehiculo.GetMantenimientos();

            metroGridMantenimientos.AutoGenerateColumns = false;
            metroGridMantenimientos.DataSource = bindingSourceMantenimientos;
            metroGridMantenimientos.AutoSize = false;


          
        }

        private void metroTextBox2_Click(object sender, EventArgs e)
        {
            metroTextBox2.Clear();
        }

        private void metroTextBoxDetalleMantenimiento_Click(object sender, EventArgs e)
        {
            metroTextBoxDetalleMantenimiento.Clear();
        }

        private void metroTextBox2_TextChanged(object sender, EventArgs e)
        {
            //metroGridMantenimientos.DataSource = mantenimientoVehiculo.FilterByPantente(metroTextBox2.Text);
        }

        private void metroTextBoxDetalleMantenimiento_TextChanged(object sender, EventArgs e)
        {
            //metroGridMantenimientos.DataSource = mantenimientoVehiculo.FilterByDetalleMantenimiento(metroTextBoxDetalleMantenimiento.Text);
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //abrir formulario de comprobantes
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == typeof(MantenimientoForm))
                {
                    f.Activate();
                    return;
                }
            }
            int IdMantenimiento = (int)metroGridMantenimientos.CurrentRow.Cells["iDMantenimientoDataGridViewTextBoxColumn"].Value;
            
            MantenimientoForm mantenimientoForm = new MantenimientoForm();

            mantenimientoForm.IDMantenimiento = IdMantenimiento;
            mantenimientoForm.Edition = true;
            mantenimientoForm.FormClosed += AdminMantenimientoVehiculoForm_FormClosed;
            mantenimientoForm.Show();

           
        }

        private void AdminMantenimientoVehiculoForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            bindingSourceMantenimientos.DataSource= mantenimientoVehiculo.GetMantenimientos();
            bindingSourceMantenimientos.ResetBindings(true);
        }

        private void AdminMantenimientoVehiculoForm_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            //abrir formulario de comprobantes
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == typeof(MantenimientoForm))
                {
                    f.Activate();
                    return;
                }
            }
            //int IdMantenimiento = (int)metroGridMantenimientos.CurrentRow.Cells["iDMantenimientoDataGridViewTextBoxColumn"].Value;
            MantenimientoForm mantenimientoForm = new MantenimientoForm();

            //mantenimientoForm.IDMantenimiento = IdMantenimiento;
            mantenimientoForm.Edition = false;
            mantenimientoForm.FormClosed += AdminMantenimientoVehiculoForm_FormClosed;
            mantenimientoForm.Show();
        }

        private void metroGridMantenimientos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //abrir formulario de comprobantes
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == typeof(MantenimientoForm))
                {
                    f.Activate();
                    return;
                }
            }
            int IdMantenimiento = (int)metroGridMantenimientos.CurrentRow.Cells["iDMantenimientoDataGridViewTextBoxColumn"].Value;
            MantenimientoForm mantenimientoForm = new MantenimientoForm();

            mantenimientoForm.IDMantenimiento = IdMantenimiento;
            mantenimientoForm.Edition = true;
            mantenimientoForm.FormClosed += AdminMantenimientoVehiculoForm_FormClosed;
            mantenimientoForm.Show();

        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                DialogResult dialogResult = MetroFramework.MetroMessageBox.Show(this, "Estas seguro que quieres eliminar el Mantenimiento seleccionado?", "Sistema de Gestion", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation & MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    mantenimientoVehiculo.DeleteManteniento((int)metroGridMantenimientos.CurrentRow.Cells["iDMantenimientoDataGridViewTextBoxColumn"].Value);
                        //((int)metroGridRegistros.CurrentRow.Cells["iDRegistroConducirDataGridViewTextBoxColumn"].Value);
                    MetroFramework.MetroMessageBox.Show(this, "Proveedor elimminado con exito", "Sistema de Gestiòn", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    bindingSourceMantenimientos.DataSource = mantenimientoVehiculo.GetMantenimientos();
                    bindingSourceMantenimientos.ResetBindings(true);

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
