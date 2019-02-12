namespace ErpGestion
{
    partial class AdminVehiculosForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminVehiculosForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.metroTextBoxYear = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBoxModelo = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBoxPatente = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBoxMarca = new MetroFramework.Controls.MetroTextBox();
            this.metroGridVehiculos = new MetroFramework.Controls.MetroGrid();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.metroTile3 = new MetroFramework.Controls.MetroTile();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.iDVehiculoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.patenteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marcasVehiculosMarcasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelosVehiculosModeloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empleadosNombresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empleadosApellidosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noCarroceriaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.combustiblesDescripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaCompraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vigenciaVTVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSourceVehiculos = new System.Core.ComponentModel.ObjectBindingSource(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGridVehiculos)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceVehiculos)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Controls.Add(this.metroTextBoxYear);
            this.groupBox1.Controls.Add(this.metroTextBoxModelo);
            this.groupBox1.Controls.Add(this.metroTextBoxPatente);
            this.groupBox1.Controls.Add(this.metroTextBoxMarca);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(269, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(568, 58);
            this.groupBox1.TabIndex = 49;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros";
            // 
            // metroTextBoxYear
            // 
            // 
            // 
            // 
            this.metroTextBoxYear.CustomButton.Image = null;
            this.metroTextBoxYear.CustomButton.Location = new System.Drawing.Point(61, 1);
            this.metroTextBoxYear.CustomButton.Name = "";
            this.metroTextBoxYear.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.metroTextBoxYear.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxYear.CustomButton.TabIndex = 1;
            this.metroTextBoxYear.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxYear.CustomButton.UseSelectable = true;
            this.metroTextBoxYear.CustomButton.Visible = false;
            this.metroTextBoxYear.Lines = new string[] {
        "Año"};
            this.metroTextBoxYear.Location = new System.Drawing.Point(471, 22);
            this.metroTextBoxYear.MaxLength = 32767;
            this.metroTextBoxYear.Name = "metroTextBoxYear";
            this.metroTextBoxYear.PasswordChar = '\0';
            this.metroTextBoxYear.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxYear.SelectedText = "";
            this.metroTextBoxYear.SelectionLength = 0;
            this.metroTextBoxYear.SelectionStart = 0;
            this.metroTextBoxYear.ShortcutsEnabled = true;
            this.metroTextBoxYear.Size = new System.Drawing.Size(87, 27);
            this.metroTextBoxYear.TabIndex = 4;
            this.metroTextBoxYear.Text = "Año";
            this.metroTextBoxYear.UseSelectable = true;
            this.metroTextBoxYear.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxYear.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.metroTextBoxYear.Click += new System.EventHandler(this.metroTextBoxYear_Click);
            // 
            // metroTextBoxModelo
            // 
            // 
            // 
            // 
            this.metroTextBoxModelo.CustomButton.Image = null;
            this.metroTextBoxModelo.CustomButton.Location = new System.Drawing.Point(153, 1);
            this.metroTextBoxModelo.CustomButton.Name = "";
            this.metroTextBoxModelo.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.metroTextBoxModelo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxModelo.CustomButton.TabIndex = 1;
            this.metroTextBoxModelo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxModelo.CustomButton.UseSelectable = true;
            this.metroTextBoxModelo.CustomButton.Visible = false;
            this.metroTextBoxModelo.Lines = new string[] {
        "Modelo"};
            this.metroTextBoxModelo.Location = new System.Drawing.Point(286, 22);
            this.metroTextBoxModelo.MaxLength = 32767;
            this.metroTextBoxModelo.Name = "metroTextBoxModelo";
            this.metroTextBoxModelo.PasswordChar = '\0';
            this.metroTextBoxModelo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxModelo.SelectedText = "";
            this.metroTextBoxModelo.SelectionLength = 0;
            this.metroTextBoxModelo.SelectionStart = 0;
            this.metroTextBoxModelo.ShortcutsEnabled = true;
            this.metroTextBoxModelo.Size = new System.Drawing.Size(179, 27);
            this.metroTextBoxModelo.TabIndex = 3;
            this.metroTextBoxModelo.Text = "Modelo";
            this.metroTextBoxModelo.UseSelectable = true;
            this.metroTextBoxModelo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxModelo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.metroTextBoxModelo.TextChanged += new System.EventHandler(this.metroTextBoxModelo_TextChanged);
            this.metroTextBoxModelo.Click += new System.EventHandler(this.metroTextBoxModelo_Click);
            // 
            // metroTextBoxPatente
            // 
            // 
            // 
            // 
            this.metroTextBoxPatente.CustomButton.Image = null;
            this.metroTextBoxPatente.CustomButton.Location = new System.Drawing.Point(61, 1);
            this.metroTextBoxPatente.CustomButton.Name = "";
            this.metroTextBoxPatente.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.metroTextBoxPatente.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxPatente.CustomButton.TabIndex = 1;
            this.metroTextBoxPatente.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxPatente.CustomButton.UseSelectable = true;
            this.metroTextBoxPatente.CustomButton.Visible = false;
            this.metroTextBoxPatente.Lines = new string[] {
        "Patente"};
            this.metroTextBoxPatente.Location = new System.Drawing.Point(6, 22);
            this.metroTextBoxPatente.MaxLength = 32767;
            this.metroTextBoxPatente.Name = "metroTextBoxPatente";
            this.metroTextBoxPatente.PasswordChar = '\0';
            this.metroTextBoxPatente.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxPatente.SelectedText = "";
            this.metroTextBoxPatente.SelectionLength = 0;
            this.metroTextBoxPatente.SelectionStart = 0;
            this.metroTextBoxPatente.ShortcutsEnabled = true;
            this.metroTextBoxPatente.Size = new System.Drawing.Size(87, 27);
            this.metroTextBoxPatente.TabIndex = 2;
            this.metroTextBoxPatente.Text = "Patente";
            this.metroTextBoxPatente.UseSelectable = true;
            this.metroTextBoxPatente.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxPatente.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.metroTextBoxPatente.TextChanged += new System.EventHandler(this.metroTextBoxPatente_TextChanged);
            this.metroTextBoxPatente.Click += new System.EventHandler(this.metroTextBox2_Click);
            // 
            // metroTextBoxMarca
            // 
            // 
            // 
            // 
            this.metroTextBoxMarca.CustomButton.Image = null;
            this.metroTextBoxMarca.CustomButton.Location = new System.Drawing.Point(153, 1);
            this.metroTextBoxMarca.CustomButton.Name = "";
            this.metroTextBoxMarca.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.metroTextBoxMarca.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxMarca.CustomButton.TabIndex = 1;
            this.metroTextBoxMarca.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxMarca.CustomButton.UseSelectable = true;
            this.metroTextBoxMarca.CustomButton.Visible = false;
            this.metroTextBoxMarca.Lines = new string[] {
        "Marca"};
            this.metroTextBoxMarca.Location = new System.Drawing.Point(101, 22);
            this.metroTextBoxMarca.MaxLength = 32767;
            this.metroTextBoxMarca.Name = "metroTextBoxMarca";
            this.metroTextBoxMarca.PasswordChar = '\0';
            this.metroTextBoxMarca.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxMarca.SelectedText = "";
            this.metroTextBoxMarca.SelectionLength = 0;
            this.metroTextBoxMarca.SelectionStart = 0;
            this.metroTextBoxMarca.ShortcutsEnabled = true;
            this.metroTextBoxMarca.Size = new System.Drawing.Size(179, 27);
            this.metroTextBoxMarca.TabIndex = 1;
            this.metroTextBoxMarca.Text = "Marca";
            this.metroTextBoxMarca.UseSelectable = true;
            this.metroTextBoxMarca.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxMarca.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.metroTextBoxMarca.TextChanged += new System.EventHandler(this.metroTextBoxMarca_TextChanged);
            this.metroTextBoxMarca.Click += new System.EventHandler(this.metroTextBoxMarca_Click);
            // 
            // metroGridVehiculos
            // 
            this.metroGridVehiculos.AllowUserToAddRows = false;
            this.metroGridVehiculos.AllowUserToResizeRows = false;
            this.metroGridVehiculos.AutoGenerateColumns = false;
            this.metroGridVehiculos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGridVehiculos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGridVehiculos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGridVehiculos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(133)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridVehiculos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.metroGridVehiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.metroGridVehiculos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDVehiculoDataGridViewTextBoxColumn,
            this.activoDataGridViewTextBoxColumn,
            this.patenteDataGridViewTextBoxColumn,
            this.marcasVehiculosMarcasDataGridViewTextBoxColumn,
            this.modelosVehiculosModeloDataGridViewTextBoxColumn,
            this.empleadosNombresDataGridViewTextBoxColumn,
            this.empleadosApellidosDataGridViewTextBoxColumn,
            this.noCarroceriaDataGridViewTextBoxColumn,
            this.combustiblesDescripcionDataGridViewTextBoxColumn,
            this.yearDataGridViewTextBoxColumn,
            this.fechaCompraDataGridViewTextBoxColumn,
            this.vigenciaVTVDataGridViewTextBoxColumn,
            this.kMDataGridViewTextBoxColumn});
            this.metroGridVehiculos.DataSource = this.bindingSourceVehiculos;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(133)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGridVehiculos.DefaultCellStyle = dataGridViewCellStyle2;
            this.metroGridVehiculos.EnableHeadersVisualStyles = false;
            this.metroGridVehiculos.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGridVehiculos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGridVehiculos.Location = new System.Drawing.Point(7, 111);
            this.metroGridVehiculos.Name = "metroGridVehiculos";
            this.metroGridVehiculos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(133)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridVehiculos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.metroGridVehiculos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGridVehiculos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGridVehiculos.Size = new System.Drawing.Size(1104, 384);
            this.metroGridVehiculos.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroGridVehiculos.TabIndex = 47;
            this.metroGridVehiculos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.metroGridVehiculos_CellDoubleClick);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(7, 25);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(211, 19);
            this.metroLabel1.TabIndex = 50;
            this.metroLabel1.Text = "ADMINISTRACION DE VEHICULOS";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox3.Controls.Add(this.metroTile3);
            this.groupBox3.Controls.Add(this.metroTile2);
            this.groupBox3.Controls.Add(this.metroTile1);
            this.groupBox3.Location = new System.Drawing.Point(7, 47);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(256, 58);
            this.groupBox3.TabIndex = 51;
            this.groupBox3.TabStop = false;
            // 
            // metroTile3
            // 
            this.metroTile3.ActiveControl = null;
            this.metroTile3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.metroTile3.Location = new System.Drawing.Point(168, 13);
            this.metroTile3.Name = "metroTile3";
            this.metroTile3.Size = new System.Drawing.Size(82, 39);
            this.metroTile3.Style = MetroFramework.MetroColorStyle.Red;
            this.metroTile3.TabIndex = 44;
            this.metroTile3.Text = "ELIMINAR";
            this.metroTile3.TileImage = global::ErpGestion.Properties.Resources.iconfinder_trash_227551;
            this.metroTile3.TileImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.metroTile3.TileTextFontSize = MetroFramework.MetroTileTextSize.Small;
            this.metroTile3.UseSelectable = true;
            this.metroTile3.UseTileImage = true;
            this.metroTile3.Click += new System.EventHandler(this.metroTile3_Click);
            // 
            // metroTile2
            // 
            this.metroTile2.ActiveControl = null;
            this.metroTile2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.metroTile2.Location = new System.Drawing.Point(87, 13);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(75, 39);
            this.metroTile2.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroTile2.TabIndex = 43;
            this.metroTile2.Text = "EDITAR";
            this.metroTile2.TileImage = global::ErpGestion.Properties.Resources.iconfinder_edit_3_3324936;
            this.metroTile2.TileImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.metroTile2.TileTextFontSize = MetroFramework.MetroTileTextSize.Small;
            this.metroTile2.UseSelectable = true;
            this.metroTile2.UseTileImage = true;
            this.metroTile2.Click += new System.EventHandler(this.metroTile2_Click);
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.metroTile1.Location = new System.Drawing.Point(6, 13);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(75, 39);
            this.metroTile1.TabIndex = 42;
            this.metroTile1.Text = "NUEVO";
            this.metroTile1.TileImage = global::ErpGestion.Properties.Resources.iconfinder_circle_add_226591;
            this.metroTile1.TileImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.metroTile1.TileTextFontSize = MetroFramework.MetroTileTextSize.Small;
            this.metroTile1.UseSelectable = true;
            this.metroTile1.UseTileImage = true;
            this.metroTile1.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // iDVehiculoDataGridViewTextBoxColumn
            // 
            this.iDVehiculoDataGridViewTextBoxColumn.DataPropertyName = "IDVehiculo";
            this.iDVehiculoDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDVehiculoDataGridViewTextBoxColumn.Name = "iDVehiculoDataGridViewTextBoxColumn";
            // 
            // activoDataGridViewTextBoxColumn
            // 
            this.activoDataGridViewTextBoxColumn.DataPropertyName = "Activo";
            this.activoDataGridViewTextBoxColumn.HeaderText = "Activo";
            this.activoDataGridViewTextBoxColumn.Name = "activoDataGridViewTextBoxColumn";
            this.activoDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.activoDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // patenteDataGridViewTextBoxColumn
            // 
            this.patenteDataGridViewTextBoxColumn.DataPropertyName = "Patente";
            this.patenteDataGridViewTextBoxColumn.HeaderText = "Patente";
            this.patenteDataGridViewTextBoxColumn.Name = "patenteDataGridViewTextBoxColumn";
            // 
            // marcasVehiculosMarcasDataGridViewTextBoxColumn
            // 
            this.marcasVehiculosMarcasDataGridViewTextBoxColumn.DataPropertyName = "MarcasVehiculos_Marcas";
            this.marcasVehiculosMarcasDataGridViewTextBoxColumn.HeaderText = "Marca";
            this.marcasVehiculosMarcasDataGridViewTextBoxColumn.Name = "marcasVehiculosMarcasDataGridViewTextBoxColumn";
            // 
            // modelosVehiculosModeloDataGridViewTextBoxColumn
            // 
            this.modelosVehiculosModeloDataGridViewTextBoxColumn.DataPropertyName = "ModelosVehiculos_Modelo";
            this.modelosVehiculosModeloDataGridViewTextBoxColumn.HeaderText = "Modelo";
            this.modelosVehiculosModeloDataGridViewTextBoxColumn.Name = "modelosVehiculosModeloDataGridViewTextBoxColumn";
            // 
            // empleadosNombresDataGridViewTextBoxColumn
            // 
            this.empleadosNombresDataGridViewTextBoxColumn.DataPropertyName = "Empleados_Nombres";
            this.empleadosNombresDataGridViewTextBoxColumn.HeaderText = "Nombres";
            this.empleadosNombresDataGridViewTextBoxColumn.Name = "empleadosNombresDataGridViewTextBoxColumn";
            // 
            // empleadosApellidosDataGridViewTextBoxColumn
            // 
            this.empleadosApellidosDataGridViewTextBoxColumn.DataPropertyName = "Empleados_Apellidos";
            this.empleadosApellidosDataGridViewTextBoxColumn.HeaderText = "Apellidos";
            this.empleadosApellidosDataGridViewTextBoxColumn.Name = "empleadosApellidosDataGridViewTextBoxColumn";
            // 
            // noCarroceriaDataGridViewTextBoxColumn
            // 
            this.noCarroceriaDataGridViewTextBoxColumn.DataPropertyName = "NoCarroceria";
            this.noCarroceriaDataGridViewTextBoxColumn.HeaderText = "No. Carroceria";
            this.noCarroceriaDataGridViewTextBoxColumn.Name = "noCarroceriaDataGridViewTextBoxColumn";
            // 
            // combustiblesDescripcionDataGridViewTextBoxColumn
            // 
            this.combustiblesDescripcionDataGridViewTextBoxColumn.DataPropertyName = "Combustibles_Descripcion";
            this.combustiblesDescripcionDataGridViewTextBoxColumn.HeaderText = "Combustible";
            this.combustiblesDescripcionDataGridViewTextBoxColumn.Name = "combustiblesDescripcionDataGridViewTextBoxColumn";
            // 
            // yearDataGridViewTextBoxColumn
            // 
            this.yearDataGridViewTextBoxColumn.DataPropertyName = "Year";
            this.yearDataGridViewTextBoxColumn.HeaderText = "Año";
            this.yearDataGridViewTextBoxColumn.Name = "yearDataGridViewTextBoxColumn";
            // 
            // fechaCompraDataGridViewTextBoxColumn
            // 
            this.fechaCompraDataGridViewTextBoxColumn.DataPropertyName = "FechaCompra";
            this.fechaCompraDataGridViewTextBoxColumn.HeaderText = "Fecha Compra";
            this.fechaCompraDataGridViewTextBoxColumn.Name = "fechaCompraDataGridViewTextBoxColumn";
            // 
            // vigenciaVTVDataGridViewTextBoxColumn
            // 
            this.vigenciaVTVDataGridViewTextBoxColumn.DataPropertyName = "VigenciaVTV";
            this.vigenciaVTVDataGridViewTextBoxColumn.HeaderText = "Vigencia VTV";
            this.vigenciaVTVDataGridViewTextBoxColumn.Name = "vigenciaVTVDataGridViewTextBoxColumn";
            // 
            // kMDataGridViewTextBoxColumn
            // 
            this.kMDataGridViewTextBoxColumn.DataPropertyName = "KM";
            this.kMDataGridViewTextBoxColumn.HeaderText = "KM";
            this.kMDataGridViewTextBoxColumn.Name = "kMDataGridViewTextBoxColumn";
            // 
            // bindingSourceVehiculos
            // 
            this.bindingSourceVehiculos.AutoCreateObjects = false;
            this.bindingSourceVehiculos.BindableProperties.Add(((System.Core.ComponentModel.BindableProperty)(resources.GetObject("bindingSourceVehiculos.BindableProperties"))));
            this.bindingSourceVehiculos.BindableProperties.Add(((System.Core.ComponentModel.BindableProperty)(resources.GetObject("bindingSourceVehiculos.BindableProperties1"))));
            this.bindingSourceVehiculos.BindableProperties.Add(((System.Core.ComponentModel.BindableProperty)(resources.GetObject("bindingSourceVehiculos.BindableProperties2"))));
            this.bindingSourceVehiculos.BindableProperties.Add(((System.Core.ComponentModel.BindableProperty)(resources.GetObject("bindingSourceVehiculos.BindableProperties3"))));
            this.bindingSourceVehiculos.BindableProperties.Add(((System.Core.ComponentModel.BindableProperty)(resources.GetObject("bindingSourceVehiculos.BindableProperties4"))));
            this.bindingSourceVehiculos.BindableProperties.Add(((System.Core.ComponentModel.BindableProperty)(resources.GetObject("bindingSourceVehiculos.BindableProperties5"))));
            this.bindingSourceVehiculos.BindableProperties.Add(((System.Core.ComponentModel.BindableProperty)(resources.GetObject("bindingSourceVehiculos.BindableProperties6"))));
            this.bindingSourceVehiculos.BindableProperties.Add(((System.Core.ComponentModel.BindableProperty)(resources.GetObject("bindingSourceVehiculos.BindableProperties7"))));
            this.bindingSourceVehiculos.BindableProperties.Add(((System.Core.ComponentModel.BindableProperty)(resources.GetObject("bindingSourceVehiculos.BindableProperties8"))));
            this.bindingSourceVehiculos.BindableProperties.Add(((System.Core.ComponentModel.BindableProperty)(resources.GetObject("bindingSourceVehiculos.BindableProperties9"))));
            this.bindingSourceVehiculos.BindableProperties.Add(((System.Core.ComponentModel.BindableProperty)(resources.GetObject("bindingSourceVehiculos.BindableProperties10"))));
            this.bindingSourceVehiculos.BindableProperties.Add(((System.Core.ComponentModel.BindableProperty)(resources.GetObject("bindingSourceVehiculos.BindableProperties11"))));
            this.bindingSourceVehiculos.BindableProperties.Add(((System.Core.ComponentModel.BindableProperty)(resources.GetObject("bindingSourceVehiculos.BindableProperties12"))));
            this.bindingSourceVehiculos.DataSource = typeof(Entidades.Vehiculos);
            // 
            // AdminVehiculosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1117, 507);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.metroGridVehiculos);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AdminVehiculosForm";
            this.Resizable = false;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminVehiculosForm_FormClosing);
            this.Load += new System.EventHandler(this.AdminVehiculosForm_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.metroGridVehiculos)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceVehiculos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroTextBox metroTextBoxPatente;
        private MetroFramework.Controls.MetroTextBox metroTextBoxMarca;
        private MetroFramework.Controls.MetroGrid metroGridVehiculos;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Core.ComponentModel.ObjectBindingSource bindingSourceVehiculos;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDVehiculoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn activoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patenteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn marcasVehiculosMarcasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelosVehiculosModeloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empleadosNombresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empleadosApellidosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noCarroceriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn combustiblesDescripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaCompraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vigenciaVTVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kMDataGridViewTextBoxColumn;
        private MetroFramework.Controls.MetroTextBox metroTextBoxYear;
        private MetroFramework.Controls.MetroTextBox metroTextBoxModelo;
        private System.Windows.Forms.GroupBox groupBox3;
        private MetroFramework.Controls.MetroTile metroTile3;
        private MetroFramework.Controls.MetroTile metroTile2;
        private MetroFramework.Controls.MetroTile metroTile1;
    }
}