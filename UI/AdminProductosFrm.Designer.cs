namespace ErpGestion
{
    partial class AdminProductosFrm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminProductosFrm));
            this.metroGridProductos = new MetroFramework.Controls.MetroGrid();
            this.bindingSourceProductos = new System.Core.ComponentModel.ObjectBindingSource(this.components);
            this.groupBoxFilterInfo = new System.Windows.Forms.GroupBox();
            this.metroTextBoxNombre = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel16 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBoxFilterRubro = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.iDArticuloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ivaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoriasCategoriaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ubicacionUbicacion1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.metroGridProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceProductos)).BeginInit();
            this.groupBoxFilterInfo.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroGridProductos
            // 
            this.metroGridProductos.AllowUserToAddRows = false;
            this.metroGridProductos.AllowUserToResizeRows = false;
            this.metroGridProductos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroGridProductos.AutoGenerateColumns = false;
            this.metroGridProductos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGridProductos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGridProductos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGridProductos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(133)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.metroGridProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.metroGridProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDArticuloDataGridViewTextBoxColumn,
            this.codigoDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.descripcionDataGridViewTextBoxColumn,
            this.ivaDataGridViewTextBoxColumn,
            this.categoriasCategoriaDataGridViewTextBoxColumn,
            this.ubicacionUbicacion1DataGridViewTextBoxColumn});
            this.metroGridProductos.DataSource = this.bindingSourceProductos;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(133)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGridProductos.DefaultCellStyle = dataGridViewCellStyle5;
            this.metroGridProductos.EnableHeadersVisualStyles = false;
            this.metroGridProductos.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGridProductos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGridProductos.Location = new System.Drawing.Point(5, 155);
            this.metroGridProductos.Name = "metroGridProductos";
            this.metroGridProductos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(133)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridProductos.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.metroGridProductos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGridProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGridProductos.Size = new System.Drawing.Size(1000, 373);
            this.metroGridProductos.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroGridProductos.TabIndex = 39;
            this.metroGridProductos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.metroGridProveedores_CellDoubleClick);
            // 
            // bindingSourceProductos
            // 
            this.bindingSourceProductos.AutoCreateObjects = false;
            this.bindingSourceProductos.BindableProperties.Add(((System.Core.ComponentModel.BindableProperty)(resources.GetObject("bindingSourceProductos.BindableProperties"))));
            this.bindingSourceProductos.BindableProperties.Add(((System.Core.ComponentModel.BindableProperty)(resources.GetObject("bindingSourceProductos.BindableProperties1"))));
            this.bindingSourceProductos.BindableProperties.Add(((System.Core.ComponentModel.BindableProperty)(resources.GetObject("bindingSourceProductos.BindableProperties2"))));
            this.bindingSourceProductos.BindableProperties.Add(((System.Core.ComponentModel.BindableProperty)(resources.GetObject("bindingSourceProductos.BindableProperties3"))));
            this.bindingSourceProductos.BindableProperties.Add(((System.Core.ComponentModel.BindableProperty)(resources.GetObject("bindingSourceProductos.BindableProperties4"))));
            this.bindingSourceProductos.BindableProperties.Add(((System.Core.ComponentModel.BindableProperty)(resources.GetObject("bindingSourceProductos.BindableProperties5"))));
            this.bindingSourceProductos.BindableProperties.Add(((System.Core.ComponentModel.BindableProperty)(resources.GetObject("bindingSourceProductos.BindableProperties6"))));
            this.bindingSourceProductos.DataSource = typeof(Entidades.Articulos);
            this.bindingSourceProductos.CurrentChanged += new System.EventHandler(this.bindingSourceProductos_CurrentChanged);
            // 
            // groupBoxFilterInfo
            // 
            this.groupBoxFilterInfo.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBoxFilterInfo.Controls.Add(this.metroTextBoxNombre);
            this.groupBoxFilterInfo.Controls.Add(this.metroLabel16);
            this.groupBoxFilterInfo.Controls.Add(this.metroTextBoxFilterRubro);
            this.groupBoxFilterInfo.Controls.Add(this.metroLabel10);
            this.groupBoxFilterInfo.Location = new System.Drawing.Point(2, 74);
            this.groupBoxFilterInfo.Name = "groupBoxFilterInfo";
            this.groupBoxFilterInfo.Size = new System.Drawing.Size(840, 75);
            this.groupBoxFilterInfo.TabIndex = 40;
            this.groupBoxFilterInfo.TabStop = false;
            this.groupBoxFilterInfo.Text = "FILTROS";
            // 
            // metroTextBoxNombre
            // 
            // 
            // 
            // 
            this.metroTextBoxNombre.CustomButton.Image = null;
            this.metroTextBoxNombre.CustomButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.metroTextBoxNombre.CustomButton.Location = new System.Drawing.Point(282, 1);
            this.metroTextBoxNombre.CustomButton.Name = "";
            this.metroTextBoxNombre.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.metroTextBoxNombre.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxNombre.CustomButton.TabIndex = 1;
            this.metroTextBoxNombre.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxNombre.CustomButton.UseSelectable = true;
            this.metroTextBoxNombre.CustomButton.Visible = false;
            this.metroTextBoxNombre.Lines = new string[0];
            this.metroTextBoxNombre.Location = new System.Drawing.Point(3, 41);
            this.metroTextBoxNombre.MaxLength = 32767;
            this.metroTextBoxNombre.Name = "metroTextBoxNombre";
            this.metroTextBoxNombre.PasswordChar = '\0';
            this.metroTextBoxNombre.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxNombre.SelectedText = "";
            this.metroTextBoxNombre.SelectionLength = 0;
            this.metroTextBoxNombre.SelectionStart = 0;
            this.metroTextBoxNombre.ShortcutsEnabled = true;
            this.metroTextBoxNombre.Size = new System.Drawing.Size(308, 27);
            this.metroTextBoxNombre.TabIndex = 16;
            this.metroTextBoxNombre.UseSelectable = true;
            this.metroTextBoxNombre.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxNombre.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.metroTextBoxNombre.TextChanged += new System.EventHandler(this.metroTextBoxNombre_TextChanged);
            // 
            // metroLabel16
            // 
            this.metroLabel16.AutoSize = true;
            this.metroLabel16.Location = new System.Drawing.Point(3, 19);
            this.metroLabel16.Name = "metroLabel16";
            this.metroLabel16.Size = new System.Drawing.Size(69, 19);
            this.metroLabel16.TabIndex = 17;
            this.metroLabel16.Text = "NOMBRE ";
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
            this.metroTextBoxFilterRubro.Location = new System.Drawing.Point(317, 41);
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
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(317, 19);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(76, 19);
            this.metroLabel10.TabIndex = 21;
            this.metroLabel10.Text = "Descripciòn";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox2.Controls.Add(this.linkLabel1);
            this.groupBox2.Controls.Add(this.linkLabel3);
            this.groupBox2.Controls.Add(this.linkLabel2);
            this.groupBox2.Location = new System.Drawing.Point(9, 22);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(255, 46);
            this.groupBox2.TabIndex = 41;
            this.groupBox2.TabStop = false;
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.DarkTurquoise;
            this.linkLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.linkLabel1.LinkColor = System.Drawing.Color.DodgerBlue;
            this.linkLabel1.Location = new System.Drawing.Point(6, 19);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(109, 13);
            this.linkLabel1.TabIndex = 29;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "NUEVO PRODUCTO";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // linkLabel3
            // 
            this.linkLabel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.linkLabel3.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.linkLabel3.Location = new System.Drawing.Point(179, 19);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(58, 13);
            this.linkLabel3.TabIndex = 37;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "ELIMINAR";
            this.linkLabel3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel3_LinkClicked);
            // 
            // linkLabel2
            // 
            this.linkLabel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.linkLabel2.LinkColor = System.Drawing.Color.Teal;
            this.linkLabel2.Location = new System.Drawing.Point(127, 19);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(47, 13);
            this.linkLabel2.TabIndex = 36;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "EDITAR";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(491, 7);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(221, 19);
            this.metroLabel2.TabIndex = 42;
            this.metroLabel2.Text = "ADMINISTRACION DE PRODUCTOS";
            // 
            // iDArticuloDataGridViewTextBoxColumn
            // 
            this.iDArticuloDataGridViewTextBoxColumn.DataPropertyName = "IDArticulo";
            this.iDArticuloDataGridViewTextBoxColumn.HeaderText = "IDArticulo";
            this.iDArticuloDataGridViewTextBoxColumn.Name = "iDArticuloDataGridViewTextBoxColumn";
            // 
            // codigoDataGridViewTextBoxColumn
            // 
            this.codigoDataGridViewTextBoxColumn.DataPropertyName = "Codigo";
            this.codigoDataGridViewTextBoxColumn.HeaderText = "Codigo";
            this.codigoDataGridViewTextBoxColumn.Name = "codigoDataGridViewTextBoxColumn";
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.Width = 200;
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            this.descripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            this.descripcionDataGridViewTextBoxColumn.Width = 200;
            // 
            // ivaDataGridViewTextBoxColumn
            // 
            this.ivaDataGridViewTextBoxColumn.DataPropertyName = "Iva";
            this.ivaDataGridViewTextBoxColumn.HeaderText = "Iva";
            this.ivaDataGridViewTextBoxColumn.Name = "ivaDataGridViewTextBoxColumn";
            // 
            // categoriasCategoriaDataGridViewTextBoxColumn
            // 
            this.categoriasCategoriaDataGridViewTextBoxColumn.DataPropertyName = "Categorias_Categoria";
            this.categoriasCategoriaDataGridViewTextBoxColumn.HeaderText = "Categorìa";
            this.categoriasCategoriaDataGridViewTextBoxColumn.Name = "categoriasCategoriaDataGridViewTextBoxColumn";
            this.categoriasCategoriaDataGridViewTextBoxColumn.Width = 200;
            // 
            // ubicacionUbicacion1DataGridViewTextBoxColumn
            // 
            this.ubicacionUbicacion1DataGridViewTextBoxColumn.DataPropertyName = "Ubicacion_Ubicacion1";
            this.ubicacionUbicacion1DataGridViewTextBoxColumn.HeaderText = "Ubicaciòn";
            this.ubicacionUbicacion1DataGridViewTextBoxColumn.Name = "ubicacionUbicacion1DataGridViewTextBoxColumn";
            // 
            // AdminProductosFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 567);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroGridProductos);
            this.Controls.Add(this.groupBoxFilterInfo);
            this.Controls.Add(this.groupBox2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AdminProductosFrm";
            this.Resizable = false;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminProductosFrm_FormClosed);
            this.Load += new System.EventHandler(this.AdminProductosFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroGridProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceProductos)).EndInit();
            this.groupBoxFilterInfo.ResumeLayout(false);
            this.groupBoxFilterInfo.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroGrid metroGridProductos;
        private System.Windows.Forms.GroupBox groupBoxFilterInfo;
        private MetroFramework.Controls.MetroTextBox metroTextBoxNombre;
        private MetroFramework.Controls.MetroLabel metroLabel16;
        private MetroFramework.Controls.MetroTextBox metroTextBoxFilterRubro;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel3;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Core.ComponentModel.ObjectBindingSource bindingSourceProductos;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDArticuloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ivaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoriasCategoriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ubicacionUbicacion1DataGridViewTextBoxColumn;
    }
}