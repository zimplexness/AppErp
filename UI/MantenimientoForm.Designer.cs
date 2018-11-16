namespace ErpGestion
{
    partial class MantenimientoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MantenimientoForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroComboBoxActividad = new MetroFramework.Controls.MetroComboBox();
            this.metroComboBoxTaller = new MetroFramework.Controls.MetroComboBox();
            this.metroComboBoxVehiculo = new MetroFramework.Controls.MetroComboBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroButtonAgregarPago = new MetroFramework.Controls.MetroButton();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBoxcomentario = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroDateTimeFECHA = new MetroFramework.Controls.MetroDateTime();
            this.LBLKM = new MetroFramework.Controls.MetroLabel();
            this.metroTextBoxKm = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroGridActividades = new MetroFramework.Controls.MetroGrid();
            this.idDetalleActividadMantenimientoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actividadMantenimientoDetalleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.objectBindingSourceActividadesMantenimiento = new System.Core.ComponentModel.ObjectBindingSource(this.components);
            this.bindingSourceDetalleMantenimiento = new System.Core.ComponentModel.ObjectBindingSource(this.components);
            this.metroGridRepuestos = new MetroFramework.Controls.MetroGrid();
            this.idDetalleMantenimientoRepuestoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.articulosNombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.objectBindingSourceRepuesto = new System.Core.ComponentModel.ObjectBindingSource(this.components);
            this.cantidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.importeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSourceDetalleRepuesto = new System.Core.ComponentModel.ObjectBindingSource(this.components);
            this.metroTextBoxRepuesto = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBoxCant = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBoxPrecio = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.metroTextBoxTotal = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.metroButton4 = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.metroGridActividades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.objectBindingSourceActividadesMantenimiento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceDetalleMantenimiento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroGridRepuestos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.objectBindingSourceRepuesto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceDetalleRepuesto)).BeginInit();
            this.SuspendLayout();
            // 
            // metroComboBoxActividad
            // 
            this.metroComboBoxActividad.FormattingEnabled = true;
            this.metroComboBoxActividad.ItemHeight = 23;
            this.metroComboBoxActividad.Location = new System.Drawing.Point(5, 189);
            this.metroComboBoxActividad.Name = "metroComboBoxActividad";
            this.metroComboBoxActividad.Size = new System.Drawing.Size(283, 29);
            this.metroComboBoxActividad.TabIndex = 6;
            this.metroComboBoxActividad.UseSelectable = true;
            // 
            // metroComboBoxTaller
            // 
            this.metroComboBoxTaller.FormattingEnabled = true;
            this.metroComboBoxTaller.ItemHeight = 23;
            this.metroComboBoxTaller.Location = new System.Drawing.Point(5, 106);
            this.metroComboBoxTaller.Name = "metroComboBoxTaller";
            this.metroComboBoxTaller.Size = new System.Drawing.Size(212, 29);
            this.metroComboBoxTaller.TabIndex = 4;
            this.metroComboBoxTaller.UseSelectable = true;
            this.metroComboBoxTaller.SelectedIndexChanged += new System.EventHandler(this.metroComboBoxTaller_SelectedIndexChanged);
            // 
            // metroComboBoxVehiculo
            // 
            this.metroComboBoxVehiculo.FormattingEnabled = true;
            this.metroComboBoxVehiculo.ItemHeight = 23;
            this.metroComboBoxVehiculo.Location = new System.Drawing.Point(5, 52);
            this.metroComboBoxVehiculo.Name = "metroComboBoxVehiculo";
            this.metroComboBoxVehiculo.Size = new System.Drawing.Size(212, 29);
            this.metroComboBoxVehiculo.TabIndex = 1;
            this.metroComboBoxVehiculo.UseSelectable = true;
            // 
            // metroButton1
            // 
            this.metroButton1.BackgroundImage = global::ErpGestion.Properties.Resources.if_17_330399__1_;
            this.metroButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.metroButton1.Location = new System.Drawing.Point(685, 472);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(49, 46);
            this.metroButton1.TabIndex = 15;
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroButtonAgregarPago
            // 
            this.metroButtonAgregarPago.BackgroundImage = global::ErpGestion.Properties.Resources._1497285414_Checkmark;
            this.metroButtonAgregarPago.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.metroButtonAgregarPago.Location = new System.Drawing.Point(741, 472);
            this.metroButtonAgregarPago.Name = "metroButtonAgregarPago";
            this.metroButtonAgregarPago.Size = new System.Drawing.Size(49, 46);
            this.metroButtonAgregarPago.TabIndex = 14;
            this.metroButtonAgregarPago.UseSelectable = true;
            this.metroButtonAgregarPago.Click += new System.EventHandler(this.metroButtonAgregarPago_Click);
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Location = new System.Drawing.Point(5, 167);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(75, 19);
            this.metroLabel11.TabIndex = 26;
            this.metroLabel11.Text = "ACTIVIDAD";
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(7, 84);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(50, 19);
            this.metroLabel9.TabIndex = 19;
            this.metroLabel9.Text = "TALLER";
            this.metroLabel9.Click += new System.EventHandler(this.metroLabel9_Click);
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(5, 30);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(70, 19);
            this.metroLabel8.TabIndex = 18;
            this.metroLabel8.Text = "VEHICULO";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(223, 84);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(94, 19);
            this.metroLabel7.TabIndex = 17;
            this.metroLabel7.Text = "COMENTARIO";
            // 
            // metroTextBoxcomentario
            // 
            // 
            // 
            // 
            this.metroTextBoxcomentario.CustomButton.Image = null;
            this.metroTextBoxcomentario.CustomButton.Location = new System.Drawing.Point(235, 1);
            this.metroTextBoxcomentario.CustomButton.Name = "";
            this.metroTextBoxcomentario.CustomButton.Size = new System.Drawing.Size(47, 47);
            this.metroTextBoxcomentario.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxcomentario.CustomButton.TabIndex = 1;
            this.metroTextBoxcomentario.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxcomentario.CustomButton.UseSelectable = true;
            this.metroTextBoxcomentario.CustomButton.Visible = false;
            this.metroTextBoxcomentario.Lines = new string[0];
            this.metroTextBoxcomentario.Location = new System.Drawing.Point(223, 106);
            this.metroTextBoxcomentario.MaxLength = 32767;
            this.metroTextBoxcomentario.Multiline = true;
            this.metroTextBoxcomentario.Name = "metroTextBoxcomentario";
            this.metroTextBoxcomentario.PasswordChar = '\0';
            this.metroTextBoxcomentario.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxcomentario.SelectedText = "";
            this.metroTextBoxcomentario.SelectionLength = 0;
            this.metroTextBoxcomentario.SelectionStart = 0;
            this.metroTextBoxcomentario.ShortcutsEnabled = true;
            this.metroTextBoxcomentario.Size = new System.Drawing.Size(283, 49);
            this.metroTextBoxcomentario.TabIndex = 5;
            this.metroTextBoxcomentario.UseSelectable = true;
            this.metroTextBoxcomentario.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxcomentario.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(364, 28);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(50, 19);
            this.metroLabel5.TabIndex = 11;
            this.metroLabel5.Text = "FECHA";
            // 
            // metroDateTimeFECHA
            // 
            this.metroDateTimeFECHA.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.metroDateTimeFECHA.Location = new System.Drawing.Point(364, 50);
            this.metroDateTimeFECHA.MinimumSize = new System.Drawing.Size(0, 29);
            this.metroDateTimeFECHA.Name = "metroDateTimeFECHA";
            this.metroDateTimeFECHA.Size = new System.Drawing.Size(131, 29);
            this.metroDateTimeFECHA.TabIndex = 3;
            // 
            // LBLKM
            // 
            this.LBLKM.AutoSize = true;
            this.LBLKM.Location = new System.Drawing.Point(223, 30);
            this.LBLKM.Name = "LBLKM";
            this.LBLKM.Size = new System.Drawing.Size(28, 19);
            this.LBLKM.TabIndex = 7;
            this.LBLKM.Text = "KM";
            // 
            // metroTextBoxKm
            // 
            // 
            // 
            // 
            this.metroTextBoxKm.CustomButton.Image = null;
            this.metroTextBoxKm.CustomButton.Location = new System.Drawing.Point(103, 1);
            this.metroTextBoxKm.CustomButton.Name = "";
            this.metroTextBoxKm.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.metroTextBoxKm.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxKm.CustomButton.TabIndex = 1;
            this.metroTextBoxKm.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxKm.CustomButton.UseSelectable = true;
            this.metroTextBoxKm.CustomButton.Visible = false;
            this.metroTextBoxKm.Lines = new string[] {
        "0"};
            this.metroTextBoxKm.Location = new System.Drawing.Point(223, 50);
            this.metroTextBoxKm.MaxLength = 11;
            this.metroTextBoxKm.Name = "metroTextBoxKm";
            this.metroTextBoxKm.PasswordChar = '\0';
            this.metroTextBoxKm.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxKm.SelectedText = "";
            this.metroTextBoxKm.SelectionLength = 0;
            this.metroTextBoxKm.SelectionStart = 0;
            this.metroTextBoxKm.ShortcutsEnabled = true;
            this.metroTextBoxKm.Size = new System.Drawing.Size(133, 31);
            this.metroTextBoxKm.TabIndex = 2;
            this.metroTextBoxKm.Text = "0";
            this.metroTextBoxKm.UseSelectable = true;
            this.metroTextBoxKm.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxKm.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(281, 9);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(225, 19);
            this.metroLabel2.TabIndex = 99;
            this.metroLabel2.Text = "FORMULARIO DE MANTENIMIENTO";
            // 
            // metroGridActividades
            // 
            this.metroGridActividades.AllowUserToAddRows = false;
            this.metroGridActividades.AllowUserToOrderColumns = true;
            this.metroGridActividades.AllowUserToResizeRows = false;
            this.metroGridActividades.AutoGenerateColumns = false;
            this.metroGridActividades.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGridActividades.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGridActividades.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGridActividades.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(133)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridActividades.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.metroGridActividades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.metroGridActividades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDetalleActividadMantenimientoDataGridViewTextBoxColumn,
            this.actividadMantenimientoDetalleDataGridViewTextBoxColumn});
            this.metroGridActividades.DataSource = this.bindingSourceDetalleMantenimiento;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(133)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGridActividades.DefaultCellStyle = dataGridViewCellStyle2;
            this.metroGridActividades.EnableHeadersVisualStyles = false;
            this.metroGridActividades.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGridActividades.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGridActividades.Location = new System.Drawing.Point(5, 224);
            this.metroGridActividades.Name = "metroGridActividades";
            this.metroGridActividades.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(133)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridActividades.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.metroGridActividades.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGridActividades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGridActividades.Size = new System.Drawing.Size(440, 100);
            this.metroGridActividades.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroGridActividades.TabIndex = 102;
            this.metroGridActividades.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.metroGridActividades_CellContentDoubleClick);
            // 
            // idDetalleActividadMantenimientoDataGridViewTextBoxColumn
            // 
            this.idDetalleActividadMantenimientoDataGridViewTextBoxColumn.DataPropertyName = "IdDetalleActividadMantenimiento";
            this.idDetalleActividadMantenimientoDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idDetalleActividadMantenimientoDataGridViewTextBoxColumn.Name = "idDetalleActividadMantenimientoDataGridViewTextBoxColumn";
            // 
            // actividadMantenimientoDetalleDataGridViewTextBoxColumn
            // 
            this.actividadMantenimientoDetalleDataGridViewTextBoxColumn.DataPropertyName = "ActividadMantenimiento_Detalle";
            this.actividadMantenimientoDetalleDataGridViewTextBoxColumn.DataSource = this.objectBindingSourceActividadesMantenimiento;
            this.actividadMantenimientoDetalleDataGridViewTextBoxColumn.DisplayMember = "Detalle";
            this.actividadMantenimientoDetalleDataGridViewTextBoxColumn.HeaderText = "ActividadMantenimiento";
            this.actividadMantenimientoDetalleDataGridViewTextBoxColumn.Name = "actividadMantenimientoDetalleDataGridViewTextBoxColumn";
            this.actividadMantenimientoDetalleDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.actividadMantenimientoDetalleDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.actividadMantenimientoDetalleDataGridViewTextBoxColumn.Width = 200;
            // 
            // objectBindingSourceActividadesMantenimiento
            // 
            this.objectBindingSourceActividadesMantenimiento.AutoCreateObjects = false;
            this.objectBindingSourceActividadesMantenimiento.DataSource = typeof(Entidades.ActividadMantenimiento);
            // 
            // bindingSourceDetalleMantenimiento
            // 
            this.bindingSourceDetalleMantenimiento.AutoCreateObjects = false;
            this.bindingSourceDetalleMantenimiento.BindableProperties.Add(((System.Core.ComponentModel.BindableProperty)(resources.GetObject("bindingSourceDetalleMantenimiento.BindableProperties"))));
            this.bindingSourceDetalleMantenimiento.BindableProperties.Add(((System.Core.ComponentModel.BindableProperty)(resources.GetObject("bindingSourceDetalleMantenimiento.BindableProperties1"))));
            this.bindingSourceDetalleMantenimiento.DataSource = typeof(Entidades.DetalleActividadMantenimiento);
            // 
            // metroGridRepuestos
            // 
            this.metroGridRepuestos.AllowUserToAddRows = false;
            this.metroGridRepuestos.AllowUserToOrderColumns = true;
            this.metroGridRepuestos.AllowUserToResizeRows = false;
            this.metroGridRepuestos.AutoGenerateColumns = false;
            this.metroGridRepuestos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGridRepuestos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGridRepuestos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGridRepuestos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(133)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridRepuestos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.metroGridRepuestos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.metroGridRepuestos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDetalleMantenimientoRepuestoDataGridViewTextBoxColumn,
            this.articulosNombreDataGridViewTextBoxColumn,
            this.cantidadDataGridViewTextBoxColumn,
            this.precioDataGridViewTextBoxColumn,
            this.importeDataGridViewTextBoxColumn});
            this.metroGridRepuestos.DataSource = this.bindingSourceDetalleRepuesto;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(133)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGridRepuestos.DefaultCellStyle = dataGridViewCellStyle5;
            this.metroGridRepuestos.EnableHeadersVisualStyles = false;
            this.metroGridRepuestos.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGridRepuestos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGridRepuestos.Location = new System.Drawing.Point(5, 386);
            this.metroGridRepuestos.Name = "metroGridRepuestos";
            this.metroGridRepuestos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(133)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridRepuestos.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.metroGridRepuestos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGridRepuestos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGridRepuestos.Size = new System.Drawing.Size(659, 125);
            this.metroGridRepuestos.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroGridRepuestos.TabIndex = 105;
            this.metroGridRepuestos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.metroGrid1_CellContentClick);
            this.metroGridRepuestos.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.metroGrid1_CellLeave);
            // 
            // idDetalleMantenimientoRepuestoDataGridViewTextBoxColumn
            // 
            this.idDetalleMantenimientoRepuestoDataGridViewTextBoxColumn.DataPropertyName = "IdDetalleMantenimientoRepuesto";
            this.idDetalleMantenimientoRepuestoDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idDetalleMantenimientoRepuestoDataGridViewTextBoxColumn.Name = "idDetalleMantenimientoRepuestoDataGridViewTextBoxColumn";
            this.idDetalleMantenimientoRepuestoDataGridViewTextBoxColumn.Width = 70;
            // 
            // articulosNombreDataGridViewTextBoxColumn
            // 
            this.articulosNombreDataGridViewTextBoxColumn.DataPropertyName = "Articulos_Nombre";
            this.articulosNombreDataGridViewTextBoxColumn.DataSource = this.objectBindingSourceRepuesto;
            this.articulosNombreDataGridViewTextBoxColumn.DisplayMember = "Nombre";
            this.articulosNombreDataGridViewTextBoxColumn.HeaderText = "Repuesto";
            this.articulosNombreDataGridViewTextBoxColumn.Name = "articulosNombreDataGridViewTextBoxColumn";
            this.articulosNombreDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.articulosNombreDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.articulosNombreDataGridViewTextBoxColumn.Width = 200;
            // 
            // objectBindingSourceRepuesto
            // 
            this.objectBindingSourceRepuesto.AutoCreateObjects = false;
            this.objectBindingSourceRepuesto.DataSource = typeof(Entidades.Articulos);
            // 
            // cantidadDataGridViewTextBoxColumn
            // 
            this.cantidadDataGridViewTextBoxColumn.DataPropertyName = "Cantidad";
            this.cantidadDataGridViewTextBoxColumn.HeaderText = "Cantidad";
            this.cantidadDataGridViewTextBoxColumn.Name = "cantidadDataGridViewTextBoxColumn";
            // 
            // precioDataGridViewTextBoxColumn
            // 
            this.precioDataGridViewTextBoxColumn.DataPropertyName = "Precio";
            this.precioDataGridViewTextBoxColumn.HeaderText = "Precio";
            this.precioDataGridViewTextBoxColumn.Name = "precioDataGridViewTextBoxColumn";
            // 
            // importeDataGridViewTextBoxColumn
            // 
            this.importeDataGridViewTextBoxColumn.DataPropertyName = "Importe";
            this.importeDataGridViewTextBoxColumn.HeaderText = "Importe";
            this.importeDataGridViewTextBoxColumn.Name = "importeDataGridViewTextBoxColumn";
            // 
            // bindingSourceDetalleRepuesto
            // 
            this.bindingSourceDetalleRepuesto.AutoCreateObjects = false;
            this.bindingSourceDetalleRepuesto.BindableProperties.Add(((System.Core.ComponentModel.BindableProperty)(resources.GetObject("bindingSourceDetalleRepuesto.BindableProperties"))));
            this.bindingSourceDetalleRepuesto.BindableProperties.Add(((System.Core.ComponentModel.BindableProperty)(resources.GetObject("bindingSourceDetalleRepuesto.BindableProperties1"))));
            this.bindingSourceDetalleRepuesto.BindableProperties.Add(((System.Core.ComponentModel.BindableProperty)(resources.GetObject("bindingSourceDetalleRepuesto.BindableProperties2"))));
            this.bindingSourceDetalleRepuesto.BindableProperties.Add(((System.Core.ComponentModel.BindableProperty)(resources.GetObject("bindingSourceDetalleRepuesto.BindableProperties3"))));
            this.bindingSourceDetalleRepuesto.BindableProperties.Add(((System.Core.ComponentModel.BindableProperty)(resources.GetObject("bindingSourceDetalleRepuesto.BindableProperties4"))));
            this.bindingSourceDetalleRepuesto.DataSource = typeof(Entidades.DetalleMantenimientoRepuestos);
            // 
            // metroTextBoxRepuesto
            // 
            // 
            // 
            // 
            this.metroTextBoxRepuesto.CustomButton.Image = null;
            this.metroTextBoxRepuesto.CustomButton.Location = new System.Drawing.Point(275, 1);
            this.metroTextBoxRepuesto.CustomButton.Name = "";
            this.metroTextBoxRepuesto.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.metroTextBoxRepuesto.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxRepuesto.CustomButton.TabIndex = 1;
            this.metroTextBoxRepuesto.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxRepuesto.CustomButton.UseSelectable = true;
            this.metroTextBoxRepuesto.CustomButton.Visible = false;
            this.metroTextBoxRepuesto.Lines = new string[0];
            this.metroTextBoxRepuesto.Location = new System.Drawing.Point(7, 349);
            this.metroTextBoxRepuesto.MaxLength = 11;
            this.metroTextBoxRepuesto.Name = "metroTextBoxRepuesto";
            this.metroTextBoxRepuesto.PasswordChar = '\0';
            this.metroTextBoxRepuesto.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxRepuesto.SelectedText = "";
            this.metroTextBoxRepuesto.SelectionLength = 0;
            this.metroTextBoxRepuesto.SelectionStart = 0;
            this.metroTextBoxRepuesto.ShortcutsEnabled = true;
            this.metroTextBoxRepuesto.Size = new System.Drawing.Size(305, 31);
            this.metroTextBoxRepuesto.TabIndex = 8;
            this.metroTextBoxRepuesto.UseSelectable = true;
            this.metroTextBoxRepuesto.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxRepuesto.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(5, 327);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(63, 19);
            this.metroLabel4.TabIndex = 104;
            this.metroLabel4.Text = "Repuesto";
            // 
            // metroTextBoxCant
            // 
            // 
            // 
            // 
            this.metroTextBoxCant.CustomButton.Image = null;
            this.metroTextBoxCant.CustomButton.Location = new System.Drawing.Point(45, 1);
            this.metroTextBoxCant.CustomButton.Name = "";
            this.metroTextBoxCant.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.metroTextBoxCant.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxCant.CustomButton.TabIndex = 1;
            this.metroTextBoxCant.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxCant.CustomButton.UseSelectable = true;
            this.metroTextBoxCant.CustomButton.Visible = false;
            this.metroTextBoxCant.Lines = new string[0];
            this.metroTextBoxCant.Location = new System.Drawing.Point(318, 349);
            this.metroTextBoxCant.MaxLength = 11;
            this.metroTextBoxCant.Name = "metroTextBoxCant";
            this.metroTextBoxCant.PasswordChar = '\0';
            this.metroTextBoxCant.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxCant.SelectedText = "";
            this.metroTextBoxCant.SelectionLength = 0;
            this.metroTextBoxCant.SelectionStart = 0;
            this.metroTextBoxCant.ShortcutsEnabled = true;
            this.metroTextBoxCant.Size = new System.Drawing.Size(75, 31);
            this.metroTextBoxCant.TabIndex = 9;
            this.metroTextBoxCant.UseSelectable = true;
            this.metroTextBoxCant.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxCant.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(323, 327);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(62, 19);
            this.metroLabel6.TabIndex = 107;
            this.metroLabel6.Text = "Cantidad";
            // 
            // metroTextBoxPrecio
            // 
            // 
            // 
            // 
            this.metroTextBoxPrecio.CustomButton.Image = null;
            this.metroTextBoxPrecio.CustomButton.Location = new System.Drawing.Point(34, 1);
            this.metroTextBoxPrecio.CustomButton.Name = "";
            this.metroTextBoxPrecio.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.metroTextBoxPrecio.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxPrecio.CustomButton.TabIndex = 1;
            this.metroTextBoxPrecio.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxPrecio.CustomButton.UseSelectable = true;
            this.metroTextBoxPrecio.CustomButton.Visible = false;
            this.metroTextBoxPrecio.Lines = new string[0];
            this.metroTextBoxPrecio.Location = new System.Drawing.Point(397, 349);
            this.metroTextBoxPrecio.MaxLength = 11;
            this.metroTextBoxPrecio.Name = "metroTextBoxPrecio";
            this.metroTextBoxPrecio.PasswordChar = '\0';
            this.metroTextBoxPrecio.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxPrecio.SelectedText = "";
            this.metroTextBoxPrecio.SelectionLength = 0;
            this.metroTextBoxPrecio.SelectionStart = 0;
            this.metroTextBoxPrecio.ShortcutsEnabled = true;
            this.metroTextBoxPrecio.Size = new System.Drawing.Size(64, 31);
            this.metroTextBoxPrecio.TabIndex = 10;
            this.metroTextBoxPrecio.UseSelectable = true;
            this.metroTextBoxPrecio.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxPrecio.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(399, 327);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(46, 19);
            this.metroLabel10.TabIndex = 109;
            this.metroLabel10.Text = "Precio";
            // 
            // metroButton2
            // 
            this.metroButton2.BackgroundImage = global::ErpGestion.Properties.Resources._1497285414_Checkmark;
            this.metroButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.metroButton2.Location = new System.Drawing.Point(467, 340);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(39, 40);
            this.metroButton2.TabIndex = 12;
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // metroButton3
            // 
            this.metroButton3.BackgroundImage = global::ErpGestion.Properties.Resources.if_17_330399__1_;
            this.metroButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.metroButton3.Location = new System.Drawing.Point(512, 340);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(36, 40);
            this.metroButton3.TabIndex = 113;
            this.metroButton3.UseSelectable = true;
            // 
            // metroTextBoxTotal
            // 
            // 
            // 
            // 
            this.metroTextBoxTotal.CustomButton.Image = null;
            this.metroTextBoxTotal.CustomButton.Location = new System.Drawing.Point(54, 1);
            this.metroTextBoxTotal.CustomButton.Name = "";
            this.metroTextBoxTotal.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.metroTextBoxTotal.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxTotal.CustomButton.TabIndex = 1;
            this.metroTextBoxTotal.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxTotal.CustomButton.UseSelectable = true;
            this.metroTextBoxTotal.CustomButton.Visible = false;
            this.metroTextBoxTotal.Lines = new string[] {
        "0"};
            this.metroTextBoxTotal.Location = new System.Drawing.Point(685, 406);
            this.metroTextBoxTotal.MaxLength = 11;
            this.metroTextBoxTotal.Name = "metroTextBoxTotal";
            this.metroTextBoxTotal.PasswordChar = '\0';
            this.metroTextBoxTotal.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxTotal.SelectedText = "";
            this.metroTextBoxTotal.SelectionLength = 0;
            this.metroTextBoxTotal.SelectionStart = 0;
            this.metroTextBoxTotal.ShortcutsEnabled = true;
            this.metroTextBoxTotal.Size = new System.Drawing.Size(84, 31);
            this.metroTextBoxTotal.TabIndex = 13;
            this.metroTextBoxTotal.Text = "0";
            this.metroTextBoxTotal.UseSelectable = true;
            this.metroTextBoxTotal.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxTotal.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel13
            // 
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.Location = new System.Drawing.Point(685, 386);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(36, 19);
            this.metroLabel13.TabIndex = 115;
            this.metroLabel13.Text = "Total";
            // 
            // metroButton4
            // 
            this.metroButton4.BackgroundImage = global::ErpGestion.Properties.Resources.if_flat_style_circle_add_1312548;
            this.metroButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.metroButton4.Location = new System.Drawing.Point(294, 189);
            this.metroButton4.Name = "metroButton4";
            this.metroButton4.Size = new System.Drawing.Size(32, 29);
            this.metroButton4.TabIndex = 7;
            this.metroButton4.UseSelectable = true;
            this.metroButton4.Click += new System.EventHandler(this.metroButton4_Click);
            // 
            // MantenimientoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 523);
            this.Controls.Add(this.metroButton4);
            this.Controls.Add(this.metroTextBoxTotal);
            this.Controls.Add(this.metroLabel13);
            this.Controls.Add(this.metroButton3);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.metroTextBoxPrecio);
            this.Controls.Add(this.metroLabel10);
            this.Controls.Add(this.metroTextBoxCant);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroGridRepuestos);
            this.Controls.Add(this.metroTextBoxRepuesto);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroGridActividades);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.metroTextBoxKm);
            this.Controls.Add(this.LBLKM);
            this.Controls.Add(this.metroComboBoxActividad);
            this.Controls.Add(this.metroDateTimeFECHA);
            this.Controls.Add(this.metroComboBoxTaller);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroComboBoxVehiculo);
            this.Controls.Add(this.metroTextBoxcomentario);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.metroButtonAgregarPago);
            this.Controls.Add(this.metroLabel9);
            this.Controls.Add(this.metroLabel11);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.Name = "MantenimientoForm";
            this.Padding = new System.Windows.Forms.Padding(23, 78, 23, 26);
            this.Resizable = false;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MantenimientoForm_FormClosed);
            this.Load += new System.EventHandler(this.MantenimientoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroGridActividades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.objectBindingSourceActividadesMantenimiento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceDetalleMantenimiento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroGridRepuestos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.objectBindingSourceRepuesto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceDetalleRepuesto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroComboBox metroComboBoxActividad;
        private MetroFramework.Controls.MetroComboBox metroComboBoxTaller;
        private MetroFramework.Controls.MetroComboBox metroComboBoxVehiculo;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton metroButtonAgregarPago;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroTextBox metroTextBoxcomentario;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroDateTime metroDateTimeFECHA;
        private MetroFramework.Controls.MetroLabel LBLKM;
        private MetroFramework.Controls.MetroTextBox metroTextBoxKm;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroGrid metroGridActividades;
        private MetroFramework.Controls.MetroGrid metroGridRepuestos;
        private MetroFramework.Controls.MetroTextBox metroTextBoxRepuesto;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox metroTextBoxCant;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox metroTextBoxPrecio;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroButton metroButton3;
        private MetroFramework.Controls.MetroTextBox metroTextBoxTotal;
        private MetroFramework.Controls.MetroLabel metroLabel13;
        private System.Core.ComponentModel.ObjectBindingSource bindingSourceDetalleMantenimiento;
        private System.Core.ComponentModel.ObjectBindingSource bindingSourceDetalleRepuesto;
        private MetroFramework.Controls.MetroButton metroButton4;
        private System.Core.ComponentModel.ObjectBindingSource objectBindingSourceActividadesMantenimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDetalleActividadMantenimientoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn actividadMantenimientoDetalleDataGridViewTextBoxColumn;
        private System.Core.ComponentModel.ObjectBindingSource objectBindingSourceRepuesto;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDetalleMantenimientoRepuestoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn articulosNombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn importeDataGridViewTextBoxColumn;
    }
}