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
    public partial class AdminPagosForm : MetroFramework.Forms.MetroForm
    {
        PagosController pagosController;
        public AdminPagosForm()
        {
            InitializeComponent();
            pagosController = new PagosController();
            
        }

        private void AdminPagosForm_Load(object sender, EventArgs e)
        {
            DateTime CurrentDate = DateTime.Now.Date;
            DateTime FechaInicio = CurrentDate.Date.AddDays(-30);
            bindingSourcePagos.DataSource = pagosController.GetPagosProveedores(FechaInicio,CurrentDate);
        }

        private void metroToggleFiltro_CheckedChanged(object sender, EventArgs e)
        {
            //if (metroToggleFiltro.Checked == true)
            //{
            //    groupBoxFiltros.Visible = true;

            //}
            //else
            //{
            //    groupBoxFiltros.Visible = false;
                
               
            //}
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {

        }

        private void metroTile3_Click(object sender, EventArgs e)
        {

        }

        private void metroTile6_Click(object sender, EventArgs e)
        {
           
        }

        private void metroTile1_Click_1(object sender, EventArgs e)
        {
            //Declaro la instancia del ReporteViwer y lo llamo
            ReportesForm reporte = new ReportesForm();
            reporte.idpagoprop = int.Parse(metroGridPagos.CurrentRow.Cells["numeroOrdenPagoDataGridViewTextBoxColumn"].Value.ToString());
            reporte.ShowDialog();

            //Declaro la instancia del ReporteViwer y lo llamo
            ReportRetencionesForm ReporRetencion = new ReportRetencionesForm();
            ReporRetencion.Idpago = int.Parse(metroGridPagos.CurrentRow.Cells["numeroOrdenPagoDataGridViewTextBoxColumn"].Value.ToString());

            ReporRetencion.ShowDialog();
        }

        private void metroButton6_Click(object sender, EventArgs e)
        {

        }

        private void metroTile2_Click_1(object sender, EventArgs e)
        {

            bindingSourcePagos.DataSource = pagosController.GetPagosProveedores(metroDateTimeInicio.Value, metroDateTimeFin.Value).ToList();
            bindingSourcePagos.ResetBindings(true);

            //Total Gastos y IVa
            double Total = 0;
           

            foreach (DataGridViewRow row in metroGridPagos.Rows)
            {
                Total += Convert.ToDouble(row.Cells["importeDataGridViewTextBoxColumn"].Value);
               
            }
            metroTextBoxTotal.Text = Total.ToString();
            metroTextBoxTotal.Enabled = false;


        }

        private void metroTile4_Click(object sender, EventArgs e)
        {
            //abrir formulario de comprobantes
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == typeof(PagosFrm))
                {
                    f.Activate();
                    return;
                }
            }
            
            PagosFrm PagosForm = new PagosFrm();
            PagosForm.Edition = false;


            PagosForm.Show();
        }

        private void metroLabel11_Click(object sender, EventArgs e)
        {

        }
    }
}
