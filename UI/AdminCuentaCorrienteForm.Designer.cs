﻿namespace ErpGestion
{
    partial class AdminCuentaCorrienteForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminCuentaCorrienteForm));
            this.metroGridCuenta = new MetroFramework.Controls.MetroGrid();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cuit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Razon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumeroCuenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vencimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Comentario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroLabel16 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBoxFiltro = new MetroFramework.Controls.MetroTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.linkLabel4 = new System.Windows.Forms.LinkLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.bindingSourcepProveedor = new System.Core.ComponentModel.ObjectBindingSource(this.components);
            this.objectBindingSourceCuentaCorriente = new System.Core.ComponentModel.ObjectBindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.metroGridCuenta)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourcepProveedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.objectBindingSourceCuentaCorriente)).BeginInit();
            this.SuspendLayout();
            // 
            // metroGridCuenta
            // 
            this.metroGridCuenta.AllowUserToAddRows = false;
            this.metroGridCuenta.AllowUserToResizeColumns = false;
            this.metroGridCuenta.AllowUserToResizeRows = false;
            this.metroGridCuenta.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGridCuenta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGridCuenta.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGridCuenta.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(133)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridCuenta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.metroGridCuenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.metroGridCuenta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Cuit,
            this.Razon,
            this.NumeroCuenta,
            this.Vencimiento,
            this.Comentario});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(133)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGridCuenta.DefaultCellStyle = dataGridViewCellStyle2;
            this.metroGridCuenta.EnableHeadersVisualStyles = false;
            this.metroGridCuenta.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGridCuenta.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGridCuenta.Location = new System.Drawing.Point(6, 159);
            this.metroGridCuenta.Name = "metroGridCuenta";
            this.metroGridCuenta.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(133)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridCuenta.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.metroGridCuenta.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGridCuenta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGridCuenta.ShowEditingIcon = false;
            this.metroGridCuenta.Size = new System.Drawing.Size(916, 349);
            this.metroGridCuenta.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroGridCuenta.TabIndex = 28;
            this.metroGridCuenta.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroGridCuenta.UseStyleColors = true;
            this.metroGridCuenta.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.metroGridFiltrarProveedores_CellContentClick);
            this.metroGridCuenta.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.metroGridCuenta_CellContentDoubleClick);
            this.metroGridCuenta.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.metroGridCuenta_CellDoubleClick);
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Proveedor";
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 150;
            // 
            // Cuit
            // 
            this.Cuit.HeaderText = "Cuit";
            this.Cuit.Name = "Cuit";
            // 
            // Razon
            // 
            this.Razon.HeaderText = "Razon Social";
            this.Razon.Name = "Razon";
            this.Razon.Width = 150;
            // 
            // NumeroCuenta
            // 
            this.NumeroCuenta.HeaderText = "Número de Cuenta";
            this.NumeroCuenta.Name = "NumeroCuenta";
            // 
            // Vencimiento
            // 
            this.Vencimiento.HeaderText = "Vencimiento";
            this.Vencimiento.Name = "Vencimiento";
            this.Vencimiento.Width = 70;
            // 
            // Comentario
            // 
            this.Comentario.HeaderText = "Comentario";
            this.Comentario.Name = "Comentario";
            this.Comentario.Width = 300;
            // 
            // metroLabel16
            // 
            this.metroLabel16.AutoSize = true;
            this.metroLabel16.Location = new System.Drawing.Point(9, 19);
            this.metroLabel16.Name = "metroLabel16";
            this.metroLabel16.Size = new System.Drawing.Size(69, 19);
            this.metroLabel16.TabIndex = 17;
            this.metroLabel16.Text = "NOMBRE ";
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
            this.metroTextBoxFiltro.Location = new System.Drawing.Point(9, 44);
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
            this.metroTextBoxFiltro.TextChanged += new System.EventHandler(this.metroTextBoxNombre_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Controls.Add(this.metroLabel16);
            this.groupBox1.Controls.Add(this.metroTextBoxFiltro);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(6, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(339, 86);
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
            this.groupBox2.Location = new System.Drawing.Point(6, 15);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(191, 46);
            this.groupBox2.TabIndex = 45;
            this.groupBox2.TabStop = false;
            // 
            // linkLabel2
            // 
            this.linkLabel2.ActiveLinkColor = System.Drawing.Color.DarkTurquoise;
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.linkLabel2.LinkColor = System.Drawing.Color.DodgerBlue;
            this.linkLabel2.Location = new System.Drawing.Point(6, 19);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(46, 15);
            this.linkLabel2.TabIndex = 29;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "NUEVO";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // linkLabel3
            // 
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.linkLabel3.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.linkLabel3.Location = new System.Drawing.Point(110, 19);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(60, 15);
            this.linkLabel3.TabIndex = 37;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "ELIMINAR";
            // 
            // linkLabel4
            // 
            this.linkLabel4.AutoSize = true;
            this.linkLabel4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.linkLabel4.LinkColor = System.Drawing.Color.Teal;
            this.linkLabel4.Location = new System.Drawing.Point(58, 19);
            this.linkLabel4.Name = "linkLabel4";
            this.linkLabel4.Size = new System.Drawing.Size(46, 15);
            this.linkLabel4.TabIndex = 36;
            this.linkLabel4.TabStop = true;
            this.linkLabel4.Text = "EDITAR";
            this.linkLabel4.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel4_LinkClicked);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(330, 15);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(280, 19);
            this.metroLabel2.TabIndex = 47;
            this.metroLabel2.Text = "ADMINISTRACION DE CUENTAS CORRIENTES";
            // 
            // bindingSourcepProveedor
            // 
            this.bindingSourcepProveedor.AutoCreateObjects = false;
            this.bindingSourcepProveedor.DataSource = typeof(Entidades.Proveedores);
            // 
            // objectBindingSourceCuentaCorriente
            // 
            this.objectBindingSourceCuentaCorriente.AutoCreateObjects = false;
            this.objectBindingSourceCuentaCorriente.BindableProperties.Add(((System.Core.ComponentModel.BindableProperty)(resources.GetObject("objectBindingSourceCuentaCorriente.BindableProperties"))));
            this.objectBindingSourceCuentaCorriente.BindableProperties.Add(((System.Core.ComponentModel.BindableProperty)(resources.GetObject("objectBindingSourceCuentaCorriente.BindableProperties1"))));
            this.objectBindingSourceCuentaCorriente.DataSource = typeof(Entidades.Proveedores);
            // 
            // AdminCuentaCorrienteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 519);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.metroGridCuenta);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AdminCuentaCorrienteForm";
            this.Padding = new System.Windows.Forms.Padding(23, 69, 23, 23);
            this.Resizable = false;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminCuentaCorrienteForm_FormClosed);
            this.Load += new System.EventHandler(this.AdminCuentaCorrienteForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroGridCuenta)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourcepProveedor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.objectBindingSourceCuentaCorriente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroGrid metroGridCuenta;
        private MetroFramework.Controls.MetroLabel metroLabel16;
        private MetroFramework.Controls.MetroTextBox metroTextBoxFiltro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cuit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Razon;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroCuenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vencimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comentario;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkLabel3;
        private System.Windows.Forms.LinkLabel linkLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Core.ComponentModel.ObjectBindingSource bindingSourcepProveedor;
        private System.Core.ComponentModel.ObjectBindingSource objectBindingSourceCuentaCorriente;
    }
}