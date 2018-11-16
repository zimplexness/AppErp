using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Common;
using System.Data.Entity.SqlServer;
using BLayer;
using Controllers;

namespace ErpGestion
{
    public partial class ReportesForm : MetroFramework.Forms.MetroForm
    {
        public int idpagoprop { get; set; }
        public ReportesForm()
        {
            InitializeComponent();
        }
        
        private void buttonCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ReportesForm_Load(object sender, EventArgs e)
        {
            ///PagosManager p = new PagosManager();
            PagosController pagosController = new PagosController();


            EncabezadoOrdenPago_ResultBindingSource.DataSource = pagosController.EncabezadoOdern(idpagoprop);
            OrdenPago_ResultBindingSource.DataSource = pagosController.OrdenPago(idpagoprop);
            SeleccionarMediosDePagos_ResultBindingSource.DataSource = pagosController.MediosPagos(idpagoprop);
            SeleccionarDatosRetencion_ResultBindingSource.DataSource = pagosController.GetDatosRetenciones(idpagoprop);


            EncabezadoOrdenPago_ResultBindingSource.DataSource = pagosController.EncabezadoOdern(idpagoprop);
            OrdenPago_ResultBindingSource.DataSource = pagosController.OrdenPago(idpagoprop);


            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
