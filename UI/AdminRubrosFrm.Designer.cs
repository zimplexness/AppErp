namespace ErpGestion
{
    partial class AdminRubrosFrm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminRubrosFrm));
            this.metroGridRubro = new MetroFramework.Controls.MetroGrid();
            this.iDRubroProveedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSourceRubros = new System.Core.ComponentModel.ObjectBindingSource(this.components);
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.metroTile4 = new MetroFramework.Controls.MetroTile();
            this.metroTile5 = new MetroFramework.Controls.MetroTile();
            this.metroTile6 = new MetroFramework.Controls.MetroTile();
            ((System.ComponentModel.ISupportInitialize)(this.metroGridRubro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceRubros)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroGridRubro
            // 
            this.metroGridRubro.AllowUserToAddRows = false;
            this.metroGridRubro.AllowUserToResizeRows = false;
            this.metroGridRubro.AutoGenerateColumns = false;
            this.metroGridRubro.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGridRubro.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGridRubro.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGridRubro.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(133)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridRubro.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.metroGridRubro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.metroGridRubro.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDRubroProveedorDataGridViewTextBoxColumn,
            this.descripcionDataGridViewTextBoxColumn});
            this.metroGridRubro.DataSource = this.bindingSourceRubros;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(133)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGridRubro.DefaultCellStyle = dataGridViewCellStyle14;
            this.metroGridRubro.EnableHeadersVisualStyles = false;
            this.metroGridRubro.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGridRubro.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGridRubro.Location = new System.Drawing.Point(2, 107);
            this.metroGridRubro.Name = "metroGridRubro";
            this.metroGridRubro.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(133)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridRubro.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.metroGridRubro.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGridRubro.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGridRubro.ShowEditingIcon = false;
            this.metroGridRubro.Size = new System.Drawing.Size(470, 195);
            this.metroGridRubro.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroGridRubro.TabIndex = 29;
            this.metroGridRubro.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroGridRubro.UseStyleColors = true;
            this.metroGridRubro.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.metroGridRubro_CellContentDoubleClick);
            this.metroGridRubro.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.metroGridRubro_CellDoubleClick);
            // 
            // iDRubroProveedorDataGridViewTextBoxColumn
            // 
            this.iDRubroProveedorDataGridViewTextBoxColumn.DataPropertyName = "IDRubroProveedor";
            this.iDRubroProveedorDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDRubroProveedorDataGridViewTextBoxColumn.Name = "iDRubroProveedorDataGridViewTextBoxColumn";
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            this.descripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.HeaderText = "Rubro";
            this.descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            this.descripcionDataGridViewTextBoxColumn.Width = 200;
            // 
            // bindingSourceRubros
            // 
            this.bindingSourceRubros.AutoCreateObjects = false;
            this.bindingSourceRubros.BindableProperties.Add(((System.Core.ComponentModel.BindableProperty)(resources.GetObject("bindingSourceRubros.BindableProperties"))));
            this.bindingSourceRubros.BindableProperties.Add(((System.Core.ComponentModel.BindableProperty)(resources.GetObject("bindingSourceRubros.BindableProperties1"))));
            this.bindingSourceRubros.DataSource = typeof(Entidades.RubroProveedor);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(8, 27);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(194, 19);
            this.metroLabel1.TabIndex = 42;
            this.metroLabel1.Text = "ADMINISTRACION DE RUBROS";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox3.Controls.Add(this.metroTile4);
            this.groupBox3.Controls.Add(this.metroTile5);
            this.groupBox3.Controls.Add(this.metroTile6);
            this.groupBox3.Location = new System.Drawing.Point(2, 49);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(256, 58);
            this.groupBox3.TabIndex = 43;
            this.groupBox3.TabStop = false;
            // 
            // metroTile4
            // 
            this.metroTile4.ActiveControl = null;
            this.metroTile4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.metroTile4.Location = new System.Drawing.Point(6, 13);
            this.metroTile4.Name = "metroTile4";
            this.metroTile4.Size = new System.Drawing.Size(75, 39);
            this.metroTile4.TabIndex = 63;
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
            this.metroTile5.TabIndex = 65;
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
            this.metroTile6.Location = new System.Drawing.Point(87, 13);
            this.metroTile6.Name = "metroTile6";
            this.metroTile6.Size = new System.Drawing.Size(75, 39);
            this.metroTile6.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroTile6.TabIndex = 64;
            this.metroTile6.Text = "EDITAR";
            this.metroTile6.TileImage = global::ErpGestion.Properties.Resources.iconfinder_edit_3_3324936;
            this.metroTile6.TileImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.metroTile6.TileTextFontSize = MetroFramework.MetroTileTextSize.Small;
            this.metroTile6.UseSelectable = true;
            this.metroTile6.UseTileImage = true;
            this.metroTile6.Click += new System.EventHandler(this.metroTile6_Click);
            // 
            // AdminRubrosFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 308);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroGridRubro);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AdminRubrosFrm";
            this.Padding = new System.Windows.Forms.Padding(23, 69, 23, 23);
            this.Resizable = false;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminRubrosFrm_FormClosed);
            this.Load += new System.EventHandler(this.AdminRubrosFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroGridRubro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceRubros)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroGrid metroGridRubro;
        private System.Core.ComponentModel.ObjectBindingSource bindingSourceRubros;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDRubroProveedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.GroupBox groupBox3;
        private MetroFramework.Controls.MetroTile metroTile4;
        private MetroFramework.Controls.MetroTile metroTile5;
        private MetroFramework.Controls.MetroTile metroTile6;
    }
}