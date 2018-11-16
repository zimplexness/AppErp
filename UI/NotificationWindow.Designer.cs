namespace ErpGestion
{
    partial class NotificationWindow
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
            this.checkedListBoxRegistros = new System.Windows.Forms.CheckedListBox();
            this.metroLabel26 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.checkedListBoxVTV = new System.Windows.Forms.CheckedListBox();
            this.checkedListBoxPolizas = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // checkedListBoxRegistros
            // 
            this.checkedListBoxRegistros.FormattingEnabled = true;
            this.checkedListBoxRegistros.Location = new System.Drawing.Point(9, 34);
            this.checkedListBoxRegistros.Name = "checkedListBoxRegistros";
            this.checkedListBoxRegistros.Size = new System.Drawing.Size(268, 256);
            this.checkedListBoxRegistros.TabIndex = 0;
            // 
            // metroLabel26
            // 
            this.metroLabel26.AutoSize = true;
            this.metroLabel26.Location = new System.Drawing.Point(9, 12);
            this.metroLabel26.Name = "metroLabel26";
            this.metroLabel26.Size = new System.Drawing.Size(142, 19);
            this.metroLabel26.TabIndex = 121;
            this.metroLabel26.Text = "Registros de Conducir ";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(283, 12);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(89, 19);
            this.metroLabel1.TabIndex = 122;
            this.metroLabel1.Text = "VTV Vehiculos";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(604, 12);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(48, 19);
            this.metroLabel2.TabIndex = 123;
            this.metroLabel2.Text = "Polizas";
            // 
            // checkedListBoxVTV
            // 
            this.checkedListBoxVTV.FormattingEnabled = true;
            this.checkedListBoxVTV.Location = new System.Drawing.Point(283, 35);
            this.checkedListBoxVTV.Name = "checkedListBoxVTV";
            this.checkedListBoxVTV.Size = new System.Drawing.Size(315, 256);
            this.checkedListBoxVTV.TabIndex = 124;
            // 
            // checkedListBoxPolizas
            // 
            this.checkedListBoxPolizas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkedListBoxPolizas.FormattingEnabled = true;
            this.checkedListBoxPolizas.Location = new System.Drawing.Point(604, 34);
            this.checkedListBoxPolizas.Name = "checkedListBoxPolizas";
            this.checkedListBoxPolizas.Size = new System.Drawing.Size(464, 256);
            this.checkedListBoxPolizas.TabIndex = 125;
            // 
            // NotificationWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 302);
            this.Controls.Add(this.checkedListBoxPolizas);
            this.Controls.Add(this.checkedListBoxVTV);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroLabel26);
            this.Controls.Add(this.checkedListBoxRegistros);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.Name = "NotificationWindow";
            this.Opacity = 0.9D;
            this.Padding = new System.Windows.Forms.Padding(23, 69, 23, 23);
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Load += new System.EventHandler(this.NotificationWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkedListBoxRegistros;
        private MetroFramework.Controls.MetroLabel metroLabel26;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.CheckedListBox checkedListBoxVTV;
        private System.Windows.Forms.CheckedListBox checkedListBoxPolizas;
    }
}