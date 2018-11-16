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
    public partial class RubroForm : MetroFramework.Forms.MetroForm
    {

        public int  IDRubro{ get; set; }
        RubroProveedor rubroProveedor;
        ProveedorController proveedorController;
        public bool Edition { get; set; }
        public RubroForm()
        {
            InitializeComponent();
            rubroProveedor = new RubroProveedor();
            proveedorController = new ProveedorController();
        }

        private void RubroForm_Load(object sender, EventArgs e)
        {
            rubroProveedor = proveedorController.GetRubro(IDRubro);
            if (rubroProveedor != null&&Edition==true)
            {
               
                metroTextBoxDescripcion.Text = rubroProveedor.Descripcion;
            }
            else
            {
                
                metroTextBoxDescripcion.Text = "";

            }
        }

        private void metroButtonAgregarPago_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(metroTextBoxDescripcion.Text))
            {
                MessageBox.Show("Error, Debe Insertar los Datos");
            }
            else
            {
                if (Edition==true)
                {
                    
                    rubroProveedor.Descripcion = metroTextBoxDescripcion.Text;
                    proveedorController.AddorUpdateRubro(rubroProveedor);
                    MessageBox.Show("Insertado con Exito");
                  
                    this.Close();
                }
                else
                {
                    rubroProveedor = new RubroProveedor();
                    rubroProveedor.Descripcion = metroTextBoxDescripcion.Text;
                    proveedorController.AddorUpdateRubro(rubroProveedor);
                    MessageBox.Show("Insertado con Exito");

                    this.Close();

                }



            }
        }
    }
}
