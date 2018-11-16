using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

using Controllers;

namespace ErpGestion
{
    public partial class RegistroConducirForm : MetroFramework.Forms.MetroForm
    {

        public int RegistroID { get; set; }
        RegistrosConducir RegistrosConducir;
        MantenimientoVehiculoController MantenimientoVehiculoController;
        EmpleadosController empleadosController;
        
        public RegistroConducirForm()
        {
            InitializeComponent();
            MantenimientoVehiculoController = new MantenimientoVehiculoController();
            empleadosController = new EmpleadosController();
            RegistrosConducir = new RegistrosConducir();

        }

        private void RegistroConducirForm_Load(object sender, EventArgs e)
        {
            VehiculosManager objvehiculo = new VehiculosManager();

            

            metroComboBoxTipoRegistro.DataSource = MantenimientoVehiculoController.GetTiposRegistrosConducir();
            metroComboBoxTipoRegistro.DisplayMember = "TipoRegistro";
            metroComboBoxTipoRegistro.ValueMember = "IdTipoRegistroConducir";

            metroComboBoxEmpleado.DataSource = objvehiculo.Choferes();
            metroComboBoxEmpleado.DisplayMember = "Chofer";
            metroComboBoxEmpleado.ValueMember = "IDEmpleado";

            RegistrosConducir = MantenimientoVehiculoController.GetRegistroConducir(RegistroID);

            if (RegistrosConducir!=null)
            {
                metroComboBoxTipoRegistro.SelectedValue = RegistrosConducir.TipoRegistroID;
                metroComboBoxEmpleado.SelectedValue = RegistrosConducir.EmpleadoID;
                metroDateTimeFechaEmision.Value = RegistrosConducir.FechaEmision.Value;
                metroDateTimeFechaFin.Value = RegistrosConducir.FechaVencimiento.Value;
            }
            
            


        }

        private void metroButtonAgregarPago_Click(object sender, EventArgs e)
        {

            try
            {
                if (RegistrosConducir!=null)
                {
                    RegistrosConducir.EmpleadoID = (int)metroComboBoxEmpleado.SelectedValue;
                    RegistrosConducir.TipoRegistroID = (int)metroComboBoxTipoRegistro.SelectedValue;
                    RegistrosConducir.FechaEmision = metroDateTimeFechaEmision.Value;
                    RegistrosConducir.FechaVencimiento = metroDateTimeFechaFin.Value;
                    MantenimientoVehiculoController.AddOrUpdateRegistro(RegistrosConducir);
                    MessageBox.Show("Registro Ingresado con exito","Sistema de Gestion Integral", MessageBoxButtons.OK,MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    RegistrosConducir = new RegistrosConducir();
                    RegistrosConducir.EmpleadoID = (int)metroComboBoxEmpleado.SelectedValue;
                    RegistrosConducir.TipoRegistroID = (int)metroComboBoxTipoRegistro.SelectedValue;
                    RegistrosConducir.FechaEmision = metroDateTimeFechaEmision.Value;
                    RegistrosConducir.FechaVencimiento = metroDateTimeFechaFin.Value;
                    MantenimientoVehiculoController.AddOrUpdateRegistro(RegistrosConducir);
                    MessageBox.Show("Registro Ingresado con exito", "Sistema de Gestion Integral", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }


        }
    }
}
