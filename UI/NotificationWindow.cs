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
    public partial class NotificationWindow : MetroFramework.Forms.MetroForm
    {

        IEnumerable<string> VehiculosVTV;
        IEnumerable<string> PolizasVencimientos;
        IEnumerable<string> RegistrosVencimientos;
        MantenimientoVehiculoController MantenimientoVehiculoController;
        
        public NotificationWindow()
        {
            InitializeComponent();
            MantenimientoVehiculoController = new MantenimientoVehiculoController();
            VehiculosVTV = new List<string>();
            DateTime CurrentDate = DateTime.Now.Date;
            DateTime FechaInicio = CurrentDate.Date.AddDays(-30);
            VehiculosVTV = MantenimientoVehiculoController.GetVencimientosVTV(FechaInicio);
            PolizasVencimientos = MantenimientoVehiculoController.GetVencimientosPolizas(FechaInicio);
            RegistrosVencimientos = MantenimientoVehiculoController.GetVencimientoRegistros(FechaInicio);

        }

        private void NotificationWindow_Load(object sender, EventArgs e)
        {
            foreach (var item in VehiculosVTV)
            {
                
                checkedListBoxVTV.Items.Add(item);
            }
            foreach (var item in PolizasVencimientos)
            {
                checkedListBoxPolizas.Items.Add(item);
            }
            foreach (var item in RegistrosVencimientos)
            {
                checkedListBoxRegistros.Items.Add(item);
            }




        }

        private void checkedListBoxVTVVehiculos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
