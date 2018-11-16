namespace ErpGestion
{
    partial class AdminPolizasSeguro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminPolizasSeguro));
            this.metroGridPolizas = new MetroFramework.Controls.MetroGrid();
            this.iDPolizaSeguroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nopolizaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaEmisionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaFinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proveedoresNombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.bindingSourcePolizas = new System.Core.ComponentModel.ObjectBindingSource(this.components);
            this.metroLabel16 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBoxFiltro = new MetroFramework.Controls.MetroTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.linkLabel4 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.metroGridPolizas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourcePolizas)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroGridPolizas
            // 
            this.metroGridPolizas.AllowUserToAddRows = false;
            this.metroGridPolizas.AllowUserToOrderColumns = true;
            this.metroGridPolizas.AllowUserToResizeColumns = false;
            this.metroGridPolizas.AllowUserToResizeRows = false;
            this.metroGridPolizas.AutoGenerateColumns = false;
            this.metroGridPolizas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGridPolizas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGridPolizas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGridPolizas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(133)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridPolizas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.metroGridPolizas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.metroGridPolizas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDPolizaSeguroDataGridViewTextBoxColumn,
            this.nopolizaDataGridViewTextBoxColumn,
            this.descripcionDataGridViewTextBoxColumn,
            this.fechaEmisionDataGridViewTextBoxColumn,
            this.fechaFinDataGridViewTextBoxColumn,
            this.proveedoresNombreDataGridViewTextBoxColumn,
            this.activaDataGridViewTextBoxColumn});
            this.metroGridPolizas.DataSource = this.bindingSourcePolizas;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(133)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGridPolizas.DefaultCellStyle = dataGridViewCellStyle2;
            this.metroGridPolizas.EnableHeadersVisualStyles = false;
            this.metroGridPolizas.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGridPolizas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGridPolizas.Location = new System.Drawing.Point(8, 156);
            this.metroGridPolizas.Name = "metroGridPolizas";
            this.metroGridPolizas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(133)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridPolizas.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.metroGridPolizas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGridPolizas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGridPolizas.ShowEditingIcon = false;
            this.metroGridPolizas.Size = new System.Drawing.Size(929, 267);
            this.metroGridPolizas.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroGridPolizas.TabIndex = 28;
            this.metroGridPolizas.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroGridPolizas.UseStyleColors = true;
            this.metroGridPolizas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.metroGridPolizas_CellContentClick);
            this.metroGridPolizas.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.metroGridPolizas_CellContentDoubleClick);
            this.metroGridPolizas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.metroGridPolizas_CellDoubleClick);
            // 
            // iDPolizaSeguroDataGridViewTextBoxColumn
            // 
            this.iDPolizaSeguroDataGridViewTextBoxColumn.DataPropertyName = "IDPolizaSeguro";
            this.iDPolizaSeguroDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDPolizaSeguroDataGridViewTextBoxColumn.Name = "iDPolizaSeguroDataGridViewTextBoxColumn";
            // 
            // nopolizaDataGridViewTextBoxColumn
            // 
            this.nopolizaDataGridViewTextBoxColumn.DataPropertyName = "Nopoliza";
            this.nopolizaDataGridViewTextBoxColumn.HeaderText = "No. Poliza";
            this.nopolizaDataGridViewTextBoxColumn.Name = "nopolizaDataGridViewTextBoxColumn";
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            this.descripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.HeaderText = "Descripción";
            this.descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            this.descripcionDataGridViewTextBoxColumn.Width = 200;
            // 
            // fechaEmisionDataGridViewTextBoxColumn
            // 
            this.fechaEmisionDataGridViewTextBoxColumn.DataPropertyName = "FechaEmision";
            this.fechaEmisionDataGridViewTextBoxColumn.HeaderText = "Fecha Emisión";
            this.fechaEmisionDataGridViewTextBoxColumn.Name = "fechaEmisionDataGridViewTextBoxColumn";
            // 
            // fechaFinDataGridViewTextBoxColumn
            // 
            this.fechaFinDataGridViewTextBoxColumn.DataPropertyName = "FechaFin";
            this.fechaFinDataGridViewTextBoxColumn.HeaderText = "Fecha Expiración";
            this.fechaFinDataGridViewTextBoxColumn.Name = "fechaFinDataGridViewTextBoxColumn";
            // 
            // proveedoresNombreDataGridViewTextBoxColumn
            // 
            this.proveedoresNombreDataGridViewTextBoxColumn.DataPropertyName = "Proveedores_Nombre";
            this.proveedoresNombreDataGridViewTextBoxColumn.HeaderText = "Compañia";
            this.proveedoresNombreDataGridViewTextBoxColumn.Name = "proveedoresNombreDataGridViewTextBoxColumn";
            this.proveedoresNombreDataGridViewTextBoxColumn.Width = 200;
            // 
            // activaDataGridViewTextBoxColumn
            // 
            this.activaDataGridViewTextBoxColumn.DataPropertyName = "Activa";
            this.activaDataGridViewTextBoxColumn.HeaderText = "Activa";
            this.activaDataGridViewTextBoxColumn.Name = "activaDataGridViewTextBoxColumn";
            this.activaDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.activaDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // bindingSourcePolizas
            // 
            this.bindingSourcePolizas.AutoCreateObjects = false;
            this.bindingSourcePolizas.BindableProperties.Add(((System.Core.ComponentModel.BindableProperty)(resources.GetObject("bindingSourcePolizas.BindableProperties"))));
            this.bindingSourcePolizas.BindableProperties.Add(((System.Core.ComponentModel.BindableProperty)(resources.GetObject("bindingSourcePolizas.BindableProperties1"))));
            this.bindingSourcePolizas.BindableProperties.Add(((System.Core.ComponentModel.BindableProperty)(resources.GetObject("bindingSourcePolizas.BindableProperties2"))));
            this.bindingSourcePolizas.BindableProperties.Add(((System.Core.ComponentModel.BindableProperty)(resources.GetObject("bindingSourcePolizas.BindableProperties3"))));
            this.bindingSourcePolizas.BindableProperties.Add(((System.Core.ComponentModel.BindableProperty)(resources.GetObject("bindingSourcePolizas.BindableProperties4"))));
            this.bindingSourcePolizas.BindableProperties.Add(((System.Core.ComponentModel.BindableProperty)(resources.GetObject("bindingSourcePolizas.BindableProperties5"))));
            this.bindingSourcePolizas.BindableProperties.Add(((System.Core.ComponentModel.BindableProperty)(resources.GetObject("bindingSourcePolizas.BindableProperties6"))));
            this.bindingSourcePolizas.DataSource = typeof(Entidades.PolizasSeguro);
            this.bindingSourcePolizas.CurrentChanged += new System.EventHandler(this.bindingSourcePolizas_CurrentChanged);
            // 
            // metroLabel16
            // 
            this.metroLabel16.AutoSize = true;
            this.metroLabel16.Location = new System.Drawing.Point(13, 19);
            this.metroLabel16.Name = "metroLabel16";
            this.metroLabel16.Size = new System.Drawing.Size(65, 19);
            this.metroLabel16.TabIndex = 17;
            this.metroLabel16.Text = "No Poliza";
            // 
            // metroTextBoxFiltro
            // 
            // 
            // 
            // 
            this.metroTextBoxFiltro.CustomButton.Image = null;
            this.metroTextBoxFiltro.CustomButton.Location = new System.Drawing.Point(291, 1);
            this.metroTextBoxFiltro.CustomButton.Name = "";
            this.metroTextBoxFiltro.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.metroTextBoxFiltro.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxFiltro.CustomButton.TabIndex = 1;
            this.metroTextBoxFiltro.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxFiltro.CustomButton.UseSelectable = true;
            this.metroTextBoxFiltro.CustomButton.Visible = false;
            this.metroTextBoxFiltro.Lines = new string[0];
            this.metroTextBoxFiltro.Location = new System.Drawing.Point(13, 44);
            this.metroTextBoxFiltro.MaxLength = 32767;
            this.metroTextBoxFiltro.Name = "metroTextBoxFiltro";
            this.metroTextBoxFiltro.PasswordChar = '\0';
            this.metroTextBoxFiltro.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxFiltro.SelectedText = "";
            this.metroTextBoxFiltro.SelectionLength = 0;
            this.metroTextBoxFiltro.SelectionStart = 0;
            this.metroTextBoxFiltro.ShortcutsEnabled = true;
            this.metroTextBoxFiltro.Size = new System.Drawing.Size(317, 27);
            this.metroTextBoxFiltro.TabIndex = 16;
            this.metroTextBoxFiltro.UseSelectable = true;
            this.metroTextBoxFiltro.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxFiltro.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Controls.Add(this.metroLabel16);
            this.groupBox1.Controls.Add(this.metroTextBoxFiltro);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(8, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(339, 86);
            this.groupBox1.TabIndex = 44;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(399, 12);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(195, 19);
            this.metroLabel1.TabIndex = 31;
            this.metroLabel1.Text = "ADMINISTRACION DE POLIZAS";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox2.Controls.Add(this.linkLabel2);
            this.groupBox2.Controls.Add(this.linkLabel3);
            this.groupBox2.Controls.Add(this.linkLabel4);
            this.groupBox2.Location = new System.Drawing.Point(8, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(255, 46);
            this.groupBox2.TabIndex = 43;
            this.groupBox2.TabStop = false;
            // 
            // linkLabel2
            // 
            this.linkLabel2.ActiveLinkColor = System.Drawing.Color.DarkTurquoise;
            this.linkLabel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.linkLabel2.LinkColor = System.Drawing.Color.DodgerBlue;
            this.linkLabel2.Location = new System.Drawing.Point(6, 19);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(86, 13);
            this.linkLabel2.TabIndex = 29;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "NUEVO POLIZA";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // linkLabel3
            // 
            this.linkLabel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.linkLabel3.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.linkLabel3.Location = new System.Drawing.Point(151, 19);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(58, 13);
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
            this.linkLabel4.Location = new System.Drawing.Point(98, 19);
            this.linkLabel4.Name = "linkLabel4";
            this.linkLabel4.Size = new System.Drawing.Size(47, 13);
            this.linkLabel4.TabIndex = 36;
            this.linkLabel4.TabStop = true;
            this.linkLabel4.Text = "EDITAR";
            this.linkLabel4.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel4_LinkClicked);
            // 
            // AdminPolizasSeguro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 446);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.metroGridPolizas);
            this.Controls.Add(this.groupBox2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AdminPolizasSeguro";
            this.Resizable = false;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminPolizasSeguro_FormClosing);
            this.Load += new System.EventHandler(this.AdminPolizasSeguro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroGridPolizas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourcePolizas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroGrid metroGridPolizas;
        private MetroFramework.Controls.MetroLabel metroLabel16;
        private MetroFramework.Controls.MetroTextBox metroTextBoxFiltro;
        private System.Core.ComponentModel.ObjectBindingSource bindingSourcePolizas;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkLabel3;
        private System.Windows.Forms.LinkLabel linkLabel4;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDPolizaSeguroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nopolizaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaEmisionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaFinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn proveedoresNombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn activaDataGridViewTextBoxColumn;
    }
}