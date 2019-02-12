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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminProductosFrm));
            this.metroGridProductos = new MetroFramework.Controls.MetroGrid();
            this.iDArticuloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ivaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoriasCategoriaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ubicacionUbicacion1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSourceProductos = new System.Core.ComponentModel.ObjectBindingSource(this.components);
            this.groupBoxFilterInfo = new System.Windows.Forms.GroupBox();
            this.metroTextBoxNombre = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBoxFilterRubro = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.metroTile4 = new MetroFramework.Controls.MetroTile();
            this.metroToggle1 = new MetroFramework.Controls.MetroToggle();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.metroTile5 = new MetroFramework.Controls.MetroTile();
            this.metroTile6 = new MetroFramework.Controls.MetroTile();
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
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(133)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
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
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(133)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGridProductos.DefaultCellStyle = dataGridViewCellStyle17;
            this.metroGridProductos.EnableHeadersVisualStyles = false;
            this.metroGridProductos.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGridProductos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGridProductos.Location = new System.Drawing.Point(5, 102);
            this.metroGridProductos.Name = "metroGridProductos";
            this.metroGridProductos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(133)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridProductos.RowHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.metroGridProductos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGridProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGridProductos.Size = new System.Drawing.Size(1041, 395);
            this.metroGridProductos.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroGridProductos.TabIndex = 39;
            this.metroGridProductos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.metroGridProveedores_CellDoubleClick);
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
            this.groupBoxFilterInfo.Controls.Add(this.metroTextBoxFilterRubro);
            this.groupBoxFilterInfo.Location = new System.Drawing.Point(351, 39);
            this.groupBoxFilterInfo.Name = "groupBoxFilterInfo";
            this.groupBoxFilterInfo.Size = new System.Drawing.Size(410, 57);
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
            this.metroTextBoxNombre.CustomButton.Location = new System.Drawing.Point(169, 1);
            this.metroTextBoxNombre.CustomButton.Name = "";
            this.metroTextBoxNombre.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.metroTextBoxNombre.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxNombre.CustomButton.TabIndex = 1;
            this.metroTextBoxNombre.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxNombre.CustomButton.UseSelectable = true;
            this.metroTextBoxNombre.CustomButton.Visible = false;
            this.metroTextBoxNombre.Lines = new string[] {
        "NOMBRE"};
            this.metroTextBoxNombre.Location = new System.Drawing.Point(6, 19);
            this.metroTextBoxNombre.MaxLength = 32767;
            this.metroTextBoxNombre.Name = "metroTextBoxNombre";
            this.metroTextBoxNombre.PasswordChar = '\0';
            this.metroTextBoxNombre.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxNombre.SelectedText = "";
            this.metroTextBoxNombre.SelectionLength = 0;
            this.metroTextBoxNombre.SelectionStart = 0;
            this.metroTextBoxNombre.ShortcutsEnabled = true;
            this.metroTextBoxNombre.Size = new System.Drawing.Size(195, 27);
            this.metroTextBoxNombre.TabIndex = 16;
            this.metroTextBoxNombre.Text = "NOMBRE";
            this.metroTextBoxNombre.UseSelectable = true;
            this.metroTextBoxNombre.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxNombre.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.metroTextBoxNombre.TextChanged += new System.EventHandler(this.metroTextBoxNombre_TextChanged);
            this.metroTextBoxNombre.Click += new System.EventHandler(this.metroTextBoxNombre_Click);
            // 
            // metroTextBoxFilterRubro
            // 
            // 
            // 
            // 
            this.metroTextBoxFilterRubro.CustomButton.Image = null;
            this.metroTextBoxFilterRubro.CustomButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.metroTextBoxFilterRubro.CustomButton.Location = new System.Drawing.Point(170, 1);
            this.metroTextBoxFilterRubro.CustomButton.Name = "";
            this.metroTextBoxFilterRubro.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.metroTextBoxFilterRubro.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxFilterRubro.CustomButton.TabIndex = 1;
            this.metroTextBoxFilterRubro.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxFilterRubro.CustomButton.UseSelectable = true;
            this.metroTextBoxFilterRubro.CustomButton.Visible = false;
            this.metroTextBoxFilterRubro.Lines = new string[] {
        "DESCRIPCION"};
            this.metroTextBoxFilterRubro.Location = new System.Drawing.Point(207, 19);
            this.metroTextBoxFilterRubro.MaxLength = 32767;
            this.metroTextBoxFilterRubro.Name = "metroTextBoxFilterRubro";
            this.metroTextBoxFilterRubro.PasswordChar = '\0';
            this.metroTextBoxFilterRubro.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxFilterRubro.SelectedText = "";
            this.metroTextBoxFilterRubro.SelectionLength = 0;
            this.metroTextBoxFilterRubro.SelectionStart = 0;
            this.metroTextBoxFilterRubro.ShortcutsEnabled = true;
            this.metroTextBoxFilterRubro.Size = new System.Drawing.Size(196, 27);
            this.metroTextBoxFilterRubro.TabIndex = 20;
            this.metroTextBoxFilterRubro.Text = "DESCRIPCION";
            this.metroTextBoxFilterRubro.UseSelectable = true;
            this.metroTextBoxFilterRubro.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxFilterRubro.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.metroTextBoxFilterRubro.Click += new System.EventHandler(this.metroTextBoxFilterRubro_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(5, 19);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(221, 19);
            this.metroLabel2.TabIndex = 42;
            this.metroLabel2.Text = "ADMINISTRACION DE PRODUCTOS";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox2.Controls.Add(this.metroTile4);
            this.groupBox2.Controls.Add(this.metroToggle1);
            this.groupBox2.Controls.Add(this.linkLabel2);
            this.groupBox2.Controls.Add(this.metroTile5);
            this.groupBox2.Controls.Add(this.metroTile6);
            this.groupBox2.Location = new System.Drawing.Point(5, 39);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(340, 57);
            this.groupBox2.TabIndex = 54;
            this.groupBox2.TabStop = false;
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
            // metroToggle1
            // 
            this.metroToggle1.AutoSize = true;
            this.metroToggle1.Location = new System.Drawing.Point(257, 26);
            this.metroToggle1.Name = "metroToggle1";
            this.metroToggle1.Size = new System.Drawing.Size(80, 17);
            this.metroToggle1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroToggle1.TabIndex = 4;
            this.metroToggle1.Text = "Off";
            this.metroToggle1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroToggle1.UseSelectable = true;
            // 
            // linkLabel2
            // 
            this.linkLabel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.linkLabel2.LinkColor = System.Drawing.Color.Teal;
            this.linkLabel2.Location = new System.Drawing.Point(272, 9);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(45, 13);
            this.linkLabel2.TabIndex = 38;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "FILTRO";
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
            this.metroTile5.Click += new System.EventHandler(this.metroTile5_Click);
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
            // AdminProductosFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 507);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroGridProductos);
            this.Controls.Add(this.groupBoxFilterInfo);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AdminProductosFrm";
            this.Resizable = false;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminProductosFrm_FormClosed);
            this.Load += new System.EventHandler(this.AdminProductosFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroGridProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceProductos)).EndInit();
            this.groupBoxFilterInfo.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroGrid metroGridProductos;
        private System.Windows.Forms.GroupBox groupBoxFilterInfo;
        private MetroFramework.Controls.MetroTextBox metroTextBoxNombre;
        private MetroFramework.Controls.MetroTextBox metroTextBoxFilterRubro;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Core.ComponentModel.ObjectBindingSource bindingSourceProductos;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDArticuloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ivaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoriasCategoriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ubicacionUbicacion1DataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroTile metroTile4;
        private MetroFramework.Controls.MetroToggle metroToggle1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private MetroFramework.Controls.MetroTile metroTile5;
        private MetroFramework.Controls.MetroTile metroTile6;
    }
}