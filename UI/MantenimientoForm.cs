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
    public partial class MantenimientoForm : MetroFramework.Forms.MetroForm
    {

        public bool Edition { get; set; }
        VehiculosManager Vehiculos;
        TallerManager taller;
        MantenimientoVehiculoController MantenimientoVehiculoController;
        public int IDMantenimiento { get; set; }
        Mantenimiento Mantenimiento;
        IEnumerable<DetalleActividadMantenimiento> ListdetalleActividadMantenimiento;
        IEnumerable<DetalleMantenimientoRepuestos> ListdetalleMantenimientoRepuestos;
        ArticuloController ArticuloController;

        public MantenimientoForm()
        {
            InitializeComponent();
            Vehiculos = new VehiculosManager();
            taller = new TallerManager();
            Mantenimiento = new Mantenimiento();
            MantenimientoVehiculoController = new MantenimientoVehiculoController();
            ArticuloController = new ArticuloController();
           

                
        }

        private void MantenimientoForm_Load(object sender, EventArgs e)
        {
            //vehiculo
            metroComboBoxVehiculo.DataSource = MantenimientoVehiculoController.GetAllVehiculos();
            metroComboBoxVehiculo.DisplayMember = "Patente";
            metroComboBoxVehiculo.ValueMember = "IDVehiculo";
            //actividades
            metroComboBoxActividad.DataSource =   Vehiculos.GetActividadMantenimientos();
            metroComboBoxActividad.DisplayMember = "Detalle";
            metroComboBoxActividad.ValueMember = "Detalle";

            //taller
           
            metroComboBoxTaller.DataSource = taller.TalleresMecanicos();
            metroComboBoxTaller.DisplayMember = "NombreTaller";
            metroComboBoxTaller.ValueMember = "IDTalleres";
          

            //Autofill Producto
            ArticuloController a = new ArticuloController();
            AutoCompleteStringCollection sourcename2 = new AutoCompleteStringCollection();
            sourcename2.AddRange(a.ListarNombresArticulos().ToArray());
            //this.metroTextBoxProducto.AutoCompleteMode = AutoCompleteMode.Suggest;
            //this.metroTextBoxProducto.AutoCompleteSource = AutoCompleteSource.CustomSource;
            //this.metroTextBoxProducto.AutoCompleteCustomSource = sourcename2;

            this.metroTextBoxRepuesto.AutoCompleteMode = AutoCompleteMode.Suggest;
            this.metroTextBoxRepuesto.AutoCompleteSource = AutoCompleteSource.CustomSource;
            this.metroTextBoxRepuesto.AutoCompleteCustomSource = sourcename2;

            //Get Object Mantenimiento

            Mantenimiento = MantenimientoVehiculoController.GetMantenimientoByID(IDMantenimiento);
            ListdetalleActividadMantenimiento = MantenimientoVehiculoController.GetAllDetalleActividadMantenimiento(IDMantenimiento);
            ListdetalleMantenimientoRepuestos = MantenimientoVehiculoController.GetAllDetalleMantenimientoRepuestos(IDMantenimiento);
            bindingSourceDetalleMantenimiento.DataSource = ListdetalleActividadMantenimiento;
            bindingSourceDetalleRepuesto.DataSource = ListdetalleMantenimientoRepuestos;
            objectBindingSourceActividadesMantenimiento.DataSource = MantenimientoVehiculoController.GetAllActividadMantenimiento();
            objectBindingSourceRepuesto.DataSource = ArticuloController.ListarArticulos();

            if (Mantenimiento!=null&&Edition==true)
            {
                metroComboBoxVehiculo.SelectedValue =(int)Mantenimiento.IdVehiculo;
                metroDateTimeFECHA.Value = Mantenimiento.Fecha.Value;
                metroComboBoxTaller.SelectedValue = Mantenimiento.IDTaller;
                metroTextBoxTotal.Text = Mantenimiento.Total.ToString();
                metroTextBoxcomentario.Text = Mantenimiento.Comentario;
                metroTextBoxKm.Text = Mantenimiento.Km.ToString();
                


            }
            else
            {
                metroGridActividades.Rows.Clear();
                metroGridActividades.DataSource = null;
                metroGridRepuestos.Rows.Clear();
                metroGridRepuestos.DataSource = null;
                

            }






        }

        private void metroComboBoxTaller_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void metroLabel9_Click(object sender, EventArgs e)
        {

        }

        private void metroButtonAgregarPago_Click(object sender, EventArgs e)
        {
            try
            {
                if (Mantenimiento!=null&&Edition==true)
                {
                    Mantenimiento.IdVehiculo = (int)metroComboBoxVehiculo.SelectedValue;
                    Mantenimiento.Km = int.Parse(metroTextBoxKm.Text);
                    Mantenimiento.Fecha = metroDateTimeFECHA.Value;
                    Mantenimiento.IDTaller = (int)metroComboBoxTaller.SelectedValue;
                    Mantenimiento.Comentario = metroTextBoxcomentario.Text;
                    Mantenimiento.Total = float.Parse(metroTextBoxTotal.Text);
                    MantenimientoVehiculoController.AddorUpdateMantenimiento(Mantenimiento);


                    foreach (DataGridViewRow row in metroGridActividades.Rows)
                    {
                        DetalleActividadMantenimiento detalleActividadMantenimiento = new DetalleActividadMantenimiento();

                        detalleActividadMantenimiento.IdDetalleActividadMantenimiento = int.Parse(row.Cells["idDetalleActividadMantenimientoDataGridViewTextBoxColumn"].Value.ToString());
                        detalleActividadMantenimiento.IdActividadMantenimiento = MantenimientoVehiculoController.GetActividadMantenimiento(row.Cells["actividadMantenimientoDetalleDataGridViewTextBoxColumn"].Value.ToString()).IDActividadMantenimiento;
                        detalleActividadMantenimiento.IdMantenimiento =Mantenimiento.IDMantenimiento;
                        MantenimientoVehiculoController.AddOrUpdateDetalleActividadMantenimiento(detalleActividadMantenimiento);
                    }

                    foreach (DataGridViewRow row1 in metroGridRepuestos.Rows)
                    {
                        DetalleMantenimientoRepuestos detalleMantenimientoRepuestos = new DetalleMantenimientoRepuestos();
                        detalleMantenimientoRepuestos.IdDetalleMantenimientoRepuesto = int.Parse(row1.Cells["idDetalleMantenimientoRepuestoDataGridViewTextBoxColumn"].Value.ToString());
                        detalleMantenimientoRepuestos.IDMantenimiento =Mantenimiento.IDMantenimiento;
                        detalleMantenimientoRepuestos.IdRepuestos = ArticuloController.DevolverIDporNombre(row1.Cells["articulosNombreDataGridViewTextBoxColumn"].Value.ToString()).IDArticulo;
                        detalleMantenimientoRepuestos.Cantidad = int.Parse(row1.Cells["cantidadDataGridViewTextBoxColumn"].Value.ToString());
                        detalleMantenimientoRepuestos.Precio= float.Parse(row1.Cells["precioDataGridViewTextBoxColumn"].Value.ToString());
                        detalleMantenimientoRepuestos.Importe = float.Parse(row1.Cells["importeDataGridViewTextBoxColumn"].Value.ToString());
                        MantenimientoVehiculoController.AddorUpdateDetalleMantenimientoRepuesto(detalleMantenimientoRepuestos);

                    }

                   

                }
                else if (Mantenimiento==null&&Edition==false)
                {
                    Mantenimiento = new Mantenimiento();
                    Mantenimiento.IdVehiculo =(int) metroComboBoxVehiculo.SelectedValue;
                    Mantenimiento.Km =int.Parse( metroTextBoxKm.Text);
                    Mantenimiento.Fecha = metroDateTimeFECHA.Value;
                    Mantenimiento.IDTaller = (int)metroComboBoxTaller.SelectedValue;
                    Mantenimiento.Comentario = metroTextBoxcomentario.Text;
                    Mantenimiento.Total = float.Parse(metroTextBoxTotal.Text);
                    var IDM=  MantenimientoVehiculoController.AddorUpdateMantenimiento(Mantenimiento).IDMantenimiento;


                    foreach (DataGridViewRow row in metroGridActividades.Rows)
                    {
                        DetalleActividadMantenimiento detalleActividadMantenimiento = new DetalleActividadMantenimiento();
                        detalleActividadMantenimiento.IdDetalleActividadMantenimiento =int.Parse( row.Cells["idDetalleActividadMantenimientoDataGridViewTextBoxColumn"].Value.ToString());
                        detalleActividadMantenimiento.IdActividadMantenimiento=MantenimientoVehiculoController.GetActividadMantenimiento(row.Cells["actividadMantenimientoDetalleDataGridViewTextBoxColumn"].Value.ToString()).IDActividadMantenimiento  ;
                        detalleActividadMantenimiento.IdMantenimiento = IDM;
                        MantenimientoVehiculoController.AddOrUpdateDetalleActividadMantenimiento(detalleActividadMantenimiento);
                    }

                    foreach (DataGridViewRow row1 in metroGridRepuestos.Rows)
                    {
                        DetalleMantenimientoRepuestos detalleMantenimientoRepuestos = new DetalleMantenimientoRepuestos();
                        detalleMantenimientoRepuestos.IdDetalleMantenimientoRepuesto = int.Parse(row1.Cells["idDetalleMantenimientoRepuestoDataGridViewTextBoxColumn"].Value.ToString());
                        detalleMantenimientoRepuestos.IDMantenimiento = IDM;
                        detalleMantenimientoRepuestos.IdRepuestos = ArticuloController.DevolverIDporNombre(row1.Cells["articulosNombreDataGridViewTextBoxColumn"].Value.ToString()).IDArticulo;
                        detalleMantenimientoRepuestos.Cantidad =int.Parse( row1.Cells["cantidadDataGridViewTextBoxColumn"].Value.ToString());
                        detalleMantenimientoRepuestos.Precio = float.Parse(row1.Cells["precioDataGridViewTextBoxColumn"].Value.ToString());
                        detalleMantenimientoRepuestos.Importe = float.Parse(row1.Cells["importeDataGridViewTextBoxColumn"].Value.ToString());
                        MantenimientoVehiculoController.AddorUpdateDetalleMantenimientoRepuesto(detalleMantenimientoRepuestos);

                    }


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
            this.Close();
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {

            if (Edition == true)
            {
                MetroFramework.MetroMessageBox.Show(this, "El formulario Mantenimiento esta en estado de edicion", "Sistema de Gestiòn", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                var Actividad = new[] { "0", metroComboBoxActividad.SelectedValue };

                metroGridActividades.Rows.Add(Actividad);

            }

           
            

        }

        private void metroGridActividades_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            metroGridActividades.CurrentCell.ReadOnly = false;
            
        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            metroGridActividades.CurrentCell.ReadOnly = false;
        }

        private void metroGrid1_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            metroGridActividades.Rows.Clear();
            metroGridActividades.DataSource = null;
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
           


            if (Edition==true)
            {
                MetroFramework.MetroMessageBox.Show(this, "El formulario Mantenimiento esta en estado de edicion", "Sistema de Gestiòn", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                float Cantidad = float.Parse(metroTextBoxCant.Text);
                float Precio = float.Parse(metroTextBoxPrecio.Text);
                float Importe = Cantidad * Precio;
                var DetalleRepuestos = new[] {"0", metroTextBoxRepuesto.Text, metroTextBoxCant.Text, metroTextBoxPrecio.Text, Importe.ToString() };
                metroGridRepuestos.Rows.Add(DetalleRepuestos);
            }

            if (metroGridRepuestos.Rows.Count != 0)
            {
                double Total = 0;
                foreach (DataGridViewRow row2 in metroGridRepuestos.Rows)
                {

                    Total += Convert.ToDouble(row2.Cells["importeDataGridViewTextBoxColumn"].Value.ToString());
                   
                }
                metroTextBoxTotal.Text = Total.ToString();
            }



        }

        private void MantenimientoForm_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
