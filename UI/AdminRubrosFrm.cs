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
    public partial class AdminRubrosFrm : MetroFramework.Forms.MetroForm
    {
        ProveedorController proveedorController;
        public AdminRubrosFrm()
        {
            InitializeComponent();
            proveedorController = new ProveedorController();
            
        }

        private void AdminRubrosFrm_Load(object sender, EventArgs e)
        {


            bindingSourceRubros.DataSource = proveedorController.GetRubroProveedor();

            metroGridRubro.AutoGenerateColumns = false;
           
            metroGridRubro.AutoSize = false;

            

        }

        private void metroTextBoxRubro_TextChanged(object sender, EventArgs e)
        {
           // bindingSourceRubros.DataSource=proveedorController
         

           

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
        }

        private void rubroForm_Form_Closed(Object sender,FormClosedEventArgs e) {
           

        }


        private void metroGridRubro_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            RubroForm rubroForm = new RubroForm();
            rubroForm.FormClosed += rubroForm_Form_Closed;

            rubroForm.ShowDialog();
        }

        private void metroGridRubro_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            RubroForm frmrubro = new RubroForm();
            frmrubro.IDRubro = int.Parse(metroGridRubro.CurrentRow.Cells["iDRubroProveedorDataGridViewTextBoxColumn"].Value.ToString());
            frmrubro.Edition = true;
            frmrubro.FormClosed += rubroForm_Form_Closed;
            frmrubro.Show();
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RubroForm frmrubro = new RubroForm();
            frmrubro.IDRubro = int.Parse(metroGridRubro.CurrentRow.Cells["iDRubroProveedorDataGridViewTextBoxColumn"].Value.ToString());
            frmrubro.Edition = true;
            frmrubro.FormClosed += rubroForm_Form_Closed;
            frmrubro.Show();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void AdminRubrosFrm_FormClosed(object sender, FormClosedEventArgs e)
        {

            bindingSourceRubros.DataSource = proveedorController.GetRubroProveedor();
            bindingSourceRubros.ResetBindings(true);

        }
    }
}
