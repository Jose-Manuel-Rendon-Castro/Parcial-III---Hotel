namespace Parcial_III___Hotel
{
    partial class FrmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pctBoxLogin = new PictureBox();
            panelLogin = new Panel();
            lblLogin_NombreHotel = new Label();
            lblLogin_Bienvenido = new Label();
            panelLogin_Credenciales = new Panel();
            txtBLogin_Contraseña = new TextBox();
            txtBLogin_Usuario = new TextBox();
            lblLogin_Contraseña = new Label();
            lblLogin_Usuario = new Label();
            panelLogin_Botones = new Panel();
            btnLogin_Salir = new Button();
            btnLogin_IniciarSesion = new Button();
            ((System.ComponentModel.ISupportInitialize)pctBoxLogin).BeginInit();
            panelLogin.SuspendLayout();
            panelLogin_Credenciales.SuspendLayout();
            panelLogin_Botones.SuspendLayout();
            SuspendLayout();
            // 
            // pctBoxLogin
            // 
            pctBoxLogin.BorderStyle = BorderStyle.Fixed3D;
            pctBoxLogin.Image = Properties.Resources.alberca_nueva_frente;
            pctBoxLogin.Location = new Point(667, 222);
            pctBoxLogin.Name = "pctBoxLogin";
            pctBoxLogin.Size = new Size(1202, 803);
            pctBoxLogin.TabIndex = 0;
            pctBoxLogin.TabStop = false;
            // 
            // panelLogin
            // 
            panelLogin.BackColor = Color.SkyBlue;
            panelLogin.Controls.Add(lblLogin_NombreHotel);
            panelLogin.Location = new Point(0, 0);
            panelLogin.Name = "panelLogin";
            panelLogin.Size = new Size(1923, 163);
            panelLogin.TabIndex = 1;
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
            // lblLogin_Bienvenido
            // 
            lblLogin_Bienvenido.AutoSize = true;
            lblLogin_Bienvenido.Font = new Font("Grand Aventure", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLogin_Bienvenido.Location = new Point(164, 279);
            lblLogin_Bienvenido.Name = "lblLogin_Bienvenido";
            lblLogin_Bienvenido.Size = new Size(299, 60);
            lblLogin_Bienvenido.TabIndex = 2;
            lblLogin_Bienvenido.Text = "Bienvenido.";
            // 
            // panelLogin_Credenciales
            // 
            panelLogin_Credenciales.BackColor = Color.LightYellow;
            panelLogin_Credenciales.Controls.Add(txtBLogin_Contraseña);
            panelLogin_Credenciales.Controls.Add(txtBLogin_Usuario);
            panelLogin_Credenciales.Controls.Add(lblLogin_Contraseña);
            panelLogin_Credenciales.Controls.Add(lblLogin_Usuario);
            panelLogin_Credenciales.ForeColor = SystemColors.ControlText;
            panelLogin_Credenciales.Location = new Point(81, 351);
            panelLogin_Credenciales.Name = "panelLogin_Credenciales";
            panelLogin_Credenciales.Size = new Size(470, 365);
            panelLogin_Credenciales.TabIndex = 3;
            // 
            // txtBLogin_Contraseña
            // 
            txtBLogin_Contraseña.Font = new Font("Courier New", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBLogin_Contraseña.Location = new Point(34, 273);
            txtBLogin_Contraseña.Name = "txtBLogin_Contraseña";
            txtBLogin_Contraseña.PasswordChar = '•';
            txtBLogin_Contraseña.Size = new Size(379, 45);
            txtBLogin_Contraseña.TabIndex = 3;
            // 
            // txtBLogin_Usuario
            // 
            txtBLogin_Usuario.Font = new Font("Courier New", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBLogin_Usuario.Location = new Point(34, 90);
            txtBLogin_Usuario.Name = "txtBLogin_Usuario";
            txtBLogin_Usuario.Size = new Size(379, 45);
            txtBLogin_Usuario.TabIndex = 2;
            // 
            // lblLogin_Contraseña
            // 
            lblLogin_Contraseña.AutoSize = true;
            lblLogin_Contraseña.Font = new Font("Microsoft YaHei UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLogin_Contraseña.Location = new Point(21, 197);
            lblLogin_Contraseña.Name = "lblLogin_Contraseña";
            lblLogin_Contraseña.Size = new Size(250, 52);
            lblLogin_Contraseña.TabIndex = 1;
            lblLogin_Contraseña.Text = "Contraseña:";
            // 
            // lblLogin_Usuario
            // 
            lblLogin_Usuario.AutoSize = true;
            lblLogin_Usuario.Font = new Font("Microsoft YaHei UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLogin_Usuario.Location = new Point(21, 23);
            lblLogin_Usuario.Name = "lblLogin_Usuario";
            lblLogin_Usuario.Size = new Size(406, 52);
            lblLogin_Usuario.TabIndex = 0;
            lblLogin_Usuario.Text = "Nombre de usuario:";
            // 
            // panelLogin_Botones
            // 
            panelLogin_Botones.BackColor = Color.LightYellow;
            panelLogin_Botones.Controls.Add(btnLogin_Salir);
            panelLogin_Botones.Controls.Add(btnLogin_IniciarSesion);
            panelLogin_Botones.Location = new Point(81, 769);
            panelLogin_Botones.Name = "panelLogin_Botones";
            panelLogin_Botones.Size = new Size(470, 125);
            panelLogin_Botones.TabIndex = 4;
            // 
            // btnLogin_Salir
            // 
            btnLogin_Salir.BackColor = Color.LightCoral;
            btnLogin_Salir.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin_Salir.Location = new Point(279, 28);
            btnLogin_Salir.Name = "btnLogin_Salir";
            btnLogin_Salir.Size = new Size(148, 65);
            btnLogin_Salir.TabIndex = 1;
            btnLogin_Salir.Text = "SALIR";
            btnLogin_Salir.UseVisualStyleBackColor = false;
            // 
            // btnLogin_IniciarSesion
            // 
            btnLogin_IniciarSesion.BackColor = SystemColors.ActiveCaption;
            btnLogin_IniciarSesion.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin_IniciarSesion.Location = new Point(34, 28);
            btnLogin_IniciarSesion.Name = "btnLogin_IniciarSesion";
            btnLogin_IniciarSesion.Size = new Size(148, 65);
            btnLogin_IniciarSesion.TabIndex = 0;
            btnLogin_IniciarSesion.Text = "INICIAR SESION";
            btnLogin_IniciarSesion.UseVisualStyleBackColor = false;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1920, 1080);
            Controls.Add(panelLogin_Botones);
            Controls.Add(panelLogin_Credenciales);
            Controls.Add(lblLogin_Bienvenido);
            Controls.Add(panelLogin);
            Controls.Add(pctBoxLogin);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmLogin";
            Text = "Login";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)pctBoxLogin).EndInit();
            panelLogin.ResumeLayout(false);
            panelLogin.PerformLayout();
            panelLogin_Credenciales.ResumeLayout(false);
            panelLogin_Credenciales.PerformLayout();
            panelLogin_Botones.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panelLogin;
        public PictureBox pctBoxLogin;
        public Label lblLogin_Bienvenido;
        private Panel panelLogin_Credenciales;
        public TextBox txtBLogin_Contraseña;
        public TextBox txtBLogin_Usuario;
        public Label lblLogin_Contraseña;
        public Label lblLogin_Usuario;
        private Panel panelLogin_Botones;
        private Label lblLogin_NombreHotel;
        public Button btnLogin_IniciarSesion;
        public Button btnLogin_Salir;
    }
}
