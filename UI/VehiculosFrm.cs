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
    public partial class VehiculosFrm : MetroFramework.Forms.MetroForm
    {

        public int IdVehiculo  { get; set; }
        Vehiculos vehiculo;
        MantenimientoVehiculoController mantenimientoVehiculo;
        SharedController sharedController;
        public VehiculosFrm()
        {
            InitializeComponent();
            vehiculo = new Vehiculos();
            mantenimientoVehiculo = new MantenimientoVehiculoController();
            sharedController = new SharedController();
        }

          VehiculosManager ObjVehiculo = new VehiculosManager();


        private void VehiculosForm_Load(object sender, EventArgs e)
        {

            //LLenar todos los combobox
            
            metroComboBoxMarca.DataSource = mantenimientoVehiculo.GetMarcasVehiculos();
            metroComboBoxMarca.DisplayMember = "Marcas";
            metroComboBoxMarca.ValueMember = "IDMarca";

            metroComboBoxModelo.DataSource = mantenimientoVehiculo.GetModelosVehiculos();
            metroComboBoxModelo.DisplayMember = "Modelo";
            metroComboBoxModelo.ValueMember = "IDModeloVehiculo";

            metroComboBoxChoferes.DataSource = sharedController.GetChoferes();
            metroComboBoxChoferes.DisplayMember = "Chofer";
            metroComboBoxChoferes.ValueMember = "IDEmpleado";

            metroComboBoxCombustible.DataSource = mantenimientoVehiculo.GetCombustibles();
            metroComboBoxCombustible.DisplayMember = "Descripcion";
            metroComboBoxCombustible.ValueMember = "IDCombustible";

            metroComboBoxPoliza.DataSource = mantenimientoVehiculo.GetPolizasSeguroActivas();
            metroComboBoxPoliza.DisplayMember = "Descripcion";
            metroComboBoxPoliza.ValueMember = "IDPolizaSeguro";

            //GetVehiculo
            vehiculo = mantenimientoVehiculo.GetVehiculosById(IdVehiculo);


            if (vehiculo!=null&&vehiculo.IdPolizaSeguro!=null && vehiculo.IDCombustible != null)
            {
                metroCheckBoxActivo.Checked = vehiculo.Activo.Value;
                metroCheckBoxGps.Checked = vehiculo.Gps.Value;
                metroCheckBoxNeumaticos.Checked = vehiculo.NeumaticoRepuesto.Value;
                metroTextBoxPatente.Text = vehiculo.Patente;
                metroComboBoxMarca.SelectedValue = vehiculo.Marca.Value;
                metroComboBoxModelo.SelectedValue = vehiculo.ModelosVehiculos.IDModeloVehiculo;
                metroDateTimeFechaCompra.Value = vehiculo.FechaCompra.Value;
                metroDateTimeFechaTransferencia.Value = vehiculo.FechaTransferencia.Value;
                metroTextBoxNochasis.Text = vehiculo.Nochasis;
                metroTextBoxNomotor.Text = vehiculo.NoMotor;
                metroDateTimeVTV.Value = vehiculo.VigenciaVTV.Value;
                metroComboBoxChoferes.Text = vehiculo.Empleados.Nombres+ vehiculo.Empleados.Apellidos;
                metroTextBoxTitular.Text = vehiculo.Titular;
                metroTextBoxKm.Text = vehiculo.KM.ToString();
                metroComboBoxPoliza.SelectedValue = vehiculo.IdPolizaSeguro.Value;
                metroComboBoxCombustible.SelectedValue = vehiculo.IDCombustible;
                metroTextBoxyear.Text = vehiculo.Year.ToString();
                metroTextBoxRadicacion.Text = vehiculo.DireccionRadicacion;


            }
            else if(vehiculo != null)
            {
                metroCheckBoxActivo.Checked = vehiculo.Activo.Value;
                metroCheckBoxGps.Checked = vehiculo.Gps.Value;
                metroCheckBoxNeumaticos.Checked = vehiculo.NeumaticoRepuesto.Value;
                metroTextBoxPatente.Text = vehiculo.Patente;
                metroComboBoxMarca.SelectedValue = vehiculo.Marca.Value;
                metroComboBoxModelo.SelectedValue = vehiculo.ModelosVehiculos.IDModeloVehiculo;
                metroDateTimeFechaCompra.Value = vehiculo.FechaCompra.Value;
                metroDateTimeFechaTransferencia.Value = vehiculo.FechaTransferencia.Value;
                metroTextBoxNochasis.Text = vehiculo.Nochasis;
                metroTextBoxNomotor.Text = vehiculo.NoMotor;
                metroDateTimeVTV.Value = vehiculo.VigenciaVTV.Value;
                metroComboBoxChoferes.Text = vehiculo.Empleados.Nombres + vehiculo.Empleados.Apellidos;
                metroTextBoxTitular.Text = vehiculo.Titular;
                metroTextBoxKm.Text = vehiculo.KM.ToString();
               // metroComboBoxPoliza.SelectedValue = vehiculo.IdPolizaSeguro.Value;
                metroComboBoxCombustible.SelectedValue = vehiculo.IDCombustible;
                metroTextBoxyear.Text = vehiculo.Year.ToString();
                metroTextBoxRadicacion.Text = vehiculo.DireccionRadicacion;

            }
           

           





        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void metroTextBoxFiltrarApellido_TextChanged(object sender, EventArgs e)
        {

            
        }

        private void metroComboBoxMarca_Leave(object sender, EventArgs e)
        {

            metroComboBoxModelo.DataSource = mantenimientoVehiculo.GetModeloxMarca((int)metroComboBoxMarca.SelectedValue);
            metroComboBoxModelo.DisplayMember = "Modelo";
            metroComboBoxModelo.ValueMember = "IDModeloVehiculo";
        }

        private void metroComboBoxChoferes_Click(object sender, EventArgs e)
        {
           metroComboBoxChoferes.DataSource = new VehiculosManager().Choferes();
           metroComboBoxChoferes.DisplayMember = "Chofer";
           metroComboBoxChoferes.ValueMember = "IDEmpleado";
        }

        private void toolStripTextBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void metroTextBoxMarca_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void metroTextBoxAnno_TextChanged(object sender, EventArgs e)
        {

           
        }

        private void metroTextBoxMarca_TextChanged_1(object sender, EventArgs e)
        {
           
        }

        private void metroTextBoxBrand_TextChanged(object sender, EventArgs e)
        {
        }

        private void metroTabPage1_Click(object sender, EventArgs e)
        {

        }

        private void metroButtonAgregarPago_Click(object sender, EventArgs e)
        {
           
        }

        private void metroTile4_Click(object sender, EventArgs e)
        {
            try
            {
                if (vehiculo != null)
                {
                    vehiculo.Activo = metroCheckBoxActivo.Checked;
                    vehiculo.Gps = metroCheckBoxGps.Checked;
                    vehiculo.NeumaticoRepuesto = metroCheckBoxNeumaticos.Checked;
                    vehiculo.Patente = metroTextBoxPatente.Text;
                    vehiculo.Marca = (int)metroComboBoxMarca.SelectedValue;
                    vehiculo.Modelo = (int)metroComboBoxModelo.SelectedValue;
                    vehiculo.FechaCompra = metroDateTimeFechaCompra.Value;
                    vehiculo.FechaTransferencia = metroDateTimeFechaTransferencia.Value;
                    vehiculo.Nochasis = metroTextBoxNochasis.Text;
                    vehiculo.NoMotor = metroTextBoxNomotor.Text;
                    vehiculo.VigenciaVTV = metroDateTimeVTV.Value;
                    vehiculo.IdChofer = (int)metroComboBoxChoferes.SelectedValue;
                    vehiculo.Titular = metroTextBoxTitular.Text;
                    vehiculo.KM = int.Parse(metroTextBoxKm.Text);
                    vehiculo.IdPolizaSeguro = (int)metroComboBoxPoliza.SelectedValue;
                    vehiculo.IDCombustible = (int)metroComboBoxCombustible.SelectedValue;
                    vehiculo.Year = int.Parse(metroTextBoxyear.Text);
                    vehiculo.DireccionRadicacion = metroTextBoxRadicacion.Text;
                    mantenimientoVehiculo.AddorUpdateVehiculo(vehiculo);

                }
                else
                {
                    vehiculo = new Vehiculos();
                    vehiculo.Activo = metroCheckBoxActivo.Checked;
                    vehiculo.Gps = metroCheckBoxGps.Checked;
                    vehiculo.NeumaticoRepuesto = metroCheckBoxNeumaticos.Checked;
                    vehiculo.Patente = metroTextBoxPatente.Text;
                    vehiculo.Marca = (int)metroComboBoxMarca.SelectedValue;
                    vehiculo.Modelo = (int)metroComboBoxModelo.SelectedValue;
                    vehiculo.FechaCompra = metroDateTimeFechaCompra.Value;
                    vehiculo.FechaTransferencia = metroDateTimeFechaTransferencia.Value;
                    vehiculo.Nochasis = metroTextBoxNochasis.Text;
                    vehiculo.NoMotor = metroTextBoxNomotor.Text;
                    vehiculo.VigenciaVTV = metroDateTimeVTV.Value;
                    vehiculo.IdChofer = (int)metroComboBoxChoferes.SelectedValue;
                    vehiculo.Titular = metroTextBoxTitular.Text;
                    vehiculo.KM = int.Parse(metroTextBoxKm.Text);
                    vehiculo.IdPolizaSeguro = (int)metroComboBoxPoliza.SelectedValue;
                    vehiculo.IDCombustible = (int)metroComboBoxCombustible.SelectedValue;
                    vehiculo.Year = int.Parse(metroTextBoxyear.Text);
                    vehiculo.DireccionRadicacion = metroTextBoxRadicacion.Text;
                    mantenimientoVehiculo.AddorUpdateVehiculo(vehiculo);

                }

                MetroFramework.MetroMessageBox.Show(this, "Mantenimeinto Agregado con exito", "Sistema de Gestiòn", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {

        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
