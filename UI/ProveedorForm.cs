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
using BLayer;





namespace ErpGestion
{
    public partial class FrmEditProveedor : MetroFramework.Forms.MetroForm
    {
        //Instanciacion de Objetos Proveedores
        Proveedores _proveedores = null;
       
        ProveedorController proveedorController;
        
        public string cuit { get ; set ; }
       

        public FrmEditProveedor()
        {
            proveedorController = new ProveedorController();
            InitializeComponent();
            
        }

        
        public FrmEditProveedor(Proveedores proveedores) : this()
        {
            _proveedores=proveedores;
        }

        public FrmEditProveedor(string cuit) : this()
        {

            Proveedores prov = proveedorController.GetProveedorObject(cuit);
            _proveedores = prov;
        }




        private void FrmEditProveedor_Load(object sender, EventArgs e)
        {
            // Carga todos los Elementos del Proveedor
            Proveedores prov = proveedorController.GetProveedorObject(cuit);
            _proveedores = prov;

            metroComboBoxProvincia.DataSource = new Provincia_localidad().ListarProvincias();
            metroComboBoxProvincia.DisplayMember = "Provincias1";
            metroComboBoxProvincia.ValueMember = "IdProvincias";


            metroComboBoxLocalidades.DataSource = new Provincia_localidad().ListarLocalidades();
            metroComboBoxLocalidades.DisplayMember = "Localidades1";
            metroComboBoxLocalidades.ValueMember = "IdLocalidad";

            metroComboBoxRubros.DataSource = proveedorController.GetRubroProveedor();
            metroComboBoxRubros.DisplayMember = "Descripcion";
            metroComboBoxRubros.ValueMember = "IDRubroProveedor";

            metroComboBoxCondicionCompra.DataSource =new ComprobanteController().GetCondicionesCompra();
            metroComboBoxCondicionCompra.DisplayMember = "Condiciondecompra";
            metroComboBoxCondicionCompra.ValueMember = "IdCondicionCompra";

            if (_proveedores!=null)
            {

                if (_proveedores.CondicionCompra!=null&&_proveedores.IDRubro!=null&&_proveedores.CuentaCorriente!=null&&_proveedores.Vencimiento!=null)
                {
                    metroTextBoxNOMBRE.Text = _proveedores.Nombre;
                    metroTextBoxRAZON.Text = _proveedores.Razon;
                    metroTextBoxCUIT.Text = _proveedores.Cuit;
                    metroDateTimeFECHA.Value = _proveedores.FechaIngreso.Value;
                    metroTextBoxIIBB.Text = _proveedores.IngresosBrutos;
                    metroTextBoxDIRECCION.Text = _proveedores.Direccion;
                    metroComboBoxLocalidades.SelectedValue = _proveedores.IDLocalidad;
                    metroTextBoxTELEFONO.Text = _proveedores.Telefono;
                    metroComboBoxProvincia.SelectedValue = _proveedores.IDProvincia;
                    metroComboBoxRubros.SelectedValue = _proveedores.IDRubro;
                    metroTextBoxEmail.Text = _proveedores.Email;
                    metroTextBoxWeb.Text = _proveedores.Web;
                    metroTextBoxContacto.Text = _proveedores.Contacto;
                    metroComboBoxCondicionCompra.SelectedValue = _proveedores.CondicionCompra;
                    metroCheckBoxActivo.Checked = _proveedores.CuentaCorriente.Value;
                    metroTextBoxVencimiento.Text = _proveedores.Vencimiento.Value.ToString();
                    metroTextBoxObservaciones.Text = _proveedores.Comentario;
                }
                else
                {
                    metroTextBoxNOMBRE.Text = _proveedores.Nombre;
                    metroTextBoxRAZON.Text = _proveedores.Razon;
                    metroTextBoxCUIT.Text = _proveedores.Cuit;
                    metroDateTimeFECHA.Value = _proveedores.FechaIngreso.Value;
                    metroTextBoxIIBB.Text = _proveedores.IngresosBrutos;
                    metroTextBoxDIRECCION.Text = _proveedores.Direccion;
                    metroComboBoxLocalidades.SelectedValue = _proveedores.IDLocalidad;
                    metroTextBoxTELEFONO.Text = _proveedores.Telefono;
                    metroComboBoxProvincia.SelectedValue = _proveedores.IDProvincia;
                    metroTextBoxEmail.Text = _proveedores.Email;
                    metroTextBoxWeb.Text = _proveedores.Web;
                    metroTextBoxContacto.Text = _proveedores.Contacto;
                    
                   
                    metroTextBoxObservaciones.Text = _proveedores.Comentario;

                }
               

              


            }






        }

        private void metroPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void metroButtonAgregarPago_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(metroTextBoxNOMBRE.Text) || string.IsNullOrEmpty(metroTextBoxRAZON.Text) ||
                    string.IsNullOrEmpty(metroTextBoxCUIT.Text) || string.IsNullOrEmpty(metroTextBoxIIBB.Text))
                {

                    MessageBox.Show("Error,Debes Insertar los Datos del Proveedor", "Sistema de Gestion", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                }
                else
                {

                    if (_proveedores!=null)
                    {
                        if (string.IsNullOrEmpty(metroTextBoxVencimiento.Text))
                        {
                            _proveedores.Nombre = metroTextBoxNOMBRE.Text;
                            _proveedores.Razon = metroTextBoxRAZON.Text;
                            _proveedores.Cuit = metroTextBoxCUIT.Text;
                            _proveedores.IngresosBrutos = metroTextBoxIIBB.Text;
                            _proveedores.Direccion = metroTextBoxDIRECCION.Text;
                            _proveedores.IDProvincia = (int)metroComboBoxProvincia.SelectedValue;
                            _proveedores.IDLocalidad = (int)metroComboBoxLocalidades.SelectedValue;
                            _proveedores.IDRubro = (int)metroComboBoxRubros.SelectedValue;
                            _proveedores.FechaIngreso = metroDateTimeFECHA.Value;
                            _proveedores.Telefono = metroTextBoxTELEFONO.Text;
                            _proveedores.Email = metroTextBoxEmail.Text;
                            _proveedores.Web = metroTextBoxWeb.Text;
                            _proveedores.Contacto = metroTextBoxContacto.Text;
                            _proveedores.CondicionCompra = (int)metroComboBoxCondicionCompra.SelectedValue;
                            _proveedores.CuentaCorriente = metroCheckBoxActivo.Checked;
                            _proveedores.Vencimiento = 0;
                            _proveedores.Comentario = metroTextBoxObservaciones.Text;
                            proveedorController.AddorUpdateProveedores(_proveedores);
                            MessageBox.Show("Proveedor Agregado con exito", "Sistema de Gestion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();

                        }
                        else
                        {
                            _proveedores.Nombre = metroTextBoxNOMBRE.Text;
                            _proveedores.Razon = metroTextBoxRAZON.Text;
                            _proveedores.Cuit = metroTextBoxCUIT.Text;
                            _proveedores.IngresosBrutos = metroTextBoxIIBB.Text;
                            _proveedores.Direccion = metroTextBoxDIRECCION.Text;
                            _proveedores.IDProvincia = (int)metroComboBoxProvincia.SelectedValue;
                            _proveedores.IDLocalidad = (int)metroComboBoxLocalidades.SelectedValue;
                            _proveedores.IDRubro = (int)metroComboBoxRubros.SelectedValue;
                            _proveedores.FechaIngreso = metroDateTimeFECHA.Value;
                            _proveedores.Telefono = metroTextBoxTELEFONO.Text;
                            _proveedores.Email = metroTextBoxEmail.Text;
                            _proveedores.Web = metroTextBoxWeb.Text;
                            _proveedores.Contacto = metroTextBoxContacto.Text;
                            _proveedores.CondicionCompra = (int)metroComboBoxCondicionCompra.SelectedValue;
                            _proveedores.CuentaCorriente = metroCheckBoxActivo.Checked;
                            _proveedores.Vencimiento = int.Parse(metroTextBoxVencimiento.Text);
                            _proveedores.Comentario = metroTextBoxObservaciones.Text;
                            proveedorController.AddorUpdateProveedores(_proveedores);
                            MessageBox.Show("Proveedor Agregado con exito", "Sistema de Gestion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();

                        }
                       

                    }
                    else
                    {
                        if (string.IsNullOrEmpty(metroTextBoxVencimiento.Text))
                        {
                            _proveedores = new Proveedores();
                        _proveedores.Nombre = metroTextBoxNOMBRE.Text;
                        _proveedores.Razon = metroTextBoxRAZON.Text;
                        _proveedores.Cuit = metroTextBoxCUIT.Text;
                        _proveedores.IngresosBrutos = metroTextBoxIIBB.Text;
                        _proveedores.Direccion = metroTextBoxDIRECCION.Text;
                        _proveedores.IDProvincia = (int)metroComboBoxProvincia.SelectedValue;
                        _proveedores.IDLocalidad = (int)metroComboBoxLocalidades.SelectedValue;
                        _proveedores.IDRubro = (int)metroComboBoxRubros.SelectedValue;
                        _proveedores.FechaIngreso = metroDateTimeFECHA.Value;
                        _proveedores.Telefono = metroTextBoxTELEFONO.Text;
                        _proveedores.Email = metroTextBoxEmail.Text;
                        _proveedores.Web = metroTextBoxWeb.Text;
                        _proveedores.Contacto = metroTextBoxContacto.Text;
                        _proveedores.CondicionCompra = (int)metroComboBoxCondicionCompra.SelectedValue;
                        _proveedores.CuentaCorriente = metroCheckBoxActivo.Checked;
                        _proveedores.Vencimiento =0;
                        _proveedores.Comentario = metroTextBoxObservaciones.Text;
                        proveedorController.AddorUpdateProveedores(_proveedores);
                        MessageBox.Show("Proveedor Agregado con exito", "Sistema de Gestion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();

                        }
                        else
                        {
                            _proveedores = new Proveedores();
                            _proveedores.Nombre = metroTextBoxNOMBRE.Text;
                            _proveedores.Razon = metroTextBoxRAZON.Text;
                            _proveedores.Cuit = metroTextBoxCUIT.Text;
                            _proveedores.IngresosBrutos = metroTextBoxIIBB.Text;
                            _proveedores.Direccion = metroTextBoxDIRECCION.Text;
                            _proveedores.IDProvincia = (int)metroComboBoxProvincia.SelectedValue;
                            _proveedores.IDLocalidad = (int)metroComboBoxLocalidades.SelectedValue;
                            _proveedores.IDRubro = (int)metroComboBoxRubros.SelectedValue;
                            _proveedores.FechaIngreso = metroDateTimeFECHA.Value;
                            _proveedores.Telefono = metroTextBoxTELEFONO.Text;
                            _proveedores.Email = metroTextBoxEmail.Text;
                            _proveedores.Web = metroTextBoxWeb.Text;
                            _proveedores.Contacto = metroTextBoxContacto.Text;
                            _proveedores.CondicionCompra = (int)metroComboBoxCondicionCompra.SelectedValue;
                            _proveedores.CuentaCorriente = metroCheckBoxActivo.Checked;
                            _proveedores.Vencimiento = int.Parse(metroTextBoxVencimiento.Text);
                            _proveedores.Comentario = metroTextBoxObservaciones.Text;
                            proveedorController.AddorUpdateProveedores(_proveedores);
                            MessageBox.Show("Proveedor Agregado con exito", "Sistema de Gestion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();

                        }



                    }

                }


            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        #region IFindProvincia Members

        public void Selected(Provincias provincias)
        {
            //_proveedores.Provincias.IDProvincias = provincias.IDProvincias;
            //metroTextBoxProvincia.Text = provincias.Provincias1;
        }





        #endregion

        private void metroButtonProvincia_Click(object sender, EventArgs e)
        {
            //FindProvinciasFrm findProvinciasFrm = new FindProvinciasFrm(this,);
            //findProvinciasFrm.ShowDialog();
        }
    }
}
