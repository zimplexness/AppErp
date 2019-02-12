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
    public partial class ZimplexHome : Form
    {
        public int id { get; set; }
        public string UserName { get; set; }
        public NetUser NetUser;
        ApplicationUsers ApplicationUser;



        public ZimplexHome(string username)
        {
            InitializeComponent();
            NetUser = new NetUser();
            ApplicationUser = new ApplicationUsers();

            NetUser = ApplicationUser.GetUser(username);


        }




        private void ribbonPanel1_Click(object sender, EventArgs e)
        {

        }

        private void ribbonPanel5_Click(object sender, EventArgs e)
        {





        }

        private void ribbonButton6_Click(object sender, EventArgs e)
        {

            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == typeof(AdminProveedorFrm))
                {
                    f.Activate();
                    return;
                }
            }
            Form proveedorfrm = new AdminProveedorFrm();
            proveedorfrm.MdiParent = this;
            proveedorfrm.Show();

        }

        private void ribbonButtonComprobantes_Click(object sender, EventArgs e)
        {
            while (this.ActiveMdiChild != null)
            {
                this.ActiveMdiChild.Close();
            }
            //abrir formulario de comprobantes
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == typeof(ComprobantesFrm))
                {
                    f.Activate();
                    return;
                }
            }
            Form comprobantesfrm = new ComprobantesFrm();
            comprobantesfrm.MdiParent = this;
            comprobantesfrm.Show();
        }

        private void ribbonButtonPagos_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == typeof(PagosFrm))
                {
                    f.Activate();
                    return;
                }
            }
            Form pagosfrm = new PagosFrm();
            pagosfrm.MdiParent = this;
            pagosfrm.Show();
        }

        private void ribbonButtonConsultas_Click(object sender, EventArgs e)
        {

        }

        private void ribbonButtonProductos_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == typeof(ProductoFrm))
                {
                    f.Activate();
                    return;
                }
            }
            Form prodfrm = new ProductoFrm();
            prodfrm.MdiParent = this;
            prodfrm.Show();
        }

        private void ribbonButtonEmpleados_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == typeof(EmpleadoForm))
                {
                    f.Activate();
                    return;
                }
            }
            Form empleadofrm = new EmpleadoForm();
            empleadofrm.MdiParent = this;
            empleadofrm.Show();
        }

        private void ribbonButtonTaller_Click(object sender, EventArgs e)
        {
            while (this.ActiveMdiChild != null)
            {
                this.ActiveMdiChild.Close();
            }
            //abrir formulario de comprobantes
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == typeof(TallerFrm))
                {
                    f.Activate();
                    return;
                }
            }
            Form tallerform = new TallerFrm();
            tallerform.MdiParent = this;
            tallerform.Show();
        }

        private void ribbonButtonVechiculo_Click(object sender, EventArgs e)
        {
            while (this.ActiveMdiChild != null)
            {
                this.ActiveMdiChild.Close();
            }
            //abrir formulario de comprobantes
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == typeof(VehiculosFrm))
                {
                    f.Activate();
                    return;
                }
            }
            Form vehiculoform = new VehiculosFrm();
            vehiculoform.MdiParent = this;
            vehiculoform.Show();
        }

        private void Ingresar_Click(object sender, EventArgs e)
        {
            while (this.ActiveMdiChild != null)
            {
                this.ActiveMdiChild.Close();
            }
            //abrir formulario de comprobantes
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == typeof(LocalidadesFrm))
                {
                    f.Activate();
                    return;
                }
            }
            Form localidadform = new LocalidadesFrm();
            localidadform.MdiParent = this;
            localidadform.Show();
        }

        private void ribbonButtonConsultaComprobantes_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == typeof(ConsultasComprobantesProveedorFrm))
                {
                    f.Activate();
                    return;
                }
            }
            Form consultas = new ConsultasComprobantesProveedorFrm();
            consultas.MdiParent = this;
            consultas.Show();
        }

        private void Ingresar_DoubleClick(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == typeof(LocalidadesFrm))
                {
                    f.Activate();
                    return;
                }
            }
            Form localidafrm = new LocalidadesFrm();
            localidafrm.MdiParent = this;
            localidafrm.Show();

        }

        private void ribbonButtonProvincia_Click(object sender, EventArgs e)
        {
            while (this.ActiveMdiChild != null)
            {
                this.ActiveMdiChild.Close();
            }
            //abrir formulario de comprobantes
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == typeof(ProvinciaFrm))
                {
                    f.Activate();
                    return;
                }
            }
            Form provinciaform = new ProvinciaFrm();
            provinciaform.MdiParent = this;
            provinciaform.Show();

        }

        private void ribbonButtonBuscar_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == typeof(AdminProveedorFrm))
                {
                    f.Activate();
                    return;
                }
            }
            Form proveedorfrm = new AdminProveedorFrm();
            proveedorfrm.MdiParent = this;
            proveedorfrm.Show();

        }

        private void PolizaButton_Click(object sender, EventArgs e)
        {
            while (this.ActiveMdiChild != null)
            {
                this.ActiveMdiChild.Close();
            }
            //abrir formulario de comprobantes
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == typeof(AdminPolizasSeguro))
                {
                    f.Activate();
                    return;
                }
            }
            Form polizaform = new AdminPolizasSeguro();
            polizaform.MdiParent = this;
            polizaform.Show();
        }

        private void ribbon1_Click(object sender, EventArgs e)
        {

        }

        private void ZimplexHome_Load(object sender, EventArgs e)
        {
            toolStripStatusLabelUser.Text = NetUser.UserName;
            if (WindowState == FormWindowState.Maximized)
            {

                notifyIconMain.BalloonTipText = "Registros Vencidos";
                notifyIconMain.ShowBalloonTip(100);


            }


        }

        private void ribbonButtonRubros_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == typeof(AdminRubrosFrm))
                {
                    f.Activate();
                    return;
                }
            }
            Form rubrofrm = new AdminRubrosFrm();
            rubrofrm.MdiParent = this;
            rubrofrm.Show();
        }

        private void CategoriaMButton_Click(object sender, EventArgs e)
        {
            while (this.ActiveMdiChild != null)
            {
                this.ActiveMdiChild.Close();
            }
            //abrir formulario de comprobantes
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == typeof(AdminActividadesMantenimientoForm))
                {
                    f.Activate();
                    return;
                }
            }
            Form vehiculoform = new AdminActividadesMantenimientoForm();
            vehiculoform.MdiParent = this;
            vehiculoform.Show();
        }

        private void ribbonButton7_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == typeof(AdminCuentaCorrienteForm))
                {
                    f.Activate();
                    return;
                }
            }
            Form rubrofrm = new AdminCuentaCorrienteForm();
            rubrofrm.MdiParent = this;
            rubrofrm.Show();
        }

        private void ribbonButton6_Click_1(object sender, EventArgs e)
        {

        }

        private void ribbonButtonMantenimiento_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == typeof(MantenimientoForm))
                {
                    f.Activate();
                    return;
                }
            }
            Form mantenimientofrm = new MantenimientoForm();
            mantenimientofrm.MdiParent = this;
            mantenimientofrm.Show();

        }

        private void ribbonButtonImportar_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == typeof(PadronForm))
                {
                    f.Activate();
                    return;
                }
            }
            Form padronfrm = new PadronForm();
            padronfrm.MdiParent = this;
            padronfrm.Show();
        }

        private void ribbonButtonListar_CanvasChanged(object sender, EventArgs e)
        {

        }

        private void ribbonButtonListar_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == typeof(AdminMantenimientoVehiculoForm))
                {
                    f.Activate();
                    return;
                }
            }
            Form padronfrm = new AdminMantenimientoVehiculoForm();
            padronfrm.MdiParent = this;
            padronfrm.Show();
        }

        private void ribbonButtonUser_Click(object sender, EventArgs e)
        {

            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == typeof(CreateNewUserForm))
                {
                    f.Activate();
                    return;
                }
            }
            Form userForm = new CreateNewUserForm();
            userForm.MdiParent = this;
            userForm.Show();

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void notifyIconMain_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            NotificationWindow NotifyWindows = new NotificationWindow();
            NotifyWindows.ShowDialog();
        }

        private void notifyIconMain_BalloonTipClicked(object sender, EventArgs e)
        {
            NotificationWindow NotifyWindows = new NotificationWindow();
            NotifyWindows.ShowDialog();
        }

        private void ribbonButtonRegistros_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == typeof(AdminRegistrosConducir))
                {
                    f.Activate();
                    return;
                }
            }
            Form adminRegistrosForm = new AdminRegistrosConducir();
            adminRegistrosForm.MdiParent = this;
            adminRegistrosForm.Show();

        }

        private void treeViewMain_AfterSelect(object sender, TreeViewEventArgs e)
        {

            int ID;

            if (treeViewMain.SelectedNode.Index == 0)
            {
                ID = 1;
                var submenus = ApplicationUser.GetSubmenus(ID);
                treeViewChild.Nodes.Clear();

                foreach (var item in submenus)
                {
                    treeViewChild.Nodes.Add(item.Submenu);
                }


            }
            else if (treeViewMain.SelectedNode.Index == 1)
            {
                treeViewChild.Nodes.Clear();
                ID = 2;
                var submenus = ApplicationUser.GetSubmenus(ID);
                foreach (var item in submenus)
                {
                    treeViewChild.Nodes.Add(item.Submenu);
                }

            }
            else if (treeViewMain.SelectedNode.Index == 2)
            {
                treeViewChild.Nodes.Clear();
                ID = 3;
                var submenus = ApplicationUser.GetSubmenus(ID);
                foreach (var item in submenus)
                {
                    treeViewChild.Nodes.Add(item.Submenu);
                }

            }
            else if (treeViewMain.SelectedNode.Index == 3)
            {
                treeViewChild.Nodes.Clear();
                ID = 4;
                var submenus = ApplicationUser.GetSubmenus(ID);
                foreach (var item in submenus)
                {
                    treeViewChild.Nodes.Add(item.Submenu);
                }

            }
            else if (treeViewMain.SelectedNode.Index == 4)
            {
                treeViewChild.Nodes.Clear();
                ID = 5;
                var submenus = ApplicationUser.GetSubmenus(ID);
                foreach (var item in submenus)
                {
                    treeViewChild.Nodes.Add(item.Submenu);
                }

            }
            else if (treeViewMain.SelectedNode.Index == 5)
            {
                treeViewChild.Nodes.Clear();
                ID = 6;
                var submenus = ApplicationUser.GetSubmenus(ID);
                foreach (var item in submenus)
                {
                    treeViewChild.Nodes.Add(item.Submenu);
                }

            }

        }

        private void treeViewMain_Click(object sender, EventArgs e)
        {




        }

        private void treeViewChild_AfterSelect(object sender, TreeViewEventArgs e)
        {
            //Compras 
            if (treeViewChild.SelectedNode.Text == "Proveedores")
            {
                foreach (Form f in this.MdiChildren)
                {
                    if (f.GetType() == typeof(AdminProveedorFrm))
                    {
                        f.Activate();
                        return;
                    }
                }
                Form proveedorfrm = new AdminProveedorFrm();
                proveedorfrm.MdiParent = this; 
                proveedorfrm.Show();


            }
            else if (treeViewChild.SelectedNode.Text == "Rubros")
            {
                foreach (Form f in this.MdiChildren)
                {
                    if (f.GetType() == typeof(AdminRubrosFrm))
                    {
                        f.Activate();
                        return;
                    }
                }

                Form adminRubrosFrm = new AdminRubrosFrm();
                adminRubrosFrm.MdiParent = this;
                adminRubrosFrm.Show();
            }
            else if (treeViewChild.SelectedNode.Text == "Cuentas Corrientes")
            {
                foreach (Form f in this.MdiChildren)
                {
                    if (f.GetType() == typeof(AdminCuentaCorrienteForm))
                    {
                        f.Activate();
                        return;
                    }
                }

                Form adminCuenta = new AdminCuentaCorrienteForm();
                adminCuenta.MdiParent = this;
                adminCuenta.Show();

            }
            else if (treeViewChild.SelectedNode.Text == "Comprobantes de Compras")
            {
                foreach (Form f in this.MdiChildren)
                {
                    if (f.GetType() == typeof(AdminComprobantesForm))
                    {
                        f.Activate();
                        return;
                    }
                }

                Form consultafrm = new AdminComprobantesForm();
                consultafrm.MdiParent = this;
                consultafrm.Show();

            }
            
            //Empleados
            if (treeViewChild.SelectedNode.Text == "Empleados")
            {
                foreach (Form f in this.MdiChildren)
                {
                    if (f.GetType() == typeof(EmpleadoForm))
                    {
                        f.Activate();
                        return;
                    }
                }

                Form empleadofrm = new EmpleadoForm();
                empleadofrm.MdiParent = this;
                empleadofrm.Show();
            }
            else if (treeViewChild.SelectedNode.Text == "Registros Conducir")
            {
                foreach (Form f in this.MdiChildren)
                {
                    if (f.GetType() == typeof(AdminRegistrosConducir))
                    {
                        f.Activate();
                        return;
                    }
                }

                Form adminRegistro = new AdminRegistrosConducir();
                adminRegistro.MdiParent = this;
                adminRegistro.Show();
            }

            //Vehiculo
            if (treeViewChild.SelectedNode.Text == "Vehiculos")
            {
                foreach (Form f in this.MdiChildren)
                {
                    if (f.GetType() == typeof(AdminVehiculosForm))
                    {
                        f.Activate();
                        return;
                    }
                }

                Form adminVehiculos = new AdminVehiculosForm();
                adminVehiculos.MdiParent = this;
                adminVehiculos.Show();
            }
            else if (treeViewChild.SelectedNode.Text == "Mantenimientos")
            {
                foreach (Form f in this.MdiChildren)
                {
                    if (f.GetType() == typeof(AdminMantenimientoVehiculoForm))
                    {
                        f.Activate();
                        return;
                    }
                }

                Form adminMantenimiento = new AdminMantenimientoVehiculoForm();
                adminMantenimiento.MdiParent = this;
                adminMantenimiento.Show();

            }
            else if (treeViewChild.SelectedNode.Text == "Talleres")
            {
                foreach (Form f in this.MdiChildren)
                {
                    if (f.GetType() == typeof(TallerFrm))
                    {
                        f.Activate();
                        return;
                    }
                }

                Form tallerfrm = new TallerFrm();
                tallerfrm.MdiParent = this;
                tallerfrm.Show();
            }
            else if (treeViewChild.SelectedNode.Text == "Actividades de Mantenimientos")
            {
                foreach (Form f in this.MdiChildren)
                {
                    if (f.GetType() == typeof(AdminActividadesMantenimientoForm))
                    {
                        f.Activate();
                        return;
                    }
                }

                Form adminActividades = new AdminActividadesMantenimientoForm();
                adminActividades.MdiParent = this;
                adminActividades.Show();
            }
            else if (treeViewChild.SelectedNode.Text == "Polizas de Seguro")
            {
                foreach (Form f in this.MdiChildren)
                {
                    if (f.GetType() == typeof(AdminPolizasSeguro))
                    {
                        f.Activate();
                        return;
                    }
                }

                Form adminPolizas = new AdminPolizasSeguro();
                adminPolizas.MdiParent = this;
                adminPolizas.Show();

            }
            else if (treeViewChild.SelectedNode.Text == "Talleres Mecanicos")
            {
                foreach (Form f in this.MdiChildren)
                {
                    if (f.GetType() == typeof(AdminTalleresForm))
                    {
                        f.Activate();
                        return;
                    }
                }

                Form adminTaller = new AdminTalleresForm();
                adminTaller.MdiParent = this;
                adminTaller.Show();

            }


            //Pagos
            if (treeViewChild.SelectedNode.Text == "Pagos a Proveedores")
            {
                // MetroFramework.MetroMessageBox.Show(this, "Recurso no Encontrado", "Sistema de Gestion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation & MessageBoxIcon.Warning);
                foreach (Form f in this.MdiChildren)
                {
                    if (f.GetType() == typeof(AdminPagosForm))
                    {
                        f.Activate();
                        return;
                    }
                }

                Form Pagosform = new AdminPagosForm();
                Pagosform.MdiParent = this;
                Pagosform.Show();
            }
             else  if (treeViewChild.SelectedNode.Text == "Reportes")
            {
                MetroFramework.MetroMessageBox.Show(this, "Recurso no Encontrado", "Sistema de Gestion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation & MessageBoxIcon.Warning);
            }
            

            //Stocks
            if (treeViewChild.SelectedNode.Text == "Materiales y Servicios")
            {
                foreach (Form f in this.MdiChildren)
                {
                    if (f.GetType() == typeof(AdminProductosFrm))
                    {
                        f.Activate();
                        return;
                    }
                }

                Form Productosform = new AdminProductosFrm();
                Productosform.MdiParent = this;
                Productosform.Show();

            }
            else if (treeViewChild.SelectedNode.Text == "Movimientos")
            {
                MetroFramework.MetroMessageBox.Show(this, "Recurso no Encontrado", "Sistema de Gestion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation & MessageBoxIcon.Warning);
            }
            else if (treeViewChild.SelectedNode.Text == "Stock")
            {
                MetroFramework.MetroMessageBox.Show(this, "Recurso no Encontrado", "Sistema de Gestion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation & MessageBoxIcon.Warning);
            }
            //Configuracion General
            //Stocks
            if (treeViewChild.SelectedNode.Text == "Localidades")
            {
                foreach (Form f in this.MdiChildren)
                {
                    if (f.GetType() == typeof(LocalidadesFrm))
                    {
                        f.Activate();
                        return;
                    }
                }

                Form Localidadform = new LocalidadesFrm();
                Localidadform.MdiParent = this;
                Localidadform.Show();

            }
            else if (treeViewChild.SelectedNode.Text == "Provincias")
            {
                foreach (Form f in this.MdiChildren)
                {
                    if (f.GetType() == typeof(ProvinciaFrm))
                    {
                        f.Activate();
                        return;
                    }
                }

                Form Provinciaform = new ProvinciaFrm();
                Provinciaform.MdiParent = this;
                Provinciaform.Show();

                // MetroFramework.MetroMessageBox.Show(this, "Recurso no Encontrado", "Sistema de Gestion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation & MessageBoxIcon.Warning);
            }
            else if (treeViewChild.SelectedNode.Text == "Configuración de Usuario")
            {
                CreateNewUserForm createNewUserForm = new CreateNewUserForm();
                createNewUserForm.ShowDialog();
                // MetroFramework.MetroMessageBox.Show(this, "Recurso no Encontrado", "Sistema de Gestion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation & MessageBoxIcon.Warning);
            }

        }

        private void ribbonButton8_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc");
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {

        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            if (metroPanelMain.Visible == true)
            {
                this.metroTile1.TileImage = global::ErpGestion.Properties.Resources.rightarrow;
                metroPanelMain.Visible = false;
               


            }
            else if (metroPanelMain.Visible == false)
            {
               
                this.metroTile1.TileImage = global::ErpGestion.Properties.Resources.if_arrow_left_01_186410;
                metroPanelMain.Visible = true;
               

            }
        }

        private void ribbonButton10_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.meistertask.com/es");
        }

        private void ribbonButton13_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.computrabajo.com.ar/");
            
        }

        private void metroTile7_Click(object sender, EventArgs e)
        {
            int ID = 1;
            var submenus = ApplicationUser.GetSubmenus(ID);
            treeViewChild.Nodes.Clear();

            foreach (var item in submenus)
            {
                treeViewChild.Nodes.Add(item.Submenu);
            }

        }

        private void metroTile6_Click(object sender, EventArgs e)
        {
            int ID = 2;
            var submenus = ApplicationUser.GetSubmenus(ID);
            treeViewChild.Nodes.Clear();

            foreach (var item in submenus)
            {
                treeViewChild.Nodes.Add(item.Submenu);
            }
        }

        private void metroTile5_Click(object sender, EventArgs e)
        {
            int ID = 3;
            var submenus = ApplicationUser.GetSubmenus(ID);
            treeViewChild.Nodes.Clear();

            foreach (var item in submenus)
            {
                treeViewChild.Nodes.Add(item.Submenu);
            }
        }

        private void metroTile4_Click(object sender, EventArgs e)
        {
            int ID = 4;
            var submenus = ApplicationUser.GetSubmenus(ID);
            treeViewChild.Nodes.Clear();

            foreach (var item in submenus)
            {
                treeViewChild.Nodes.Add(item.Submenu);
            }
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            int ID = 5;
            var submenus = ApplicationUser.GetSubmenus(ID);
            treeViewChild.Nodes.Clear();

            foreach (var item in submenus)
            {
                treeViewChild.Nodes.Add(item.Submenu);
            }
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            int ID = 6;
            var submenus = ApplicationUser.GetSubmenus(ID);
            treeViewChild.Nodes.Clear();

            foreach (var item in submenus)
            {
                treeViewChild.Nodes.Add(item.Submenu);
            }
        }

        private void metroTile7_MouseHover(object sender, EventArgs e)
        {
           
        }

        private void metroTile7_MouseLeave(object sender, EventArgs e)
        {
           
        }

        private void ZimplexHome_Click(object sender, EventArgs e)
        {
           
        }

        private void ZimplexHome_MouseDown(object sender, MouseEventArgs e)
        {
           
        }

        private void ZimplexHome_MouseClick(object sender, MouseEventArgs e)
        {
           
        }

        private void ribbonButton9_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.apelaez.com.ar/index.php");
            
        }

        private void ribbonButton11_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://cablevision.exactian.solutions/index.php");
            
        }
    }
}
       
    


