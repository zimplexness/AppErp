namespace ErpGestion
{
    partial class AdminActividadesMantenimientoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminActividadesMantenimientoForm));
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBoxRubro = new MetroFramework.Controls.MetroTextBox();
            this.metroGridActividad = new MetroFramework.Controls.MetroGrid();
            this.iDActividadMantenimientoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detalleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSourceActividades = new System.Core.ComponentModel.ObjectBindingSource(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.metroTile3 = new MetroFramework.Controls.MetroTile();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.metroGridActividad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceActividades)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(9, 19);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(89, 19);
            this.metroLabel1.TabIndex = 35;
            this.metroLabel1.Text = "ACTIVIDADES";
            // 
            // metroTextBoxRubro
            // 
            // 
            // 
            // 
            this.metroTextBoxRubro.CustomButton.Image = null;
            this.metroTextBoxRubro.CustomButton.Location = new System.Drawing.Point(260, 1);
            this.metroTextBoxRubro.CustomButton.Name = "";
            this.metroTextBoxRubro.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.metroTextBoxRubro.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxRubro.CustomButton.TabIndex = 1;
            this.metroTextBoxRubro.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxRubro.CustomButton.UseSelectable = true;
            this.metroTextBoxRubro.CustomButton.Visible = false;
            this.metroTextBoxRubro.Lines = new string[0];
            this.metroTextBoxRubro.Location = new System.Drawing.Point(104, 11);
            this.metroTextBoxRubro.MaxLength = 32767;
            this.metroTextBoxRubro.Name = "metroTextBoxRubro";
            this.metroTextBoxRubro.PasswordChar = '\0';
            this.metroTextBoxRubro.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxRubro.SelectedText = "";
            this.metroTextBoxRubro.SelectionLength = 0;
            this.metroTextBoxRubro.SelectionStart = 0;
            this.metroTextBoxRubro.ShortcutsEnabled = true;
            this.metroTextBoxRubro.Size = new System.Drawing.Size(286, 27);
            this.metroTextBoxRubro.TabIndex = 34;
            this.metroTextBoxRubro.UseSelectable = true;
            this.metroTextBoxRubro.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxRubro.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroGridActividad
            // 
            this.metroGridActividad.AllowUserToAddRows = false;
            this.metroGridActividad.AllowUserToResizeRows = false;
            this.metroGridActividad.AutoGenerateColumns = false;
            this.metroGridActividad.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGridActividad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGridActividad.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGridActividad.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(133)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridActividad.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.metroGridActividad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.metroGridActividad.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDActividadMantenimientoDataGridViewTextBoxColumn,
            this.detalleDataGridViewTextBoxColumn});
            this.metroGridActividad.DataSource = this.bindingSourceActividades;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(133)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGridActividad.DefaultCellStyle = dataGridViewCellStyle2;
            this.metroGridActividad.EnableHeadersVisualStyles = false;
            this.metroGridActividad.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGridActividad.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGridActividad.Location = new System.Drawing.Point(8, 168);
            this.metroGridActividad.Name = "metroGridActividad";
            this.metroGridActividad.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(133)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridActividad.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.metroGridActividad.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGridActividad.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGridActividad.ShowEditingIcon = false;
            this.metroGridActividad.Size = new System.Drawing.Size(428, 267);
            this.metroGridActividad.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroGridActividad.TabIndex = 33;
            this.metroGridActividad.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroGridActividad.UseStyleColors = true;
            this.metroGridActividad.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.metroGridActividad_CellContentClick);
            this.metroGridActividad.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.metroGridActividad_CellDoubleClick);
            // 
            // iDActividadMantenimientoDataGridViewTextBoxColumn
            // 
            this.iDActividadMantenimientoDataGridViewTextBoxColumn.DataPropertyName = "IDActividadMantenimiento";
            this.iDActividadMantenimientoDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDActividadMantenimientoDataGridViewTextBoxColumn.Name = "iDActividadMantenimientoDataGridViewTextBoxColumn";
            // 
            // detalleDataGridViewTextBoxColumn
            // 
            this.detalleDataGridViewTextBoxColumn.DataPropertyName = "Detalle";
            this.detalleDataGridViewTextBoxColumn.HeaderText = "Actividades";
            this.detalleDataGridViewTextBoxColumn.Name = "detalleDataGridViewTextBoxColumn";
            this.detalleDataGridViewTextBoxColumn.Width = 170;
            // 
            // bindingSourceActividades
            // 
            this.bindingSourceActividades.AutoCreateObjects = false;
            this.bindingSourceActividades.BindableProperties.Add(((System.Core.ComponentModel.BindableProperty)(resources.GetObject("bindingSourceActividades.BindableProperties"))));
            this.bindingSourceActividades.BindableProperties.Add(((System.Core.ComponentModel.BindableProperty)(resources.GetObject("bindingSourceActividades.BindableProperties1"))));
            this.bindingSourceActividades.DataSource = typeof(Entidades.ActividadMantenimiento);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox2.Controls.Add(this.metroTile1);
            this.groupBox2.Controls.Add(this.metroTile2);
            this.groupBox2.Controls.Add(this.metroTile3);
            this.groupBox2.Location = new System.Drawing.Point(8, 55);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(260, 59);
            this.groupBox2.TabIndex = 39;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.metroTile1.Location = new System.Drawing.Point(9, 14);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(75, 39);
            this.metroTile1.TabIndex = 45;
            this.metroTile1.Text = "NUEVO";
            this.metroTile1.TileImage = global::ErpGestion.Properties.Resources.iconfinder_circle_add_226591;
            this.metroTile1.TileImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.metroTile1.TileTextFontSize = MetroFramework.MetroTileTextSize.Small;
            this.metroTile1.UseSelectable = true;
            this.metroTile1.UseTileImage = true;
            this.metroTile1.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // metroTile2
            // 
            this.metroTile2.ActiveControl = null;
            this.metroTile2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.metroTile2.Location = new System.Drawing.Point(90, 14);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(75, 39);
            this.metroTile2.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroTile2.TabIndex = 46;
            this.metroTile2.Text = "EDITAR";
            this.metroTile2.TileImage = global::ErpGestion.Properties.Resources.iconfinder_edit_3_3324936;
            this.metroTile2.TileImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.metroTile2.TileTextFontSize = MetroFramework.MetroTileTextSize.Small;
            this.metroTile2.UseSelectable = true;
            this.metroTile2.UseTileImage = true;
            this.metroTile2.Click += new System.EventHandler(this.metroTile2_Click);
            // 
            // metroTile3
            // 
            this.metroTile3.ActiveControl = null;
            this.metroTile3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.metroTile3.Location = new System.Drawing.Point(171, 14);
            this.metroTile3.Name = "metroTile3";
            this.metroTile3.Size = new System.Drawing.Size(83, 39);
            this.metroTile3.Style = MetroFramework.MetroColorStyle.Red;
            this.metroTile3.TabIndex = 47;
            this.metroTile3.Text = "ELIMINAR";
            this.metroTile3.TileImage = global::ErpGestion.Properties.Resources.iconfinder_trash_227551;
            this.metroTile3.TileImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.metroTile3.TileTextFontSize = MetroFramework.MetroTileTextSize.Small;
            this.metroTile3.UseSelectable = true;
            this.metroTile3.UseTileImage = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Controls.Add(this.metroTextBoxRubro);
            this.groupBox1.Location = new System.Drawing.Point(8, 114);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(395, 48);
            this.groupBox1.TabIndex = 40;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "FILTRAR";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(8, 33);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(203, 19);
            this.metroLabel2.TabIndex = 41;
            this.metroLabel2.Text = "ADMINISTRACION ACTIVIDADES";
            // 
            // AdminActividadesMantenimientoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 461);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.metroGridActividad);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AdminActividadesMantenimientoForm";
            this.Padding = new System.Windows.Forms.Padding(23, 69, 23, 23);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminActividadesMantenimientoForm_FormClosed);
            this.Load += new System.EventHandler(this.AdminActividadesMantenimientoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroGridActividad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceActividades)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox metroTextBoxRubro;
        private MetroFramework.Controls.MetroGrid metroGridActividad;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Core.ComponentModel.ObjectBindingSource bindingSourceActividades;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDActividadMantenimientoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn detalleDataGridViewTextBoxColumn;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroTile metroTile2;
        private MetroFramework.Controls.MetroTile metroTile3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
    }
}