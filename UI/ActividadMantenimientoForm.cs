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
    public partial class ActividadMantenimientoForm : MetroFramework.Forms.MetroForm
    {
        public bool Edition { get; set; }
        public int IDActividadMantenimiento{ get; set; }
        ActividadMantenimiento actividadMantenimiento;
        MantenimientoVehiculoController mantenimiento;

        public ActividadMantenimientoForm()
        {
            InitializeComponent();
            mantenimiento = new MantenimientoVehiculoController();
            actividadMantenimiento = new ActividadMantenimiento();
        }

        private void ActividadVehiculoForm_Load(object sender, EventArgs e)
        {

            actividadMantenimiento = mantenimiento.GetActividadMantenimientoByID(IDActividadMantenimiento);
            if (actividadMantenimiento!=null)
            {
                metroTextBoxActividad.Text = actividadMantenimiento.Detalle;

            }
            else
            {
                metroTextBoxActividad.Clear();
            }

        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {
           
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (actividadMantenimiento != null)
                {
                    actividadMantenimiento.Detalle = metroTextBoxActividad.Text;
                    mantenimiento.AddActividadMantenimiento(actividadMantenimiento);
                    

                }
                else
                {
                    actividadMantenimiento = new ActividadMantenimiento();
                    actividadMantenimiento.Detalle = metroTextBoxActividad.Text;
                    mantenimiento.AddActividadMantenimiento(actividadMantenimiento);
                }
                MetroFramework.MetroMessageBox.Show(this, "Actividad de Mantenimiento Agregado con exito", "Sistema de Gestiòn", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
    }
}
