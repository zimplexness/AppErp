namespace ErpGestion
{
    partial class ReportRetencionesForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SeleccionarDatosRetencion_ResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.EncabezadoOrdenPago_ResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.OrdenPago_ResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.SeleccionarDatosRetencion_ResultBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EncabezadoOrdenPago_ResultBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrdenPago_ResultBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "Retencion";
            reportDataSource1.Value = this.SeleccionarDatosRetencion_ResultBindingSource;
            reportDataSource2.Name = "OrdenHead";
            reportDataSource2.Value = this.EncabezadoOrdenPago_ResultBindingSource;
            reportDataSource3.Name = "Orden";
            reportDataSource3.Value = this.OrdenPago_ResultBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ErpGestion.ReportRetenciones.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(20, 60);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(760, 370);
            this.reportViewer1.TabIndex = 7;
            // 
            // SeleccionarDatosRetencion_ResultBindingSource
            // 
            this.SeleccionarDatosRetencion_ResultBindingSource.DataSource = typeof(Entidades.SeleccionarDatosRetencion_Result);
            this.SeleccionarDatosRetencion_ResultBindingSource.CurrentChanged += new System.EventHandler(this.SeleccionarDatosRetencion_ResultBindingSource_CurrentChanged);
            // 
            // EncabezadoOrdenPago_ResultBindingSource
            // 
            this.EncabezadoOrdenPago_ResultBindingSource.DataSource = typeof(Entidades.EncabezadoOrdenPago_Result);
            // 
            // OrdenPago_ResultBindingSource
            // 
            this.OrdenPago_ResultBindingSource.DataSource = typeof(Entidades.OrdenPago_Result);
            // 
            // ReportRetencionesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReportRetencionesForm";
            this.Text = "ReportRetencionesForm";
            this.Load += new System.EventHandler(this.ReportRetencionesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SeleccionarDatosRetencion_ResultBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EncabezadoOrdenPago_ResultBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrdenPago_ResultBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource SeleccionarDatosRetencion_ResultBindingSource;
        private System.Windows.Forms.BindingSource EncabezadoOrdenPago_ResultBindingSource;
        private System.Windows.Forms.BindingSource OrdenPago_ResultBindingSource;
    }
}