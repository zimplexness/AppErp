namespace ErpGestion
{
    partial class AdminPagosForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminPagosForm));
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.groupBoxFiltros = new System.Windows.Forms.GroupBox();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.metroDateTimeFin = new MetroFramework.Controls.MetroDateTime();
            this.metroDateTimeInicio = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel16 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBoxFiltro = new MetroFramework.Controls.MetroTextBox();
            this.metroGridPagos = new MetroFramework.Controls.MetroGrid();
            this.fechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.razonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroOrdenPagoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.importeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.conceptoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSourcePagos = new System.Core.ComponentModel.ObjectBindingSource(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.metroTile4 = new MetroFramework.Controls.MetroTile();
            this.metroToggleFiltro = new MetroFramework.Controls.MetroToggle();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.metroTile5 = new MetroFramework.Controls.MetroTile();
            this.metroTile6 = new MetroFramework.Controls.MetroTile();
            this.metroTextBoxTotal = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.groupBoxFiltros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGridPagos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourcePagos)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(11, 22);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(165, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "ADMINISTRACION PAGOS";
            // 
            // groupBoxFiltros
            // 
            this.groupBoxFiltros.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBoxFiltros.Controls.Add(this.metroTile2);
            this.groupBoxFiltros.Controls.Add(this.metroLabel11);
            this.groupBoxFiltros.Controls.Add(this.metroLabel10);
            this.groupBoxFiltros.Controls.Add(this.metroDateTimeFin);
            this.groupBoxFiltros.Controls.Add(this.metroDateTimeInicio);
            this.groupBoxFiltros.Controls.Add(this.metroLabel16);
            this.groupBoxFiltros.Controls.Add(this.metroTextBoxFiltro);
            this.groupBoxFiltros.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxFiltros.Location = new System.Drawing.Point(497, 42);
            this.groupBoxFiltros.Name = "groupBoxFiltros";
            this.groupBoxFiltros.Size = new System.Drawing.Size(610, 56);
            this.groupBoxFiltros.TabIndex = 47;
            this.groupBoxFiltros.TabStop = false;
            this.groupBoxFiltros.Text = "FILTROS";
            // 
            // metroTile2
            // 
            this.metroTile2.ActiveControl = null;
            this.metroTile2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.metroTile2.Location = new System.Drawing.Point(526, 11);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(75, 39);
            this.metroTile2.Style = MetroFramework.MetroColorStyle.Yellow;
            this.metroTile2.TabIndex = 57;
            this.metroTile2.Text = "BUSCAR";
            this.metroTile2.TileImage = global::ErpGestion.Properties.Resources.iconfinder_magnifying_glass_226571;
            this.metroTile2.TileImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.metroTile2.TileTextFontSize = MetroFramework.MetroTileTextSize.Small;
            this.metroTile2.UseSelectable = true;
            this.metroTile2.UseTileImage = true;
            this.metroTile2.Click += new System.EventHandler(this.metroTile2_Click_1);
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Location = new System.Drawing.Point(351, 29);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(64, 19);
            this.metroLabel11.TabIndex = 21;
            this.metroLabel11.Text = "Fecha Fin";
            this.metroLabel11.Click += new System.EventHandler(this.metroLabel11_Click);
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(159, 23);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(77, 19);
            this.metroLabel10.TabIndex = 20;
            this.metroLabel10.Text = "Fecha Inicio";
            // 
            // metroDateTimeFin
            // 
            this.metroDateTimeFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.metroDateTimeFin.Location = new System.Drawing.Point(421, 19);
            this.metroDateTimeFin.MinimumSize = new System.Drawing.Size(0, 29);
            this.metroDateTimeFin.Name = "metroDateTimeFin";
            this.metroDateTimeFin.Size = new System.Drawing.Size(99, 29);
            this.metroDateTimeFin.TabIndex = 19;
            // 
            // metroDateTimeInicio
            // 
            this.metroDateTimeInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.metroDateTimeInicio.Location = new System.Drawing.Point(242, 19);
            this.metroDateTimeInicio.MinimumSize = new System.Drawing.Size(0, 29);
            this.metroDateTimeInicio.Name = "metroDateTimeInicio";
            this.metroDateTimeInicio.Size = new System.Drawing.Size(103, 29);
            this.metroDateTimeInicio.TabIndex = 18;
            // 
            // metroLabel16
            // 
            this.metroLabel16.AutoSize = true;
            this.metroLabel16.Location = new System.Drawing.Point(6, 23);
            this.metroLabel16.Name = "metroLabel16";
            this.metroLabel16.Size = new System.Drawing.Size(61, 19);
            this.metroLabel16.TabIndex = 17;
            this.metroLabel16.Text = "No Pago";
            // 
            // metroTextBoxFiltro
            // 
            // 
            // 
            // 
            this.metroTextBoxFiltro.CustomButton.Image = null;
            this.metroTextBoxFiltro.CustomButton.Location = new System.Drawing.Point(54, 1);
            this.metroTextBoxFiltro.CustomButton.Name = "";
            this.metroTextBoxFiltro.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.metroTextBoxFiltro.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxFiltro.CustomButton.TabIndex = 1;
            this.metroTextBoxFiltro.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxFiltro.CustomButton.UseSelectable = true;
            this.metroTextBoxFiltro.CustomButton.Visible = false;
            this.metroTextBoxFiltro.Lines = new string[0];
            this.metroTextBoxFiltro.Location = new System.Drawing.Point(73, 21);
            this.metroTextBoxFiltro.MaxLength = 32767;
            this.metroTextBoxFiltro.Name = "metroTextBoxFiltro";
            this.metroTextBoxFiltro.PasswordChar = '\0';
            this.metroTextBoxFiltro.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxFiltro.SelectedText = "";
            this.metroTextBoxFiltro.SelectionLength = 0;
            this.metroTextBoxFiltro.SelectionStart = 0;
            this.metroTextBoxFiltro.ShortcutsEnabled = true;
            this.metroTextBoxFiltro.Size = new System.Drawing.Size(80, 27);
            this.metroTextBoxFiltro.TabIndex = 16;
            this.metroTextBoxFiltro.UseSelectable = true;
            this.metroTextBoxFiltro.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxFiltro.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroGridPagos
            // 
            this.metroGridPagos.AllowUserToAddRows = false;
            this.metroGridPagos.AllowUserToOrderColumns = true;
            this.metroGridPagos.AllowUserToResizeColumns = false;
            this.metroGridPagos.AllowUserToResizeRows = false;
            this.metroGridPagos.AutoGenerateColumns = false;
            this.metroGridPagos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGridPagos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGridPagos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGridPagos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(133)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridPagos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.metroGridPagos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.metroGridPagos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fechaDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.razonDataGridViewTextBoxColumn,
            this.numeroOrdenPagoDataGridViewTextBoxColumn,
            this.importeDataGridViewTextBoxColumn,
            this.conceptoDataGridViewTextBoxColumn});
            this.metroGridPagos.DataSource = this.bindingSourcePagos;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(133)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGridPagos.DefaultCellStyle = dataGridViewCellStyle2;
            this.metroGridPagos.EnableHeadersVisualStyles = false;
            this.metroGridPagos.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGridPagos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGridPagos.Location = new System.Drawing.Point(5, 105);
            this.metroGridPagos.Name = "metroGridPagos";
            this.metroGridPagos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(133)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridPagos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.metroGridPagos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGridPagos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGridPagos.ShowEditingIcon = false;
            this.metroGridPagos.Size = new System.Drawing.Size(1041, 391);
            this.metroGridPagos.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroGridPagos.TabIndex = 45;
            this.metroGridPagos.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroGridPagos.UseStyleColors = true;
            // 
            // fechaDataGridViewTextBoxColumn
            // 
            this.fechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha";
            this.fechaDataGridViewTextBoxColumn.HeaderText = "Fecha";
            this.fechaDataGridViewTextBoxColumn.Name = "fechaDataGridViewTextBoxColumn";
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre Proveedor";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.Width = 200;
            // 
            // razonDataGridViewTextBoxColumn
            // 
            this.razonDataGridViewTextBoxColumn.DataPropertyName = "Razon";
            this.razonDataGridViewTextBoxColumn.HeaderText = "Razòn Social";
            this.razonDataGridViewTextBoxColumn.Name = "razonDataGridViewTextBoxColumn";
            this.razonDataGridViewTextBoxColumn.Width = 200;
            // 
            // numeroOrdenPagoDataGridViewTextBoxColumn
            // 
            this.numeroOrdenPagoDataGridViewTextBoxColumn.DataPropertyName = "NumeroOrdenPago";
            this.numeroOrdenPagoDataGridViewTextBoxColumn.HeaderText = "# Orden Pago";
            this.numeroOrdenPagoDataGridViewTextBoxColumn.Name = "numeroOrdenPagoDataGridViewTextBoxColumn";
            // 
            // importeDataGridViewTextBoxColumn
            // 
            this.importeDataGridViewTextBoxColumn.DataPropertyName = "Importe";
            this.importeDataGridViewTextBoxColumn.HeaderText = "Importe";
            this.importeDataGridViewTextBoxColumn.Name = "importeDataGridViewTextBoxColumn";
            // 
            // conceptoDataGridViewTextBoxColumn
            // 
            this.conceptoDataGridViewTextBoxColumn.DataPropertyName = "Concepto";
            this.conceptoDataGridViewTextBoxColumn.HeaderText = "Concepto";
            this.conceptoDataGridViewTextBoxColumn.Name = "conceptoDataGridViewTextBoxColumn";
            this.conceptoDataGridViewTextBoxColumn.Width = 250;
            // 
            // bindingSourcePagos
            // 
            this.bindingSourcePagos.AutoCreateObjects = false;
            this.bindingSourcePagos.BindableProperties.Add(((System.Core.ComponentModel.BindableProperty)(resources.GetObject("bindingSourcePagos.BindableProperties"))));
            this.bindingSourcePagos.BindableProperties.Add(((System.Core.ComponentModel.BindableProperty)(resources.GetObject("bindingSourcePagos.BindableProperties1"))));
            this.bindingSourcePagos.BindableProperties.Add(((System.Core.ComponentModel.BindableProperty)(resources.GetObject("bindingSourcePagos.BindableProperties2"))));
            this.bindingSourcePagos.BindableProperties.Add(((System.Core.ComponentModel.BindableProperty)(resources.GetObject("bindingSourcePagos.BindableProperties3"))));
            this.bindingSourcePagos.BindableProperties.Add(((System.Core.ComponentModel.BindableProperty)(resources.GetObject("bindingSourcePagos.BindableProperties4"))));
            this.bindingSourcePagos.BindableProperties.Add(((System.Core.ComponentModel.BindableProperty)(resources.GetObject("bindingSourcePagos.BindableProperties5"))));
            this.bindingSourcePagos.DataSource = typeof(Entidades.SelectPagosProveedores_Result);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox2.Controls.Add(this.metroTile1);
            this.groupBox2.Controls.Add(this.metroTile4);
            this.groupBox2.Controls.Add(this.metroToggleFiltro);
            this.groupBox2.Controls.Add(this.linkLabel1);
            this.groupBox2.Controls.Add(this.metroTile5);
            this.groupBox2.Controls.Add(this.metroTile6);
            this.groupBox2.Location = new System.Drawing.Point(5, 42);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(486, 57);
            this.groupBox2.TabIndex = 52;
            this.groupBox2.TabStop = false;
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.metroTile1.Location = new System.Drawing.Point(257, 9);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(85, 39);
            this.metroTile1.Style = MetroFramework.MetroColorStyle.Lime;
            this.metroTile1.TabIndex = 56;
            this.metroTile1.Text = "IMPRIMIR";
            this.metroTile1.TileImage = global::ErpGestion.Properties.Resources.iconfinder_printer_226565;
            this.metroTile1.TileImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.metroTile1.TileTextFontSize = MetroFramework.MetroTileTextSize.Small;
            this.metroTile1.UseSelectable = true;
            this.metroTile1.UseTileImage = true;
            this.metroTile1.Click += new System.EventHandler(this.metroTile1_Click_1);
            // 
            // metroTile4
            // 
            this.metroTile4.ActiveControl = null;
            this.metroTile4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.metroTile4.Location = new System.Drawing.Point(6, 10);
            this.metroTile4.Name = "metroTile4";
            this.metroTile4.Size = new System.Drawing.Size(75, 39);
            this.metroTile4.TabIndex = 54;
            this.metroTile4.Text = "NUEVO";
            this.metroTile4.TileImage = global::ErpGestion.Properties.Resources.iconfinder_circle_add_226591;
            this.metroTile4.TileImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.metroTile4.TileTextFontSize = MetroFramework.MetroTileTextSize.Small;
            this.metroTile4.UseSelectable = true;
            this.metroTile4.UseTileImage = true;
            this.metroTile4.Click += new System.EventHandler(this.metroTile4_Click);
            // 
            // metroToggleFiltro
            // 
            this.metroToggleFiltro.AutoSize = true;
            this.metroToggleFiltro.Location = new System.Drawing.Point(348, 32);
            this.metroToggleFiltro.Name = "metroToggleFiltro";
            this.metroToggleFiltro.Size = new System.Drawing.Size(80, 17);
            this.metroToggleFiltro.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroToggleFiltro.TabIndex = 4;
            this.metroToggleFiltro.Text = "Off";
            this.metroToggleFiltro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroToggleFiltro.UseSelectable = true;
            // 
            // linkLabel1
            // 
            this.linkLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.linkLabel1.LinkColor = System.Drawing.Color.Teal;
            this.linkLabel1.Location = new System.Drawing.Point(383, 9);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(45, 13);
            this.linkLabel1.TabIndex = 38;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "FILTRO";
            // 
            // metroTile5
            // 
            this.metroTile5.ActiveControl = null;
            this.metroTile5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.metroTile5.Location = new System.Drawing.Point(168, 9);
            this.metroTile5.Name = "metroTile5";
            this.metroTile5.Size = new System.Drawing.Size(83, 39);
            this.metroTile5.Style = MetroFramework.MetroColorStyle.Red;
            this.metroTile5.TabIndex = 56;
            this.metroTile5.Text = "ELIMINAR";
            this.metroTile5.TileImage = global::ErpGestion.Properties.Resources.iconfinder_trash_227551;
            this.metroTile5.TileImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.metroTile5.TileTextFontSize = MetroFramework.MetroTileTextSize.Small;
            this.metroTile5.UseSelectable = true;
            this.metroTile5.UseTileImage = true;
            // 
            // metroTile6
            // 
            this.metroTile6.ActiveControl = null;
            this.metroTile6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.metroTile6.Location = new System.Drawing.Point(87, 10);
            this.metroTile6.Name = "metroTile6";
            this.metroTile6.Size = new System.Drawing.Size(75, 39);
            this.metroTile6.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroTile6.TabIndex = 55;
            this.metroTile6.Text = "EDITAR";
            this.metroTile6.TileImage = global::ErpGestion.Properties.Resources.iconfinder_edit_3_3324936;
            this.metroTile6.TileImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.metroTile6.TileTextFontSize = MetroFramework.MetroTileTextSize.Small;
            this.metroTile6.UseSelectable = true;
            this.metroTile6.UseTileImage = true;
            this.metroTile6.Click += new System.EventHandler(this.metroTile6_Click);
            // 
            // metroTextBoxTotal
            // 
            // 
            // 
            // 
            this.metroTextBoxTotal.CustomButton.Image = null;
            this.metroTextBoxTotal.CustomButton.Location = new System.Drawing.Point(54, 1);
            this.metroTextBoxTotal.CustomButton.Name = "";
            this.metroTextBoxTotal.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.metroTextBoxTotal.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxTotal.CustomButton.TabIndex = 1;
            this.metroTextBoxTotal.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxTotal.CustomButton.UseSelectable = true;
            this.metroTextBoxTotal.CustomButton.Visible = false;
            this.metroTextBoxTotal.Lines = new string[0];
            this.metroTextBoxTotal.Location = new System.Drawing.Point(966, 502);
            this.metroTextBoxTotal.MaxLength = 32767;
            this.metroTextBoxTotal.Name = "metroTextBoxTotal";
            this.metroTextBoxTotal.PasswordChar = '\0';
            this.metroTextBoxTotal.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxTotal.SelectedText = "";
            this.metroTextBoxTotal.SelectionLength = 0;
            this.metroTextBoxTotal.SelectionStart = 0;
            this.metroTextBoxTotal.ShortcutsEnabled = true;
            this.metroTextBoxTotal.Size = new System.Drawing.Size(80, 27);
            this.metroTextBoxTotal.TabIndex = 53;
            this.metroTextBoxTotal.UseSelectable = true;
            this.metroTextBoxTotal.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxTotal.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(924, 510);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(36, 19);
            this.metroLabel2.TabIndex = 54;
            this.metroLabel2.Text = "Total";
            // 
            // AdminPagosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1122, 566);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroTextBoxTotal);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBoxFiltros);
            this.Controls.Add(this.metroGridPagos);
            this.Controls.Add(this.metroLabel1);
            this.MaximizeBox = false;
            this.Name = "AdminPagosForm";
            this.Resizable = false;
            this.Load += new System.EventHandler(this.AdminPagosForm_Load);
            this.groupBoxFiltros.ResumeLayout(false);
            this.groupBoxFiltros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGridPagos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourcePagos)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.GroupBox groupBoxFiltros;
        private MetroFramework.Controls.MetroLabel metroLabel16;
        private MetroFramework.Controls.MetroTextBox metroTextBoxFiltro;
        private MetroFramework.Controls.MetroGrid metroGridPagos;
        private System.Core.ComponentModel.ObjectBindingSource bindingSourcePagos;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn razonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroOrdenPagoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn importeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn conceptoDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroTile metroTile4;
        private MetroFramework.Controls.MetroToggle metroToggleFiltro;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private MetroFramework.Controls.MetroTile metroTile5;
        private MetroFramework.Controls.MetroTile metroTile6;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroTile metroTile2;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroDateTime metroDateTimeFin;
        private MetroFramework.Controls.MetroDateTime metroDateTimeInicio;
        private MetroFramework.Controls.MetroTextBox metroTextBoxTotal;
        private MetroFramework.Controls.MetroLabel metroLabel2;
    }
}