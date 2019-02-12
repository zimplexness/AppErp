namespace ErpGestion
{
    partial class AdminMantenimientoVehiculoForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminMantenimientoVehiculoForm));
            this.metroGridMantenimientos = new MetroFramework.Controls.MetroGrid();
            this.iDMantenimientoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vehiculosPatenteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.talleresNombreTallerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSourceMantenimientos = new System.Core.ComponentModel.ObjectBindingSource(this.components);
            this.metroTextBoxDetalleMantenimiento = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBox2 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.metroToggleFiltro = new MetroFramework.Controls.MetroToggle();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.metroTile3 = new MetroFramework.Controls.MetroTile();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            ((System.ComponentModel.ISupportInitialize)(this.metroGridMantenimientos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceMantenimientos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroGridMantenimientos
            // 
            this.metroGridMantenimientos.AllowUserToAddRows = false;
            this.metroGridMantenimientos.AllowUserToResizeRows = false;
            this.metroGridMantenimientos.AutoGenerateColumns = false;
            this.metroGridMantenimientos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGridMantenimientos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGridMantenimientos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGridMantenimientos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(133)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridMantenimientos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.metroGridMantenimientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.metroGridMantenimientos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDMantenimientoDataGridViewTextBoxColumn,
            this.fechaDataGridViewTextBoxColumn,
            this.vehiculosPatenteDataGridViewTextBoxColumn,
            this.kmDataGridViewTextBoxColumn,
            this.talleresNombreTallerDataGridViewTextBoxColumn,
            this.totalDataGridViewTextBoxColumn});
            this.metroGridMantenimientos.DataSource = this.bindingSourceMantenimientos;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(133)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGridMantenimientos.DefaultCellStyle = dataGridViewCellStyle8;
            this.metroGridMantenimientos.EnableHeadersVisualStyles = false;
            this.metroGridMantenimientos.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGridMantenimientos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGridMantenimientos.Location = new System.Drawing.Point(8, 117);
            this.metroGridMantenimientos.Name = "metroGridMantenimientos";
            this.metroGridMantenimientos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(133)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridMantenimientos.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.metroGridMantenimientos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGridMantenimientos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGridMantenimientos.Size = new System.Drawing.Size(849, 355);
            this.metroGridMantenimientos.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroGridMantenimientos.TabIndex = 0;
            this.metroGridMantenimientos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.metroGridMantenimientos_CellDoubleClick);
            // 
            // iDMantenimientoDataGridViewTextBoxColumn
            // 
            this.iDMantenimientoDataGridViewTextBoxColumn.DataPropertyName = "IDMantenimiento";
            this.iDMantenimientoDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDMantenimientoDataGridViewTextBoxColumn.Name = "iDMantenimientoDataGridViewTextBoxColumn";
            this.iDMantenimientoDataGridViewTextBoxColumn.Width = 70;
            // 
            // fechaDataGridViewTextBoxColumn
            // 
            this.fechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha";
            this.fechaDataGridViewTextBoxColumn.HeaderText = "Fecha";
            this.fechaDataGridViewTextBoxColumn.Name = "fechaDataGridViewTextBoxColumn";
            // 
            // vehiculosPatenteDataGridViewTextBoxColumn
            // 
            this.vehiculosPatenteDataGridViewTextBoxColumn.DataPropertyName = "Vehiculos_Patente";
            this.vehiculosPatenteDataGridViewTextBoxColumn.HeaderText = "Patente";
            this.vehiculosPatenteDataGridViewTextBoxColumn.Name = "vehiculosPatenteDataGridViewTextBoxColumn";
            this.vehiculosPatenteDataGridViewTextBoxColumn.Width = 150;
            // 
            // kmDataGridViewTextBoxColumn
            // 
            this.kmDataGridViewTextBoxColumn.DataPropertyName = "Km";
            this.kmDataGridViewTextBoxColumn.HeaderText = "Km";
            this.kmDataGridViewTextBoxColumn.Name = "kmDataGridViewTextBoxColumn";
            // 
            // talleresNombreTallerDataGridViewTextBoxColumn
            // 
            this.talleresNombreTallerDataGridViewTextBoxColumn.DataPropertyName = "Talleres_NombreTaller";
            this.talleresNombreTallerDataGridViewTextBoxColumn.HeaderText = "Taller";
            this.talleresNombreTallerDataGridViewTextBoxColumn.Name = "talleresNombreTallerDataGridViewTextBoxColumn";
            this.talleresNombreTallerDataGridViewTextBoxColumn.Width = 250;
            // 
            // totalDataGridViewTextBoxColumn
            // 
            this.totalDataGridViewTextBoxColumn.DataPropertyName = "Total";
            this.totalDataGridViewTextBoxColumn.HeaderText = "Total";
            this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            this.totalDataGridViewTextBoxColumn.Width = 150;
            // 
            // bindingSourceMantenimientos
            // 
            this.bindingSourceMantenimientos.AutoCreateObjects = false;
            this.bindingSourceMantenimientos.BindableProperties.Add(((System.Core.ComponentModel.BindableProperty)(resources.GetObject("bindingSourceMantenimientos.BindableProperties"))));
            this.bindingSourceMantenimientos.BindableProperties.Add(((System.Core.ComponentModel.BindableProperty)(resources.GetObject("bindingSourceMantenimientos.BindableProperties1"))));
            this.bindingSourceMantenimientos.BindableProperties.Add(((System.Core.ComponentModel.BindableProperty)(resources.GetObject("bindingSourceMantenimientos.BindableProperties2"))));
            this.bindingSourceMantenimientos.BindableProperties.Add(((System.Core.ComponentModel.BindableProperty)(resources.GetObject("bindingSourceMantenimientos.BindableProperties3"))));
            this.bindingSourceMantenimientos.BindableProperties.Add(((System.Core.ComponentModel.BindableProperty)(resources.GetObject("bindingSourceMantenimientos.BindableProperties4"))));
            this.bindingSourceMantenimientos.BindableProperties.Add(((System.Core.ComponentModel.BindableProperty)(resources.GetObject("bindingSourceMantenimientos.BindableProperties5"))));
            this.bindingSourceMantenimientos.DataSource = typeof(Entidades.Mantenimiento);
            // 
            // metroTextBoxDetalleMantenimiento
            // 
            // 
            // 
            // 
            this.metroTextBoxDetalleMantenimiento.CustomButton.Image = null;
            this.metroTextBoxDetalleMantenimiento.CustomButton.Location = new System.Drawing.Point(226, 1);
            this.metroTextBoxDetalleMantenimiento.CustomButton.Name = "";
            this.metroTextBoxDetalleMantenimiento.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.metroTextBoxDetalleMantenimiento.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxDetalleMantenimiento.CustomButton.TabIndex = 1;
            this.metroTextBoxDetalleMantenimiento.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxDetalleMantenimiento.CustomButton.UseSelectable = true;
            this.metroTextBoxDetalleMantenimiento.CustomButton.Visible = false;
            this.metroTextBoxDetalleMantenimiento.Lines = new string[] {
        "Detalle Mantenimiento"};
            this.metroTextBoxDetalleMantenimiento.Location = new System.Drawing.Point(99, 15);
            this.metroTextBoxDetalleMantenimiento.MaxLength = 32767;
            this.metroTextBoxDetalleMantenimiento.Name = "metroTextBoxDetalleMantenimiento";
            this.metroTextBoxDetalleMantenimiento.PasswordChar = '\0';
            this.metroTextBoxDetalleMantenimiento.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxDetalleMantenimiento.SelectedText = "";
            this.metroTextBoxDetalleMantenimiento.SelectionLength = 0;
            this.metroTextBoxDetalleMantenimiento.SelectionStart = 0;
            this.metroTextBoxDetalleMantenimiento.ShortcutsEnabled = true;
            this.metroTextBoxDetalleMantenimiento.Size = new System.Drawing.Size(252, 27);
            this.metroTextBoxDetalleMantenimiento.TabIndex = 1;
            this.metroTextBoxDetalleMantenimiento.Text = "Detalle Mantenimiento";
            this.metroTextBoxDetalleMantenimiento.UseSelectable = true;
            this.metroTextBoxDetalleMantenimiento.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxDetalleMantenimiento.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.metroTextBoxDetalleMantenimiento.TextChanged += new System.EventHandler(this.metroTextBoxDetalleMantenimiento_TextChanged);
            this.metroTextBoxDetalleMantenimiento.Click += new System.EventHandler(this.metroTextBoxDetalleMantenimiento_Click);
            // 
            // metroTextBox2
            // 
            // 
            // 
            // 
            this.metroTextBox2.CustomButton.Image = null;
            this.metroTextBox2.CustomButton.Location = new System.Drawing.Point(61, 1);
            this.metroTextBox2.CustomButton.Name = "";
            this.metroTextBox2.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.metroTextBox2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox2.CustomButton.TabIndex = 1;
            this.metroTextBox2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox2.CustomButton.UseSelectable = true;
            this.metroTextBox2.CustomButton.Visible = false;
            this.metroTextBox2.Lines = new string[] {
        "Patente"};
            this.metroTextBox2.Location = new System.Drawing.Point(6, 15);
            this.metroTextBox2.MaxLength = 32767;
            this.metroTextBox2.Name = "metroTextBox2";
            this.metroTextBox2.PasswordChar = '\0';
            this.metroTextBox2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox2.SelectedText = "";
            this.metroTextBox2.SelectionLength = 0;
            this.metroTextBox2.SelectionStart = 0;
            this.metroTextBox2.ShortcutsEnabled = true;
            this.metroTextBox2.Size = new System.Drawing.Size(87, 27);
            this.metroTextBox2.TabIndex = 2;
            this.metroTextBox2.Text = "Patente";
            this.metroTextBox2.UseSelectable = true;
            this.metroTextBox2.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox2.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.metroTextBox2.TextChanged += new System.EventHandler(this.metroTextBox2_TextChanged);
            this.metroTextBox2.Click += new System.EventHandler(this.metroTextBox2_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(8, 34);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(257, 19);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "ADMINISTRACION DE MANTENIMIENTOS";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Controls.Add(this.metroTextBox2);
            this.groupBox1.Controls.Add(this.metroTextBoxDetalleMantenimiento);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(354, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(361, 48);
            this.groupBox1.TabIndex = 46;
            this.groupBox1.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox3.Controls.Add(this.metroTile1);
            this.groupBox3.Controls.Add(this.metroToggleFiltro);
            this.groupBox3.Controls.Add(this.linkLabel1);
            this.groupBox3.Controls.Add(this.metroTile3);
            this.groupBox3.Controls.Add(this.metroTile2);
            this.groupBox3.Location = new System.Drawing.Point(8, 56);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(340, 55);
            this.groupBox3.TabIndex = 49;
            this.groupBox3.TabStop = false;
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.metroTile1.Location = new System.Drawing.Point(6, 10);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(75, 39);
            this.metroTile1.TabIndex = 54;
            this.metroTile1.Text = "NUEVO";
            this.metroTile1.TileImage = global::ErpGestion.Properties.Resources.iconfinder_circle_add_226591;
            this.metroTile1.TileImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.metroTile1.TileTextFontSize = MetroFramework.MetroTileTextSize.Small;
            this.metroTile1.UseSelectable = true;
            this.metroTile1.UseTileImage = true;
            this.metroTile1.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // metroToggleFiltro
            // 
            this.metroToggleFiltro.AutoSize = true;
            this.metroToggleFiltro.Location = new System.Drawing.Point(254, 30);
            this.metroToggleFiltro.Name = "metroToggleFiltro";
            this.metroToggleFiltro.Size = new System.Drawing.Size(80, 19);
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
            this.linkLabel1.Location = new System.Drawing.Point(270, 10);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(45, 15);
            this.linkLabel1.TabIndex = 38;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "FILTRO";
            // 
            // metroTile3
            // 
            this.metroTile3.ActiveControl = null;
            this.metroTile3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.metroTile3.Location = new System.Drawing.Point(168, 10);
            this.metroTile3.Name = "metroTile3";
            this.metroTile3.Size = new System.Drawing.Size(80, 39);
            this.metroTile3.Style = MetroFramework.MetroColorStyle.Red;
            this.metroTile3.TabIndex = 56;
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
            this.metroTile2.Location = new System.Drawing.Point(87, 10);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(75, 39);
            this.metroTile2.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroTile2.TabIndex = 55;
            this.metroTile2.Text = "EDITAR";
            this.metroTile2.TileImage = global::ErpGestion.Properties.Resources.iconfinder_edit_3_3324936;
            this.metroTile2.TileImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.metroTile2.UseSelectable = true;
            this.metroTile2.UseTileImage = true;
            this.metroTile2.Click += new System.EventHandler(this.metroTile2_Click);
            // 
            // AdminMantenimientoVehiculoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 483);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroGridMantenimientos);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AdminMantenimientoVehiculoForm";
            this.Padding = new System.Windows.Forms.Padding(23, 69, 23, 23);
            this.Resizable = false;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminMantenimientoVehiculoForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminMantenimientoVehiculoForm_FormClosed);
            this.Load += new System.EventHandler(this.AdminMantenimientoVehiculoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroGridMantenimientos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceMantenimientos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroGrid metroGridMantenimientos;
        private MetroFramework.Controls.MetroTextBox metroTextBoxDetalleMantenimiento;
        private MetroFramework.Controls.MetroTextBox metroTextBox2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Core.ComponentModel.ObjectBindingSource bindingSourceMantenimientos;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDMantenimientoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vehiculosPatenteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kmDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn talleresNombreTallerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBox3;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroToggle metroToggleFiltro;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private MetroFramework.Controls.MetroTile metroTile3;
        private MetroFramework.Controls.MetroTile metroTile2;
    }
}