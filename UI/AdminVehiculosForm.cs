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
    public partial class AdminVehiculosForm : MetroFramework.Forms.MetroForm
    {
        MantenimientoVehiculoController mantenimientoVehiculo;

        public AdminVehiculosForm()
        {
            InitializeComponent();
            mantenimientoVehiculo = new MantenimientoVehiculoController();
        }

        private void AdminVehiculosForm_Load(object sender, EventArgs e)
        {
            bindingSourceVehiculos.DataSource = mantenimientoVehiculo.GetAllVehiculos();

        }

        private void metroTextBox2_Click(object sender, EventArgs e)
        {
            metroTextBoxPatente.Clear();
        }

        private void metroTextBoxMarca_Click(object sender, EventArgs e)
        {
            metroTextBoxMarca.Clear();
        }

        private void metroTextBoxModelo_Click(object sender, EventArgs e)
        {
            metroTextBoxModelo.Clear();
        }

        private void metroTextBoxYear_Click(object sender, EventArgs e)
        {
            metroTextBoxYear.Clear();
        }

        private void metroTextBoxPatente_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(metroTextBoxPatente.Text)==false)
            {

                bindingSourceVehiculos.DataSource = mantenimientoVehiculo.FilterVehiculoByPatente(metroTextBoxPatente.Text);

                metroGridVehiculos.DataSource = bindingSourceVehiculos;
                metroGridVehiculos.Update();
            }
            else
            {
                bindingSourceVehiculos.DataSource = mantenimientoVehiculo.GetAllVehiculos();

                metroGridVehiculos.DataSource = bindingSourceVehiculos;
                metroGridVehiculos.Update();

            }
           




        }

        private void metroTextBoxMarca_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(metroTextBoxMarca.Text) == false)
            {

                bindingSourceVehiculos.DataSource = mantenimientoVehiculo.FilterVehiculosbyMarca(metroTextBoxMarca.Text);

                metroGridVehiculos.DataSource = bindingSourceVehiculos;
                metroGridVehiculos.Update();
            }
            else
            {
                bindingSourceVehiculos.DataSource = mantenimientoVehiculo.GetAllVehiculos();

                metroGridVehiculos.DataSource = bindingSourceVehiculos;
                metroGridVehiculos.Update();

            }
        }

        private void metroTextBoxModelo_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(metroTextBoxModelo.Text) == false)
            {

                bindingSourceVehiculos.DataSource = mantenimientoVehiculo.FilterVehiculosModelos(metroTextBoxModelo.Text);

                metroGridVehiculos.DataSource = bindingSourceVehiculos;
                metroGridVehiculos.Update();
            }
            else
            {
                bindingSourceVehiculos.DataSource = mantenimientoVehiculo.GetAllVehiculos();

                metroGridVehiculos.DataSource = bindingSourceVehiculos;
                metroGridVehiculos.Update();

            }


        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           

        }

        private void AdminVehiculosForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            bindingSourceVehiculos.DataSource = mantenimientoVehiculo.GetAllVehiculos();
            bindingSourceVehiculos.ResetBindings(true);
        }

        private void metroGridVehiculos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //abrir formulario de comprobantes
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == typeof(VehiculosFrm))
                {
                    f.Activate();
                    return;
                }
            }
            int IdVehiculo = (int)metroGridVehiculos.CurrentRow.Cells["iDVehiculoDataGridViewTextBoxColumn"].Value;

            VehiculosFrm vehiculosFrm = new VehiculosFrm();

            vehiculosFrm.IdVehiculo = IdVehiculo;

            vehiculosFrm.FormClosing += AdminVehiculosForm_FormClosing;
            vehiculosFrm.Show();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                DialogResult dialogResult = MetroFramework.MetroMessageBox.Show(this, "Estas seguro que quieres eliminar el Vehiculo seleccionado?", "Sistema de Gestion", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation & MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    mantenimientoVehiculo.DeleteVehiculo((int)metroGridVehiculos.CurrentRow.Cells["iDVehiculoDataGridViewTextBoxColumn"].Value);
                    //((int)metroGridRegistros.CurrentRow.Cells["iDRegistroConducirDataGridViewTextBoxColumn"].Value);
                    MetroFramework.MetroMessageBox.Show(this, "Vehiculo elimminado con exito", "Sistema de Gestiòn", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    bindingSourceVehiculos.DataSource = mantenimientoVehiculo.GetAllVehiculos();
                    bindingSourceVehiculos.ResetBindings(true);

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

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            

        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            //abrir formulario de comprobantes
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == typeof(VehiculosFrm))
                {
                    f.Activate();
                    return;
                }
            }
            // int IdVehiculo = (int)metroGridVehiculos.CurrentRow.Cells["iDVehiculoDataGridViewTextBoxColumn"].Value;

            VehiculosFrm vehiculosFrm = new VehiculosFrm();

            //vehiculosFrm.IdVehiculo = IdVehiculo;

            vehiculosFrm.FormClosing += AdminVehiculosForm_FormClosing;
            vehiculosFrm.Show();
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            //abrir formulario de comprobantes
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == typeof(VehiculosFrm))
                {
                    f.Activate();
                    return;
                }
            }
            int IdVehiculo = (int)metroGridVehiculos.CurrentRow.Cells["iDVehiculoDataGridViewTextBoxColumn"].Value;

            VehiculosFrm vehiculosFrm = new VehiculosFrm();

            vehiculosFrm.IdVehiculo = IdVehiculo;

            vehiculosFrm.FormClosing += AdminVehiculosForm_FormClosing;
            vehiculosFrm.Show();
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MetroFramework.MetroMessageBox.Show(this, "Estas seguro que quieres eliminar el Vehiculo seleccionado?", "Sistema de Gestion", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation & MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    mantenimientoVehiculo.DeleteVehiculo((int)metroGridVehiculos.CurrentRow.Cells["iDVehiculoDataGridViewTextBoxColumn"].Value);
                    //((int)metroGridRegistros.CurrentRow.Cells["iDRegistroConducirDataGridViewTextBoxColumn"].Value);
                    MetroFramework.MetroMessageBox.Show(this, "Vehiculo elimminado con exito", "Sistema de Gestiòn", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    bindingSourceVehiculos.DataSource = mantenimientoVehiculo.GetAllVehiculos();
                    bindingSourceVehiculos.ResetBindings(true);

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
