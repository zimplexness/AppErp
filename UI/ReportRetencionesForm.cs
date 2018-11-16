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
using BLayer.Controller;
using BLayer;

namespace ErpGestion
{
    public partial class ReportRetencionesForm : MetroFramework.Forms.MetroForm
    {
        public int Idpago{ get; set; }
        public ReportRetencionesForm()
        {
            InitializeComponent();
        }

        private void ReportRetencionesForm_Load(object sender, EventArgs e)
        {
           // PagosManager p = new PagosManager();
            PagosController pagosController = new PagosController();


            EncabezadoOrdenPago_ResultBindingSource.DataSource = pagosController.EncabezadoOdern(Idpago);
            OrdenPago_ResultBindingSource.DataSource = pagosController.OrdenPago(Idpago);

            SeleccionarDatosRetencion_ResultBindingSource.DataSource = pagosController.GetDatosRetenciones(Idpago);

            this.reportViewer1.RefreshReport();
        }

        private void SeleccionarDatosRetencion_ResultBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
