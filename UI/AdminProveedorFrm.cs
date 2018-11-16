using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLayer.Controller;
using Controllers;
using Entidades;




namespace ErpGestion
{
    public partial class AdminProveedorFrm : MetroFramework.Forms.MetroForm
    {
        private ProveedorController ProveedorController;

       
        public AdminProveedorFrm()
        {
            InitializeComponent();
            ProveedorController = new ProveedorController();
        }

         
        //ProveedorRepository proveedorRepository = new ProveedorRepository();
        private void ProveedoresForm_Load(object sender, EventArgs e)
        {


            var proveedores =ProveedorController.GetProveedores();

            proveedoresBindingSource.DataSource = proveedores;
          
            metroGridProveedores.AutoGenerateColumns = false;
            metroGridProveedores.DataSource = proveedores;
            metroGridProveedores.AutoSize = false;

            foreach (var item in proveedores)
            {
                Nombre.DataPropertyName = "Nombre";
                Razon.DataPropertyName = "Razon";
                Cuit.DataPropertyName = "Cuit";
                FechaIngreso.DataPropertyName = "FechaIngreso";
                IngresosBrutos.DataPropertyName = "IngresosBrutos";
                Direccion.DataPropertyName = "Direccion";
                Provincia.DataPropertyName = "Provincias";
                Localidades.DataPropertyName = "Localidades";
                Telefono.DataPropertyName = "Telefono";
                Rubro.DataPropertyName = "RubroProveedor";

            }
















        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {

        }

        private void metroButton2_Click(object sender, EventArgs e)
        {

        }

        private void metroButton4_Click(object sender, EventArgs e)
        {

        }

        private void metroButton3_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBoxFILTRONOMBRE_TextChanged(object sender, EventArgs e)
        {

        }

        private void metroTextBoxfiltrorazon_TextChanged(object sender, EventArgs e)
        {

        }

        private void metroTextBoxfiltrorubro_TextChanged(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void metroGridFiltrarProveedores_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            
           

          
            


        }

        private void metroGridFiltrarProveedores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {





        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            FrmEditProveedor frmEditProveedor = new FrmEditProveedor();
            frmEditProveedor.FormClosed += AdminProveedorFrm_FormClosed;
            frmEditProveedor.Show();


        }

        private void metroTextBoxNombre_TextChanged(object sender, EventArgs e)
        {
            metroGridProveedores.DataSource = ProveedorController.FilterByNombre(metroTextBoxNombre.Text);
        }

        private void metroTextBoxFilterRazon_TextChanged(object sender, EventArgs e)
        {
            metroGridProveedores.DataSource = ProveedorController.FilterByRazon(metroTextBoxFilterRazon.Text);
        }

        private void metroTextBoxFilterRubro_TextChanged(object sender, EventArgs e)
        {

            metroGridProveedores.DataSource = ProveedorController.FilterByRubro(metroTextBoxFilterRubro.Text);
        }

        private void metroTabPage2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void metroTextBoxCuit_TextChanged(object sender, EventArgs e)
        {
            metroGridProveedores.DataSource = ProveedorController.FilterByCuit(metroTextBoxCuit.Text);
        }

        private void proveedoresDataGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           

        }

        private void metroGridProveedores_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void bindingNavigatorDeleteItem_Click_1(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("Desea Eliminar el Proveedor", "Sistema de Gestion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                //Add comprobante a Selected Comprobante
               
                        if (dialogResult == DialogResult.Yes)
                        {
                    ProveedorController.DeleteProveedores(metroGridProveedores.CurrentRow.Cells["Cuit"].Value.ToString());
                           
                            MessageBox.Show("Proveedor Eliminado Satisfactoriamente", "Sistema de Gestion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
        {

        }

        private void metroGridProveedores_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //abrir formulario de comprobantes
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == typeof(FrmEditProveedor))
                {
                    f.Activate();
                    return;
                }
            }
            string cuit = metroGridProveedores.CurrentRow.Cells["Cuit"].Value.ToString();
            FrmEditProveedor frmEditProveedor = new FrmEditProveedor();

            frmEditProveedor.cuit = cuit;

            frmEditProveedor.FormClosed += AdminProveedorFrm_FormClosed;
            frmEditProveedor.Show();
        }

        private void AdminProveedorFrm_FormClosing(object sender, FormClosingEventArgs e)
        {


        }

        private void AdminProveedorFrm_FormClosed(object sender, FormClosedEventArgs e)
        {
            var proveedores = ProveedorController.GetProveedores();

            proveedoresBindingSource.DataSource = proveedores;

            metroGridProveedores.AutoGenerateColumns = false;
            metroGridProveedores.DataSource = proveedores;
            metroGridProveedores.AutoSize = false;

            foreach (var item in proveedores)
            {
                Nombre.DataPropertyName = "Nombre";
                Razon.DataPropertyName = "Razon";
                Cuit.DataPropertyName = "Cuit";
                FechaIngreso.DataPropertyName = "FechaIngreso";
                IngresosBrutos.DataPropertyName = "IngresosBrutos";
                Direccion.DataPropertyName = "Direccion";
                Provincia.DataPropertyName = "Provincias";
                Localidades.DataPropertyName = "Localidades";
                Telefono.DataPropertyName = "Telefono";
                Rubro.DataPropertyName = "RubroProveedor";

            }

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //abrir formulario de comprobantes
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == typeof(FrmEditProveedor))
                {
                    f.Activate();
                    return;
                }
            }
            string cuit = metroGridProveedores.CurrentRow.Cells["Cuit"].Value.ToString();
            FrmEditProveedor frmEditProveedor = new FrmEditProveedor();

            frmEditProveedor.cuit = cuit;

            frmEditProveedor.FormClosed += AdminProveedorFrm_FormClosed;
            frmEditProveedor.Show();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                DialogResult dialogResult= MetroFramework.MetroMessageBox.Show(this, "Estas seguro que quieres eliminar el Proveedor seleccionado?", "Sistema de Gestion", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation & MessageBoxIcon.Warning);
                if (dialogResult==DialogResult.Yes)
                {
                    ProveedorController.DeleteProveedores(metroGridProveedores.CurrentRow.Cells["Cuit"].Value.ToString());
                    MetroFramework.MetroMessageBox.Show(this, "Proveedor elimminado con exito", "Sistema de Gestiòn", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else if (dialogResult==DialogResult.No)
                {
                    
                }

            }
            catch (Exception EX)
            {

                throw new Exception(EX.Message);
            }
        }

        private void metroToggleFiltro_CheckedChanged(object sender, EventArgs e)
        {
            if (metroToggleFiltro.Checked==true)
            {
                groupBoxFilterInfo.Visible = true;
            }
            else
            {
                groupBoxFilterInfo.Visible = false;
            }
        }

        private void metroCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (metroCheckBoxCuentas.Checked==true)
            {
                metroGridProveedores.DataSource = ProveedorController.GetProveedoresCuentaCorriente();
            }
            else if(metroCheckBoxCuentas.Checked==false)
            {
                var proveedores = ProveedorController.GetProveedores();

                proveedoresBindingSource.DataSource = proveedores;

                metroGridProveedores.AutoGenerateColumns = false;
                metroGridProveedores.DataSource = proveedores;
                metroGridProveedores.AutoSize = false;

                foreach (var item in proveedores)
                {
                    Nombre.DataPropertyName = "Nombre";
                    Razon.DataPropertyName = "Razon";
                    Cuit.DataPropertyName = "Cuit";
                    FechaIngreso.DataPropertyName = "FechaIngreso";
                    IngresosBrutos.DataPropertyName = "IngresosBrutos";
                    Direccion.DataPropertyName = "Direccion";
                    Provincia.DataPropertyName = "Provincias";
                    Localidades.DataPropertyName = "Localidades";
                    Telefono.DataPropertyName = "Telefono";
                    Rubro.DataPropertyName = "RubroProveedor";

                }

            }
        }
    }
}