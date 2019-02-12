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
    public partial class TallerFrm : MetroFramework.Forms.MetroForm
    {
        public int IDTaller { get; set; }
        MantenimientoVehiculoController mantenimientoVehiculo;
        SharedController sharedController;
        Talleres taller;
        public TallerFrm()
        {
            InitializeComponent();
            mantenimientoVehiculo = new MantenimientoVehiculoController();
            sharedController = new SharedController();
            taller = new Talleres();
        }

        private void TallerFrm_Load(object sender, EventArgs e)
        {
           //Fill Comboboxes

            metroComboBoxlocalidad.DataSource = sharedController.GetLocalidades();
            metroComboBoxlocalidad.DisplayMember = "Localidades1";
            metroComboBoxlocalidad.ValueMember = "IdLocalidad";

            metroComboBoxtipotaller.DataSource = mantenimientoVehiculo.GetAllTiposTalleres();
            metroComboBoxtipotaller.DisplayMember = "DescripcionTaller";
            metroComboBoxtipotaller.ValueMember = "IdTipoTaller";

            taller = mantenimientoVehiculo.GetTallerByID(IDTaller);

            if (taller!=null)
            {
                metroTextBoxNombre.Text = taller.NombreTaller;
                metroTextBoxencargado.Text = taller.NombreEncargado;
                metroComboBoxtipotaller.SelectedValue = taller.IdTipoTaller;
                metroTextBoxdireccion.Text = taller.Direccion;
                metroComboBoxlocalidad.SelectedValue = taller.IDLocalidad;
                metroTextBoxtelefono.Text = taller.TelefonoCotacto;
            }

            
        }

        private void metroButtonAgregarPago_Click(object sender, EventArgs e)
        {
           
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void metroTile4_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(metroTextBoxNombre.Text))
                {
                    MetroFramework.MetroMessageBox.Show(this, "Ingrese el nombre del taller", "Sistema de Gestiòn", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    if (taller != null)
                    {
                        taller.NombreTaller = metroTextBoxNombre.Text;
                        taller.NombreEncargado = metroTextBoxencargado.Text;
                        taller.IdTipoTaller = (int)metroComboBoxtipotaller.SelectedValue;
                        taller.Direccion = metroTextBoxdireccion.Text;
                        taller.IDLocalidad = (int)metroComboBoxlocalidad.SelectedValue;
                        taller.TelefonoCotacto = metroTextBoxtelefono.Text;
                        mantenimientoVehiculo.AddorUpdateTaller(taller);
                    }
                    else
                    {
                        taller = new Talleres();
                        taller.NombreTaller = metroTextBoxNombre.Text;
                        taller.NombreEncargado = metroTextBoxencargado.Text;
                        taller.IdTipoTaller = (int)metroComboBoxtipotaller.SelectedValue;
                        taller.Direccion = metroTextBoxdireccion.Text;
                        taller.IDLocalidad = (int)metroComboBoxlocalidad.SelectedValue;
                        taller.TelefonoCotacto = metroTextBoxtelefono.Text;
                        mantenimientoVehiculo.AddorUpdateTaller(taller);

                    }
                    MetroFramework.MetroMessageBox.Show(this, "Taller ingresado con exito", "Sistema de Gestiòn", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
