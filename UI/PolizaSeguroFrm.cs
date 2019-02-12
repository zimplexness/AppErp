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
using BLayer;
using Controllers;


namespace ErpGestion
{
    public partial class PolizaSeguroFrm : MetroFramework.Forms.MetroForm
    {
        private PolizasSeguro PolizaObject=null;
        public MantenimientoVehiculoController MantenimientoVehiculo;

        public int ID { get; set; }

        
        public PolizaSeguroFrm()
        {
            InitializeComponent();
           this.PolizaObject = new PolizasSeguro();
           this.MantenimientoVehiculo = new MantenimientoVehiculoController();

        }

        
         

        private void metroLabel2_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void metroTabPage1_Click(object sender, EventArgs e)
        {

        }

        private void PolizaSeguroFrm_Load(object sender, EventArgs e)
        {
            //autocomplete textbox con proveedores

            ProveedorController proveedorController = new ProveedorController();

            AutoCompleteStringCollection sourcename = new AutoCompleteStringCollection();
            sourcename.AddRange(proveedorController.GetProveedoresName().ToArray());
            metroTextBoxProveedor.AutoCompleteMode = AutoCompleteMode.Suggest;
            metroTextBoxProveedor.AutoCompleteSource = AutoCompleteSource.CustomSource;
            metroTextBoxProveedor.AutoCompleteCustomSource = sourcename;

            
            PolizaObject = MantenimientoVehiculo.GetPolizaSeguro(ID);

            if (PolizaObject!=null)
            {
                metroTextBoxNoPoliza.Text = PolizaObject.Nopoliza;
                metroTextBoxDescripcionPoliza.Text = PolizaObject.Descripcion;
                metroDateTimeFechaEmision.Value = PolizaObject.FechaEmision.Value;
                metroDateTimeFechaFin.Value = PolizaObject.FechaFin.Value;
                metroTextBoxProveedor.Text = PolizaObject.Proveedores.Nombre;
            }
            else
            {
                metroTextBoxNoPoliza.Clear();
                metroTextBoxDescripcionPoliza.Clear();
                metroDateTimeFechaEmision.Refresh();
                metroDateTimeFechaFin.Refresh();
                


            }
            


        }

        private void metroButtonAgregarPago_Click(object sender, EventArgs e)
        {

        }

        private void metroButtonAgregarPago_Click_1(object sender, EventArgs e)
        {
           
        }

        private void PolizaSeguroFrm_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void metroTile4_Click(object sender, EventArgs e)
        {
            try
            {
                if (PolizaObject != null)
                {
                    PolizaObject.Nopoliza = metroTextBoxNoPoliza.Text;
                    PolizaObject.Descripcion = metroTextBoxDescripcionPoliza.Text;
                    PolizaObject.FechaEmision = metroDateTimeFechaEmision.Value;
                    PolizaObject.FechaFin = metroDateTimeFechaFin.Value;
                    PolizaObject.IDCompania = new ProveedorController().GetProveedorByName(metroTextBoxProveedor.Text).IdProveedores;
                    PolizaObject.Activa = metroCheckBoxActivo.Checked;

                    if (MantenimientoVehiculo.AddorUpdatePolizas(PolizaObject) != null)
                    {
                        MessageBox.Show("Poliza agregada con exito", "Sistema de Gestion Integral", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
                else
                {
                    PolizaObject = new PolizasSeguro();
                    PolizaObject.Nopoliza = metroTextBoxNoPoliza.Text;
                    PolizaObject.Descripcion = metroTextBoxDescripcionPoliza.Text;
                    PolizaObject.FechaEmision = metroDateTimeFechaEmision.Value;
                    PolizaObject.FechaFin = metroDateTimeFechaFin.Value;
                    PolizaObject.Activa = metroCheckBoxActivo.Checked;
                    PolizaObject.IDCompania = new ProveedorController().GetProveedorByName(metroTextBoxProveedor.Text).IdProveedores;

                    if (MantenimientoVehiculo.AddorUpdatePolizas(PolizaObject) != null)
                    {
                        MessageBox.Show("Poliza agregada con exito", "Sistema de Gestion Integral", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }




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
