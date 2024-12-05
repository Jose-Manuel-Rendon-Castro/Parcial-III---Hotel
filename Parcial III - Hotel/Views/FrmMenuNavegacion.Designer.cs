namespace Parcial_III___Hotel.Views
{
    partial class FrmMenuNavegacion
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
            panelLogin = new Panel();
            lblLogin_NombreHotel = new Label();
            splitContainer1 = new SplitContainer();
            lblMenu_Bienvenida = new Label();
            panelLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // panelLogin
            // 
            panelLogin.BackColor = Color.SkyBlue;
            panelLogin.Controls.Add(lblLogin_NombreHotel);
            panelLogin.Location = new Point(-10, 0);
            panelLogin.Name = "panelLogin";
            panelLogin.Size = new Size(1923, 163);
            panelLogin.TabIndex = 2;
            // 
            // lblLogin_NombreHotel
            // 
            lblLogin_NombreHotel.AutoSize = true;
            lblLogin_NombreHotel.Font = new Font("Mongolian Baiti", 48F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblLogin_NombreHotel.Location = new Point(37, 34);
            lblLogin_NombreHotel.Name = "lblLogin_NombreHotel";
            lblLogin_NombreHotel.Size = new Size(896, 85);
            lblLogin_NombreHotel.TabIndex = 0;
            lblLogin_NombreHotel.Text = "HOTEL SUITE SAVAGE";
            // 
            // splitContainer1
            // 
            splitContainer1.Location = new Point(-10, 159);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.BackColor = SystemColors.HotTrack;
            splitContainer1.Panel1.Controls.Add(lblMenu_Bienvenida);
            splitContainer1.Size = new Size(1920, 875);
            splitContainer1.SplitterDistance = 362;
            splitContainer1.TabIndex = 3;
            // 
            // lblMenu_Bienvenida
            // 
            lblMenu_Bienvenida.AutoSize = true;
            lblMenu_Bienvenida.Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMenu_Bienvenida.Location = new Point(37, 21);
            lblMenu_Bienvenida.Name = "lblMenu_Bienvenida";
            lblMenu_Bienvenida.Size = new Size(104, 39);
            lblMenu_Bienvenida.TabIndex = 0;
            lblMenu_Bienvenida.Text = "label1";
            // 
            // FrmMenuNavegacion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1902, 1033);
            Controls.Add(splitContainer1);
            Controls.Add(panelLogin);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmMenuNavegacion";
            Text = "FrmMenuNavegacion";
            WindowState = FormWindowState.Maximized;
            panelLogin.ResumeLayout(false);
            panelLogin.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelLogin;
        private Label lblLogin_NombreHotel;
        private SplitContainer splitContainer1;
        public Label lblMenu_Bienvenida;
    }
}