namespace ErpGestion
{
    partial class RubroForm
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
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroButtonAgregarPago = new MetroFramework.Controls.MetroButton();
            this.metroTextBoxDescripcion = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // metroButton1
            // 
            this.metroButton1.BackgroundImage = global::ErpGestion.Properties.Resources.if_17_330399__1_;
            this.metroButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.metroButton1.Location = new System.Drawing.Point(323, 98);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(41, 38);
            this.metroButton1.TabIndex = 32;
            this.metroButton1.UseSelectable = true;
            // 
            // metroButtonAgregarPago
            // 
            this.metroButtonAgregarPago.BackgroundImage = global::ErpGestion.Properties.Resources._1497285414_Checkmark;
            this.metroButtonAgregarPago.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.metroButtonAgregarPago.Location = new System.Drawing.Point(370, 98);
            this.metroButtonAgregarPago.Name = "metroButtonAgregarPago";
            this.metroButtonAgregarPago.Size = new System.Drawing.Size(41, 38);
            this.metroButtonAgregarPago.TabIndex = 31;
            this.metroButtonAgregarPago.UseSelectable = true;
            this.metroButtonAgregarPago.Click += new System.EventHandler(this.metroButtonAgregarPago_Click);
            // 
            // metroTextBoxDescripcion
            // 
            // 
            // 
            // 
            this.metroTextBoxDescripcion.CustomButton.Image = null;
            this.metroTextBoxDescripcion.CustomButton.Location = new System.Drawing.Point(372, 1);
            this.metroTextBoxDescripcion.CustomButton.Name = "";
            this.metroTextBoxDescripcion.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.metroTextBoxDescripcion.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxDescripcion.CustomButton.TabIndex = 1;
            this.metroTextBoxDescripcion.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxDescripcion.CustomButton.UseSelectable = true;
            this.metroTextBoxDescripcion.CustomButton.Visible = false;
            this.metroTextBoxDescripcion.Lines = new string[0];
            this.metroTextBoxDescripcion.Location = new System.Drawing.Point(13, 65);
            this.metroTextBoxDescripcion.MaxLength = 32767;
            this.metroTextBoxDescripcion.Name = "metroTextBoxDescripcion";
            this.metroTextBoxDescripcion.PasswordChar = '\0';
            this.metroTextBoxDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxDescripcion.SelectedText = "";
            this.metroTextBoxDescripcion.SelectionLength = 0;
            this.metroTextBoxDescripcion.SelectionStart = 0;
            this.metroTextBoxDescripcion.ShortcutsEnabled = true;
            this.metroTextBoxDescripcion.Size = new System.Drawing.Size(398, 27);
            this.metroTextBoxDescripcion.TabIndex = 29;
            this.metroTextBoxDescripcion.UseSelectable = true;
            this.metroTextBoxDescripcion.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxDescripcion.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(13, 43);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(93, 19);
            this.metroLabel1.TabIndex = 30;
            this.metroLabel1.Text = "DESCRIPCION";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(145, 13);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(162, 19);
            this.metroLabel3.TabIndex = 35;
            this.metroLabel3.Text = "FORMULARIO DE RUBRO";
            this.metroLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RubroForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 162);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.metroButtonAgregarPago);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroTextBoxDescripcion);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RubroForm";
            this.Padding = new System.Windows.Forms.Padding(23, 69, 23, 23);
            this.Resizable = false;
            this.Load += new System.EventHandler(this.RubroForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton metroButtonAgregarPago;
        private MetroFramework.Controls.MetroTextBox metroTextBoxDescripcion;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel3;
    }
}