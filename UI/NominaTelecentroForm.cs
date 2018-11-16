﻿using System;

using Controllers;

namespace ErpGestion
{
    public partial class NominaTelecentroForm : MetroFramework.Forms.MetroForm
    {
        public NominaTelecentroForm()
        {
            InitializeComponent();
        }

        //declaro propiedades para listar la nomina de telecentro

        public DateTime FechaFin { get; set; }

        








        private void NominaTelecentroForm_Load(object sender, EventArgs e)
        {


            ReporteNominaTelecentro_ResultBindingSource.DataSource = new EmpleadosController().ReporteNominaTLC(FechaFin);

            System.Security.PermissionSet sec = new System.Security.PermissionSet(System.Security.Permissions.PermissionState.Unrestricted);
            this.reportViewer1.LocalReport.SetBasePermissionsForSandboxAppDomain(sec);


           


            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            
            
        }
    }
}
