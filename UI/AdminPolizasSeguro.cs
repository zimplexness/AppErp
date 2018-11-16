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
    public partial class AdminPolizasSeguro : MetroFramework.Forms.MetroForm
    {

        MantenimientoVehiculoController mantenimientoVehiculo;
        public AdminPolizasSeguro()
        {
            InitializeComponent();
            mantenimientoVehiculo = new MantenimientoVehiculoController();
        }

        private void AdminPolizasSeguro_Load(object sender, EventArgs e)
        {

            
           
            bindingSourcePolizas.DataSource = new MantenimientoVehiculoController().GetPolizasSeguroActivas();
            metroGridPolizas.AutoGenerateColumns = false;
          
           


            


        }

        private void metroTabPage2_Click(object sender, EventArgs e)
        {

        }

        private void metroGridPolizas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bindingSourcePolizas_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void metroGridPolizas_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           

            
        }

        
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PolizaSeguroFrm polizaSeguroFrm = new PolizaSeguroFrm();
            polizaSeguroFrm.ShowDialog();
        }

        private void AdminPolizasSeguro_FormClosing(object sender, FormClosingEventArgs e)
        {
            bindingSourcePolizas.DataSource = new MantenimientoVehiculoController().GetPolizasSeguroActivas();
            bindingSourcePolizas.ResetBindings(true);

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PolizaSeguroFrm polizaSeguroFrm = new PolizaSeguroFrm();
           
            polizaSeguroFrm.ShowDialog();
        }

        private void metroGridPolizas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int ID = (int)metroGridPolizas.CurrentRow.Cells["iDPolizaSeguroDataGridViewTextBoxColumn"].Value;
            PolizaSeguroFrm polizafrm = new PolizaSeguroFrm();
            polizafrm.FormClosing += AdminPolizasSeguro_FormClosing;
            polizafrm.ID = ID;
            polizafrm.Show();
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            int ID = (int)metroGridPolizas.CurrentRow.Cells["iDPolizaSeguroDataGridViewTextBoxColumn"].Value;
            PolizaSeguroFrm polizafrm = new PolizaSeguroFrm();
            polizafrm.FormClosing += AdminPolizasSeguro_FormClosing;
            polizafrm.ID = ID;
            polizafrm.Show();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                DialogResult dialogResult = MetroFramework.MetroMessageBox.Show(this, "Estas seguro que quieres eliminar la poliza seleccionada seleccionado?", "Sistema de Gestion", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation & MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    mantenimientoVehiculo.DeletePolizaSeguro((int)metroGridPolizas.CurrentRow.Cells["iDPolizaSeguroDataGridViewTextBoxColumn"].Value);
                    //((int)metroGridRegistros.CurrentRow.Cells["iDRegistroConducirDataGridViewTextBoxColumn"].Value);
                    MetroFramework.MetroMessageBox.Show(this, "La poliza ha sido elimminado con exito", "Sistema de Gestiòn", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    bindingSourcePolizas.DataSource = mantenimientoVehiculo.GetPolizasSeguroActivas();
                    bindingSourcePolizas.ResetBindings(true);

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
