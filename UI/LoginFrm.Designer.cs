namespace ErpGestion
{
    partial class LoginFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginFrm));
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroPanel3 = new MetroFramework.Controls.MetroPanel();
            this.metroTextBoxContraseña = new MetroFramework.Controls.MetroTextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.metroTextBoxUserName = new MetroFramework.Controls.MetroTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroPanel1.SuspendLayout();
            this.metroPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.metroPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.metroPanel3);
            this.metroPanel1.Controls.Add(this.metroPanel2);
            this.metroPanel1.Controls.Add(this.metroButton2);
            this.metroPanel1.Controls.Add(this.metroButton1);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 12;
            this.metroPanel1.Location = new System.Drawing.Point(16, 73);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(414, 288);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 12;
            // 
            // metroPanel3
            // 
            this.metroPanel3.Controls.Add(this.metroTextBoxContraseña);
            this.metroPanel3.Controls.Add(this.pictureBox2);
            this.metroPanel3.HorizontalScrollbarBarColor = true;
            this.metroPanel3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel3.HorizontalScrollbarSize = 12;
            this.metroPanel3.Location = new System.Drawing.Point(42, 77);
            this.metroPanel3.Name = "metroPanel3";
            this.metroPanel3.Size = new System.Drawing.Size(330, 40);
            this.metroPanel3.TabIndex = 7;
            this.metroPanel3.VerticalScrollbarBarColor = true;
            this.metroPanel3.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel3.VerticalScrollbarSize = 12;
            // 
            // metroTextBoxContraseña
            // 
            // 
            // 
            // 
            this.metroTextBoxContraseña.CustomButton.Image = null;
            this.metroTextBoxContraseña.CustomButton.Location = new System.Drawing.Point(242, 2);
            this.metroTextBoxContraseña.CustomButton.Name = "";
            this.metroTextBoxContraseña.CustomButton.Size = new System.Drawing.Size(35, 35);
            this.metroTextBoxContraseña.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxContraseña.CustomButton.TabIndex = 1;
            this.metroTextBoxContraseña.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxContraseña.CustomButton.UseSelectable = true;
            this.metroTextBoxContraseña.CustomButton.Visible = false;
            this.metroTextBoxContraseña.Dock = System.Windows.Forms.DockStyle.Right;
            this.metroTextBoxContraseña.Lines = new string[] {
        "CONTRASEÑA"};
            this.metroTextBoxContraseña.Location = new System.Drawing.Point(50, 0);
            this.metroTextBoxContraseña.MaxLength = 32767;
            this.metroTextBoxContraseña.Name = "metroTextBoxContraseña";
            this.metroTextBoxContraseña.PasswordChar = '\0';
            this.metroTextBoxContraseña.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxContraseña.SelectedText = "";
            this.metroTextBoxContraseña.SelectionLength = 0;
            this.metroTextBoxContraseña.SelectionStart = 0;
            this.metroTextBoxContraseña.ShortcutsEnabled = true;
            this.metroTextBoxContraseña.Size = new System.Drawing.Size(280, 40);
            this.metroTextBoxContraseña.TabIndex = 8;
            this.metroTextBoxContraseña.Text = "CONTRASEÑA";
            this.metroTextBoxContraseña.UseSelectable = true;
            this.metroTextBoxContraseña.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxContraseña.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.metroTextBoxContraseña.Click += new System.EventHandler(this.metroTextBoxContraseña_Click);
            this.metroTextBoxContraseña.Enter += new System.EventHandler(this.metroTextBoxContraseña_Enter);
            this.metroTextBoxContraseña.KeyDown += new System.Windows.Forms.KeyEventHandler(this.metroTextBoxContraseña_KeyDown);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox2.Image = global::ErpGestion.Properties.Resources.if_cloud_key_lock_532256;
            this.pictureBox2.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.InitialImage")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 40);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // metroPanel2
            // 
            this.metroPanel2.Controls.Add(this.metroTextBoxUserName);
            this.metroPanel2.Controls.Add(this.pictureBox1);
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 12;
            this.metroPanel2.Location = new System.Drawing.Point(42, 18);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(330, 36);
            this.metroPanel2.TabIndex = 6;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 12;
            // 
            // metroTextBoxUserName
            // 
            // 
            // 
            // 
            this.metroTextBoxUserName.CustomButton.Image = null;
            this.metroTextBoxUserName.CustomButton.Location = new System.Drawing.Point(246, 2);
            this.metroTextBoxUserName.CustomButton.Name = "";
            this.metroTextBoxUserName.CustomButton.Size = new System.Drawing.Size(31, 31);
            this.metroTextBoxUserName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxUserName.CustomButton.TabIndex = 1;
            this.metroTextBoxUserName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxUserName.CustomButton.UseSelectable = true;
            this.metroTextBoxUserName.CustomButton.Visible = false;
            this.metroTextBoxUserName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTextBoxUserName.Lines = new string[0];
            this.metroTextBoxUserName.Location = new System.Drawing.Point(50, 0);
            this.metroTextBoxUserName.MaxLength = 32767;
            this.metroTextBoxUserName.Name = "metroTextBoxUserName";
            this.metroTextBoxUserName.PasswordChar = '\0';
            this.metroTextBoxUserName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxUserName.SelectedText = "";
            this.metroTextBoxUserName.SelectionLength = 0;
            this.metroTextBoxUserName.SelectionStart = 0;
            this.metroTextBoxUserName.ShortcutsEnabled = true;
            this.metroTextBoxUserName.Size = new System.Drawing.Size(280, 36);
            this.metroTextBoxUserName.TabIndex = 8;
            this.metroTextBoxUserName.UseSelectable = true;
            this.metroTextBoxUserName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxUserName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::ErpGestion.Properties.Resources._1497286033_user;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 36);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // metroButton2
            // 
            this.metroButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.metroButton2.Location = new System.Drawing.Point(92, 187);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(280, 38);
            this.metroButton2.Style = MetroFramework.MetroColorStyle.Red;
            this.metroButton2.TabIndex = 5;
            this.metroButton2.Text = "CANCELAR";
            this.metroButton2.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroButton2.UseSelectable = true;
            this.metroButton2.UseStyleColors = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // metroButton1
            // 
            this.metroButton1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.metroButton1.Location = new System.Drawing.Point(92, 135);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(280, 35);
            this.metroButton1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroButton1.TabIndex = 4;
            this.metroButton1.Text = "LOGIN";
            this.metroButton1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroButton1.UseSelectable = true;
            this.metroButton1.UseStyleColors = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // LoginFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(457, 388);
            this.Controls.Add(this.metroPanel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginFrm";
            this.Padding = new System.Windows.Forms.Padding(23, 69, 23, 23);
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "INICIO DE SESION";
            this.Load += new System.EventHandler(this.LOGINFORM_Load);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.metroPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroPanel metroPanel3;
        private MetroFramework.Controls.MetroTextBox metroTextBoxContraseña;
        private System.Windows.Forms.PictureBox pictureBox2;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroTextBox metroTextBoxUserName;
    }
}