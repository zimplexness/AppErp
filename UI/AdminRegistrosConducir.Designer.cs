namespace ErpGestion
{
    partial class AdminRegistrosConducir
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminRegistrosConducir));
            this.metroGridRegistros = new MetroFramework.Controls.MetroGrid();
            this.iDRegistroConducirDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empleadosDNIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empleadosApellidosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empleadosNombresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tiposRegistrosConducirTipoRegistroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tiposRegistrosConducirDescripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaEmisionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaVencimientoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSourceRegistrosConducir = new System.Core.ComponentModel.ObjectBindingSource(this.components);
            this.metroLabel16 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBoxFiltro = new MetroFramework.Controls.MetroTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.linkLabel4 = new System.Windows.Forms.LinkLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.metroGridRegistros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceRegistrosConducir)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroGridRegistros
            // 
            this.metroGridRegistros.AllowUserToAddRows = false;
            this.metroGridRegistros.AllowUserToOrderColumns = true;
            this.metroGridRegistros.AllowUserToResizeColumns = false;
            this.metroGridRegistros.AllowUserToResizeRows = false;
            this.metroGridRegistros.AutoGenerateColumns = false;
            this.metroGridRegistros.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGridRegistros.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGridRegistros.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGridRegistros.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(133)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridRegistros.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.metroGridRegistros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.metroGridRegistros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDRegistroConducirDataGridViewTextBoxColumn,
            this.empleadosDNIDataGridViewTextBoxColumn,
            this.empleadosApellidosDataGridViewTextBoxColumn,
            this.empleadosNombresDataGridViewTextBoxColumn,
            this.tiposRegistrosConducirTipoRegistroDataGridViewTextBoxColumn,
            this.tiposRegistrosConducirDescripcionDataGridViewTextBoxColumn,
            this.fechaEmisionDataGridViewTextBoxColumn,
            this.fechaVencimientoDataGridViewTextBoxColumn});
            this.metroGridRegistros.DataSource = this.bindingSourceRegistrosConducir;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(133)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGridRegistros.DefaultCellStyle = dataGridViewCellStyle2;
            this.metroGridRegistros.EnableHeadersVisualStyles = false;
            this.metroGridRegistros.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGridRegistros.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGridRegistros.Location = new System.Drawing.Point(12, 159);
            this.metroGridRegistros.Name = "metroGridRegistros";
            this.metroGridRegistros.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(133)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridRegistros.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.metroGridRegistros.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGridRegistros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGridRegistros.ShowEditingIcon = false;
            this.metroGridRegistros.Size = new System.Drawing.Size(1008, 283);
            this.metroGridRegistros.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroGridRegistros.TabIndex = 28;
            this.metroGridRegistros.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroGridRegistros.UseStyleColors = true;
            this.metroGridRegistros.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.metroGridRegistros_CellDoubleClick);
            // 
            // iDRegistroConducirDataGridViewTextBoxColumn
            // 
            this.iDRegistroConducirDataGridViewTextBoxColumn.DataPropertyName = "IDRegistroConducir";
            this.iDRegistroConducirDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDRegistroConducirDataGridViewTextBoxColumn.Name = "iDRegistroConducirDataGridViewTextBoxColumn";
            // 
            // empleadosDNIDataGridViewTextBoxColumn
            // 
            this.empleadosDNIDataGridViewTextBoxColumn.DataPropertyName = "Empleados_DNI";
            this.empleadosDNIDataGridViewTextBoxColumn.HeaderText = "DNI";
            this.empleadosDNIDataGridViewTextBoxColumn.Name = "empleadosDNIDataGridViewTextBoxColumn";
            // 
            // empleadosApellidosDataGridViewTextBoxColumn
            // 
            this.empleadosApellidosDataGridViewTextBoxColumn.DataPropertyName = "Empleados_Apellidos";
            this.empleadosApellidosDataGridViewTextBoxColumn.HeaderText = "Apellidos";
            this.empleadosApellidosDataGridViewTextBoxColumn.Name = "empleadosApellidosDataGridViewTextBoxColumn";
            this.empleadosApellidosDataGridViewTextBoxColumn.Width = 150;
            // 
            // empleadosNombresDataGridViewTextBoxColumn
            // 
            this.empleadosNombresDataGridViewTextBoxColumn.DataPropertyName = "Empleados_Nombres";
            this.empleadosNombresDataGridViewTextBoxColumn.HeaderText = "Nombres";
            this.empleadosNombresDataGridViewTextBoxColumn.Name = "empleadosNombresDataGridViewTextBoxColumn";
            this.empleadosNombresDataGridViewTextBoxColumn.Width = 150;
            // 
            // tiposRegistrosConducirTipoRegistroDataGridViewTextBoxColumn
            // 
            this.tiposRegistrosConducirTipoRegistroDataGridViewTextBoxColumn.DataPropertyName = "TiposRegistrosConducir_TipoRegistro";
            this.tiposRegistrosConducirTipoRegistroDataGridViewTextBoxColumn.HeaderText = "Tipo Registro";
            this.tiposRegistrosConducirTipoRegistroDataGridViewTextBoxColumn.Name = "tiposRegistrosConducirTipoRegistroDataGridViewTextBoxColumn";
            // 
            // tiposRegistrosConducirDescripcionDataGridViewTextBoxColumn
            // 
            this.tiposRegistrosConducirDescripcionDataGridViewTextBoxColumn.DataPropertyName = "TiposRegistrosConducir_Descripcion";
            this.tiposRegistrosConducirDescripcionDataGridViewTextBoxColumn.HeaderText = "Descripción";
            this.tiposRegistrosConducirDescripcionDataGridViewTextBoxColumn.Name = "tiposRegistrosConducirDescripcionDataGridViewTextBoxColumn";
            this.tiposRegistrosConducirDescripcionDataGridViewTextBoxColumn.Width = 250;
            // 
            // fechaEmisionDataGridViewTextBoxColumn
            // 
            this.fechaEmisionDataGridViewTextBoxColumn.DataPropertyName = "FechaEmision";
            this.fechaEmisionDataGridViewTextBoxColumn.HeaderText = "Fecha Emisión";
            this.fechaEmisionDataGridViewTextBoxColumn.Name = "fechaEmisionDataGridViewTextBoxColumn";
            // 
            // fechaVencimientoDataGridViewTextBoxColumn
            // 
            this.fechaVencimientoDataGridViewTextBoxColumn.DataPropertyName = "FechaVencimiento";
            this.fechaVencimientoDataGridViewTextBoxColumn.HeaderText = "Vencimiento";
            this.fechaVencimientoDataGridViewTextBoxColumn.Name = "fechaVencimientoDataGridViewTextBoxColumn";
            // 
            // bindingSourceRegistrosConducir
            // 
            this.bindingSourceRegistrosConducir.AutoCreateObjects = false;
            this.bindingSourceRegistrosConducir.BindableProperties.Add(((System.Core.ComponentModel.BindableProperty)(resources.GetObject("bindingSourceRegistrosConducir.BindableProperties"))));
            this.bindingSourceRegistrosConducir.BindableProperties.Add(((System.Core.ComponentModel.BindableProperty)(resources.GetObject("bindingSourceRegistrosConducir.BindableProperties1"))));
            this.bindingSourceRegistrosConducir.BindableProperties.Add(((System.Core.ComponentModel.BindableProperty)(resources.GetObject("bindingSourceRegistrosConducir.BindableProperties2"))));
            this.bindingSourceRegistrosConducir.BindableProperties.Add(((System.Core.ComponentModel.BindableProperty)(resources.GetObject("bindingSourceRegistrosConducir.BindableProperties3"))));
            this.bindingSourceRegistrosConducir.BindableProperties.Add(((System.Core.ComponentModel.BindableProperty)(resources.GetObject("bindingSourceRegistrosConducir.BindableProperties4"))));
            this.bindingSourceRegistrosConducir.BindableProperties.Add(((System.Core.ComponentModel.BindableProperty)(resources.GetObject("bindingSourceRegistrosConducir.BindableProperties5"))));
            this.bindingSourceRegistrosConducir.BindableProperties.Add(((System.Core.ComponentModel.BindableProperty)(resources.GetObject("bindingSourceRegistrosConducir.BindableProperties6"))));
            this.bindingSourceRegistrosConducir.BindableProperties.Add(((System.Core.ComponentModel.BindableProperty)(resources.GetObject("bindingSourceRegistrosConducir.BindableProperties7"))));
            this.bindingSourceRegistrosConducir.DataSource = typeof(Entidades.RegistrosConducir);
            this.bindingSourceRegistrosConducir.CurrentChanged += new System.EventHandler(this.bindingSourceRegistrosConducir_CurrentChanged);
            // 
            // metroLabel16
            // 
            this.metroLabel16.AutoSize = true;
            this.metroLabel16.Location = new System.Drawing.Point(11, 16);
            this.metroLabel16.Name = "metroLabel16";
            this.metroLabel16.Size = new System.Drawing.Size(139, 19);
            this.metroLabel16.TabIndex = 17;
            this.metroLabel16.Text = "No. Registro Conducir";
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
            this.metroTextBoxFiltro.Location = new System.Drawing.Point(11, 41);
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
            this.metroTextBoxFiltro.TextChanged += new System.EventHandler(this.metroTextBoxFiltro_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox2.Controls.Add(this.linkLabel2);
            this.groupBox2.Controls.Add(this.linkLabel3);
            this.groupBox2.Controls.Add(this.linkLabel4);
            this.groupBox2.Location = new System.Drawing.Point(12, 15);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(255, 46);
            this.groupBox2.TabIndex = 39;
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
            this.linkLabel2.Size = new System.Drawing.Size(104, 13);
            this.linkLabel2.TabIndex = 29;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "NUEVO REGISTRO";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // linkLabel3
            // 
            this.linkLabel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.linkLabel3.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.linkLabel3.Location = new System.Drawing.Point(169, 19);
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
            this.linkLabel4.Location = new System.Drawing.Point(116, 19);
            this.linkLabel4.Name = "linkLabel4";
            this.linkLabel4.Size = new System.Drawing.Size(47, 13);
            this.linkLabel4.TabIndex = 36;
            this.linkLabel4.TabStop = true;
            this.linkLabel4.Text = "EDITAR";
            this.linkLabel4.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel4_LinkClicked);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Controls.Add(this.metroLabel16);
            this.groupBox1.Controls.Add(this.metroTextBoxFiltro);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(389, 86);
            this.groupBox1.TabIndex = 40;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros";
            // 
            // AdminRegistrosConducir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 463);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.metroGridRegistros);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AdminRegistrosConducir";
            this.Resizable = false;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminRegistrosConducir_FormClosing);
            this.Load += new System.EventHandler(this.AdminRegistrosConducir_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroGridRegistros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceRegistrosConducir)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroGrid metroGridRegistros;
        private MetroFramework.Controls.MetroLabel metroLabel16;
        private MetroFramework.Controls.MetroTextBox metroTextBoxFiltro;
        private System.Core.ComponentModel.ObjectBindingSource bindingSourceRegistrosConducir;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDRegistroConducirDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empleadosDNIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empleadosApellidosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empleadosNombresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tiposRegistrosConducirTipoRegistroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tiposRegistrosConducirDescripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaEmisionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaVencimientoDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkLabel3;
        private System.Windows.Forms.LinkLabel linkLabel4;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}