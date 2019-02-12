namespace ErpGestion
{
    partial class AdminProveedorFrm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBoxFilterInfo = new System.Windows.Forms.GroupBox();
            this.metroTextBoxNombre = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel16 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBoxFilterRazon = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel15 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBoxCuit = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBoxFilterRubro = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.metroCheckBoxCuentas = new MetroFramework.Controls.MetroCheckBox();
            this.metroGridProveedores = new MetroFramework.Controls.MetroGrid();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Razon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cuit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IngresosBrutos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaIngreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Provincia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Localidades = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rubro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proveedoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.metroToggleFiltro = new MetroFramework.Controls.MetroToggle();
            this.linkLabel4 = new System.Windows.Forms.LinkLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroTile4 = new MetroFramework.Controls.MetroTile();
            this.metroTile5 = new MetroFramework.Controls.MetroTile();
            this.metroTile6 = new MetroFramework.Controls.MetroTile();
            this.groupBoxFilterInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGridProveedores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedoresBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxFilterInfo
            // 
            this.groupBoxFilterInfo.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBoxFilterInfo.Controls.Add(this.metroTextBoxNombre);
            this.groupBoxFilterInfo.Controls.Add(this.metroLabel16);
            this.groupBoxFilterInfo.Controls.Add(this.metroTextBoxFilterRazon);
            this.groupBoxFilterInfo.Controls.Add(this.metroLabel1);
            this.groupBoxFilterInfo.Controls.Add(this.metroLabel15);
            this.groupBoxFilterInfo.Controls.Add(this.metroTextBoxCuit);
            this.groupBoxFilterInfo.Controls.Add(this.metroTextBoxFilterRubro);
            this.groupBoxFilterInfo.Controls.Add(this.metroLabel10);
            this.groupBoxFilterInfo.Location = new System.Drawing.Point(349, 52);
            this.groupBoxFilterInfo.Name = "groupBoxFilterInfo";
            this.groupBoxFilterInfo.Size = new System.Drawing.Size(823, 69);
            this.groupBoxFilterInfo.TabIndex = 35;
            this.groupBoxFilterInfo.TabStop = false;
            this.groupBoxFilterInfo.Text = "FILTROS";
            this.groupBoxFilterInfo.Visible = false;
            // 
            // metroTextBoxNombre
            // 
            // 
            // 
            // 
            this.metroTextBoxNombre.CustomButton.Image = null;
            this.metroTextBoxNombre.CustomButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.metroTextBoxNombre.CustomButton.Location = new System.Drawing.Point(172, 1);
            this.metroTextBoxNombre.CustomButton.Name = "";
            this.metroTextBoxNombre.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.metroTextBoxNombre.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxNombre.CustomButton.TabIndex = 1;
            this.metroTextBoxNombre.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxNombre.CustomButton.UseSelectable = true;
            this.metroTextBoxNombre.CustomButton.Visible = false;
            this.metroTextBoxNombre.Lines = new string[0];
            this.metroTextBoxNombre.Location = new System.Drawing.Point(6, 35);
            this.metroTextBoxNombre.MaxLength = 32767;
            this.metroTextBoxNombre.Name = "metroTextBoxNombre";
            this.metroTextBoxNombre.PasswordChar = '\0';
            this.metroTextBoxNombre.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxNombre.SelectedText = "";
            this.metroTextBoxNombre.SelectionLength = 0;
            this.metroTextBoxNombre.SelectionStart = 0;
            this.metroTextBoxNombre.ShortcutsEnabled = true;
            this.metroTextBoxNombre.Size = new System.Drawing.Size(198, 27);
            this.metroTextBoxNombre.TabIndex = 16;
            this.metroTextBoxNombre.UseSelectable = true;
            this.metroTextBoxNombre.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxNombre.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.metroTextBoxNombre.TextChanged += new System.EventHandler(this.metroTextBoxNombre_TextChanged);
            // 
            // metroLabel16
            // 
            this.metroLabel16.AutoSize = true;
            this.metroLabel16.Location = new System.Drawing.Point(6, 13);
            this.metroLabel16.Name = "metroLabel16";
            this.metroLabel16.Size = new System.Drawing.Size(69, 19);
            this.metroLabel16.TabIndex = 17;
            this.metroLabel16.Text = "NOMBRE ";
            // 
            // metroTextBoxFilterRazon
            // 
            // 
            // 
            // 
            this.metroTextBoxFilterRazon.CustomButton.Image = null;
            this.metroTextBoxFilterRazon.CustomButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.metroTextBoxFilterRazon.CustomButton.Location = new System.Drawing.Point(172, 1);
            this.metroTextBoxFilterRazon.CustomButton.Name = "";
            this.metroTextBoxFilterRazon.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.metroTextBoxFilterRazon.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxFilterRazon.CustomButton.TabIndex = 1;
            this.metroTextBoxFilterRazon.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxFilterRazon.CustomButton.UseSelectable = true;
            this.metroTextBoxFilterRazon.CustomButton.Visible = false;
            this.metroTextBoxFilterRazon.Lines = new string[0];
            this.metroTextBoxFilterRazon.Location = new System.Drawing.Point(207, 35);
            this.metroTextBoxFilterRazon.MaxLength = 32767;
            this.metroTextBoxFilterRazon.Name = "metroTextBoxFilterRazon";
            this.metroTextBoxFilterRazon.PasswordChar = '\0';
            this.metroTextBoxFilterRazon.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxFilterRazon.SelectedText = "";
            this.metroTextBoxFilterRazon.SelectionLength = 0;
            this.metroTextBoxFilterRazon.SelectionStart = 0;
            this.metroTextBoxFilterRazon.ShortcutsEnabled = true;
            this.metroTextBoxFilterRazon.Size = new System.Drawing.Size(198, 27);
            this.metroTextBoxFilterRazon.TabIndex = 18;
            this.metroTextBoxFilterRazon.UseSelectable = true;
            this.metroTextBoxFilterRazon.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxFilterRazon.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.metroTextBoxFilterRazon.TextChanged += new System.EventHandler(this.metroTextBoxFilterRazon_TextChanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(408, 13);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(37, 19);
            this.metroLabel1.TabIndex = 32;
            this.metroLabel1.Text = "CUIT";
            // 
            // metroLabel15
            // 
            this.metroLabel15.AutoSize = true;
            this.metroLabel15.Location = new System.Drawing.Point(207, 13);
            this.metroLabel15.Name = "metroLabel15";
            this.metroLabel15.Size = new System.Drawing.Size(105, 19);
            this.metroLabel15.TabIndex = 19;
            this.metroLabel15.Text = "RAZON SOCIAL";
            // 
            // metroTextBoxCuit
            // 
            // 
            // 
            // 
            this.metroTextBoxCuit.CustomButton.Image = null;
            this.metroTextBoxCuit.CustomButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.metroTextBoxCuit.CustomButton.Location = new System.Drawing.Point(103, 1);
            this.metroTextBoxCuit.CustomButton.Name = "";
            this.metroTextBoxCuit.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.metroTextBoxCuit.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxCuit.CustomButton.TabIndex = 1;
            this.metroTextBoxCuit.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxCuit.CustomButton.UseSelectable = true;
            this.metroTextBoxCuit.CustomButton.Visible = false;
            this.metroTextBoxCuit.Lines = new string[0];
            this.metroTextBoxCuit.Location = new System.Drawing.Point(408, 35);
            this.metroTextBoxCuit.MaxLength = 32767;
            this.metroTextBoxCuit.Name = "metroTextBoxCuit";
            this.metroTextBoxCuit.PasswordChar = '\0';
            this.metroTextBoxCuit.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxCuit.SelectedText = "";
            this.metroTextBoxCuit.SelectionLength = 0;
            this.metroTextBoxCuit.SelectionStart = 0;
            this.metroTextBoxCuit.ShortcutsEnabled = true;
            this.metroTextBoxCuit.Size = new System.Drawing.Size(129, 27);
            this.metroTextBoxCuit.TabIndex = 31;
            this.metroTextBoxCuit.UseSelectable = true;
            this.metroTextBoxCuit.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxCuit.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.metroTextBoxCuit.TextChanged += new System.EventHandler(this.metroTextBoxCuit_TextChanged);
            // 
            // metroTextBoxFilterRubro
            // 
            // 
            // 
            // 
            this.metroTextBoxFilterRubro.CustomButton.Image = null;
            this.metroTextBoxFilterRubro.CustomButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.metroTextBoxFilterRubro.CustomButton.Location = new System.Drawing.Point(252, 1);
            this.metroTextBoxFilterRubro.CustomButton.Name = "";
            this.metroTextBoxFilterRubro.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.metroTextBoxFilterRubro.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxFilterRubro.CustomButton.TabIndex = 1;
            this.metroTextBoxFilterRubro.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxFilterRubro.CustomButton.UseSelectable = true;
            this.metroTextBoxFilterRubro.CustomButton.Visible = false;
            this.metroTextBoxFilterRubro.Lines = new string[0];
            this.metroTextBoxFilterRubro.Location = new System.Drawing.Point(543, 35);
            this.metroTextBoxFilterRubro.MaxLength = 32767;
            this.metroTextBoxFilterRubro.Name = "metroTextBoxFilterRubro";
            this.metroTextBoxFilterRubro.PasswordChar = '\0';
            this.metroTextBoxFilterRubro.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxFilterRubro.SelectedText = "";
            this.metroTextBoxFilterRubro.SelectionLength = 0;
            this.metroTextBoxFilterRubro.SelectionStart = 0;
            this.metroTextBoxFilterRubro.ShortcutsEnabled = true;
            this.metroTextBoxFilterRubro.Size = new System.Drawing.Size(278, 27);
            this.metroTextBoxFilterRubro.TabIndex = 20;
            this.metroTextBoxFilterRubro.UseSelectable = true;
            this.metroTextBoxFilterRubro.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxFilterRubro.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.metroTextBoxFilterRubro.TextChanged += new System.EventHandler(this.metroTextBoxFilterRubro_TextChanged);
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(538, 13);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(60, 19);
            this.metroLabel10.TabIndex = 21;
            this.metroLabel10.Text = "RUBROS";
            // 
            // metroCheckBoxCuentas
            // 
            this.metroCheckBoxCuentas.AutoSize = true;
            this.metroCheckBoxCuentas.Location = new System.Drawing.Point(6, 116);
            this.metroCheckBoxCuentas.Name = "metroCheckBoxCuentas";
            this.metroCheckBoxCuentas.Size = new System.Drawing.Size(250, 15);
            this.metroCheckBoxCuentas.TabIndex = 33;
            this.metroCheckBoxCuentas.Text = "PROVEEDORES CON CUENTA CORRIENTES";
            this.metroCheckBoxCuentas.UseSelectable = true;
            this.metroCheckBoxCuentas.CheckedChanged += new System.EventHandler(this.metroCheckBox1_CheckedChanged);
            // 
            // metroGridProveedores
            // 
            this.metroGridProveedores.AllowUserToResizeRows = false;
            this.metroGridProveedores.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGridProveedores.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGridProveedores.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGridProveedores.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(133)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridProveedores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.metroGridProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.metroGridProveedores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Razon,
            this.Cuit,
            this.IngresosBrutos,
            this.Direccion,
            this.Telefono,
            this.FechaIngreso,
            this.Provincia,
            this.Localidades,
            this.Rubro});
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(133)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGridProveedores.DefaultCellStyle = dataGridViewCellStyle17;
            this.metroGridProveedores.EnableHeadersVisualStyles = false;
            this.metroGridProveedores.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGridProveedores.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGridProveedores.Location = new System.Drawing.Point(6, 137);
            this.metroGridProveedores.Name = "metroGridProveedores";
            this.metroGridProveedores.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(133)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridProveedores.RowHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.metroGridProveedores.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGridProveedores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGridProveedores.Size = new System.Drawing.Size(1201, 505);
            this.metroGridProveedores.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroGridProveedores.TabIndex = 33;
            this.metroGridProveedores.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.metroGridProveedores_CellContentDoubleClick);
            this.metroGridProveedores.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.metroGridProveedores_CellDoubleClick);
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 200;
            // 
            // Razon
            // 
            this.Razon.HeaderText = "Razon";
            this.Razon.Name = "Razon";
            this.Razon.Width = 200;
            // 
            // Cuit
            // 
            this.Cuit.HeaderText = "Cuit";
            this.Cuit.Name = "Cuit";
            this.Cuit.Width = 70;
            // 
            // IngresosBrutos
            // 
            this.IngresosBrutos.HeaderText = "IIBB";
            this.IngresosBrutos.Name = "IngresosBrutos";
            this.IngresosBrutos.Width = 70;
            // 
            // Direccion
            // 
            this.Direccion.HeaderText = "Direcciòn";
            this.Direccion.Name = "Direccion";
            this.Direccion.Width = 200;
            // 
            // Telefono
            // 
            this.Telefono.HeaderText = "Telèfono";
            this.Telefono.Name = "Telefono";
            this.Telefono.Width = 70;
            // 
            // FechaIngreso
            // 
            this.FechaIngreso.HeaderText = "Fecha Ingreso";
            this.FechaIngreso.Name = "FechaIngreso";
            this.FechaIngreso.Width = 60;
            // 
            // Provincia
            // 
            this.Provincia.HeaderText = "Provincia";
            this.Provincia.Name = "Provincia";
            // 
            // Localidades
            // 
            this.Localidades.HeaderText = "Localidad";
            this.Localidades.Name = "Localidades";
            // 
            // Rubro
            // 
            this.Rubro.HeaderText = "Rubro";
            this.Rubro.Name = "Rubro";
            this.Rubro.Width = 200;
            // 
            // proveedoresBindingSource
            // 
            this.proveedoresBindingSource.DataSource = typeof(Entidades.Proveedores);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox2.Controls.Add(this.metroTile4);
            this.groupBox2.Controls.Add(this.metroTile5);
            this.groupBox2.Controls.Add(this.metroToggleFiltro);
            this.groupBox2.Controls.Add(this.metroTile6);
            this.groupBox2.Controls.Add(this.linkLabel4);
            this.groupBox2.Location = new System.Drawing.Point(6, 52);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(337, 58);
            this.groupBox2.TabIndex = 38;
            this.groupBox2.TabStop = false;
            // 
            // metroToggleFiltro
            // 
            this.metroToggleFiltro.AutoSize = true;
            this.metroToggleFiltro.Location = new System.Drawing.Point(249, 33);
            this.metroToggleFiltro.Name = "metroToggleFiltro";
            this.metroToggleFiltro.Size = new System.Drawing.Size(80, 19);
            this.metroToggleFiltro.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroToggleFiltro.TabIndex = 40;
            this.metroToggleFiltro.Text = "Off";
            this.metroToggleFiltro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroToggleFiltro.UseSelectable = true;
            this.metroToggleFiltro.CheckedChanged += new System.EventHandler(this.metroToggleFiltro_CheckedChanged);
            // 
            // linkLabel4
            // 
            this.linkLabel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.linkLabel4.AutoSize = true;
            this.linkLabel4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.linkLabel4.LinkColor = System.Drawing.Color.Teal;
            this.linkLabel4.Location = new System.Drawing.Point(284, 13);
            this.linkLabel4.Name = "linkLabel4";
            this.linkLabel4.Size = new System.Drawing.Size(45, 15);
            this.linkLabel4.TabIndex = 41;
            this.linkLabel4.TabStop = true;
            this.linkLabel4.Text = "FILTRO";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(6, 30);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(234, 19);
            this.metroLabel2.TabIndex = 39;
            this.metroLabel2.Text = "ADMINISTRACION DE PROVEEDORES";
            // 
            // metroTile4
            // 
            this.metroTile4.ActiveControl = null;
            this.metroTile4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.metroTile4.Location = new System.Drawing.Point(6, 13);
            this.metroTile4.Name = "metroTile4";
            this.metroTile4.Size = new System.Drawing.Size(75, 39);
            this.metroTile4.TabIndex = 57;
            this.metroTile4.Text = "NUEVO";
            this.metroTile4.TileImage = global::ErpGestion.Properties.Resources.iconfinder_circle_add_226591;
            this.metroTile4.TileImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.metroTile4.TileTextFontSize = MetroFramework.MetroTileTextSize.Small;
            this.metroTile4.UseSelectable = true;
            this.metroTile4.UseTileImage = true;
            this.metroTile4.Click += new System.EventHandler(this.metroTile4_Click);
            // 
            // metroTile5
            // 
            this.metroTile5.ActiveControl = null;
            this.metroTile5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.metroTile5.Location = new System.Drawing.Point(168, 12);
            this.metroTile5.Name = "metroTile5";
            this.metroTile5.Size = new System.Drawing.Size(83, 39);
            this.metroTile5.Style = MetroFramework.MetroColorStyle.Red;
            this.metroTile5.TabIndex = 59;
            this.metroTile5.Text = "ELIMINAR";
            this.metroTile5.TileImage = global::ErpGestion.Properties.Resources.iconfinder_trash_227551;
            this.metroTile5.TileImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.metroTile5.TileTextFontSize = MetroFramework.MetroTileTextSize.Small;
            this.metroTile5.UseSelectable = true;
            this.metroTile5.UseTileImage = true;
            this.metroTile5.Click += new System.EventHandler(this.metroTile5_Click);
            // 
            // metroTile6
            // 
            this.metroTile6.ActiveControl = null;
            this.metroTile6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.metroTile6.Location = new System.Drawing.Point(87, 13);
            this.metroTile6.Name = "metroTile6";
            this.metroTile6.Size = new System.Drawing.Size(75, 39);
            this.metroTile6.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroTile6.TabIndex = 58;
            this.metroTile6.Text = "EDITAR";
            this.metroTile6.TileImage = global::ErpGestion.Properties.Resources.iconfinder_edit_3_3324936;
            this.metroTile6.TileImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.metroTile6.TileTextFontSize = MetroFramework.MetroTileTextSize.Small;
            this.metroTile6.UseSelectable = true;
            this.metroTile6.UseTileImage = true;
            this.metroTile6.Click += new System.EventHandler(this.metroTile6_Click);
            // 
            // AdminProveedorFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1212, 690);
            this.Controls.Add(this.metroCheckBoxCuentas);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroGridProveedores);
            this.Controls.Add(this.groupBoxFilterInfo);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AdminProveedorFrm";
            this.Padding = new System.Windows.Forms.Padding(23, 69, 23, 23);
            this.Resizable = false;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminProveedorFrm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminProveedorFrm_FormClosed);
            this.Load += new System.EventHandler(this.ProveedoresForm_Load);
            this.groupBoxFilterInfo.ResumeLayout(false);
            this.groupBoxFilterInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGridProveedores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedoresBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroTextBox metroTextBoxFilterRubro;
        private MetroFramework.Controls.MetroLabel metroLabel15;
        private MetroFramework.Controls.MetroTextBox metroTextBoxFilterRazon;
        private MetroFramework.Controls.MetroLabel metroLabel16;
        private MetroFramework.Controls.MetroTextBox metroTextBoxNombre;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox metroTextBoxCuit;
        private System.Windows.Forms.BindingSource proveedoresBindingSource;
        private System.Windows.Forms.GroupBox groupBoxFilterInfo;
        private MetroFramework.Controls.MetroGrid metroGridProveedores;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Razon;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cuit;
        private System.Windows.Forms.DataGridViewTextBoxColumn IngresosBrutos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaIngreso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Provincia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Localidades;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rubro;
        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroCheckBox metroCheckBoxCuentas;
        private System.Windows.Forms.LinkLabel linkLabel4;
        private MetroFramework.Controls.MetroToggle metroToggleFiltro;
        private MetroFramework.Controls.MetroTile metroTile4;
        private MetroFramework.Controls.MetroTile metroTile5;
        private MetroFramework.Controls.MetroTile metroTile6;
    }
}