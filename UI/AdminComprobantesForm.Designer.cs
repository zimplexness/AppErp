namespace ErpGestion
{
    partial class AdminComprobantesForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminComprobantesForm));
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.groupBoxFiltros = new System.Windows.Forms.GroupBox();
            this.metroButtonCreate = new MetroFramework.Controls.MetroButton();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBoxProveedor = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroDateTimeFechainicio = new MetroFramework.Controls.MetroDateTime();
            this.metroDateTimeFechaFin = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroRadioButtonFacturaFecha = new MetroFramework.Controls.MetroRadioButton();
            this.metroRadioButtonporFecha = new MetroFramework.Controls.MetroRadioButton();
            this.metroRadioButtonProveedor = new MetroFramework.Controls.MetroRadioButton();
            this.metroTextBoxSucursal = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBoxNoFactura = new MetroFramework.Controls.MetroTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.metroToggleFiltro = new MetroFramework.Controls.MetroToggle();
            this.linkLabel4 = new System.Windows.Forms.LinkLabel();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.metroGridComprobantes = new MetroFramework.Controls.MetroGrid();
            this.idComprobanteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreProveedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoComprobanteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoFacturaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sucursalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noFacturaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.condiciondecompraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.importeNetoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ivaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iIBBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.percepcionesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.otrosGastosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSourceComprobantes = new System.Core.ComponentModel.ObjectBindingSource(this.components);
            this.groupBoxFiltros.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGridComprobantes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceComprobantes)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(465, 8);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(250, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "ADMINISTRACION DE COMPROBANTES";
            // 
            // groupBoxFiltros
            // 
            this.groupBoxFiltros.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBoxFiltros.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBoxFiltros.Controls.Add(this.metroButtonCreate);
            this.groupBoxFiltros.Controls.Add(this.metroLabel6);
            this.groupBoxFiltros.Controls.Add(this.metroLabel5);
            this.groupBoxFiltros.Controls.Add(this.metroTextBoxProveedor);
            this.groupBoxFiltros.Controls.Add(this.metroLabel2);
            this.groupBoxFiltros.Controls.Add(this.metroDateTimeFechainicio);
            this.groupBoxFiltros.Controls.Add(this.metroDateTimeFechaFin);
            this.groupBoxFiltros.Controls.Add(this.metroLabel3);
            this.groupBoxFiltros.Controls.Add(this.metroLabel4);
            this.groupBoxFiltros.Controls.Add(this.metroRadioButtonFacturaFecha);
            this.groupBoxFiltros.Controls.Add(this.metroRadioButtonporFecha);
            this.groupBoxFiltros.Controls.Add(this.metroRadioButtonProveedor);
            this.groupBoxFiltros.Controls.Add(this.metroTextBoxSucursal);
            this.groupBoxFiltros.Controls.Add(this.metroTextBoxNoFactura);
            this.groupBoxFiltros.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxFiltros.Location = new System.Drawing.Point(291, 30);
            this.groupBoxFiltros.Name = "groupBoxFiltros";
            this.groupBoxFiltros.Size = new System.Drawing.Size(790, 82);
            this.groupBoxFiltros.TabIndex = 49;
            this.groupBoxFiltros.TabStop = false;
            this.groupBoxFiltros.Text = "Filtros";
            this.groupBoxFiltros.Visible = false;
            // 
            // metroButtonCreate
            // 
            this.metroButtonCreate.BackgroundImage = global::ErpGestion.Properties.Resources.if_Tick_Mark_Circle_1398913;
            this.metroButtonCreate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.metroButtonCreate.Location = new System.Drawing.Point(740, 17);
            this.metroButtonCreate.Name = "metroButtonCreate";
            this.metroButtonCreate.Size = new System.Drawing.Size(30, 36);
            this.metroButtonCreate.TabIndex = 38;
            this.metroButtonCreate.UseSelectable = true;
            this.metroButtonCreate.Click += new System.EventHandler(this.metroButtonCreate_Click);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(338, 19);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(76, 19);
            this.metroLabel6.TabIndex = 37;
            this.metroLabel6.Text = "No. Factura";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(263, 20);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(55, 19);
            this.metroLabel5.TabIndex = 36;
            this.metroLabel5.Text = "Punto V";
            // 
            // metroTextBoxProveedor
            // 
            // 
            // 
            // 
            this.metroTextBoxProveedor.CustomButton.Image = null;
            this.metroTextBoxProveedor.CustomButton.Location = new System.Drawing.Point(231, 1);
            this.metroTextBoxProveedor.CustomButton.Name = "";
            this.metroTextBoxProveedor.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.metroTextBoxProveedor.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxProveedor.CustomButton.TabIndex = 1;
            this.metroTextBoxProveedor.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxProveedor.CustomButton.UseSelectable = true;
            this.metroTextBoxProveedor.CustomButton.Visible = false;
            this.metroTextBoxProveedor.Lines = new string[0];
            this.metroTextBoxProveedor.Location = new System.Drawing.Point(6, 41);
            this.metroTextBoxProveedor.MaxLength = 32767;
            this.metroTextBoxProveedor.Name = "metroTextBoxProveedor";
            this.metroTextBoxProveedor.PasswordChar = '\0';
            this.metroTextBoxProveedor.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxProveedor.SelectedText = "";
            this.metroTextBoxProveedor.SelectionLength = 0;
            this.metroTextBoxProveedor.SelectionStart = 0;
            this.metroTextBoxProveedor.ShortcutsEnabled = true;
            this.metroTextBoxProveedor.Size = new System.Drawing.Size(257, 27);
            this.metroTextBoxProveedor.TabIndex = 35;
            this.metroTextBoxProveedor.UseSelectable = true;
            this.metroTextBoxProveedor.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxProveedor.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(6, 19);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(125, 19);
            this.metroLabel2.TabIndex = 29;
            this.metroLabel2.Text = "Nombre Proveedor";
            // 
            // metroDateTimeFechainicio
            // 
            this.metroDateTimeFechainicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.metroDateTimeFechainicio.Location = new System.Drawing.Point(426, 37);
            this.metroDateTimeFechainicio.MinimumSize = new System.Drawing.Size(0, 29);
            this.metroDateTimeFechainicio.Name = "metroDateTimeFechainicio";
            this.metroDateTimeFechainicio.Size = new System.Drawing.Size(100, 29);
            this.metroDateTimeFechainicio.TabIndex = 31;
            // 
            // metroDateTimeFechaFin
            // 
            this.metroDateTimeFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.metroDateTimeFechaFin.Location = new System.Drawing.Point(532, 37);
            this.metroDateTimeFechaFin.MinimumSize = new System.Drawing.Size(0, 29);
            this.metroDateTimeFechaFin.Name = "metroDateTimeFechaFin";
            this.metroDateTimeFechaFin.Size = new System.Drawing.Size(98, 29);
            this.metroDateTimeFechaFin.TabIndex = 32;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(420, 20);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(77, 19);
            this.metroLabel3.TabIndex = 33;
            this.metroLabel3.Text = "Fecha Inicio";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(532, 20);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(64, 19);
            this.metroLabel4.TabIndex = 34;
            this.metroLabel4.Text = "Fecha Fin";
            // 
            // metroRadioButtonFacturaFecha
            // 
            this.metroRadioButtonFacturaFecha.AutoSize = true;
            this.metroRadioButtonFacturaFecha.Location = new System.Drawing.Point(636, 59);
            this.metroRadioButtonFacturaFecha.Name = "metroRadioButtonFacturaFecha";
            this.metroRadioButtonFacturaFecha.Size = new System.Drawing.Size(148, 15);
            this.metroRadioButtonFacturaFecha.TabIndex = 7;
            this.metroRadioButtonFacturaFecha.Text = "Por No. Factura y Fecha";
            this.metroRadioButtonFacturaFecha.UseSelectable = true;
            // 
            // metroRadioButtonporFecha
            // 
            this.metroRadioButtonporFecha.AutoSize = true;
            this.metroRadioButtonporFecha.Location = new System.Drawing.Point(636, 38);
            this.metroRadioButtonporFecha.Name = "metroRadioButtonporFecha";
            this.metroRadioButtonporFecha.Size = new System.Drawing.Size(75, 15);
            this.metroRadioButtonporFecha.TabIndex = 6;
            this.metroRadioButtonporFecha.Text = "Por Fecha";
            this.metroRadioButtonporFecha.UseSelectable = true;
            // 
            // metroRadioButtonProveedor
            // 
            this.metroRadioButtonProveedor.AutoSize = true;
            this.metroRadioButtonProveedor.Location = new System.Drawing.Point(636, 17);
            this.metroRadioButtonProveedor.Name = "metroRadioButtonProveedor";
            this.metroRadioButtonProveedor.Size = new System.Drawing.Size(98, 15);
            this.metroRadioButtonProveedor.TabIndex = 5;
            this.metroRadioButtonProveedor.Text = "Por Proveedor";
            this.metroRadioButtonProveedor.UseSelectable = true;
            // 
            // metroTextBoxSucursal
            // 
            // 
            // 
            // 
            this.metroTextBoxSucursal.CustomButton.Image = null;
            this.metroTextBoxSucursal.CustomButton.Location = new System.Drawing.Point(37, 1);
            this.metroTextBoxSucursal.CustomButton.Name = "";
            this.metroTextBoxSucursal.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.metroTextBoxSucursal.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxSucursal.CustomButton.TabIndex = 1;
            this.metroTextBoxSucursal.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxSucursal.CustomButton.UseSelectable = true;
            this.metroTextBoxSucursal.CustomButton.Visible = false;
            this.metroTextBoxSucursal.Lines = new string[0];
            this.metroTextBoxSucursal.Location = new System.Drawing.Point(269, 40);
            this.metroTextBoxSucursal.MaxLength = 32767;
            this.metroTextBoxSucursal.Name = "metroTextBoxSucursal";
            this.metroTextBoxSucursal.PasswordChar = '\0';
            this.metroTextBoxSucursal.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxSucursal.SelectedText = "";
            this.metroTextBoxSucursal.SelectionLength = 0;
            this.metroTextBoxSucursal.SelectionStart = 0;
            this.metroTextBoxSucursal.ShortcutsEnabled = true;
            this.metroTextBoxSucursal.Size = new System.Drawing.Size(63, 27);
            this.metroTextBoxSucursal.TabIndex = 2;
            this.metroTextBoxSucursal.UseSelectable = true;
            this.metroTextBoxSucursal.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxSucursal.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.metroTextBoxSucursal.Leave += new System.EventHandler(this.metroTextBoxSucursal_Leave);
            // 
            // metroTextBoxNoFactura
            // 
            // 
            // 
            // 
            this.metroTextBoxNoFactura.CustomButton.Image = null;
            this.metroTextBoxNoFactura.CustomButton.Location = new System.Drawing.Point(56, 1);
            this.metroTextBoxNoFactura.CustomButton.Name = "";
            this.metroTextBoxNoFactura.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.metroTextBoxNoFactura.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxNoFactura.CustomButton.TabIndex = 1;
            this.metroTextBoxNoFactura.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxNoFactura.CustomButton.UseSelectable = true;
            this.metroTextBoxNoFactura.CustomButton.Visible = false;
            this.metroTextBoxNoFactura.Lines = new string[0];
            this.metroTextBoxNoFactura.Location = new System.Drawing.Point(338, 39);
            this.metroTextBoxNoFactura.MaxLength = 32767;
            this.metroTextBoxNoFactura.Name = "metroTextBoxNoFactura";
            this.metroTextBoxNoFactura.PasswordChar = '\0';
            this.metroTextBoxNoFactura.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxNoFactura.SelectedText = "";
            this.metroTextBoxNoFactura.SelectionLength = 0;
            this.metroTextBoxNoFactura.SelectionStart = 0;
            this.metroTextBoxNoFactura.ShortcutsEnabled = true;
            this.metroTextBoxNoFactura.Size = new System.Drawing.Size(82, 27);
            this.metroTextBoxNoFactura.TabIndex = 1;
            this.metroTextBoxNoFactura.UseSelectable = true;
            this.metroTextBoxNoFactura.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxNoFactura.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.metroTextBoxNoFactura.Leave += new System.EventHandler(this.metroTextBoxNoFactura_Leave);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox2.Controls.Add(this.linkLabel1);
            this.groupBox2.Controls.Add(this.linkLabel2);
            this.groupBox2.Controls.Add(this.metroToggleFiltro);
            this.groupBox2.Controls.Add(this.linkLabel4);
            this.groupBox2.Controls.Add(this.linkLabel3);
            this.groupBox2.Location = new System.Drawing.Point(6, 30);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(279, 62);
            this.groupBox2.TabIndex = 48;
            this.groupBox2.TabStop = false;
            // 
            // linkLabel1
            // 
            this.linkLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.linkLabel1.LinkColor = System.Drawing.Color.Teal;
            this.linkLabel1.Location = new System.Drawing.Point(181, 20);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(45, 13);
            this.linkLabel1.TabIndex = 38;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "FILTRO";
            // 
            // linkLabel2
            // 
            this.linkLabel2.ActiveLinkColor = System.Drawing.Color.DarkTurquoise;
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.linkLabel2.LinkColor = System.Drawing.Color.DodgerBlue;
            this.linkLabel2.Location = new System.Drawing.Point(6, 19);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(45, 13);
            this.linkLabel2.TabIndex = 29;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "NUEVO";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // metroToggleFiltro
            // 
            this.metroToggleFiltro.AutoSize = true;
            this.metroToggleFiltro.Location = new System.Drawing.Point(167, 37);
            this.metroToggleFiltro.Name = "metroToggleFiltro";
            this.metroToggleFiltro.Size = new System.Drawing.Size(80, 17);
            this.metroToggleFiltro.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroToggleFiltro.TabIndex = 4;
            this.metroToggleFiltro.Text = "Off";
            this.metroToggleFiltro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroToggleFiltro.UseSelectable = true;
            this.metroToggleFiltro.CheckedChanged += new System.EventHandler(this.metroToggleFiltro_CheckedChanged);
            // 
            // linkLabel4
            // 
            this.linkLabel4.AutoSize = true;
            this.linkLabel4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.linkLabel4.LinkColor = System.Drawing.Color.Teal;
            this.linkLabel4.Location = new System.Drawing.Point(57, 19);
            this.linkLabel4.Name = "linkLabel4";
            this.linkLabel4.Size = new System.Drawing.Size(47, 13);
            this.linkLabel4.TabIndex = 36;
            this.linkLabel4.TabStop = true;
            this.linkLabel4.Text = "EDITAR";
            this.linkLabel4.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel4_LinkClicked);
            // 
            // linkLabel3
            // 
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.linkLabel3.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.linkLabel3.Location = new System.Drawing.Point(110, 20);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(58, 13);
            this.linkLabel3.TabIndex = 37;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "ELIMINAR";
            this.linkLabel3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel3_LinkClicked);
            // 
            // metroGridComprobantes
            // 
            this.metroGridComprobantes.AllowUserToOrderColumns = true;
            this.metroGridComprobantes.AllowUserToResizeRows = false;
            this.metroGridComprobantes.AutoGenerateColumns = false;
            this.metroGridComprobantes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGridComprobantes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGridComprobantes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGridComprobantes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(133)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridComprobantes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.metroGridComprobantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.metroGridComprobantes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idComprobanteDataGridViewTextBoxColumn,
            this.nombreProveedorDataGridViewTextBoxColumn,
            this.tipoComprobanteDataGridViewTextBoxColumn,
            this.fechaDataGridViewTextBoxColumn,
            this.tipoFacturaDataGridViewTextBoxColumn,
            this.sucursalDataGridViewTextBoxColumn,
            this.noFacturaDataGridViewTextBoxColumn,
            this.condiciondecompraDataGridViewTextBoxColumn,
            this.importeNetoDataGridViewTextBoxColumn,
            this.ivaDataGridViewTextBoxColumn,
            this.iIBBDataGridViewTextBoxColumn,
            this.percepcionesDataGridViewTextBoxColumn,
            this.otrosGastosDataGridViewTextBoxColumn,
            this.totalDataGridViewTextBoxColumn,
            this.estadosDataGridViewTextBoxColumn});
            this.metroGridComprobantes.DataSource = this.bindingSourceComprobantes;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(133)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGridComprobantes.DefaultCellStyle = dataGridViewCellStyle2;
            this.metroGridComprobantes.EnableHeadersVisualStyles = false;
            this.metroGridComprobantes.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGridComprobantes.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGridComprobantes.Location = new System.Drawing.Point(6, 118);
            this.metroGridComprobantes.Name = "metroGridComprobantes";
            this.metroGridComprobantes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(133)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridComprobantes.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.metroGridComprobantes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGridComprobantes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGridComprobantes.Size = new System.Drawing.Size(1214, 405);
            this.metroGridComprobantes.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroGridComprobantes.TabIndex = 47;
            this.metroGridComprobantes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.metroGridComprobantes_CellContentClick);
            this.metroGridComprobantes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.metroGridComprobantes_CellDoubleClick);
            // 
            // idComprobanteDataGridViewTextBoxColumn
            // 
            this.idComprobanteDataGridViewTextBoxColumn.DataPropertyName = "IdComprobante";
            this.idComprobanteDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idComprobanteDataGridViewTextBoxColumn.Name = "idComprobanteDataGridViewTextBoxColumn";
            this.idComprobanteDataGridViewTextBoxColumn.Width = 50;
            // 
            // nombreProveedorDataGridViewTextBoxColumn
            // 
            this.nombreProveedorDataGridViewTextBoxColumn.DataPropertyName = "NombreProveedor";
            this.nombreProveedorDataGridViewTextBoxColumn.HeaderText = "Proveedor";
            this.nombreProveedorDataGridViewTextBoxColumn.Name = "nombreProveedorDataGridViewTextBoxColumn";
            this.nombreProveedorDataGridViewTextBoxColumn.Width = 150;
            // 
            // tipoComprobanteDataGridViewTextBoxColumn
            // 
            this.tipoComprobanteDataGridViewTextBoxColumn.DataPropertyName = "TipoComprobante";
            this.tipoComprobanteDataGridViewTextBoxColumn.HeaderText = "Tipo de Comprobante";
            this.tipoComprobanteDataGridViewTextBoxColumn.Name = "tipoComprobanteDataGridViewTextBoxColumn";
            // 
            // fechaDataGridViewTextBoxColumn
            // 
            this.fechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha";
            this.fechaDataGridViewTextBoxColumn.HeaderText = "Fecha";
            this.fechaDataGridViewTextBoxColumn.Name = "fechaDataGridViewTextBoxColumn";
            // 
            // tipoFacturaDataGridViewTextBoxColumn
            // 
            this.tipoFacturaDataGridViewTextBoxColumn.DataPropertyName = "TipoFactura";
            this.tipoFacturaDataGridViewTextBoxColumn.HeaderText = "Tipo";
            this.tipoFacturaDataGridViewTextBoxColumn.Name = "tipoFacturaDataGridViewTextBoxColumn";
            this.tipoFacturaDataGridViewTextBoxColumn.Width = 40;
            // 
            // sucursalDataGridViewTextBoxColumn
            // 
            this.sucursalDataGridViewTextBoxColumn.DataPropertyName = "Sucursal";
            this.sucursalDataGridViewTextBoxColumn.HeaderText = "Punto V";
            this.sucursalDataGridViewTextBoxColumn.Name = "sucursalDataGridViewTextBoxColumn";
            this.sucursalDataGridViewTextBoxColumn.Width = 50;
            // 
            // noFacturaDataGridViewTextBoxColumn
            // 
            this.noFacturaDataGridViewTextBoxColumn.DataPropertyName = "NoFactura";
            this.noFacturaDataGridViewTextBoxColumn.HeaderText = "No. Factura";
            this.noFacturaDataGridViewTextBoxColumn.Name = "noFacturaDataGridViewTextBoxColumn";
            // 
            // condiciondecompraDataGridViewTextBoxColumn
            // 
            this.condiciondecompraDataGridViewTextBoxColumn.DataPropertyName = "Condiciondecompra";
            this.condiciondecompraDataGridViewTextBoxColumn.HeaderText = "Condicion de compra";
            this.condiciondecompraDataGridViewTextBoxColumn.Name = "condiciondecompraDataGridViewTextBoxColumn";
            this.condiciondecompraDataGridViewTextBoxColumn.Width = 150;
            // 
            // importeNetoDataGridViewTextBoxColumn
            // 
            this.importeNetoDataGridViewTextBoxColumn.DataPropertyName = "ImporteNeto";
            this.importeNetoDataGridViewTextBoxColumn.HeaderText = "Importe Neto";
            this.importeNetoDataGridViewTextBoxColumn.Name = "importeNetoDataGridViewTextBoxColumn";
            this.importeNetoDataGridViewTextBoxColumn.Width = 70;
            // 
            // ivaDataGridViewTextBoxColumn
            // 
            this.ivaDataGridViewTextBoxColumn.DataPropertyName = "Iva";
            this.ivaDataGridViewTextBoxColumn.HeaderText = "Iva";
            this.ivaDataGridViewTextBoxColumn.Name = "ivaDataGridViewTextBoxColumn";
            this.ivaDataGridViewTextBoxColumn.Width = 50;
            // 
            // iIBBDataGridViewTextBoxColumn
            // 
            this.iIBBDataGridViewTextBoxColumn.DataPropertyName = "IIBB";
            this.iIBBDataGridViewTextBoxColumn.HeaderText = "IIBB";
            this.iIBBDataGridViewTextBoxColumn.Name = "iIBBDataGridViewTextBoxColumn";
            this.iIBBDataGridViewTextBoxColumn.Width = 50;
            // 
            // percepcionesDataGridViewTextBoxColumn
            // 
            this.percepcionesDataGridViewTextBoxColumn.DataPropertyName = "Percepciones";
            this.percepcionesDataGridViewTextBoxColumn.HeaderText = "Percepciones";
            this.percepcionesDataGridViewTextBoxColumn.Name = "percepcionesDataGridViewTextBoxColumn";
            this.percepcionesDataGridViewTextBoxColumn.Width = 80;
            // 
            // otrosGastosDataGridViewTextBoxColumn
            // 
            this.otrosGastosDataGridViewTextBoxColumn.DataPropertyName = "OtrosGastos";
            this.otrosGastosDataGridViewTextBoxColumn.HeaderText = "Otros Gastos";
            this.otrosGastosDataGridViewTextBoxColumn.Name = "otrosGastosDataGridViewTextBoxColumn";
            this.otrosGastosDataGridViewTextBoxColumn.Width = 50;
            // 
            // totalDataGridViewTextBoxColumn
            // 
            this.totalDataGridViewTextBoxColumn.DataPropertyName = "Total";
            this.totalDataGridViewTextBoxColumn.HeaderText = "Total";
            this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            this.totalDataGridViewTextBoxColumn.Width = 50;
            // 
            // estadosDataGridViewTextBoxColumn
            // 
            this.estadosDataGridViewTextBoxColumn.DataPropertyName = "Estados";
            this.estadosDataGridViewTextBoxColumn.HeaderText = "Estados";
            this.estadosDataGridViewTextBoxColumn.Name = "estadosDataGridViewTextBoxColumn";
            // 
            // bindingSourceComprobantes
            // 
            this.bindingSourceComprobantes.AutoCreateObjects = false;
            this.bindingSourceComprobantes.BindableProperties.Add(((System.Core.ComponentModel.BindableProperty)(resources.GetObject("bindingSourceComprobantes.BindableProperties"))));
            this.bindingSourceComprobantes.BindableProperties.Add(((System.Core.ComponentModel.BindableProperty)(resources.GetObject("bindingSourceComprobantes.BindableProperties1"))));
            this.bindingSourceComprobantes.BindableProperties.Add(((System.Core.ComponentModel.BindableProperty)(resources.GetObject("bindingSourceComprobantes.BindableProperties2"))));
            this.bindingSourceComprobantes.BindableProperties.Add(((System.Core.ComponentModel.BindableProperty)(resources.GetObject("bindingSourceComprobantes.BindableProperties3"))));
            this.bindingSourceComprobantes.BindableProperties.Add(((System.Core.ComponentModel.BindableProperty)(resources.GetObject("bindingSourceComprobantes.BindableProperties4"))));
            this.bindingSourceComprobantes.BindableProperties.Add(((System.Core.ComponentModel.BindableProperty)(resources.GetObject("bindingSourceComprobantes.BindableProperties5"))));
            this.bindingSourceComprobantes.BindableProperties.Add(((System.Core.ComponentModel.BindableProperty)(resources.GetObject("bindingSourceComprobantes.BindableProperties6"))));
            this.bindingSourceComprobantes.BindableProperties.Add(((System.Core.ComponentModel.BindableProperty)(resources.GetObject("bindingSourceComprobantes.BindableProperties7"))));
            this.bindingSourceComprobantes.BindableProperties.Add(((System.Core.ComponentModel.BindableProperty)(resources.GetObject("bindingSourceComprobantes.BindableProperties8"))));
            this.bindingSourceComprobantes.BindableProperties.Add(((System.Core.ComponentModel.BindableProperty)(resources.GetObject("bindingSourceComprobantes.BindableProperties9"))));
            this.bindingSourceComprobantes.BindableProperties.Add(((System.Core.ComponentModel.BindableProperty)(resources.GetObject("bindingSourceComprobantes.BindableProperties10"))));
            this.bindingSourceComprobantes.BindableProperties.Add(((System.Core.ComponentModel.BindableProperty)(resources.GetObject("bindingSourceComprobantes.BindableProperties11"))));
            this.bindingSourceComprobantes.BindableProperties.Add(((System.Core.ComponentModel.BindableProperty)(resources.GetObject("bindingSourceComprobantes.BindableProperties12"))));
            this.bindingSourceComprobantes.BindableProperties.Add(((System.Core.ComponentModel.BindableProperty)(resources.GetObject("bindingSourceComprobantes.BindableProperties13"))));
            this.bindingSourceComprobantes.BindableProperties.Add(((System.Core.ComponentModel.BindableProperty)(resources.GetObject("bindingSourceComprobantes.BindableProperties14"))));
            this.bindingSourceComprobantes.DataSource = typeof(Entidades.GetAllComprobantesxFechas_Result);
            // 
            // AdminComprobantesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1243, 531);
            this.Controls.Add(this.groupBoxFiltros);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.metroGridComprobantes);
            this.Controls.Add(this.metroLabel1);
            this.Name = "AdminComprobantesForm";
            this.Resizable = false;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminComprobantesForm_FormClosed);
            this.Load += new System.EventHandler(this.AdminComprobantesForm_Load);
            this.groupBoxFiltros.ResumeLayout(false);
            this.groupBoxFiltros.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGridComprobantes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceComprobantes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.GroupBox groupBoxFiltros;
        private MetroFramework.Controls.MetroTextBox metroTextBoxSucursal;
        private MetroFramework.Controls.MetroTextBox metroTextBoxNoFactura;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkLabel3;
        private System.Windows.Forms.LinkLabel linkLabel4;
        private MetroFramework.Controls.MetroGrid metroGridComprobantes;
        private System.Core.ComponentModel.ObjectBindingSource bindingSourceComprobantes;
        private MetroFramework.Controls.MetroRadioButton metroRadioButtonFacturaFecha;
        private MetroFramework.Controls.MetroRadioButton metroRadioButtonporFecha;
        private MetroFramework.Controls.MetroRadioButton metroRadioButtonProveedor;
        private MetroFramework.Controls.MetroToggle metroToggleFiltro;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox metroTextBoxProveedor;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroDateTime metroDateTimeFechainicio;
        private MetroFramework.Controls.MetroDateTime metroDateTimeFechaFin;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private MetroFramework.Controls.MetroButton metroButtonCreate;
        private System.Windows.Forms.DataGridViewTextBoxColumn idComprobanteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreProveedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoComprobanteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoFacturaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sucursalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noFacturaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn condiciondecompraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn importeNetoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ivaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iIBBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn percepcionesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn otrosGastosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadosDataGridViewTextBoxColumn;
    }
}