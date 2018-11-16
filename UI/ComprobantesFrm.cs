using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLayer;
using Entidades;
using Controllers;

namespace ErpGestion
{
    public partial class ComprobantesFrm : MetroFramework.Forms.MetroForm
    {
        public int IDComprobante{ get; set; }
        public bool Edition { get; set; }
        ArticuloController articuloController;
        public Comprobantes comprobantes;
        public ComprobanteController comprobanteController;
        public ProveedorController proveedorController;
        public Proveedores proveedores;
        public DetallesComprobanteArticulos DetallesComprobanteArticulos;
        public PagosController PagosController = new PagosController();
        
        
        public ComprobantesFrm()
        {
            InitializeComponent();
            comprobantes = new Comprobantes();
            comprobanteController = new ComprobanteController();
            proveedorController = new ProveedorController();
            proveedores = new Proveedores();
            DetallesComprobanteArticulos = new DetallesComprobanteArticulos();
            articuloController = new ArticuloController();
        }

        private void ComprobantesForm_Load(object sender, EventArgs e)
        {
           //LLenar Comboboxes


            metroComboBoxCentroCosto.DataSource = comprobanteController.GetCentroCostos();
            metroComboBoxCentroCosto.DisplayMember = "CentroCosto";
            metroComboBoxCentroCosto.ValueMember = "IdCentroCosto";

            metroComboBoxContable.DataSource = comprobanteController.GetContable();
            metroComboBoxContable.DisplayMember = "Contable1";
            metroComboBoxContable.ValueMember = "IdContable";

            metroComboBoxTipoFactura.DataSource = comprobanteController.GetTiposFactura();
            metroComboBoxTipoFactura.DisplayMember = "TipoFactura";
            metroComboBoxTipoFactura.ValueMember = "IdTipoFactura";

            metroComboBoxCondicionCompra.DataSource = comprobanteController.GetCondicionesCompra();
            metroComboBoxCondicionCompra.DisplayMember = "Condiciondecompra";
            metroComboBoxCondicionCompra.ValueMember = "IdCondicionCompra";

            metroComboBoxTipoComprobante.DataSource = comprobanteController.GetTiposComprobante();
            metroComboBoxTipoComprobante.DisplayMember = "TipoComprobante";
            metroComboBoxTipoComprobante.ValueMember = "IdTipoComprobante";

            //llenar combobox
            metroComboBoxMedioPago.DataSource = PagosController.GetMediosPago();
            metroComboBoxMedioPago.ValueMember = "IdMedioPago";
            metroComboBoxMedioPago.DisplayMember = "MediosPago1";




            //autocomplete textbox con proveedores
          
            AutoCompleteStringCollection sourcename = new AutoCompleteStringCollection();
            sourcename.AddRange( proveedorController.GetProveedoresName().ToArray());
            metroTextBoxProveedor.AutoCompleteMode = AutoCompleteMode.Suggest;
            metroTextBoxProveedor.AutoCompleteSource = AutoCompleteSource.CustomSource;
            metroTextBoxProveedor.AutoCompleteCustomSource = sourcename;
            //autocompletar combobox articulos

            ArticuloController a = new ArticuloController();
            AutoCompleteStringCollection sourcename2 = new AutoCompleteStringCollection();
            sourcename2.AddRange(a.ListarNombresArticulos().ToArray());
           

            this.metroTextBoxProductTest.AutoCompleteMode = AutoCompleteMode.Suggest;
            this.metroTextBoxProductTest.AutoCompleteSource = AutoCompleteSource.CustomSource;
            this.metroTextBoxProductTest.AutoCompleteCustomSource = sourcename2;

            comprobantes = comprobanteController.GetComprobanteById(IDComprobante);
            objectBindingSourceArticulos.DataSource = articuloController.ListarArticulos();
            bindingSourceComprobantes.DataSource = comprobanteController.GetALLDetallesComprobanteArticulos(IDComprobante);
            if (Edition==true&&comprobantes!=null)
            {
                metroComboBoxTipoComprobante.SelectedValue = comprobantes.IdTipoComprobante;
                metroComboBoxCentroCosto.SelectedValue = comprobantes.IdCentroCosto;
                metroTextBoxProveedor.Text = proveedorController.GetProveedorById((int)comprobantes.IdProveedor).Nombre;
                metroComboBoxTipoFactura.SelectedValue = comprobantes.IdTipoFactura;
                metroTextBoxPuntoV.Text = comprobantes.Sucursal;
                metroTextBoxNoFactura.Text = comprobantes.NoFactura;
                metroComboBoxCondicionCompra.SelectedValue = comprobantes.IdCondicionCompra;
                metroComboBoxContable.SelectedValue = comprobantes.Contable;
                metroDateTimeFecha.Value = comprobantes.Fecha.Value;
                metroDateTimeVencimiento.Value = comprobantes.FechaVencimiento.Value;
                metroTextBoxIIBB.Text = comprobantes.IIBB.Value.ToString();
                metroTextBoxRetenciones.Text = comprobantes.Retenciones.Value.ToString();
                metroTextBoxOtrosGastos.Text = comprobantes.ConceptosNograbado.Value.ToString();
                metroTextBoxPercepcion.Text = comprobantes.PercepcionIva.Value.ToString();
                metroTextBoxSubTotal.Text = comprobantes.ImporteNeto.Value.ToString();
                metroTextBoxTotal.Text = comprobantes.Importe.Value.ToString();
                
            }
            else if(Edition==false)
            {
                metroGridTest.Rows.Clear();
                metroGridTest.DataSource = null;

            }
            



        }

        private void metroButtonAgregarComprobante_Click(object sender, EventArgs e)
        {
            try
            {
                if (metroTextBoxProveedor.Text == "" || metroTextBoxPuntoV.Text == "" || metroTextBoxNoFactura.Text == "")
                {
                    MessageBox.Show("Por Favor Ingrese el Proveedor y los Datos de la factura", "Sistema de Gestion de Compras", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                }
                else
                {
                    Comprobantes Comprobante = new Comprobantes();
                    var IdProveedor = proveedorController.GetProveedorByName(metroTextBoxProveedor.Text);
                    Comprobante.IdTipoComprobante = (int)metroComboBoxTipoComprobante.SelectedValue;
                    Comprobante.IdCentroCosto = (int)metroComboBoxCentroCosto.SelectedValue;
                    Comprobante.IdProveedor = (int)IdProveedor.IdProveedores;
                    Comprobante.IdTipoFactura = (int)metroComboBoxTipoFactura.SelectedValue;
                    Comprobante.Sucursal = metroTextBoxPuntoV.Text;
                    Comprobante.NoFactura = metroTextBoxNoFactura.Text;
                    Comprobante.IdCondicionCompra = (int)metroComboBoxCondicionCompra.SelectedValue;
                    Comprobante.Contable = (int)metroComboBoxContable.SelectedValue;
                    Comprobante.Fecha = metroDateTimeFecha.Value;
                    Comprobante.FechaVencimiento = metroDateTimeVencimiento.Value;
                    comprobanteController.AddorUpdateComprobantes(Comprobante);
                    MessageBox.Show("Comprobante Insertado con exito","Sistem de Gestion Integral",MessageBoxButtons.OK,MessageBoxIcon.Information);

                    //metroPanelProducto.Enabled = true;
                    //metroGridProductosServicios.Enabled = true;

                    metroTextBoxProveedor.Enabled = false;
                    metroTextBoxPuntoV.Enabled = false;
                    metroTextBoxNoFactura.Enabled = false;
                    metroComboBoxCondicionCompra.Enabled = false;
                    metroComboBoxTipoComprobante.Enabled = false;
                    metroComboBoxContable.Enabled = false;
                    metroComboBoxCentroCosto.Enabled = false;
                    metroDateTimeFecha.Enabled = false;
                    metroDateTimeVencimiento.Enabled = false;
                    metroComboBoxTipoFactura.Enabled = false;


                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        private void metroButtonCancelarComprobante_Click(object sender, EventArgs e)
        {
            try
            {

                if (metroTextBoxProveedor.Text == "" || metroTextBoxPuntoV.Text == "" || metroTextBoxNoFactura.Text == "")
                {
                    MessageBox.Show("No tiene Factura para Cancelar, ingrese Punto V, No Factura, y Proveedor", "Sistema de Gestion de Compras", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                }
                

                 
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void metroButtonAgregarProducto_Click(object sender, EventArgs e)
        {
            
        }

        private void metroButtonCancelarProducto_Click(object sender, EventArgs e)
        {
           
        }

        private void metroTextBoxPrecio_KeyDown(object sender, KeyEventArgs e)
        {
          
        }

        private void metroButtonConfirmar_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    ProveedorManager prov = new ProveedorManager();
                
            //    if (string.IsNullOrEmpty(metroTextBoxPuntoV.Text) || string.IsNullOrEmpty(metroTextBoxNoFactura.Text) || metroGridProductosServicios.Rows.Count == 0)
            //    {
            //        MessageBox.Show("Error, No posee ningun comprobante para Confirmar", "Sistema de Gestion de Compras", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //    else
            //    {

            //        if ((int)metroComboBoxCondicionCompra.SelectedValue == 1)
            //        {
            //            ComprobantesManager c = new ComprobantesManager();
            //            PagosManager p = new PagosManager();

            //            double iibb = Convert.ToDouble(metroTextBoxIIBB.Text.Replace(".", ","));
            //            double retenciones = Convert.ToDouble(metroTextBoxRetenciones.Text.Replace(".", ","));
            //            double otrosgastos = Convert.ToDouble(metroTextBoxOtrosGastos.Text.Replace(".", ","));
            //            double roundednum = Convert.ToDouble(metroTextBoxImporte.Text.Replace(".", ","));
            //            double retiva1 = Convert.ToDouble(metroTextBoxPercepcion.Text.Replace(".", ","));

            //            comprobantes.
            //            c.ActualizarImporteComprobante(c.DevolverIDporNoFactura(metroTextBoxPuntoV.Text, metroTextBoxNoFactura.Text, prov.DevolverIdPRoveedorporNombre(metroTextBoxProveedor.Text)));
            //           //c.ActualizarEstado(c.DevolverIDporNoFactura(metroTextBoxPuntoV.Text, metroTextBoxNoFactura.Text, prov.DevolverIdPRoveedorporNombre(metroTextBoxProveedor.Text)), 1);
            //            c.ActualizarOtrosGastosComprobante(c.DevolverIDporNoFactura(metroTextBoxPuntoV.Text, metroTextBoxNoFactura.Text, prov.DevolverIdPRoveedorporNombre(metroTextBoxProveedor.Text)), Math.Round(iibb, 2), Math.Round(retenciones, 2), Math.Round(otrosgastos, 2), Math.Round(retiva1, 2));

            //            //insertar un pago en efectivo





            //            //int idpago = p.InsertarPagoContado(metroDateTimeFecha.Value, metroTextBoxConceptoPago.Text, Math.Round(roundednum, 2));

            //            //p.InsertarDetallePago(idpago, c.DevolverIDporNoFactura(metroTextBoxPuntoV.Text, metroTextBoxNoFactura.Text, prov.DevolverIdPRoveedorporNombre(metroTextBoxProveedor.Text)));

            //            //p.InsertarMediosPagoContado(int.Parse(metroComboBoxMedioPago.SelectedValue.ToString()), Math.Round(roundednum, 2), idpago);

            //            MessageBox.Show("Se Actualizaron todos los Datos del Comprobante con el pago", "Sistema de Gestion de Compras", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //            metroTextBoxPuntoV.Clear();
            //            metroTextBoxNoFactura.Clear();
            //            metroTextBoxConceptoPago.Clear();
            //            metroTextBoxPercepcion.Clear();
            //            metroTextBoxIIBB.Clear();
            //            metroTextBoxRetenciones.Clear();
            //            metroTextBoxImporte.Clear();
            //            metroTextBoxIIBB.Text = "00,00";
            //            metroTextBoxRetenciones.Text = "00,00";
            //            metroTextBoxOtrosGastos.Text = "00,00";
            //            metroTextBoxImporte.Text = "00,00";
            //            metroTextBoxPercepcion.Text = "00,00";

            //            metroGridProductosServicios.DataSource = null;
            //            metroTextBoxProveedor.Enabled = true;
            //            metroTextBoxPuntoV.Enabled = true;
            //            metroTextBoxNoFactura.Enabled = true;
            //            metroComboBoxCondicionCompra.Enabled = true;
            //            metroComboBoxTipoComprobante.Enabled = true;
            //            metroComboBoxContable.Enabled = true;
            //            metroComboBoxCentroCosto.Enabled = true;

            //            metroComboBoxTipoFactura.Enabled = true;
            //            metroDateTimeFecha.Enabled = true;
            //            metroDateTimeVencimiento.Enabled = true;
            //            metroPanelProducto.Enabled = false;
            //            metroPanelPago.Enabled = false;
            //            metroPanelGastos.Enabled = false;

            //        }
            //        if ((int)metroComboBoxCondicionCompra.SelectedValue == 2)
            //        {
            //            ComprobantesManager c = new ComprobantesManager();
            //            double iibb = Convert.ToDouble(metroTextBoxIIBB.Text.Replace(".", ","));
            //            double retenciones = Convert.ToDouble(metroTextBoxRetenciones.Text.Replace(".", ","));
            //            double otrosgastos = Convert.ToDouble(metroTextBoxOtrosGastos.Text.Replace(".", ","));
            //            double roundednum = Convert.ToDouble(metroTextBoxImporte.Text.Replace(".", ","));
            //            double retiva1 = Convert.ToDouble(metroTextBoxPercepcion.Text.Replace(".", ","));

            //            c.ActualizarImporteComprobante(c.DevolverIDporNoFactura(metroTextBoxPuntoV.Text, metroTextBoxNoFactura.Text, prov.DevolverIdPRoveedorporNombre(metroTextBoxProveedor.Text)));
            //            c.ActualizarEstado(c.DevolverIDporNoFactura(metroTextBoxPuntoV.Text, metroTextBoxNoFactura.Text, prov.DevolverIdPRoveedorporNombre(metroTextBoxProveedor.Text)), 2);
            //            c.ActualizarOtrosGastosComprobante(c.DevolverIDporNoFactura(metroTextBoxPuntoV.Text, metroTextBoxNoFactura.Text, prov.DevolverIdPRoveedorporNombre(metroTextBoxProveedor.Text)), Math.Round(iibb, 2), Math.Round(retenciones, 2), Math.Round(otrosgastos, 2), Math.Round(retiva1, 2));

            //            //Como es condicion de compra cuenta corriente no se ingresa ningun pago
            //            MessageBox.Show("Insertado con exito", "Sistema de Gestion de Compras", MessageBoxButtons.OK, MessageBoxIcon.Information);



            //            metroTextBoxPuntoV.Clear();
            //            metroTextBoxNoFactura.Clear();
            //            metroTextBoxPercepcion.Clear();
            //            metroTextBoxIIBB.Clear();
            //            metroTextBoxRetenciones.Clear();
            //            metroTextBoxImporte.Clear();
            //            metroTextBoxOtrosGastos.Clear();

            //            metroTextBoxIIBB.Text = "00,00";
            //            metroTextBoxRetenciones.Text = "00,00";
            //            metroTextBoxOtrosGastos.Text = "00,00";
            //            metroTextBoxPercepcion.Text = "00,00";
            //            metroTextBoxImporte.Text = "00,00";

            //            metroGridProductosServicios.DataSource = null;
            //            metroTextBoxProveedor.Enabled = true;
            //            metroTextBoxPuntoV.Enabled = true;
            //            metroTextBoxNoFactura.Enabled = true;
            //            metroComboBoxCondicionCompra.Enabled = true;
            //            metroComboBoxTipoComprobante.Enabled = true;
            //            metroComboBoxContable.Enabled = true;
            //            metroComboBoxCentroCosto.Enabled = true;

            //            metroComboBoxTipoFactura.Enabled = true;
            //            metroDateTimeFecha.Enabled = true;
            //            metroDateTimeVencimiento.Enabled = true;
            //            metroPanelProducto.Enabled = false;
            //            metroPanelPago.Enabled = false;
            //            metroPanelGastos.Enabled = false;


            //        }
            //        else
            //        {
            //            //if (metroComboBoxCondicionCompra.SelectedValue.ToString() == "2")
            //            //{
            //            //    ComprobantesManager c = new ComprobantesManager();
            //            //    Double iibb = Math.Round(Convert.ToDouble(metroTextBoxIIBB.Text.Replace(".", ",")), 2);
            //            //    Double retenciones = Math.Round(Convert.ToDouble(metroTextBoxRetenciones.Text.Replace(".", ",")), 2);
            //            //    Double otrosgastos = Math.Round(Convert.ToDouble(metroTextBoxOtrosGastos.Text.Replace(".", ",")), 2);
            //            //    double ivaRet = Math.Round(Convert.ToDouble(metroTextBoxIva.Text.Replace(".", ",")), 2);

            //            //    c.ActualizarImporteComprobante(c.DevolverIDporNoFactura(metroTextBoxPuntoV.Text, metroTextBoxNoFactura.Text, prov.DevolverIdPRoveedorporNombre(metroTextBoxProveedor.Text)));
            //            //    c.ActualizarEstado(c.DevolverIDporNoFactura(metroTextBoxPuntoV.Text, metroTextBoxNoFactura.Text, prov.DevolverIdPRoveedorporNombre(metroTextBoxProveedor.Text)), 2);
            //            //    c.ActualizarOtrosGastosComprobante(c.DevolverIDporNoFactura(metroTextBoxPuntoV.Text, metroTextBoxNoFactura.Text, prov.DevolverIdPRoveedorporNombre(metroTextBoxProveedor.Text)), iibb, retenciones, otrosgastos, ivaRet);

            //            //    //Como es condicion de compra cuenta corriente no se ingresa ningun pago




            //            //    metroTextBoxPuntoV.Clear();
            //            //    metroTextBoxNoFactura.Clear();
            //            //    metroTextBoxPercepcion.Clear();
            //            //    metroTextBoxIIBB.Clear();
            //            //    metroTextBoxRetenciones.Clear();
            //            //    metroTextBoxImporte.Clear();
            //            //    metroTextBoxOtrosGastos.Clear();

            //            //    metroTextBoxIIBB.Text = "00,00";
            //            //    metroTextBoxRetenciones.Text = "00,00";
            //            //    metroTextBoxOtrosGastos.Text = "00,00";
            //            //    metroTextBoxPercepcion.Text = "00,00";
            //            //    metroTextBoxImporte.Text = "00,00";

            //            //    metroGridProductosServicios.DataSource = null;
            //            //    metroTextBoxProveedor.Enabled = true;
            //            //    metroTextBoxPuntoV.Enabled = true;
            //            //    metroTextBoxNoFactura.Enabled = true;
            //            //    metroComboBoxCondicionCompra.Enabled = true;
            //            //    metroComboBoxTipoComprobante.Enabled = true;
            //            //    metroComboBoxContable.Enabled = true;
            //            //    metroComboBoxCentroCosto.Enabled = true;

            //            //    metroComboBoxTipoFactura.Enabled = true;
            //            //    metroDateTimeFecha.Enabled = true;
            //            //    metroDateTimeVencimiento.Enabled = true;


            //            //}

            //        }
            //    }

            //}
            //catch (Exception)
            //{

            //    throw;
            //}
        }

        private void metroTextBoxPuntoV_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(metroTextBoxPuntoV.Text) == false)
            {
                metroTextBoxPuntoV.Text = string.Format("{0:0000}", int.Parse(metroTextBoxPuntoV.Text));
            }
            else
            {

            }

        

        }

        private void metroTextBoxNoFactura_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(metroTextBoxNoFactura.Text) == false)
            {
                metroTextBoxNoFactura.Text = string.Format("{0:00000000}", int.Parse(metroTextBoxNoFactura.Text));
                if (comprobanteController.VerifyComprobantes(proveedorController.GetProveedorByName(metroTextBoxProveedor.Text).IdProveedores,metroTextBoxPuntoV.Text,metroTextBoxNoFactura.Text)==true)
                {
                  DialogResult dialogResult=  MessageBox.Show("El Comprobante ya Existe","Desea Actualizarlo",MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
                    if (dialogResult==DialogResult.OK)
                    {
                        Comprobantes SelectedComprobante = new Comprobantes();
                        SelectedComprobante = comprobanteController.GetComprobante(proveedorController.GetProveedorByName(metroTextBoxProveedor.Text).IdProveedores, metroTextBoxPuntoV.Text, metroTextBoxNoFactura.Text);
                        //metroComboBoxEstadoCivil.DataBindings.Add("Text", bindingSourceEmpleado, "EstadoCivil", true);
                        var detallesComprobantes = comprobanteController.GetALLDetallesComprobanteArticulos(SelectedComprobante.IdComprobante);
                       
                        metroComboBoxTipoComprobante.Text=SelectedComprobante.TiposComprobante.TipoComprobante;

                        metroComboBoxCentroCosto.Text = SelectedComprobante.CentroCostos.CentroCosto;
                        metroComboBoxTipoFactura.Text = SelectedComprobante.TiposFactura.TipoFactura;
                        metroComboBoxCondicionCompra.Text = SelectedComprobante.CondicionesCompra.Condiciondecompra;
                        metroComboBoxContable.Text = SelectedComprobante.Contable1.Contable1;
                        metroDateTimeFecha.Value = SelectedComprobante.Fecha.Value;
                        metroDateTimeVencimiento.Value = SelectedComprobante.FechaVencimiento.Value;
                        metroTextBoxIIBB.Text = SelectedComprobante.IIBB.Value.ToString();
                        metroTextBoxRetenciones.Text = SelectedComprobante.Retenciones.Value.ToString();
                        metroTextBoxOtrosGastos.Text = SelectedComprobante.ConceptosNograbado.Value.ToString();
                        metroTextBoxPercepcion.Text = SelectedComprobante.PercepcionIva.Value.ToString();
                        metroTextBoxSubTotal.Text = SelectedComprobante.ImporteNeto.Value.ToString();
                        metroTextBoxTotal.Text = SelectedComprobante.Importe.Value.ToString();

                        //LLeno El DataGrid Articulos
                        metroGridTest.AutoGenerateColumns = false;
                        metroGridTest.DataSource = detallesComprobantes;
                        metroGridTest.AutoSize = false;

                        //foreach (var item in detallesComprobantes)
                        //{

                        //    var Subt = item.Importe - item.Precio;
                        //    Producto.DataPropertyName="Nombre";
                        //    Cantidad.DataPropertyName="Cantidad";
                        //    Iva.DataPropertyName ="Iva";
                        //    Precio.DataPropertyName = "Precio";
                        //    Subtotal.DataPropertyName = "Importe-Precio";
                        //    Total.DataPropertyName = "Importe";
                            
                            
                           
                        //}
                    }
                }
            }
            else
            {

            }
        }

        private void metroDateTimeFecha_Leave(object sender, EventArgs e)
        {
            DateTime fecha_vencimiento = metroDateTimeFecha.Value.AddDays(30);
            metroDateTimeVencimiento.Value = fecha_vencimiento;
        }

        private void metroTabPage1_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBoxProveedor_TextChanged(object sender, EventArgs e)
        {

        }

        private void metroButtonDescartar_Click(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            try
            {
               if(string.IsNullOrEmpty(metroTextBoxPuntoV.Text) || string.IsNullOrEmpty(metroTextBoxNoFactura.Text) || metroGridTest.Rows.Count == 0)
                {
                    MessageBox.Show("Error, No posee ningun comprobante para Confirmar", "Sistema de Gestion de Compras", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (Edition==false&& comprobantes==null)
                    {

                        if ((int)metroComboBoxCondicionCompra.SelectedValue == 1)
                        {


                            Comprobantes Comprobante = new Comprobantes();
                            var IdProveedor = proveedorController.GetProveedorByName(metroTextBoxProveedor.Text);
                            Comprobante.IdTipoComprobante = (int)metroComboBoxTipoComprobante.SelectedValue;
                            Comprobante.IdCentroCosto = (int)metroComboBoxCentroCosto.SelectedValue;
                            Comprobante.IdProveedor = (int)IdProveedor.IdProveedores;
                            Comprobante.IdTipoFactura = (int)metroComboBoxTipoFactura.SelectedValue;
                            Comprobante.Sucursal = metroTextBoxPuntoV.Text;
                            Comprobante.NoFactura = metroTextBoxNoFactura.Text;
                            Comprobante.IdCondicionCompra = (int)metroComboBoxCondicionCompra.SelectedValue;
                            Comprobante.Contable = (int)metroComboBoxContable.SelectedValue;
                            Comprobante.Fecha = metroDateTimeFecha.Value;
                            Comprobante.FechaVencimiento = metroDateTimeVencimiento.Value;
                            Comprobante.IIBB = Convert.ToDouble(metroTextBoxIIBB.Text.Replace(".", ","));
                            Comprobante.Retenciones = Convert.ToDouble(metroTextBoxRetenciones.Text.Replace(".", ","));
                            Comprobante.ConceptosNograbado = Convert.ToDouble(metroTextBoxOtrosGastos.Text.Replace(".", ","));
                            Comprobante.PercepcionIva = Convert.ToDouble(metroTextBoxPercepcion.Text.Replace(".", ","));
                            Comprobante.ImporteNeto = Convert.ToDouble(metroTextBoxSubTotal.Text);
                            Comprobante.IdEstado = 1;
                            Comprobante.Importe = Convert.ToDouble(metroTextBoxTotal.Text); ;

                            var ComprobanteO = comprobanteController.AddorUpdateComprobantes(Comprobante);


                            foreach (DataGridViewRow row2 in metroGridTest.Rows)
                            {
                                //Insertar Tabla Comprobantes Articulos
                                 DetallesComprobanteArticulos _DetalleComprobanteArticulos = new DetallesComprobanteArticulos();
                                _DetalleComprobanteArticulos.idTable_DetallesComprobanteArticulos = int.Parse(row2.Cells["idTableDetallesComprobanteArticulosDataGridViewTextBoxColumn"].Value.ToString());
                                _DetalleComprobanteArticulos.IdArticulo = comprobanteController.GetArticuloByName(row2.Cells["articulosNombreDataGridViewTextBoxColumn"].Value.ToString()).IDArticulo;
                                _DetalleComprobanteArticulos.Cantidad = Convert.ToDouble(row2.Cells["cantidadDataGridViewTextBoxColumn"].Value.ToString());
                                _DetalleComprobanteArticulos.Precio = Convert.ToDouble(row2.Cells["precioDataGridViewTextBoxColumn"].Value.ToString());
                                _DetalleComprobanteArticulos.Iva = Convert.ToDouble(row2.Cells["ivaDataGridViewTextBoxColumn"].Value.ToString());
                                _DetalleComprobanteArticulos.IvaCalculado = Convert.ToDouble(row2.Cells["IvaCalculado"].Value.ToString());
                                _DetalleComprobanteArticulos.IdComprobante = ComprobanteO.IdComprobante;
                                _DetalleComprobanteArticulos.Importe = Convert.ToDouble(row2.Cells["importeDataGridViewTextBoxColumn"].Value.ToString());

                                comprobanteController.AddorUpdateComprobantesArticulos(_DetalleComprobanteArticulos);
                            }
                            //comprobanteController.AddorUpdateComprobantes(Comprobante);

                            //Insertar Pago Contado
                            Pagos Pago = new Pagos();
                            Pago.Fecha = metroDateTimeFecha.Value;
                            Pago.Concepto = "Pago Contado";
                            Pago.Importe = ComprobanteO.Importe + ComprobanteO.Retenciones + ComprobanteO.PercepcionIva + ComprobanteO.ConceptosNograbado + ComprobanteO.IIBB;
                            var IDPago = PagosController.AddorUpdatePagos(Pago).Idpago;

                            //Insertar Detalle de Pago
                            DetallesPago detallesPago = new DetallesPago();
                            detallesPago.idComprobante = comprobanteController.GetComprobanteByFacturaPRoveedor(proveedorController.GetProveedorByName(metroTextBoxProveedor.Text).IdProveedores, metroTextBoxPuntoV.Text, metroTextBoxNoFactura.Text).IdComprobante;
                            detallesPago.IdPago = IDPago;
                            PagosController.AddorUpdateDetallesPagos(detallesPago);

                            //Insertar Detalle Medios de Pago
                            DetalleMediosPagos detalleMediosPagos = new DetalleMediosPagos();
                            detalleMediosPagos.IdMedioPago = (int)metroComboBoxMedioPago.SelectedValue;


                            detalleMediosPagos.Importe = Convert.ToDouble(metroTextBoxTotal.Text.Replace(".", ",")) + Convert.ToDouble(metroTextBoxIIBB.Text.Replace(".", ",")) + Convert.ToDouble(metroTextBoxRetenciones.Text.Replace(".", ",")) + Convert.ToDouble(metroTextBoxOtrosGastos.Text.Replace(".", ",")) + Convert.ToDouble(metroTextBoxPercepcion.Text.Replace(".", ","));
                            detalleMediosPagos.IdPago = IDPago;
                            PagosController.AddorUpdateMediosPagos(detalleMediosPagos);



                            MessageBox.Show("Se Actualizaron todos los Datos del Comprobante", "Sistema de Gestion de Compras", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            metroTextBoxPuntoV.Clear();
                            metroTextBoxNoFactura.Clear();

                            metroTextBoxPercepcion.Clear();
                            metroTextBoxIIBB.Clear();
                            metroTextBoxRetenciones.Clear();
                            metroTextBoxSubTotal.Clear();
                            metroTextBoxTotal.Clear();

                            metroTextBoxIIBB.Text = "00,00";
                            metroTextBoxRetenciones.Text = "00,00";
                            metroTextBoxOtrosGastos.Text = "00,00";

                            metroTextBoxPercepcion.Text = "00,00";




                            metroGridTest.Rows.Clear();
                            this.Close();


                        }
                        else
                        {

                            //var Idproveedor = proveedorController.GetProveedorByName(metroTextBoxProveedor.Text).IdProveedores;
                            //var Comprobante = comprobanteController.GetComprobanteByFacturaPRoveedor(Idproveedor, metroTextBoxPuntoV.Text, metroTextBoxNoFactura.Text);
                            Comprobantes Comprobante = new Comprobantes();
                            var IdProveedor = proveedorController.GetProveedorByName(metroTextBoxProveedor.Text);
                            Comprobante.IdTipoComprobante = (int)metroComboBoxTipoComprobante.SelectedValue;
                            Comprobante.IdCentroCosto = (int)metroComboBoxCentroCosto.SelectedValue;
                            Comprobante.IdProveedor = (int)IdProveedor.IdProveedores;
                            Comprobante.IdTipoFactura = (int)metroComboBoxTipoFactura.SelectedValue;
                            Comprobante.Sucursal = metroTextBoxPuntoV.Text;
                            Comprobante.NoFactura = metroTextBoxNoFactura.Text;
                            Comprobante.IdCondicionCompra = (int)metroComboBoxCondicionCompra.SelectedValue;
                            Comprobante.Contable = (int)metroComboBoxContable.SelectedValue;
                            Comprobante.Fecha = metroDateTimeFecha.Value;
                            Comprobante.FechaVencimiento = metroDateTimeVencimiento.Value;
                            Comprobante.IIBB = Convert.ToDouble(metroTextBoxIIBB.Text.Replace(".", ","));
                            Comprobante.Retenciones = Convert.ToDouble(metroTextBoxRetenciones.Text.Replace(".", ","));
                            Comprobante.ConceptosNograbado = Convert.ToDouble(metroTextBoxOtrosGastos.Text.Replace(".", ","));
                            Comprobante.PercepcionIva = Convert.ToDouble(metroTextBoxPercepcion.Text.Replace(".", ","));
                            Comprobante.ImporteNeto = Convert.ToDouble(metroTextBoxSubTotal.Text);
                            Comprobante.IdEstado = 2;
                            Comprobante.Importe = Convert.ToDouble(metroTextBoxTotal.Text); ;

                            var IDComp=  comprobanteController.AddorUpdateComprobantes(Comprobante);


                            foreach (DataGridViewRow row2 in metroGridTest.Rows)
                            {
                                //Insertar Tabla Comprobantes Articulos
                                DetallesComprobanteArticulos _DetalleComprobanteArticulos = new DetallesComprobanteArticulos();
                                _DetalleComprobanteArticulos.idTable_DetallesComprobanteArticulos = int.Parse(row2.Cells["idTableDetallesComprobanteArticulosDataGridViewTextBoxColumn"].Value.ToString());
                                _DetalleComprobanteArticulos.IdArticulo = comprobanteController.GetArticuloByName(row2.Cells["articulosNombreDataGridViewTextBoxColumn"].Value.ToString()).IDArticulo;
                                _DetalleComprobanteArticulos.Cantidad = Convert.ToDouble(row2.Cells["cantidadDataGridViewTextBoxColumn"].Value.ToString());
                                _DetalleComprobanteArticulos.Precio = Convert.ToDouble(row2.Cells["precioDataGridViewTextBoxColumn"].Value.ToString());
                                _DetalleComprobanteArticulos.Iva = Convert.ToDouble(row2.Cells["ivaDataGridViewTextBoxColumn"].Value.ToString());
                                _DetalleComprobanteArticulos.IvaCalculado = Convert.ToDouble(row2.Cells["IvaCalculado"].Value.ToString());
                                _DetalleComprobanteArticulos.IdComprobante = IDComp.IdComprobante;
                                _DetalleComprobanteArticulos.Importe = Convert.ToDouble(row2.Cells["importeDataGridViewTextBoxColumn"].Value.ToString());

                                comprobanteController.AddorUpdateComprobantesArticulos(_DetalleComprobanteArticulos);
                            }
                           

                            MessageBox.Show("Se Actualizaron todos los Datos del Comprobante con el pago", "Sistema de Gestion de Compras", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            metroTextBoxPuntoV.Clear();
                            metroTextBoxNoFactura.Clear();

                            metroTextBoxPercepcion.Clear();
                            metroTextBoxIIBB.Clear();
                            metroTextBoxRetenciones.Clear();

                            metroTextBoxIIBB.Text = "00,00";
                            metroTextBoxRetenciones.Text = "00,00";
                            metroTextBoxOtrosGastos.Text = "00,00";

                            metroTextBoxPercepcion.Text = "00,00";
                            metroTextBoxSubTotal.Clear();
                            metroTextBoxTotal.Clear();
                            metroGridTest.Rows.Clear();




                        }
                    }
                    else if(Edition==true&&comprobantes!=null)
                    {
                        if ((int)metroComboBoxCondicionCompra.SelectedValue == 1)
                        {


                            var IdProveedor = proveedorController.GetProveedorByName(metroTextBoxProveedor.Text);
                            comprobantes.IdTipoComprobante = (int)metroComboBoxTipoComprobante.SelectedValue;
                            comprobantes.IdCentroCosto = (int)metroComboBoxCentroCosto.SelectedValue;
                            comprobantes.IdProveedor = (int)IdProveedor.IdProveedores;
                            comprobantes.IdTipoFactura = (int)metroComboBoxTipoFactura.SelectedValue;
                            comprobantes.Sucursal = metroTextBoxPuntoV.Text;
                            comprobantes.NoFactura = metroTextBoxNoFactura.Text;
                            comprobantes.IdCondicionCompra = (int)metroComboBoxCondicionCompra.SelectedValue;
                            comprobantes.Contable = (int)metroComboBoxContable.SelectedValue;
                            comprobantes.Fecha = metroDateTimeFecha.Value;
                            comprobantes.FechaVencimiento = metroDateTimeVencimiento.Value;
                            comprobantes.IIBB = Convert.ToDouble(metroTextBoxIIBB.Text.Replace(".", ","));
                            comprobantes.Retenciones = Convert.ToDouble(metroTextBoxRetenciones.Text.Replace(".", ","));
                            comprobantes.ConceptosNograbado = Convert.ToDouble(metroTextBoxOtrosGastos.Text.Replace(".", ","));
                            comprobantes.PercepcionIva = Convert.ToDouble(metroTextBoxPercepcion.Text.Replace(".", ","));
                            comprobantes.ImporteNeto = Convert.ToDouble(metroTextBoxSubTotal.Text);
                            comprobantes.IdEstado = 2;
                            comprobantes.Importe = Convert.ToDouble(metroTextBoxTotal.Text);

                            comprobanteController.AddorUpdateComprobantes(comprobantes);


                            foreach (DataGridViewRow row2 in metroGridTest.Rows)
                            {
                                //Insertar Tabla Comprobantes Articulos
                                DetallesComprobanteArticulos _DetalleComprobanteArticulos = new DetallesComprobanteArticulos();
                                _DetalleComprobanteArticulos.idTable_DetallesComprobanteArticulos = int.Parse(row2.Cells["idTableDetallesComprobanteArticulosDataGridViewTextBoxColumn"].Value.ToString());
                                _DetalleComprobanteArticulos.IdArticulo = comprobanteController.GetArticuloByName(row2.Cells["articulosNombreDataGridViewTextBoxColumn"].Value.ToString()).IDArticulo;
                                _DetalleComprobanteArticulos.Cantidad = Convert.ToDouble(row2.Cells["cantidadDataGridViewTextBoxColumn"].Value.ToString());
                                _DetalleComprobanteArticulos.Precio = Convert.ToDouble(row2.Cells["precioDataGridViewTextBoxColumn"].Value.ToString());
                                _DetalleComprobanteArticulos.Iva = Convert.ToDouble(row2.Cells["ivaDataGridViewTextBoxColumn"].Value.ToString());
                                _DetalleComprobanteArticulos.IvaCalculado = Convert.ToDouble(row2.Cells["IvaCalculado"].Value.ToString());
                                _DetalleComprobanteArticulos.IdComprobante =comprobantes.IdComprobante;
                                _DetalleComprobanteArticulos.Importe = Convert.ToDouble(row2.Cells["importeDataGridViewTextBoxColumn"].Value.ToString());

                                comprobanteController.AddorUpdateComprobantesArticulos(_DetalleComprobanteArticulos);
                            }

                            //Insertar Pago Contado
                            Pagos Pago = new Pagos();
                            Pago.Fecha = metroDateTimeFecha.Value;
                            Pago.Concepto = "Pago Contado";
                            Pago.Importe = comprobantes.Importe + comprobantes.Retenciones + comprobantes.PercepcionIva + comprobantes.ConceptosNograbado + comprobantes.IIBB;
                            var IDPago = PagosController.AddorUpdatePagos(Pago).Idpago;

                            //Insertar Detalle de Pago
                            DetallesPago detallesPago = new DetallesPago();
                            detallesPago.idComprobante = comprobanteController.GetComprobanteByFacturaPRoveedor(proveedorController.GetProveedorByName(metroTextBoxProveedor.Text).IdProveedores, metroTextBoxPuntoV.Text, metroTextBoxNoFactura.Text).IdComprobante;
                            detallesPago.IdPago = IDPago;
                            PagosController.AddorUpdateDetallesPagos(detallesPago);

                            //Insertar Detalle Medios de Pago
                            DetalleMediosPagos detalleMediosPagos = new DetalleMediosPagos();
                            detalleMediosPagos.IdMedioPago = (int)metroComboBoxMedioPago.SelectedValue;


                            detalleMediosPagos.Importe = Convert.ToDouble(metroTextBoxTotal.Text.Replace(".", ",")) + Convert.ToDouble(metroTextBoxIIBB.Text.Replace(".", ",")) + Convert.ToDouble(metroTextBoxRetenciones.Text.Replace(".", ",")) + Convert.ToDouble(metroTextBoxOtrosGastos.Text.Replace(".", ",")) + Convert.ToDouble(metroTextBoxPercepcion.Text.Replace(".", ","));
                            detalleMediosPagos.IdPago = IDPago;
                            PagosController.AddorUpdateMediosPagos(detalleMediosPagos);



                            MessageBox.Show("Se Actualizaron todos los Datos del Comprobante", "Sistema de Gestion de Compras", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            metroTextBoxPuntoV.Clear();
                            metroTextBoxNoFactura.Clear();

                            metroTextBoxPercepcion.Clear();
                            metroTextBoxIIBB.Clear();
                            metroTextBoxRetenciones.Clear();
                            metroTextBoxSubTotal.Clear();
                            metroTextBoxTotal.Clear();

                            metroTextBoxIIBB.Text = "00,00";
                            metroTextBoxRetenciones.Text = "00,00";
                            metroTextBoxOtrosGastos.Text = "00,00";

                            metroTextBoxPercepcion.Text = "00,00";




                            metroGridTest.Rows.Clear();


                        }
                        else 
                        {
                                                                                  
                            var IdProveedor = proveedorController.GetProveedorByName(metroTextBoxProveedor.Text);
                            comprobantes.IdTipoComprobante = (int)metroComboBoxTipoComprobante.SelectedValue;
                            comprobantes.IdCentroCosto = (int)metroComboBoxCentroCosto.SelectedValue;
                            comprobantes.IdProveedor = (int)IdProveedor.IdProveedores;
                            comprobantes.IdTipoFactura = (int)metroComboBoxTipoFactura.SelectedValue;
                            comprobantes.Sucursal = metroTextBoxPuntoV.Text;
                            comprobantes.NoFactura = metroTextBoxNoFactura.Text;
                            comprobantes.IdCondicionCompra = (int)metroComboBoxCondicionCompra.SelectedValue;
                            comprobantes.Contable = (int)metroComboBoxContable.SelectedValue;
                            comprobantes.Fecha = metroDateTimeFecha.Value;
                            comprobantes.FechaVencimiento = metroDateTimeVencimiento.Value;
                            comprobantes.IIBB = Convert.ToDouble(metroTextBoxIIBB.Text.Replace(".", ","));
                            comprobantes.Retenciones = Convert.ToDouble(metroTextBoxRetenciones.Text.Replace(".", ","));
                            comprobantes.ConceptosNograbado = Convert.ToDouble(metroTextBoxOtrosGastos.Text.Replace(".", ","));
                            comprobantes.PercepcionIva = Convert.ToDouble(metroTextBoxPercepcion.Text.Replace(".", ","));
                            comprobantes.ImporteNeto = Convert.ToDouble(metroTextBoxSubTotal.Text);
                            comprobantes.IdEstado = 2;
                            comprobantes.Importe = Convert.ToDouble(metroTextBoxTotal.Text);

                            comprobanteController.AddorUpdateComprobantes(comprobantes);

                           
                            foreach (DataGridViewRow row2 in metroGridTest.Rows)
                            {
                                //Insertar Tabla Comprobantes Articulos
                                DetallesComprobanteArticulos _DetalleComprobanteArticulos = new DetallesComprobanteArticulos();
                                _DetalleComprobanteArticulos.idTable_DetallesComprobanteArticulos = int.Parse(row2.Cells["idTableDetallesComprobanteArticulosDataGridViewTextBoxColumn"].Value.ToString());
                                _DetalleComprobanteArticulos.IdArticulo = comprobanteController.GetArticuloByName(row2.Cells["articulosNombreDataGridViewTextBoxColumn"].Value.ToString()).IDArticulo;
                                _DetalleComprobanteArticulos.Cantidad = Convert.ToDouble(row2.Cells["cantidadDataGridViewTextBoxColumn"].Value.ToString());
                                _DetalleComprobanteArticulos.Precio = Convert.ToDouble(row2.Cells["precioDataGridViewTextBoxColumn"].Value.ToString());
                                _DetalleComprobanteArticulos.Iva = Convert.ToDouble(row2.Cells["ivaDataGridViewTextBoxColumn"].Value.ToString());
                                _DetalleComprobanteArticulos.IvaCalculado = Convert.ToDouble(row2.Cells["IvaCalculado"].Value.ToString());
                                _DetalleComprobanteArticulos.IdComprobante = comprobantes.IdComprobante;
                                _DetalleComprobanteArticulos.Importe = Convert.ToDouble(row2.Cells["importeDataGridViewTextBoxColumn"].Value.ToString());

                                comprobanteController.AddorUpdateComprobantesArticulos(_DetalleComprobanteArticulos);
                            }




                            MessageBox.Show("Se Actualizaron todos los Datos del Comprobante con el pago", "Sistema de Gestion de Compras", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            metroTextBoxPuntoV.Clear();
                            metroTextBoxNoFactura.Clear();

                            metroTextBoxPercepcion.Clear();
                            metroTextBoxIIBB.Clear();
                            metroTextBoxRetenciones.Clear();

                            metroTextBoxIIBB.Text = "00,00";
                            metroTextBoxRetenciones.Text = "00,00";
                            metroTextBoxOtrosGastos.Text = "00,00";

                            metroTextBoxPercepcion.Text = "00,00";
                            metroTextBoxSubTotal.Clear();
                            metroTextBoxTotal.Clear();
                            metroGridTest.Rows.Clear();




                        }

                    }


                }
                   
                

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        private void metroTextBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {

                    
                    if (string.IsNullOrEmpty(metroTextBoxProductTest.Text) == true || string.IsNullOrEmpty(metroTextBoxCantTest.Text) == true || string.IsNullOrEmpty(metroTextBoxIvaTest.Text) == true)
                    {
                        MessageBox.Show("Debe Ingresar el Articulo", "Sistema de Gestion de Compras", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {                      
                        double ImporteConIva = 0;
                        double ImporteSinIva = 0;
                        double IvaCalculado = 0;
                        double TotalIvaCalculado = 0;
                        double subtotal = 0;
                        double IvaDecimal = 0;
                        double Iva = 0;
                       
                        double Total = 0;
                        if (float.Parse(metroTextBoxIvaTest.Text.ToString())==0)
                        {
                            
                            ImporteSinIva = (Convert.ToDouble(metroTextBoxPrecioTest.Text.Replace(".", ",")) * Convert.ToDouble(metroTextBoxCantTest.Text.Replace(".", ",")));
                            IvaCalculado = 0;
                            var ProductoList = new string[] { "0", metroTextBoxProductTest.Text,metroTextBoxCantTest.Text,metroTextBoxPrecioTest.Text,Iva.ToString(),IvaCalculado.ToString(),ImporteSinIva.ToString()};
                            metroGridTest.Rows.Add(ProductoList);
                        }
                        else
                        {
                            Iva = Convert.ToDouble(metroTextBoxIvaTest.Text.Replace(".", ","));
                            IvaDecimal = (Convert.ToDouble(metroTextBoxIvaTest.Text.Replace(".", ",")) / 100)+1;
                            ImporteConIva = (Convert.ToDouble(metroTextBoxPrecioTest.Text.Replace(".", ",")) * Convert.ToDouble(metroTextBoxCantTest.Text.Replace(".", ","))) * IvaDecimal;
                            ImporteSinIva = (Convert.ToDouble(metroTextBoxPrecioTest.Text.Replace(".", ",")) * Convert.ToDouble(metroTextBoxCantTest.Text.Replace(".", ",")));
                            IvaCalculado = ImporteConIva - ImporteSinIva;
                            var ProductoList = new string[] {"0" ,metroTextBoxProductTest.Text, metroTextBoxCantTest.Text, metroTextBoxPrecioTest.Text, Iva.ToString() , IvaCalculado.ToString(),ImporteConIva.ToString() };
                            metroGridTest.Rows.Add(ProductoList);
                            
                           
                        }

                       

                        if (metroGridTest.Rows.Count!=0)
                        {
                            foreach (DataGridViewRow row2 in metroGridTest.Rows)
                            {
                               
                                TotalIvaCalculado += Convert.ToDouble(row2.Cells["IvaCalculado"].Value.ToString());
                                Total+= Convert.ToDouble(row2.Cells["importeDataGridViewTextBoxColumn"].Value.ToString());
                                
                               
                            }
                            subtotal = Total - TotalIvaCalculado;
                            metroTextBoxSubTotal.Text =subtotal.ToString();
                            metroTextBoxTotal.Text = Total.ToString();
                        }

                        
                        


                    }

                    metroTextBoxProductTest.Clear();
                    metroTextBoxCantTest.Clear();
                    metroTextBoxIvaTest.Clear();
                    metroTextBoxPrecioTest.Clear();







                }
                catch (Exception ex)
                {

                    throw new Exception(ex.Message);
                }


            }
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            try
            {
                if (metroGridTest.Rows.Count == 0)
                {
                    MessageBox.Show("Error, no tiene Medios de Pago para Eliminar", "Sistema de Gestion de Compras", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    metroGridTest.Rows.RemoveAt(metroGridTest.CurrentRow.Index);
                }





            }
            catch (Exception)
            {

                throw;
            }
        }

        private void metroTextBoxIIBB_Leave(object sender, EventArgs e)
        {
            
            metroTextBoxTotalGeneral.Text =( Convert.ToDouble(metroTextBoxIIBB.Text) + Convert.ToDouble(metroTextBoxTotal.Text)+ Convert.ToDouble(metroTextBoxRetenciones.Text)+ Convert.ToDouble(metroTextBoxPercepcion.Text)+ Convert.ToDouble(metroTextBoxOtrosGastos.Text)).ToString();
        }

        private void metroTextBoxRetenciones_Leave(object sender, EventArgs e)
        {
            metroTextBoxTotalGeneral.Text = (Convert.ToDouble(metroTextBoxIIBB.Text) + Convert.ToDouble(metroTextBoxTotal.Text) + Convert.ToDouble(metroTextBoxRetenciones.Text) + Convert.ToDouble(metroTextBoxPercepcion.Text) + Convert.ToDouble(metroTextBoxOtrosGastos.Text)).ToString();
        }

        private void metroTextBoxOtrosGastos_Leave(object sender, EventArgs e)
        {
            metroTextBoxTotalGeneral.Text = (Convert.ToDouble(metroTextBoxIIBB.Text) + Convert.ToDouble(metroTextBoxTotal.Text) + Convert.ToDouble(metroTextBoxRetenciones.Text) + Convert.ToDouble(metroTextBoxPercepcion.Text) + Convert.ToDouble(metroTextBoxOtrosGastos.Text)).ToString();
        }

        private void metroTextBoxPercepcion_Leave(object sender, EventArgs e)
        {
            metroTextBoxTotalGeneral.Text = (Convert.ToDouble(metroTextBoxIIBB.Text) + Convert.ToDouble(metroTextBoxTotal.Text) + Convert.ToDouble(metroTextBoxRetenciones.Text) + Convert.ToDouble(metroTextBoxPercepcion.Text) + Convert.ToDouble(metroTextBoxOtrosGastos.Text)).ToString();
        }
    }
}
