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
    public partial class AdminComprobantesForm : MetroFramework.Forms.MetroForm
    {
        ComprobanteController comprobanteController;
        ProveedorController proveedorController;
        public AdminComprobantesForm()
        {
            InitializeComponent();
            comprobanteController = new ComprobanteController();
            proveedorController = new ProveedorController();
        }

        private void AdminComprobantesForm_Load(object sender, EventArgs e)
        {
            DateTime CurrentDate = DateTime.Now.Date;
            DateTime FechaInicio = CurrentDate.Date.AddDays(-60);

            bindingSourceComprobantes.DataSource = comprobanteController.GetAllComprobantes(FechaInicio,CurrentDate);
            //autocomplete textbox con proveedores

            AutoCompleteStringCollection sourcename = new AutoCompleteStringCollection();
            sourcename.AddRange(proveedorController.GetProveedoresName().ToArray());
            metroTextBoxProveedor.AutoCompleteMode = AutoCompleteMode.Suggest;
            metroTextBoxProveedor.AutoCompleteSource = AutoCompleteSource.CustomSource;
            metroTextBoxProveedor.AutoCompleteCustomSource = sourcename;

        }

        private void metroToggleFiltro_CheckedChanged(object sender, EventArgs e)
        {
            if (metroToggleFiltro.Checked==true)
            {
                groupBoxFiltros.Visible = true;

            }
            else
            {
                groupBoxFiltros.Visible = false;
                DateTime CurrentDate = DateTime.Now.Date;
                DateTime FechaInicio = CurrentDate.Date.AddDays(-60);
                bindingSourceComprobantes.DataSource = comprobanteController.GetAllComprobantes(FechaInicio, CurrentDate);
            }
        }

        private void metroButtonCreate_Click(object sender, EventArgs e)
        {
            if (metroRadioButtonporFecha.Checked==true)
            {
                bindingSourceComprobantes.DataSource = comprobanteController.GetAllComprobantes(metroDateTimeFechainicio.Value,metroDateTimeFechaFin.Value);
                bindingSourceComprobantes.ResetBindings(true);
            }
            else if(metroRadioButtonProveedor.Checked==true)
            {
                bindingSourceComprobantes.DataSource = comprobanteController.GetAllComprobantesxProveedor(metroTextBoxProveedor.Text,metroDateTimeFechainicio.Value, metroDateTimeFechaFin.Value);
                bindingSourceComprobantes.ResetBindings(true);
            }
            else if (metroRadioButtonFacturaFecha.Checked==true)
            {
                bindingSourceComprobantes.DataSource = comprobanteController.GetAllComprobantesxFactura(metroTextBoxSucursal.Text,metroTextBoxNoFactura.Text,metroDateTimeFechainicio.Value, metroDateTimeFechaFin.Value);
                bindingSourceComprobantes.ResetBindings(true);
            }
        }

        private void metroGridComprobantes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void metroTextBoxSucursal_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(metroTextBoxSucursal.Text) == false)
            {
                metroTextBoxSucursal.Text = string.Format("{0:0000}", int.Parse(metroTextBoxSucursal.Text));
            }
           
        }

        private void metroTextBoxNoFactura_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(metroTextBoxNoFactura.Text) == false)
            {
                metroTextBoxNoFactura.Text = string.Format("{0:00000000}", int.Parse(metroTextBoxNoFactura.Text));
            }
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //abrir formulario de comprobantes
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == typeof(ComprobantesFrm))
                {
                    f.Activate();
                    return;
                }
            }
            int IdComprobante = (int)metroGridComprobantes.CurrentRow.Cells["idComprobanteDataGridViewTextBoxColumn"].Value;

            ComprobantesFrm ComprobanteForm = new ComprobantesFrm();

            ComprobanteForm.IDComprobante = IdComprobante;
            ComprobanteForm.Edition = true;
            ComprobanteForm.FormClosed += AdminComprobantesForm_FormClosed;
            ComprobanteForm.Show();

        }

        private void AdminComprobantesForm_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            //abrir formulario de comprobantes
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == typeof(ComprobantesFrm))
                {
                    f.Activate();
                    return;
                }
            }
           

            ComprobantesFrm ComprobanteForm = new ComprobantesFrm();

            
            ComprobanteForm.Edition =false;
            ComprobanteForm.FormClosed += AdminComprobantesForm_FormClosed;
            ComprobanteForm.Show();

        }

        private void metroGridComprobantes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //abrir formulario de comprobantes
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == typeof(ComprobantesFrm))
                {
                    f.Activate();
                    return;
                }
            }
            int IdComprobante = (int)metroGridComprobantes.CurrentRow.Cells["idComprobanteDataGridViewTextBoxColumn"].Value;

            ComprobantesFrm ComprobanteForm = new ComprobantesFrm();

            ComprobanteForm.IDComprobante = IdComprobante;
            ComprobanteForm.Edition = true;
            ComprobanteForm.FormClosed += AdminComprobantesForm_FormClosed;
            ComprobanteForm.Show();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                DialogResult dialogResult = MetroFramework.MetroMessageBox.Show(this, "Estas seguro que quieres eliminar la Factura seleccionada?", "Sistema de Gestion", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation & MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    comprobanteController.DeleteComprobantes((int)metroGridComprobantes.CurrentRow.Cells["idComprobanteDataGridViewTextBoxColumn"].Value);
                    
                    MetroFramework.MetroMessageBox.Show(this, "Comprobante elimminado con exito", "Sistema de Gestiòn", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
