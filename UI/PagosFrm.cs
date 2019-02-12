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
using BLayer.Controller;
using Entidades;
using Controllers;

namespace ErpGestion
{
    public partial class PagosFrm : MetroFramework.Forms.MetroForm
    {
        private ProveedorController ProveedorController;
        private PagosController PagosController;
        private ComprobanteController ComprobanteController;
        private Pagos Pago;
        private DetalleMediosPagos DetalleMediosPagos;
        private Comprobantes Comprobantes;
        private DetallesPago DetallesPago;
        private Retenciones Retenciones;
        public Boolean Edition { get; set; }


        public PagosFrm()
        {
            InitializeComponent();
            ProveedorController = new ProveedorController();
            PagosController = new PagosController();
            ComprobanteController = new ComprobanteController();
            Pago = new Pagos();
            DetallesPago = new DetallesPago();
            DetalleMediosPagos = new DetalleMediosPagos();
            Comprobantes = new Comprobantes();
            Retenciones = new Retenciones();
            
        }
        
        private void PagosForm_Load(object sender, EventArgs e)
        {
          
            //llenar combobox
            metroComboBoxMedioPago.DataSource =PagosController.GetMediosPago();
            metroComboBoxMedioPago.ValueMember = "MediosPago1";
            metroComboBoxMedioPago.DisplayMember = "MediosPago1";

            metroComboBoxBanco.DataSource = PagosController.GetBancos();
            metroComboBoxBanco.ValueMember = "Nombre";
            metroComboBoxBanco.DisplayMember = "Nombre";
            //Autocomplete Proveedores
            AutoCompleteStringCollection sourcename = new AutoCompleteStringCollection();
            sourcename.AddRange(ProveedorController.GetProveedoresName().ToArray());
            metroTextBoxNOMBREProveedor.AutoCompleteMode = AutoCompleteMode.Suggest;
            metroTextBoxNOMBREProveedor.AutoCompleteSource = AutoCompleteSource.CustomSource;
            metroTextBoxNOMBREProveedor.AutoCompleteCustomSource = sourcename;

        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
          
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
           
        }

        private void metroButton5_Click(object sender, EventArgs e)
        {
           
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
           
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            try
            {
                //REPORTE DE FACTURAS PENDIENTES DE PAGO
                int IDProveedor = ProveedorController.GetProveedorByName(metroTextBoxNOMBREProveedor.Text).IdProveedores;
                ReporteDeudaFrm ReportFrm = new ReporteDeudaFrm();
                ReportFrm.idproveedor = IDProveedor;
                ReportFrm.ShowDialog();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        private void metroCheckBoxSelectAll_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void metroCheckBoxSelectAll_Click(object sender, EventArgs e)
        {

        }

        private void metroCheckBoxSelectAll_CheckStateChanged(object sender, EventArgs e)
        {
            try
            {
                if (metroCheckBoxSelectAll.Checked == true)
                {
                    foreach (DataGridViewRow row1 in metroGridComprobantes.Rows)
                    {
                        DataGridViewCheckBoxCell ck = row1.Cells["Seleccionar"] as DataGridViewCheckBoxCell;
                        if (Convert.ToBoolean(ck.Value) == false)
                        {
                            ck.Value = true;
                        }
                    }

                }
                else
                {
                    if (metroCheckBoxSelectAll.Checked == false)
                    {
                        foreach (DataGridViewRow row1 in metroGridComprobantes.Rows)
                        {
                            DataGridViewCheckBoxCell ck = row1.Cells["Seleccionar"] as DataGridViewCheckBoxCell;
                            if (Convert.ToBoolean(ck.Value) == true)
                            {
                                ck.Value = false;
                            }
                        }

                    }


                }


            }
            catch (Exception)
            {

                throw;
            }
        }

        private void metroButtonAgregarPago_Click(object sender, EventArgs e)
        {
          
        }

        private void metroButtonCancelarPago_Click(object sender, EventArgs e)
        {

        }

        private void metroGridComprobantes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           

        }

        private void metroButton6_Click(object sender, EventArgs e)
        {

           
        }

        private void metroLabel9_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBoxTotalFact_Click(object sender, EventArgs e)
        {

        }

        private void metroGridComprobantes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void metroGridComprobantes_SelectionChanged(object sender, EventArgs e)
        {
          
        }

        private void metroGridComprobantes_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
          
        }

        private void metroTabPage1_Click(object sender, EventArgs e)
        {

        }

        private void metroButton7_Click(object sender, EventArgs e)
        {
            try
            {
                double TotalNeto = 0;
                double TotalFactura = 0;
                Retenciones retencion = new Retenciones();
                foreach (DataGridViewRow row1 in metroGridComprobantes.Rows)
                {
                    DataGridViewCheckBoxCell ck = row1.Cells["column7"] as DataGridViewCheckBoxCell;
                    if (Convert.ToBoolean(ck.Value) == true)
                    {
                        TotalNeto += Math.Round(Convert.ToDouble(row1.Cells["ImporteNeto"].Value.ToString()), 2);
                        TotalFactura+= Math.Round(Convert.ToDouble(row1.Cells["column5"].Value.ToString()), 2);
                    }
                }




                if (metroGridComprobantes.Rows.Count >= 1 && TotalNeto > 2000)
                {
                     retencion = PagosController.CalcularRetenciones(metroTextBoxNOMBREProveedor.Text, float.Parse(TotalNeto.ToString()));
                    if (retencion!= null)
                    {
                        
                        double totalPAgar = TotalFactura - Convert.ToDouble(retencion.Importe);
                        metroTextBoxIDRet.Text = retencion.IDRetencion.ToString();
                        metroTextBoxALi.Text = Math.Round((double)retencion.Alicuota, 2).ToString();
                        metroTextBoxImporteRet.Text = Math.Round((double)retencion.Importe, 2).ToString();
                        metroTextBoxiMPORTE.Text = (TotalFactura - Math.Round((double)retencion.Importe, 2)).ToString();
                        metroTextBoxTotalFact.Text = TotalFactura.ToString();

                    }
                    else
                    {
                        if (retencion == null)
                        metroTextBoxIDRet.Clear();
                        metroTextBoxALi.Clear();
                        metroTextBoxImporteRet.Clear();
                        metroTextBoxiMPORTE.Clear();
                        metroTextBoxTotalFact.Clear();
                       
                    }
                }
                else
                {
                    MessageBox.Show("Al proveedor no se le hacen retenciones","Sistema de Gestion");
                }
               }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        private void metroButton8_Click(object sender, EventArgs e)
        {
           
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void metroButton9_Click(object sender, EventArgs e)
        {

        }

        private void metroButton11_Click(object sender, EventArgs e)
        {
           
        }

        private void metroButton10_Click(object sender, EventArgs e)
        {

        }

        private void metroButtonImprimirOrden_Click(object sender, EventArgs e)
        {
           
        }

        private void metroGridPagosProveedores_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            try
            {
                //LISTAR FACTURAS PENDIENTES DE PAGO
                int IDproveedor = ProveedorController.GetProveedorByName(metroTextBoxNOMBREProveedor.Text).IdProveedores;
                bindingSourceFacturasPendientes.DataSource=ComprobanteController.GetAllFacturasPedientes(IDproveedor).ToList();
               
           
               
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            try
            {
                //REPORTE DE FACTURAS PENDIENTES DE PAGO
                int IDProveedor = ProveedorController.GetProveedorByName(metroTextBoxNOMBREProveedor.Text).IdProveedores;
                ReporteDeudaFrm ReportFrm = new ReporteDeudaFrm();
                ReportFrm.idproveedor = IDProveedor;
                ReportFrm.ShowDialog();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            try
            {
                double total = 0;
                foreach (DataGridViewRow row1 in metroGridComprobantes.Rows)
                {
                    DataGridViewCheckBoxCell ck = row1.Cells["Seleccionar"] as DataGridViewCheckBoxCell;
                    if (Convert.ToBoolean(ck.Value) == true)
                    {
                        total += Math.Round(Convert.ToDouble(row1.Cells["totalDataGridViewTextBoxColumn"].Value.ToString()), 2);
                    }
                }
                metroTextBoxTotalFact.Text = total.ToString();

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void metroTile4_Click(object sender, EventArgs e)
        {
            try
            {
                //DECLARACION DE VARIA
                Double TotalMediosPago = 0;
                double TotalImporteComprobante = 0;
                int IDPago = 0;


                //Verifico si no estan vacios los DatagridGastospendientes y Medios de Pago
                if (metroGridComprobantes.Rows.Count == 0 || metroGridMedioPAgo.Rows.Count == 0)
                {
                    MessageBox.Show("Error, Inserte los Medios de Pago y los comprobantes a aplicarle el pago", "Sistema de Gestion de Compras", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    //Calculo el Total de Comprobantes
                    foreach (DataGridViewRow row1 in metroGridComprobantes.Rows)
                    {
                        DataGridViewCheckBoxCell ck = row1.Cells["Seleccionar"] as DataGridViewCheckBoxCell;
                        if (Convert.ToBoolean(ck.Value) == true)
                        {
                            TotalImporteComprobante += Math.Round(Convert.ToDouble(row1.Cells["totalDataGridViewTextBoxColumn"].Value.ToString()), 2);
                        }
                    }
                    //Calculo el Total de Medios de Pago
                    foreach (DataGridViewRow rown1 in metroGridMedioPAgo.Rows)
                    {
                        TotalMediosPago += Convert.ToDouble(rown1.Cells["ImportePago"].Value.ToString().Replace(".", ","));
                    }


                    Pagos pagos = new Pagos();
                    pagos.Fecha = metroDateTimeFechaPago.Value;
                    pagos.Concepto = metroTextBoxConcepto.Text;
                    pagos.Importe = TotalMediosPago;
                    IDPago = PagosController.AddorUpdatePagos(pagos).Idpago;

                    //Inserto en la tabla Detalle de pago
                    foreach (DataGridViewRow row2 in metroGridComprobantes.Rows)
                    {
                        var Detalle = new DetallesPago();
                        DataGridViewCheckBoxCell ck3 = row2.Cells["Seleccionar"] as DataGridViewCheckBoxCell;
                        if (Convert.ToBoolean(ck3.Value) == true)
                        {
                            Detalle.idComprobante = int.Parse(row2.Cells["idComprobanteDataGridViewTextBoxColumn"].Value.ToString());
                            Detalle.IdPago = IDPago;
                            PagosController.AddorUpdateDetallesPagos(Detalle);
                        }
                    }
                    //Inserto en la Tabla Medios de Pago
                    //INSERTO EN LA TABLA MEDIOS DE PAGO
                    foreach (DataGridViewRow row3 in metroGridMedioPAgo.Rows)
                    {
                        DetalleMediosPagos detalleMediosPagos = new DetalleMediosPagos();
                        detalleMediosPagos.IdMedioPago = PagosController.GetMedioPagoByNombre(row3.Cells["MedioPago"].Value.ToString()).IdMedioPago;
                        detalleMediosPagos.FechaVencimientoCheque = Convert.ToDateTime(row3.Cells["FechaVencimiento"].Value);
                        detalleMediosPagos.NoCheque = row3.Cells["ChequeTransferencia"].Value.ToString();
                        detalleMediosPagos.IdBanco = PagosController.GetBancobyName(row3.Cells["Banco"].Value.ToString()).IdBanco;
                        detalleMediosPagos.Importe = Convert.ToDouble(row3.Cells["ImportePago"].Value.ToString().Replace(".", ","));
                        detalleMediosPagos.IdPago = IDPago;
                        PagosController.AddorUpdateMediosPagos(detalleMediosPagos);
                    }

                    //INSERTO EN LA TABLA DETALLE DE PAGOS Y ACTUALIZO EL ESTADO DE LOS COMPROBANTES A 1
                    DialogResult dialogResult = MessageBox.Show("Pago Realizado, Deseas Confirmarla como Pagada", "Sistema de Gestios de Compras v1.0", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                    if (dialogResult == DialogResult.Yes)
                    {
                        //si se aplica la cancelacion del comprobante se actualiza el estado del comprobante
                        foreach (DataGridViewRow row2 in metroGridComprobantes.Rows)
                        {
                            DataGridViewCheckBoxCell ck3 = row2.Cells["Seleccionar"] as DataGridViewCheckBoxCell;
                            if (Convert.ToBoolean(ck3.Value) == true)
                            {
                                //Actualizar EStado de Comprobante
                                ComprobanteController.ActualizarEstadoComprobante(int.Parse(row2.Cells["idComprobanteDataGridViewTextBoxColumn"].Value.ToString()));
                                //Comprobantes.IdComprobante = int.Parse(row2.Cells["column2"].Value.ToString());
                                //Comprobantes.IdEstado = 1;
                                //ComprobanteController.AddorUpdateComprobantes(Comprobantes);

                            }
                        }
                    }
                    else if (dialogResult == DialogResult.No)
                    {

                    }

                    //Si no se cancela el comprobante no se actualiza el estado del comprobante
                    if (string.IsNullOrEmpty(metroTextBoxALi.Text) != true || string.IsNullOrEmpty(metroTextBoxImporteRet.Text) != true)
                    {
                        Retenciones.Alicuota = float.Parse(metroTextBoxALi.Text);
                        Retenciones.Importe = float.Parse(metroTextBoxImporteRet.Text);
                        Retenciones.IdPago = IDPago;
                        Retenciones.EmpresaID = 1;
                        Retenciones.Fecha = metroDateTimeFechaPago.Value;
                        PagosController.AddorUpdateRetencion(Retenciones);
                    }


                    //Declaro la instancia del ReporteViwer y lo llamo
                    ReportesForm reporte = new ReportesForm();
                    reporte.idpagoprop = IDPago;

                    reporte.ShowDialog();

                    //Declaro la instancia del ReporteViwer y lo llamo
                    ReportRetencionesForm ReporRetencion = new ReportRetencionesForm();
                    ReporRetencion.Idpago = IDPago;

                    ReporRetencion.ShowDialog();

                    //BORRO TODOS LOS DATOS DEL DATA GRID Y DE LOS TEXTBOXES
                    metroGridMedioPAgo.Rows.Clear();
                    metroGridComprobantes.DataSource = "";
                    metroTextBoxConcepto.Clear();
                    metroTextBoxChque.Clear();
                    metroTextBoxiMPORTE.Clear();


                }

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        private void metroTile5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void metroTile6_Click(object sender, EventArgs e)
        {
        
                if (Edition==false)
                {
                metroGridMedioPAgo.DataSource = null;
                    try
                    {

                        if (string.IsNullOrEmpty(metroComboBoxMedioPago.Text) == true || string.IsNullOrEmpty(metroTextBoxiMPORTE.Text) == true)
                        {

                            MessageBox.Show("Error Debe Insertar El Medio de Pago y el Importe", "Sistema de Gestion de Compras", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                        else
                        {

                            //Ingresar Medios de Pago 
                            string medio = metroComboBoxMedioPago.SelectedValue.ToString();
                            string banco = metroComboBoxBanco.SelectedValue.ToString();
                            string fechavencimiento = metroDateTimeVencimiento.Value.ToShortDateString();
                            var listmedios = new String[] {medio, fechavencimiento, metroTextBoxChque.Text, banco, metroTextBoxiMPORTE.Text };
                            metroGridMedioPAgo.Rows.Add(listmedios);
                            metroTextBoxChque.Clear();
                            metroTextBoxiMPORTE.Clear();


                           

                        }

                    }
                    catch (Exception ex)
                    {

                        throw new Exception(ex.Message);
                    }

                }




           
        }

        private void metroTile7_Click(object sender, EventArgs e)
        {
            try
            {
                if (metroGridMedioPAgo.Rows.Count == 0)
                {
                    MessageBox.Show("Error, no tiene Medios de Pago para Eliminar", "Sistema de Gestion de Compras", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    metroGridMedioPAgo.Rows.RemoveAt(metroGridMedioPAgo.CurrentRow.Index);
                }





            }
            catch (Exception)
            {

                throw;
            }
        }

        private void metroTile8_Click(object sender, EventArgs e)
        {
            try
            {
                double TotalNeto = 0;
                double TotalFactura = 0;
                Retenciones retencion = new Retenciones();
                foreach (DataGridViewRow row1 in metroGridComprobantes.Rows)
                {
                    DataGridViewCheckBoxCell ck = row1.Cells["Seleccionar"] as DataGridViewCheckBoxCell;
                    if (Convert.ToBoolean(ck.Value) == true)
                    {
                        TotalNeto += Math.Round(Convert.ToDouble(row1.Cells["importeNetoDataGridViewTextBoxColumn"].Value.ToString()), 2);
                        TotalFactura += Math.Round(Convert.ToDouble(row1.Cells["totalDataGridViewTextBoxColumn"].Value.ToString()), 2);
                    }
                }




                if (metroGridComprobantes.Rows.Count >= 1 && TotalNeto > 2000)
                {
                    retencion = PagosController.CalcularRetenciones(metroTextBoxNOMBREProveedor.Text, float.Parse(TotalNeto.ToString()));
                    if (retencion != null)
                    {

                        double totalPAgar = TotalFactura - Convert.ToDouble(retencion.Importe);
                        metroTextBoxIDRet.Text = retencion.IDRetencion.ToString();
                        metroTextBoxALi.Text = Math.Round((double)retencion.Alicuota, 2).ToString();
                        metroTextBoxImporteRet.Text = Math.Round((double)retencion.Importe, 2).ToString();
                        metroTextBoxiMPORTE.Text = (TotalFactura - Math.Round((double)retencion.Importe, 2)).ToString();
                        metroTextBoxTotalFact.Text = TotalFactura.ToString();

                    }
                    else
                    {
                        if (retencion == null)
                            metroTextBoxIDRet.Clear();
                        metroTextBoxALi.Clear();
                        metroTextBoxImporteRet.Clear();
                        metroTextBoxiMPORTE.Clear();
                        metroTextBoxTotalFact.Clear();

                    }
                }
                else
                {
                    MessageBox.Show("Al proveedor no se le hacen retenciones", "Sistema de Gestion");
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        private void metroTile9_Click(object sender, EventArgs e)
        {
            metroTextBoxIDRet.Clear();
            metroTextBoxALi.Clear();
            metroTextBoxImporteRet.Clear();
        }
    }
}
