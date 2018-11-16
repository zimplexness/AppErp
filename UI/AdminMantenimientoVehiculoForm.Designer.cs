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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.linkLabel4 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.metroGridMantenimientos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceMantenimientos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(133)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridMantenimientos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.metroGridMantenimientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.metroGridMantenimientos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDMantenimientoDataGridViewTextBoxColumn,
            this.fechaDataGridViewTextBoxColumn,
            this.vehiculosPatenteDataGridViewTextBoxColumn,
            this.kmDataGridViewTextBoxColumn,
            this.talleresNombreTallerDataGridViewTextBoxColumn,
            this.totalDataGridViewTextBoxColumn});
            this.metroGridMantenimientos.DataSource = this.bindingSourceMantenimientos;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(133)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGridMantenimientos.DefaultCellStyle = dataGridViewCellStyle2;
            this.metroGridMantenimientos.EnableHeadersVisualStyles = false;
            this.metroGridMantenimientos.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGridMantenimientos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGridMantenimientos.Location = new System.Drawing.Point(8, 146);
            this.metroGridMantenimientos.Name = "metroGridMantenimientos";
            this.metroGridMantenimientos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(133)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridMantenimientos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.metroGridMantenimientos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGridMantenimientos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGridMantenimientos.Size = new System.Drawing.Size(835, 355);
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
            this.metroTextBoxDetalleMantenimiento.Location = new System.Drawing.Point(101, 22);
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
            this.metroTextBox2.Location = new System.Drawing.Point(6, 22);
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
            this.metroLabel1.Location = new System.Drawing.Point(307, 9);
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
            this.groupBox1.Location = new System.Drawing.Point(8, 82);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(413, 58);
            this.groupBox1.TabIndex = 46;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox2.Controls.Add(this.linkLabel2);
            this.groupBox2.Controls.Add(this.linkLabel3);
            this.groupBox2.Controls.Add(this.linkLabel4);
            this.groupBox2.Location = new System.Drawing.Point(8, 30);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(392, 46);
            this.groupBox2.TabIndex = 45;
            this.groupBox2.TabStop = false;
            // 
            // linkLabel2
            // 
            this.linkLabel2.ActiveLinkColor = System.Drawing.Color.DarkTurquoise;
            this.linkLabel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.linkLabel2.LinkColor = System.Drawing.Color.DodgerBlue;
            this.linkLabel2.Location = new System.Drawing.Point(9, 19);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(147, 15);
            this.linkLabel2.TabIndex = 29;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "NUEVO MANTENIMIENTO";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // linkLabel3
            // 
            this.linkLabel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.linkLabel3.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.linkLabel3.Location = new System.Drawing.Point(214, 19);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(60, 15);
            this.linkLabel3.TabIndex = 37;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "ELIMINAR";
            this.linkLabel3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel3_LinkClicked);
            // 
            // linkLabel4
            // 
            this.linkLabel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.linkLabel4.AutoSize = true;
            this.linkLabel4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.linkLabel4.LinkColor = System.Drawing.Color.Teal;
            this.linkLabel4.Location = new System.Drawing.Point(162, 19);
            this.linkLabel4.Name = "linkLabel4";
            this.linkLabel4.Size = new System.Drawing.Size(46, 15);
            this.linkLabel4.TabIndex = 36;
            this.linkLabel4.TabStop = true;
            this.linkLabel4.Text = "EDITAR";
            this.linkLabel4.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel4_LinkClicked);
            // 
            // AdminMantenimientoVehiculoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 527);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
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
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroGrid metroGridMantenimientos;
        private MetroFramework.Controls.MetroTextBox metroTextBoxDetalleMantenimiento;
        private MetroFramework.Controls.MetroTextBox metroTextBox2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkLabel3;
        private System.Windows.Forms.LinkLabel linkLabel4;
        private System.Core.ComponentModel.ObjectBindingSource bindingSourceMantenimientos;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDMantenimientoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vehiculosPatenteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kmDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn talleresNombreTallerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
    }
}