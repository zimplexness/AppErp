namespace ErpGestion
{
    partial class ActividadMantenimientoForm
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
            this.metroTextBoxActividad = new MetroFramework.Controls.MetroTextBox();
            this.metroButtonAdd = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // metroTextBoxActividad
            // 
            // 
            // 
            // 
            this.metroTextBoxActividad.CustomButton.Image = null;
            this.metroTextBoxActividad.CustomButton.Location = new System.Drawing.Point(361, 1);
            this.metroTextBoxActividad.CustomButton.Name = "";
            this.metroTextBoxActividad.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.metroTextBoxActividad.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxActividad.CustomButton.TabIndex = 1;
            this.metroTextBoxActividad.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxActividad.CustomButton.UseSelectable = true;
            this.metroTextBoxActividad.CustomButton.Visible = false;
            this.metroTextBoxActividad.Lines = new string[0];
            this.metroTextBoxActividad.Location = new System.Drawing.Point(28, 72);
            this.metroTextBoxActividad.MaxLength = 32767;
            this.metroTextBoxActividad.Name = "metroTextBoxActividad";
            this.metroTextBoxActividad.PasswordChar = '\0';
            this.metroTextBoxActividad.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxActividad.SelectedText = "";
            this.metroTextBoxActividad.SelectionLength = 0;
            this.metroTextBoxActividad.SelectionStart = 0;
            this.metroTextBoxActividad.ShortcutsEnabled = true;
            this.metroTextBoxActividad.Size = new System.Drawing.Size(387, 27);
            this.metroTextBoxActividad.TabIndex = 0;
            this.metroTextBoxActividad.UseSelectable = true;
            this.metroTextBoxActividad.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxActividad.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.metroTextBoxActividad.Click += new System.EventHandler(this.metroTextBox1_Click);
            // 
            // metroButtonAdd
            // 
            this.metroButtonAdd.BackgroundImage = global::ErpGestion.Properties.Resources._1497285414_Checkmark;
            this.metroButtonAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.metroButtonAdd.Location = new System.Drawing.Point(358, 105);
            this.metroButtonAdd.Name = "metroButtonAdd";
            this.metroButtonAdd.Size = new System.Drawing.Size(57, 39);
            this.metroButtonAdd.TabIndex = 2;
            this.metroButtonAdd.UseSelectable = true;
            this.metroButtonAdd.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(60, 8);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(315, 19);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "FORMULARIO DE ACTIVIDAD DE MANTENIMIENTO";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(28, 50);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(75, 19);
            this.metroLabel2.TabIndex = 4;
            this.metroLabel2.Text = "ACTIVIDAD";
            // 
            // metroButton1
            // 
            this.metroButton1.BackgroundImage = global::ErpGestion.Properties.Resources._1497285708_Cancel;
            this.metroButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.metroButton1.Location = new System.Drawing.Point(295, 105);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(57, 39);
            this.metroButton1.TabIndex = 5;
            this.metroButton1.UseSelectable = true;
            // 
            // ActividadMantenimientoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 157);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroButtonAdd);
            this.Controls.Add(this.metroTextBoxActividad);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ActividadMantenimientoForm";
            this.Padding = new System.Windows.Forms.Padding(23, 69, 23, 23);
            this.Resizable = false;
            this.Load += new System.EventHandler(this.ActividadVehiculoForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox metroTextBoxActividad;
        private MetroFramework.Controls.MetroButton metroButtonAdd;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton metroButton1;
    }
}