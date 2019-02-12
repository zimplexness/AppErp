namespace ErpGestion
{
    partial class AdminTalleresForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminTalleresForm));
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroGridTalleres = new MetroFramework.Controls.MetroGrid();
            this.iDTalleresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreTallerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoTallerDescripcionTallerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.localidadesLocalidades1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreEncargadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoCotactoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSourceTalleres = new System.Core.ComponentModel.ObjectBindingSource(this.components);
            this.groupBoxFilterInfo = new System.Windows.Forms.GroupBox();
            this.metroTextBoxNombre = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel16 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBoxFilterDireccion = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.metroTile4 = new MetroFramework.Controls.MetroTile();
            this.metroTile5 = new MetroFramework.Controls.MetroTile();
            this.metroTile6 = new MetroFramework.Controls.MetroTile();
            ((System.ComponentModel.ISupportInitialize)(this.metroGridTalleres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceTalleres)).BeginInit();
            this.groupBoxFilterInfo.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(6, 35);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(198, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "ADMINISTRACION DE TALLERES";
            // 
            // metroGridTalleres
            // 
            this.metroGridTalleres.AllowUserToAddRows = false;
            this.metroGridTalleres.AllowUserToResizeRows = false;
            this.metroGridTalleres.AutoGenerateColumns = false;
            this.metroGridTalleres.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGridTalleres.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGridTalleres.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGridTalleres.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(133)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridTalleres.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.metroGridTalleres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.metroGridTalleres.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDTalleresDataGridViewTextBoxColumn,
            this.nombreTallerDataGridViewTextBoxColumn,
            this.tipoTallerDescripcionTallerDataGridViewTextBoxColumn,
            this.direccionDataGridViewTextBoxColumn,
            this.localidadesLocalidades1DataGridViewTextBoxColumn,
            this.nombreEncargadoDataGridViewTextBoxColumn,
            this.telefonoCotactoDataGridViewTextBoxColumn});
            this.metroGridTalleres.DataSource = this.bindingSourceTalleres;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(133)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGridTalleres.DefaultCellStyle = dataGridViewCellStyle2;
            this.metroGridTalleres.EnableHeadersVisualStyles = false;
            this.metroGridTalleres.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGridTalleres.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGridTalleres.Location = new System.Drawing.Point(6, 121);
            this.metroGridTalleres.Name = "metroGridTalleres";
            this.metroGridTalleres.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(133)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridTalleres.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.metroGridTalleres.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGridTalleres.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGridTalleres.Size = new System.Drawing.Size(841, 349);
            this.metroGridTalleres.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroGridTalleres.TabIndex = 42;
            this.metroGridTalleres.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.metroGridTalleres_CellDoubleClick);
            // 
            // iDTalleresDataGridViewTextBoxColumn
            // 
            this.iDTalleresDataGridViewTextBoxColumn.DataPropertyName = "IDTalleres";
            this.iDTalleresDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDTalleresDataGridViewTextBoxColumn.Name = "iDTalleresDataGridViewTextBoxColumn";
            // 
            // nombreTallerDataGridViewTextBoxColumn
            // 
            this.nombreTallerDataGridViewTextBoxColumn.DataPropertyName = "NombreTaller";
            this.nombreTallerDataGridViewTextBoxColumn.HeaderText = "Taller";
            this.nombreTallerDataGridViewTextBoxColumn.Name = "nombreTallerDataGridViewTextBoxColumn";
            this.nombreTallerDataGridViewTextBoxColumn.Width = 150;
            // 
            // tipoTallerDescripcionTallerDataGridViewTextBoxColumn
            // 
            this.tipoTallerDescripcionTallerDataGridViewTextBoxColumn.DataPropertyName = "TipoTaller_DescripcionTaller";
            this.tipoTallerDescripcionTallerDataGridViewTextBoxColumn.HeaderText = "Descripciòn";
            this.tipoTallerDescripcionTallerDataGridViewTextBoxColumn.Name = "tipoTallerDescripcionTallerDataGridViewTextBoxColumn";
            this.tipoTallerDescripcionTallerDataGridViewTextBoxColumn.Width = 150;
            // 
            // direccionDataGridViewTextBoxColumn
            // 
            this.direccionDataGridViewTextBoxColumn.DataPropertyName = "Direccion";
            this.direccionDataGridViewTextBoxColumn.HeaderText = "Direcciòn";
            this.direccionDataGridViewTextBoxColumn.Name = "direccionDataGridViewTextBoxColumn";
            this.direccionDataGridViewTextBoxColumn.Width = 200;
            // 
            // localidadesLocalidades1DataGridViewTextBoxColumn
            // 
            this.localidadesLocalidades1DataGridViewTextBoxColumn.DataPropertyName = "Localidades_Localidades1";
            this.localidadesLocalidades1DataGridViewTextBoxColumn.HeaderText = "Localidad";
            this.localidadesLocalidades1DataGridViewTextBoxColumn.Name = "localidadesLocalidades1DataGridViewTextBoxColumn";
            // 
            // nombreEncargadoDataGridViewTextBoxColumn
            // 
            this.nombreEncargadoDataGridViewTextBoxColumn.DataPropertyName = "NombreEncargado";
            this.nombreEncargadoDataGridViewTextBoxColumn.HeaderText = "Encargado";
            this.nombreEncargadoDataGridViewTextBoxColumn.Name = "nombreEncargadoDataGridViewTextBoxColumn";
            // 
            // telefonoCotactoDataGridViewTextBoxColumn
            // 
            this.telefonoCotactoDataGridViewTextBoxColumn.DataPropertyName = "TelefonoCotacto";
            this.telefonoCotactoDataGridViewTextBoxColumn.HeaderText = "Telèfono de Cotacto";
            this.telefonoCotactoDataGridViewTextBoxColumn.Name = "telefonoCotactoDataGridViewTextBoxColumn";
            // 
            // bindingSourceTalleres
            // 
            this.bindingSourceTalleres.AutoCreateObjects = false;
            this.bindingSourceTalleres.BindableProperties.Add(((System.Core.ComponentModel.BindableProperty)(resources.GetObject("bindingSourceTalleres.BindableProperties"))));
            this.bindingSourceTalleres.BindableProperties.Add(((System.Core.ComponentModel.BindableProperty)(resources.GetObject("bindingSourceTalleres.BindableProperties1"))));
            this.bindingSourceTalleres.BindableProperties.Add(((System.Core.ComponentModel.BindableProperty)(resources.GetObject("bindingSourceTalleres.BindableProperties2"))));
            this.bindingSourceTalleres.BindableProperties.Add(((System.Core.ComponentModel.BindableProperty)(resources.GetObject("bindingSourceTalleres.BindableProperties3"))));
            this.bindingSourceTalleres.BindableProperties.Add(((System.Core.ComponentModel.BindableProperty)(resources.GetObject("bindingSourceTalleres.BindableProperties4"))));
            this.bindingSourceTalleres.BindableProperties.Add(((System.Core.ComponentModel.BindableProperty)(resources.GetObject("bindingSourceTalleres.BindableProperties5"))));
            this.bindingSourceTalleres.BindableProperties.Add(((System.Core.ComponentModel.BindableProperty)(resources.GetObject("bindingSourceTalleres.BindableProperties6"))));
            this.bindingSourceTalleres.DataSource = typeof(Entidades.Talleres);
            // 
            // groupBoxFilterInfo
            // 
            this.groupBoxFilterInfo.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBoxFilterInfo.Controls.Add(this.metroTextBoxNombre);
            this.groupBoxFilterInfo.Controls.Add(this.metroLabel16);
            this.groupBoxFilterInfo.Controls.Add(this.metroTextBoxFilterDireccion);
            this.groupBoxFilterInfo.Controls.Add(this.metroLabel10);
            this.groupBoxFilterInfo.Location = new System.Drawing.Point(268, 46);
            this.groupBoxFilterInfo.Name = "groupBoxFilterInfo";
            this.groupBoxFilterInfo.Size = new System.Drawing.Size(579, 69);
            this.groupBoxFilterInfo.TabIndex = 43;
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
            this.metroTextBoxNombre.CustomButton.Location = new System.Drawing.Point(233, 1);
            this.metroTextBoxNombre.CustomButton.Name = "";
            this.metroTextBoxNombre.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.metroTextBoxNombre.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxNombre.CustomButton.TabIndex = 1;
            this.metroTextBoxNombre.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxNombre.CustomButton.UseSelectable = true;
            this.metroTextBoxNombre.CustomButton.Visible = false;
            this.metroTextBoxNombre.Lines = new string[0];
            this.metroTextBoxNombre.Location = new System.Drawing.Point(6, 31);
            this.metroTextBoxNombre.MaxLength = 32767;
            this.metroTextBoxNombre.Name = "metroTextBoxNombre";
            this.metroTextBoxNombre.PasswordChar = '\0';
            this.metroTextBoxNombre.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxNombre.SelectedText = "";
            this.metroTextBoxNombre.SelectionLength = 0;
            this.metroTextBoxNombre.SelectionStart = 0;
            this.metroTextBoxNombre.ShortcutsEnabled = true;
            this.metroTextBoxNombre.Size = new System.Drawing.Size(259, 27);
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
            this.metroLabel16.Size = new System.Drawing.Size(50, 19);
            this.metroLabel16.TabIndex = 17;
            this.metroLabel16.Text = "TALLER";
            // 
            // metroTextBoxFilterDireccion
            // 
            // 
            // 
            // 
            this.metroTextBoxFilterDireccion.CustomButton.Image = null;
            this.metroTextBoxFilterDireccion.CustomButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.metroTextBoxFilterDireccion.CustomButton.Location = new System.Drawing.Point(270, 1);
            this.metroTextBoxFilterDireccion.CustomButton.Name = "";
            this.metroTextBoxFilterDireccion.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.metroTextBoxFilterDireccion.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxFilterDireccion.CustomButton.TabIndex = 1;
            this.metroTextBoxFilterDireccion.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxFilterDireccion.CustomButton.UseSelectable = true;
            this.metroTextBoxFilterDireccion.CustomButton.Visible = false;
            this.metroTextBoxFilterDireccion.Lines = new string[0];
            this.metroTextBoxFilterDireccion.Location = new System.Drawing.Point(271, 31);
            this.metroTextBoxFilterDireccion.MaxLength = 32767;
            this.metroTextBoxFilterDireccion.Name = "metroTextBoxFilterDireccion";
            this.metroTextBoxFilterDireccion.PasswordChar = '\0';
            this.metroTextBoxFilterDireccion.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxFilterDireccion.SelectedText = "";
            this.metroTextBoxFilterDireccion.SelectionLength = 0;
            this.metroTextBoxFilterDireccion.SelectionStart = 0;
            this.metroTextBoxFilterDireccion.ShortcutsEnabled = true;
            this.metroTextBoxFilterDireccion.Size = new System.Drawing.Size(296, 27);
            this.metroTextBoxFilterDireccion.TabIndex = 20;
            this.metroTextBoxFilterDireccion.UseSelectable = true;
            this.metroTextBoxFilterDireccion.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxFilterDireccion.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.metroTextBoxFilterDireccion.TextChanged += new System.EventHandler(this.metroTextBoxFilterDireccion_TextChanged);
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(270, 13);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(77, 19);
            this.metroLabel10.TabIndex = 21;
            this.metroLabel10.Text = "DIRECCION";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox3.Controls.Add(this.metroTile4);
            this.groupBox3.Controls.Add(this.metroTile5);
            this.groupBox3.Controls.Add(this.metroTile6);
            this.groupBox3.Location = new System.Drawing.Point(6, 57);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(256, 58);
            this.groupBox3.TabIndex = 52;
            this.groupBox3.TabStop = false;
            // 
            // metroTile4
            // 
            this.metroTile4.ActiveControl = null;
            this.metroTile4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.metroTile4.Location = new System.Drawing.Point(6, 13);
            this.metroTile4.Name = "metroTile4";
            this.metroTile4.Size = new System.Drawing.Size(75, 39);
            this.metroTile4.TabIndex = 66;
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
            this.metroTile5.TabIndex = 68;
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
            this.metroTile6.TabIndex = 67;
            this.metroTile6.Text = "EDITAR";
            this.metroTile6.TileImage = global::ErpGestion.Properties.Resources.iconfinder_edit_3_3324936;
            this.metroTile6.TileImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.metroTile6.TileTextFontSize = MetroFramework.MetroTileTextSize.Small;
            this.metroTile6.UseSelectable = true;
            this.metroTile6.UseTileImage = true;
            this.metroTile6.Click += new System.EventHandler(this.metroTile6_Click);
            // 
            // AdminTalleresForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 482);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.metroGridTalleres);
            this.Controls.Add(this.groupBoxFilterInfo);
            this.Controls.Add(this.metroLabel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AdminTalleresForm";
            this.Resizable = false;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminTalleresForm_FormClosing);
            this.Load += new System.EventHandler(this.AdminTalleresForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroGridTalleres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceTalleres)).EndInit();
            this.groupBoxFilterInfo.ResumeLayout(false);
            this.groupBoxFilterInfo.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroGrid metroGridTalleres;
        private System.Windows.Forms.GroupBox groupBoxFilterInfo;
        private MetroFramework.Controls.MetroTextBox metroTextBoxNombre;
        private MetroFramework.Controls.MetroLabel metroLabel16;
        private MetroFramework.Controls.MetroTextBox metroTextBoxFilterDireccion;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private System.Core.ComponentModel.ObjectBindingSource bindingSourceTalleres;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDTalleresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreTallerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoTallerDescripcionTallerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn localidadesLocalidades1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreEncargadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoCotactoDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBox3;
        private MetroFramework.Controls.MetroTile metroTile4;
        private MetroFramework.Controls.MetroTile metroTile5;
        private MetroFramework.Controls.MetroTile metroTile6;
    }
}