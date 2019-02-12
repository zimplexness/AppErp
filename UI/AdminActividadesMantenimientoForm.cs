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
    public partial class AdminActividadesMantenimientoForm : MetroFramework.Forms.MetroForm
    {
        
        MantenimientoVehiculoController mantenimientoVehiculo;
        public AdminActividadesMantenimientoForm()
        {
            InitializeComponent();
           
            mantenimientoVehiculo = new MantenimientoVehiculoController();

        }

        private void AdminActividadesMantenimientoForm_Load(object sender, EventArgs e)
        {
            bindingSourceActividades.DataSource = mantenimientoVehiculo.GetAllActividadMantenimiento();


        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ActividadMantenimientoForm mantenimientoForm = new ActividadMantenimientoForm();
            mantenimientoForm.ShowDialog();
        }

        private void metroGridActividad_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //abrir formulario de comprobantes
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == typeof(ActividadMantenimientoForm))
                {
                    f.Activate();
                    return;
                }
            }
            int IdActividad = (int)metroGridActividad.CurrentRow.Cells["iDActividadMantenimientoDataGridViewTextBoxColumn"].Value;

            ActividadMantenimientoForm ActividadForm = new ActividadMantenimientoForm();

            ActividadForm.IDActividadMantenimiento = IdActividad;
            ActividadForm.Edition = true;
            ActividadForm.FormClosed +=AdminActividadesMantenimientoForm_FormClosed;
            ActividadForm.Show();
        }

        private void AdminActividadesMantenimientoForm_FormClosed(object sender, FormClosedEventArgs e)
        {
           
            bindingSourceActividades.DataSource = mantenimientoVehiculo.GetAllActividadMantenimiento();
            bindingSourceActividades.ResetBindings(true);

        }

        private void metroGridActividad_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //abrir formulario de comprobantes
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == typeof(ActividadMantenimientoForm))
                {
                    f.Activate();
                    return;
                }
            }
            int IdActividad = (int)metroGridActividad.CurrentRow.Cells["iDActividadMantenimientoDataGridViewTextBoxColumn"].Value;

            ActividadMantenimientoForm ActividadForm = new ActividadMantenimientoForm();

            ActividadForm.IDActividadMantenimiento = IdActividad;
            ActividadForm.Edition = true;
            ActividadForm.FormClosed += AdminActividadesMantenimientoForm_FormClosed;
            ActividadForm.Show();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            ActividadMantenimientoForm mantenimientoForm = new ActividadMantenimientoForm();
            mantenimientoForm.ShowDialog();
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            //abrir formulario de comprobantes
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == typeof(ActividadMantenimientoForm))
                {
                    f.Activate();
                    return;
                }
            }
            int IdActividad = (int)metroGridActividad.CurrentRow.Cells["iDActividadMantenimientoDataGridViewTextBoxColumn"].Value;

            ActividadMantenimientoForm ActividadForm = new ActividadMantenimientoForm();

            ActividadForm.IDActividadMantenimiento = IdActividad;
            ActividadForm.Edition = true;
            ActividadForm.FormClosed += AdminActividadesMantenimientoForm_FormClosed;
            ActividadForm.Show();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
