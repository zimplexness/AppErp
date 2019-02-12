using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Controllers;

namespace ErpGestion
{
    public partial class AdminTalleresForm : MetroFramework.Forms.MetroForm
    {
        MantenimientoVehiculoController mantenimientoVehiculo;
        public AdminTalleresForm()
        {
            InitializeComponent();
            mantenimientoVehiculo = new MantenimientoVehiculoController();
        }

        private void AdminTalleresForm_Load(object sender, EventArgs e)
        {
            bindingSourceTalleres.DataSource = mantenimientoVehiculo.GetAllTalleres();
        }

        private void metroTextBoxNombre_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(metroTextBoxNombre.Text) == false)
            {

                bindingSourceTalleres.DataSource = mantenimientoVehiculo.FilterByTaller(metroTextBoxNombre.Text);

                metroGridTalleres.DataSource = bindingSourceTalleres;
                metroGridTalleres.Update();
            }
            else
            {
                bindingSourceTalleres.DataSource = mantenimientoVehiculo.GetAllTalleres();

                metroGridTalleres.DataSource = bindingSourceTalleres;
                metroGridTalleres.Update();

            }
        }

        private void metroTextBoxFilterDireccion_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(metroTextBoxFilterDireccion.Text) == false)
            {

                bindingSourceTalleres.DataSource = mantenimientoVehiculo.FilterByDireccion(metroTextBoxFilterDireccion.Text);

                metroGridTalleres.DataSource = bindingSourceTalleres;
                metroGridTalleres.Update();
            }
            else
            {
                bindingSourceTalleres.DataSource = mantenimientoVehiculo.GetAllTalleres();

                metroGridTalleres.DataSource = bindingSourceTalleres;
                metroGridTalleres.Update();

            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           
        }

        private void AdminTalleresForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            metroGridTalleres.DataSource = mantenimientoVehiculo.GetAllTalleres();

            metroGridTalleres.DataSource = bindingSourceTalleres;
            metroGridTalleres.Update();
        }

        private void metroGridTalleres_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //abrir formulario de comprobantes
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == typeof(TallerFrm))
                {
                    f.Activate();
                    return;
                }
            }
            int IdTaller = (int)metroGridTalleres.CurrentRow.Cells["iDTalleresDataGridViewTextBoxColumn"].Value;

            TallerFrm tallerFrm = new TallerFrm();

            tallerFrm.IDTaller = IdTaller;

            tallerFrm.FormClosing += AdminTalleresForm_FormClosing;
            tallerFrm.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
          
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
            //abrir formulario de comprobantes
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == typeof(TallerFrm))
                {
                    f.Activate();
                    return;
                }
            }


            TallerFrm tallerFrm = new TallerFrm();

            tallerFrm.FormClosing += AdminTalleresForm_FormClosing;
            tallerFrm.Show();
        }

        private void metroTile6_Click(object sender, EventArgs e)
        {
            //abrir formulario de comprobantes
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == typeof(TallerFrm))
                {
                    f.Activate();
                    return;
                }
            }
            int IdTaller = (int)metroGridTalleres.CurrentRow.Cells["iDTalleresDataGridViewTextBoxColumn"].Value;

            TallerFrm tallerFrm = new TallerFrm();

            tallerFrm.IDTaller = IdTaller;

            tallerFrm.FormClosing += AdminTalleresForm_FormClosing;
            tallerFrm.Show();
        }

        private void metroTile5_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MetroFramework.MetroMessageBox.Show(this, "Estas seguro que quieres eliminar el Taller seleccionado?", "Sistema de Gestion", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation & MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    mantenimientoVehiculo.DeleteTaller((int)metroGridTalleres.CurrentRow.Cells["iDTalleresDataGridViewTextBoxColumn"].Value);
                    //((int)metroGridRegistros.CurrentRow.Cells["iDRegistroConducirDataGridViewTextBoxColumn"].Value);
                    MetroFramework.MetroMessageBox.Show(this, "Taller elimminado con exito", "Sistema de Gestiòn", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    bindingSourceTalleres.DataSource = mantenimientoVehiculo.GetAllTalleres(); ;
                    bindingSourceTalleres.ResetBindings(true);

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
