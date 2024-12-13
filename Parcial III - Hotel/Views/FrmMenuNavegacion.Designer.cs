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
            panelMenu_Opciones = new Panel();
            btnMenu_CheckIn = new Button();
            btnMenu_Reservar = new Button();
            lblMenu_Bienvenido = new Label();
            btnMenu_Inicio = new Button();
            btnMenu_Reservacion = new Button();
            panelMenu_SidePanel = new Panel();
            btnMenu_Salir = new Button();
            lblMenu_Copyright = new Label();
            panelMenu_InicioUC = new UserControls.InicioUC();
            panelMenu_ReservarUC = new UserControls.ReservarUC();
            panelMenu_CheckInUC = new UserControls.CheckInUC();
            panelLogin.SuspendLayout();
            panelMenu_Opciones.SuspendLayout();
            SuspendLayout();
            // 
            // panelLogin
            // 
            panelLogin.BackColor = Color.SkyBlue;
            panelLogin.Controls.Add(lblLogin_NombreHotel);
            panelLogin.Location = new Point(-10, 0);
            panelLogin.Name = "panelLogin";
            panelLogin.Size = new Size(1940, 163);
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
            // panelMenu_Opciones
            // 
            panelMenu_Opciones.BackColor = Color.RoyalBlue;
            panelMenu_Opciones.Controls.Add(btnMenu_CheckIn);
            panelMenu_Opciones.Controls.Add(btnMenu_Reservar);
            panelMenu_Opciones.Controls.Add(lblMenu_Bienvenido);
            panelMenu_Opciones.Controls.Add(btnMenu_Inicio);
            panelMenu_Opciones.Controls.Add(btnMenu_Reservacion);
            panelMenu_Opciones.Controls.Add(panelMenu_SidePanel);
            panelMenu_Opciones.Controls.Add(btnMenu_Salir);
            panelMenu_Opciones.Location = new Point(0, 163);
            panelMenu_Opciones.Name = "panelMenu_Opciones";
            panelMenu_Opciones.Size = new Size(343, 917);
            panelMenu_Opciones.TabIndex = 3;
            // 
            // btnMenu_CheckIn
            // 
            btnMenu_CheckIn.FlatAppearance.BorderSize = 0;
            btnMenu_CheckIn.FlatStyle = FlatStyle.Flat;
            btnMenu_CheckIn.Font = new Font("Microsoft YaHei UI", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMenu_CheckIn.Location = new Point(12, 331);
            btnMenu_CheckIn.Name = "btnMenu_CheckIn";
            btnMenu_CheckIn.Size = new Size(331, 86);
            btnMenu_CheckIn.TabIndex = 10;
            btnMenu_CheckIn.Text = "Check-In";
            btnMenu_CheckIn.TextAlign = ContentAlignment.MiddleLeft;
            btnMenu_CheckIn.UseVisualStyleBackColor = true;
            // 
            // btnMenu_Reservar
            // 
            btnMenu_Reservar.FlatAppearance.BorderSize = 0;
            btnMenu_Reservar.FlatStyle = FlatStyle.Flat;
            btnMenu_Reservar.Font = new Font("Microsoft YaHei UI", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMenu_Reservar.Location = new Point(12, 244);
            btnMenu_Reservar.Name = "btnMenu_Reservar";
            btnMenu_Reservar.Size = new Size(331, 86);
            btnMenu_Reservar.TabIndex = 5;
            btnMenu_Reservar.Text = "Reservar";
            btnMenu_Reservar.TextAlign = ContentAlignment.MiddleLeft;
            btnMenu_Reservar.UseVisualStyleBackColor = true;
            // 
            // lblMenu_Bienvenido
            // 
            lblMenu_Bienvenido.AutoSize = true;
            lblMenu_Bienvenido.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMenu_Bienvenido.Location = new Point(13, 41);
            lblMenu_Bienvenido.Name = "lblMenu_Bienvenido";
            lblMenu_Bienvenido.Size = new Size(65, 28);
            lblMenu_Bienvenido.TabIndex = 8;
            lblMenu_Bienvenido.Text = "label1";
            // 
            // btnMenu_Inicio
            // 
            btnMenu_Inicio.FlatAppearance.BorderSize = 0;
            btnMenu_Inicio.FlatStyle = FlatStyle.Flat;
            btnMenu_Inicio.Font = new Font("Microsoft YaHei UI", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMenu_Inicio.Location = new Point(12, 157);
            btnMenu_Inicio.Name = "btnMenu_Inicio";
            btnMenu_Inicio.Size = new Size(332, 86);
            btnMenu_Inicio.TabIndex = 7;
            btnMenu_Inicio.Text = "Inicio";
            btnMenu_Inicio.TextAlign = ContentAlignment.MiddleLeft;
            btnMenu_Inicio.UseVisualStyleBackColor = true;
            // 
            // btnMenu_Reservacion
            // 
            btnMenu_Reservacion.FlatAppearance.BorderSize = 0;
            btnMenu_Reservacion.FlatStyle = FlatStyle.Flat;
            btnMenu_Reservacion.Font = new Font("Microsoft YaHei UI", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMenu_Reservacion.Location = new Point(9, 573);
            btnMenu_Reservacion.Name = "btnMenu_Reservacion";
            btnMenu_Reservacion.Size = new Size(331, 86);
            btnMenu_Reservacion.TabIndex = 6;
            btnMenu_Reservacion.Text = "Reservacion";
            btnMenu_Reservacion.TextAlign = ContentAlignment.MiddleLeft;
            btnMenu_Reservacion.UseVisualStyleBackColor = true;
            // 
            // panelMenu_SidePanel
            // 
            panelMenu_SidePanel.BackColor = Color.MidnightBlue;
            panelMenu_SidePanel.Location = new Point(0, 157);
            panelMenu_SidePanel.Name = "panelMenu_SidePanel";
            panelMenu_SidePanel.Size = new Size(14, 86);
            panelMenu_SidePanel.TabIndex = 5;
            // 
            // btnMenu_Salir
            // 
            btnMenu_Salir.BackColor = Color.MidnightBlue;
            btnMenu_Salir.FlatAppearance.BorderSize = 0;
            btnMenu_Salir.FlatStyle = FlatStyle.Flat;
            btnMenu_Salir.Font = new Font("Microsoft YaHei UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMenu_Salir.Location = new Point(1, 829);
            btnMenu_Salir.Name = "btnMenu_Salir";
            btnMenu_Salir.Size = new Size(343, 88);
            btnMenu_Salir.TabIndex = 5;
            btnMenu_Salir.Text = "CERRAR SESIÓN";
            btnMenu_Salir.UseVisualStyleBackColor = false;
            // 
            // lblMenu_Copyright
            // 
            lblMenu_Copyright.AutoSize = true;
            lblMenu_Copyright.ForeColor = SystemColors.ButtonShadow;
            lblMenu_Copyright.Location = new Point(1544, 1051);
            lblMenu_Copyright.Name = "lblMenu_Copyright";
            lblMenu_Copyright.Size = new Size(364, 20);
            lblMenu_Copyright.TabIndex = 4;
            lblMenu_Copyright.Text = "TM © 2024 - Hotel Suite Savage - All Rights Reserved";
            // 
            // panelMenu_InicioUC
            // 
            panelMenu_InicioUC.Location = new Point(394, 204);
            panelMenu_InicioUC.Name = "panelMenu_InicioUC";
            panelMenu_InicioUC.Size = new Size(1448, 804);
            panelMenu_InicioUC.TabIndex = 5;
            // 
            // panelMenu_ReservarUC
            // 
            panelMenu_ReservarUC.BackColor = SystemColors.ActiveCaption;
            panelMenu_ReservarUC.Location = new Point(394, 204);
            panelMenu_ReservarUC.Name = "panelMenu_ReservarUC";
            panelMenu_ReservarUC.Size = new Size(1448, 804);
            panelMenu_ReservarUC.TabIndex = 6;
            // 
            // panelMenu_CheckInUC
            // 
            panelMenu_CheckInUC.Location = new Point(394, 204);
            panelMenu_CheckInUC.Name = "panelMenu_CheckInUC";
            panelMenu_CheckInUC.Size = new Size(1448, 804);
            panelMenu_CheckInUC.TabIndex = 7;
            // 
            // FrmMenuNavegacion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1920, 1080);
            Controls.Add(panelMenu_CheckInUC);
            Controls.Add(panelMenu_ReservarUC);
            Controls.Add(panelMenu_InicioUC);
            Controls.Add(lblMenu_Copyright);
            Controls.Add(panelMenu_Opciones);
            Controls.Add(panelLogin);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmMenuNavegacion";
            Text = "Menú de navegación";
            WindowState = FormWindowState.Maximized;
            panelLogin.ResumeLayout(false);
            panelLogin.PerformLayout();
            panelMenu_Opciones.ResumeLayout(false);
            panelMenu_Opciones.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelLogin;
        private Label lblLogin_NombreHotel;
        private Panel panelMenu_Opciones;
        public Button btnMenu_Salir;
        private Label lblMenu_Copyright;
        public Button btnMenu_Reservacion;
        private Panel panel1;
        public Panel panelMenu_SidePanel;
        public Button btnMenu_Inicio;
        public UserControls.InicioUC InicioUC;
        private UserControls.ReservacionUC reservacionuc1;
        public Label lblMenu_Bienvenido;
        public Button btnMenu_Reservar;
        public Button btnMenu_CheckIn;
        public UserControls.InicioUC panelMenu_InicioUC;
        public UserControls.ReservarUC panelMenu_ReservarUC;
        public UserControls.CheckInUC panelMenu_CheckInUC;
    }
}