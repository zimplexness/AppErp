namespace ErpGestion
{
    partial class ConsultasComprobantesProveedorFrm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroLabel16 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBoxFiltroProveedor = new MetroFramework.Controls.MetroTextBox();
            this.metroDateTimeFechainicio = new MetroFramework.Controls.MetroDateTime();
            this.metroDateTimeFechaFin = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroGridCompProveedores = new MetroFramework.Controls.MetroGrid();
            this.Select = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PuntoV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NoFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CondicionCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBoxTotal = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBoxIva = new MetroFramework.Controls.MetroTextBox();
            this.metroButtonEliminar = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.metroGridCompProveedores)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel16
            // 
            this.metroLabel16.AutoSize = true;
            this.metroLabel16.Location = new System.Drawing.Point(291, 12);
            this.metroLabel16.Name = "metroLabel16";
            this.metroLabel16.Size = new System.Drawing.Size(293, 19);
            this.metroLabel16.TabIndex = 28;
            this.metroLabel16.Text = "CONSULTAS DE COMPROBANTES PROVEEDOR";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(26, 31);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(125, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Nombre Proveedor";
            // 
            // metroTextBoxFiltroProveedor
            // 
            // 
            // 
            // 
            this.metroTextBoxFiltroProveedor.CustomButton.Image = null;
            this.metroTextBoxFiltroProveedor.CustomButton.Location = new System.Drawing.Point(262, 1);
            this.metroTextBoxFiltroProveedor.CustomButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.metroTextBoxFiltroProveedor.CustomButton.Name = "";
            this.metroTextBoxFiltroProveedor.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.metroTextBoxFiltroProveedor.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxFiltroProveedor.CustomButton.TabIndex = 1;
            this.metroTextBoxFiltroProveedor.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxFiltroProveedor.CustomButton.UseSelectable = true;
            this.metroTextBoxFiltroProveedor.CustomButton.Visible = false;
            this.metroTextBoxFiltroProveedor.Lines = new string[0];
            this.metroTextBoxFiltroProveedor.Location = new System.Drawing.Point(23, 53);
            this.metroTextBoxFiltroProveedor.MaxLength = 32767;
            this.metroTextBoxFiltroProveedor.Name = "metroTextBoxFiltroProveedor";
            this.metroTextBoxFiltroProveedor.PasswordChar = '\0';
            this.metroTextBoxFiltroProveedor.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxFiltroProveedor.SelectedText = "";
            this.metroTextBoxFiltroProveedor.SelectionLength = 0;
            this.metroTextBoxFiltroProveedor.SelectionStart = 0;
            this.metroTextBoxFiltroProveedor.ShortcutsEnabled = true;
            this.metroTextBoxFiltroProveedor.Size = new System.Drawing.Size(292, 31);
            this.metroTextBoxFiltroProveedor.TabIndex = 3;
            this.metroTextBoxFiltroProveedor.UseSelectable = true;
            this.metroTextBoxFiltroProveedor.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxFiltroProveedor.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroDateTimeFechainicio
            // 
            this.metroDateTimeFechainicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.metroDateTimeFechainicio.Location = new System.Drawing.Point(321, 53);
            this.metroDateTimeFechainicio.MinimumSize = new System.Drawing.Size(0, 29);
            this.metroDateTimeFechainicio.Name = "metroDateTimeFechainicio";
            this.metroDateTimeFechainicio.Size = new System.Drawing.Size(132, 29);
            this.metroDateTimeFechainicio.TabIndex = 4;
            // 
            // metroDateTimeFechaFin
            // 
            this.metroDateTimeFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.metroDateTimeFechaFin.Location = new System.Drawing.Point(463, 53);
            this.metroDateTimeFechaFin.MinimumSize = new System.Drawing.Size(0, 29);
            this.metroDateTimeFechaFin.Name = "metroDateTimeFechaFin";
            this.metroDateTimeFechaFin.Size = new System.Drawing.Size(132, 29);
            this.metroDateTimeFechaFin.TabIndex = 5;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(321, 31);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(77, 19);
            this.metroLabel2.TabIndex = 6;
            this.metroLabel2.Text = "Fecha Inicio";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(463, 31);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(64, 19);
            this.metroLabel3.TabIndex = 7;
            this.metroLabel3.Text = "Fecha Fin";
            // 
            // metroButton1
            // 
            this.metroButton1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.metroButton1.BackgroundImage = global::ErpGestion.Properties.Resources._1498842292_Citycons_magnify;
            this.metroButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.metroButton1.Location = new System.Drawing.Point(601, 41);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(39, 41);
            this.metroButton1.TabIndex = 8;
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroGridCompProveedores
            // 
            this.metroGridCompProveedores.AllowUserToAddRows = false;
            this.metroGridCompProveedores.AllowUserToOrderColumns = true;
            this.metroGridCompProveedores.AllowUserToResizeRows = false;
            this.metroGridCompProveedores.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.metroGridCompProveedores.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGridCompProveedores.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGridCompProveedores.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGridCompProveedores.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(133)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridCompProveedores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.metroGridCompProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.metroGridCompProveedores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Select,
            this.Fecha,
            this.TipoFactura,
            this.PuntoV,
            this.NoFactura,
            this.CondicionCompra,
            this.Total,
            this.Estado});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(133)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGridCompProveedores.DefaultCellStyle = dataGridViewCellStyle2;
            this.metroGridCompProveedores.EnableHeadersVisualStyles = false;
            this.metroGridCompProveedores.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGridCompProveedores.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGridCompProveedores.Location = new System.Drawing.Point(6, 90);
            this.metroGridCompProveedores.Name = "metroGridCompProveedores";
            this.metroGridCompProveedores.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(133)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridCompProveedores.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.metroGridCompProveedores.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGridCompProveedores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGridCompProveedores.Size = new System.Drawing.Size(865, 400);
            this.metroGridCompProveedores.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroGridCompProveedores.TabIndex = 9;
            // 
            // Select
            // 
            this.Select.HeaderText = "Seleccionar";
            this.Select.Name = "Select";
            this.Select.Width = 70;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            // 
            // TipoFactura
            // 
            this.TipoFactura.HeaderText = "Tipo";
            this.TipoFactura.Name = "TipoFactura";
            // 
            // PuntoV
            // 
            this.PuntoV.HeaderText = "Punto de Venta";
            this.PuntoV.Name = "PuntoV";
            // 
            // NoFactura
            // 
            this.NoFactura.HeaderText = "NoFactura";
            this.NoFactura.Name = "NoFactura";
            // 
            // CondicionCompra
            // 
            this.CondicionCompra.HeaderText = "Condicion de Compra";
            this.CondicionCompra.Name = "CondicionCompra";
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            // 
            // metroLabel6
            // 
            this.metroLabel6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(6, 493);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(128, 19);
            this.metroLabel6.TabIndex = 10;
            this.metroLabel6.Text = "Total Comprobantes";
            // 
            // metroTextBoxTotal
            // 
            this.metroTextBoxTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            // 
            // 
            // 
            this.metroTextBoxTotal.CustomButton.Image = null;
            this.metroTextBoxTotal.CustomButton.Location = new System.Drawing.Point(88, 1);
            this.metroTextBoxTotal.CustomButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.metroTextBoxTotal.CustomButton.Name = "";
            this.metroTextBoxTotal.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.metroTextBoxTotal.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxTotal.CustomButton.TabIndex = 1;
            this.metroTextBoxTotal.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxTotal.CustomButton.UseSelectable = true;
            this.metroTextBoxTotal.CustomButton.Visible = false;
            this.metroTextBoxTotal.Lines = new string[0];
            this.metroTextBoxTotal.Location = new System.Drawing.Point(13, 515);
            this.metroTextBoxTotal.MaxLength = 32767;
            this.metroTextBoxTotal.Name = "metroTextBoxTotal";
            this.metroTextBoxTotal.PasswordChar = '\0';
            this.metroTextBoxTotal.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxTotal.SelectedText = "";
            this.metroTextBoxTotal.SelectionLength = 0;
            this.metroTextBoxTotal.SelectionStart = 0;
            this.metroTextBoxTotal.ShortcutsEnabled = true;
            this.metroTextBoxTotal.Size = new System.Drawing.Size(118, 31);
            this.metroTextBoxTotal.TabIndex = 11;
            this.metroTextBoxTotal.UseSelectable = true;
            this.metroTextBoxTotal.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxTotal.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel7
            // 
            this.metroLabel7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(149, 493);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(56, 19);
            this.metroLabel7.TabIndex = 12;
            this.metroLabel7.Text = "Total Iva";
            // 
            // metroTextBoxIva
            // 
            this.metroTextBoxIva.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            // 
            // 
            // 
            this.metroTextBoxIva.CustomButton.Image = null;
            this.metroTextBoxIva.CustomButton.Location = new System.Drawing.Point(78, 1);
            this.metroTextBoxIva.CustomButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.metroTextBoxIva.CustomButton.Name = "";
            this.metroTextBoxIva.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.metroTextBoxIva.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxIva.CustomButton.TabIndex = 1;
            this.metroTextBoxIva.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxIva.CustomButton.UseSelectable = true;
            this.metroTextBoxIva.CustomButton.Visible = false;
            this.metroTextBoxIva.Lines = new string[0];
            this.metroTextBoxIva.Location = new System.Drawing.Point(149, 515);
            this.metroTextBoxIva.MaxLength = 32767;
            this.metroTextBoxIva.Name = "metroTextBoxIva";
            this.metroTextBoxIva.PasswordChar = '\0';
            this.metroTextBoxIva.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxIva.SelectedText = "";
            this.metroTextBoxIva.SelectionLength = 0;
            this.metroTextBoxIva.SelectionStart = 0;
            this.metroTextBoxIva.ShortcutsEnabled = true;
            this.metroTextBoxIva.Size = new System.Drawing.Size(108, 31);
            this.metroTextBoxIva.TabIndex = 13;
            this.metroTextBoxIva.UseSelectable = true;
            this.metroTextBoxIva.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxIva.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroButtonEliminar
            // 
            this.metroButtonEliminar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.metroButtonEliminar.BackgroundImage = global::ErpGestion.Properties.Resources._1497285708_Cancel;
            this.metroButtonEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.metroButtonEliminar.Location = new System.Drawing.Point(646, 41);
            this.metroButtonEliminar.Name = "metroButtonEliminar";
            this.metroButtonEliminar.Size = new System.Drawing.Size(45, 41);
            this.metroButtonEliminar.TabIndex = 14;
            this.metroButtonEliminar.UseSelectable = true;
            this.metroButtonEliminar.Click += new System.EventHandler(this.metroButtonEliminar_Click);
            // 
            // ConsultasComprobantesProveedorFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 563);
            this.Controls.Add(this.metroLabel16);
            this.Controls.Add(this.metroGridCompProveedores);
            this.Controls.Add(this.metroTextBoxIva);
            this.Controls.Add(this.metroButtonEliminar);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroTextBoxTotal);
            this.Controls.Add(this.metroTextBoxFiltroProveedor);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroDateTimeFechainicio);
            this.Controls.Add(this.metroDateTimeFechaFin);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroButton1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConsultasComprobantesProveedorFrm";
            this.Padding = new System.Windows.Forms.Padding(23, 78, 23, 26);
            this.Resizable = false;
            this.Load += new System.EventHandler(this.Consultas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroGridCompProveedores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroLabel metroLabel16;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox metroTextBoxFiltroProveedor;
        private MetroFramework.Controls.MetroDateTime metroDateTimeFechainicio;
        private MetroFramework.Controls.MetroDateTime metroDateTimeFechaFin;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroGrid metroGridCompProveedores;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Select;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn PuntoV;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn CondicionCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox metroTextBoxTotal;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroTextBox metroTextBoxIva;
        private MetroFramework.Controls.MetroButton metroButtonEliminar;
    }
}